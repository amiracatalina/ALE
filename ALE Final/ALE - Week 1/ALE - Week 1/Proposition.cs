using System;
using System.Collections.Generic;
using System.Linq;

namespace ALE___Week_1
{
   public class Proposition
    {
        public Node Node { get; set; }

        public Proposition LeftChild { get; set; }

        public Proposition RightChild { get; set; }

        public Proposition(string proposition)
        {
            try
            {
                //Does not take spaces into consideration
                proposition = proposition.Replace(" ", "");

                char firstCharacter = proposition.First();

                if (IsLetter(firstCharacter))
                {
                    Node = new Operand(firstCharacter);
                }

                if (IsOperator(firstCharacter))
                {
                    Node = new Operator(firstCharacter);
                }

                if (!IsLetter(firstCharacter) && !IsNegation(firstCharacter))
                {
                    Break(proposition);
                }
                else
                {
                    if (IsNegation(firstCharacter)) LeftChild = new Proposition(proposition.Substring(2, proposition.Length - 3));
                }
            }catch (Exception)
            {
               
            }
        }
       
        // Check if the character is letter
        private bool IsLetter(char letter)
        {
            return char.IsLetter(letter);
        }

        // Check if the character is negation
        private bool IsNegation(char c)
        {
            return c == '~';
        }

        // Check if the character is operator
        public bool IsOperator(char operatorChar)
        {
            if (operatorChar == '~' || operatorChar == '&' || operatorChar == '|' || operatorChar == '=' || operatorChar == '>' || operatorChar == '%')
            {
                return true;
            } else
                return false;
        }

        public override string ToString()
        {
            try {
                if (Node is Operator)
                {
                    if (IsNegation(Node.NodeValue))
                    {
                        return $"{Node.NodeValue}({LeftChild.ToString()})";
                    }
                    else
                    {
                        return $"({LeftChild?.ToString()}{Node.NodeValue}{RightChild?.ToString()})";
                    }
                }

                else
                {
                    return Node.NodeValue.ToString();
                }
            }
            catch(System.NullReferenceException)
            {
                return "Ups, you did something wrong!";
            }
        }
        public List<char> GetVariables()
        {
            try
            {
                List<char> variableList = new List<char>();

                if (IsLetter(Node.NodeValue)) variableList.Add(Node.NodeValue);
                if (LeftChild != null) variableList.AddRange(LeftChild.GetVariables());
                if (RightChild != null) variableList.AddRange(RightChild.GetVariables());

                List<char> lowerVariableList = new List<char>();
                foreach (char variable in variableList)
                {
                    lowerVariableList.Add(Char.ToLower(variable));
                }

                lowerVariableList.Sort();

                return lowerVariableList.Distinct().ToList();

            } catch(Exception)
            {
                return null;
            }
        }

        public void Break(string proposition)
        {
            int openBracket = 0;
            int closeBracket = 0;

            if (Node is Operator) proposition = proposition.Substring(2, proposition.Length - 3);

            for (int i = 0; i < proposition.Length; i++)
            {
                if (proposition[i] == '(') openBracket++;

                if (proposition[i] == ')') closeBracket++;

                if(openBracket == closeBracket && proposition[i] == ',')
                {
                    int split = i;
                    LeftChild = new Proposition(proposition.Substring(0, split));
                    RightChild = new Proposition(proposition.Substring(split + 1));
                }
            }
        }

        // GRAPH

        public virtual string[] MakeGraph()
        {
            List<string> listNodes = new List<string>();

            string nodeNo = Node.NodeNo.ToString();
            string nodeValue = Node.NodeValue.ToString();

            listNodes.Add($"node{nodeNo} [ label = \"{nodeValue}\" color=\"red\"]");
            if(LeftChild != null)
            {
                listNodes.Add($"node{nodeNo} -- node{LeftChild.Node.NodeNo}");
                listNodes.AddRange(LeftChild.MakeGraph());
            }
            if(RightChild != null)
            {
                listNodes.Add($"node{nodeNo} -- node{RightChild.Node.NodeNo}");
                listNodes.AddRange(RightChild.MakeGraph());
            }
          
            return listNodes.ToArray();
        }

        public List<string> GenerateFile()
        {
            List<string> listLines = new List<string>();

            listLines.Add("graph logic {");
            listLines.Add("node [ fontname = \"Comic Sans\" fontsize = 15 ]");
            listLines.AddRange(MakeGraph());
            listLines.Add("}");

            return listLines;
        }


        // TRUTH TABLE
        public bool CheckTruthSign()
        {
            if (Node is Operand)
            {
                return Node.Boolean;
            }
            else
            {
                if(Node.NodeValue == '~')
                {
                    return !LeftChild.CheckTruthSign();
                } else
                {
                    if(Node.NodeValue == '>')
                    {
                        return !LeftChild.CheckTruthSign() || RightChild.CheckTruthSign();
                    }
                    else if(Node.NodeValue == '=')
                    {
                        return LeftChild.CheckTruthSign() == RightChild.CheckTruthSign();
                    }
                    else if (Node.NodeValue == '&')
                    {
                        return LeftChild.CheckTruthSign() && RightChild.CheckTruthSign();
                    }
                    else if (Node.NodeValue == '|')
                    {
                        return LeftChild.CheckTruthSign() || RightChild.CheckTruthSign();
                    }
                    else if (Node.NodeValue == '%')
                    {
                        return !(LeftChild.CheckTruthSign() && RightChild.CheckTruthSign());
                    }
                    else
                    {
                        throw new ArgumentException("Ups, you did something wrong!");
                    }
                }
            }
        }

        public void SetValue(char c, bool value)
        {
            if (Node is Operator)
            {
                LeftChild.SetValue(c, value);
                RightChild?.SetValue(c, value);
            }
            else
            {
                if (Node.NodeValue == c) ((Operand)Node).SetBoolean(value);
            }
        }

        //NANDIFY
        public string GetNandify()
        {
            if (Node is Operand)
            {
                return Node.NodeValue.ToString();
            }
            else
            {
                if(Node.NodeValue == '~')
                {
                    return $"%({LeftChild.GetNandify()}, {LeftChild.GetNandify()})";
                }
                else if(Node.NodeValue == '>')
                {
                    return $"%({LeftChild.GetNandify()}, %({RightChild.GetNandify()}, {RightChild.GetNandify()}))";
                }
                else if(Node.NodeValue == '=')
                {
                   return $"%(%(%({LeftChild.GetNandify()}, {LeftChild.GetNandify()}), %({RightChild.GetNandify()}, {RightChild.GetNandify()})), %({LeftChild.GetNandify()}, {RightChild.GetNandify()}))";
                }
                else if(Node.NodeValue == '&')
                {
                    return $"%(%({LeftChild.GetNandify()}, {RightChild.GetNandify()}), %({LeftChild.GetNandify()}, {RightChild.GetNandify()}))";
                }
                else if(Node.NodeValue == '|')
                {
                    return $"%(%({LeftChild.GetNandify()}, {LeftChild.GetNandify()}), %({RightChild.GetNandify()}, {RightChild.GetNandify()}))";
                }
                else if(Node.NodeValue == '%')
                {
                    return $"%({LeftChild.GetNandify()}, {RightChild.GetNandify()})";
                }
                else
                {
                    throw new ArgumentException("Ups, you did something wrong!");
                }
            }
        }
    }
}
