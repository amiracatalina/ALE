using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ALE___Week_1
{
   public class Service
    {
        public Proposition PropositionNode { get; set; }

        //Truth Table
        public TruthTable TruthTableService { get; set; }

        public string Proposition(string input)
        {
            input = input.Replace(" ", "");

            PropositionNode = new Proposition(input);
            return PropositionNode.ToString();
        }

        public List<char> GetVariables()
        {
            return PropositionNode.GetVariables();
        }

        //Tree
        public string GetGraphService()
        {
            File.WriteAllLines($"./abc.dot", this.PropositionNode.GenerateFile());
            Process dot = new Process();

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Exe files|*.exe";
            openFileDialog.Title = "Select the location of your dot.exe";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dot.StartInfo.FileName = openFileDialog.FileName;
            }

            dot.StartInfo.Arguments = $"-Tpng -o ./abc.png ./abc.dot";
            dot.Start();
            dot.WaitForExit();
            return $"abc.png";
        }

        // Truth Table
        public List<List<string>> GetTruthTable()
        {
            try
            {
                if (PropositionNode == null) return null;

                List<List<string>> allRows = new List<List<string>>();

                List<string> header = PropositionNode.GetVariables().OrderBy(c => c).Select(c => c.ToString()).ToList();

                header.Add(PropositionNode.ToString());
                allRows.Add(header);

                int noPrepositions = header.Count - 1;
                int rows = (int)Math.Pow(2, noPrepositions);

                for (int i = 0; i < rows; i++)
                {
                    List<string> row = new List<string>();
                    string x = Convert.ToString(i, 2);
                    if (x.Count() < noPrepositions)
                    {
                        while (x.Count() != noPrepositions)
                            x = x.Insert(0, "0");
                    }

                    char[] array = x.ToCharArray();

                    for (int j = 0; j < noPrepositions; j++)
                    {
                        char character = header[j].First();
                        bool boolValue = array[j] == '1';
                        PropositionNode.SetValue(character, boolValue);
                        row.Add(array[j].ToString());
                    }

                    if (PropositionNode.CheckTruthSign() == false)
                    {
                        row.Add("0");
                    }
                    else
                    {
                        row.Add("1");
                    }

                    allRows.Add(row);
                }

                return allRows;

            } catch (Exception)
            {
                return null;
            }
        }

        public TruthTableStructure GetTableService()
        {
            try
            {
                if (TruthTableService == null)
                {
                    List<List<string>> truthTable = GetTruthTable();
                    TruthTableService = new TruthTable(truthTable[0], truthTable.GetRange(1, truthTable.Count - 1).Select(r => new TruthTableRow(r)).ToList());
                }

                return TruthTableService.GetTruthTable();

            }
            catch (Exception)
            {
                return null;
            }
        }


        // Truth table hexadecimal
        public string TruthTableHexService()
        {
            try
            {
                if (TruthTableService == null)
                {
                    var truthTable = GetTruthTable();
                    TruthTableService = new TruthTable(truthTable[0], truthTable.GetRange(1, truthTable.Count - 1).Select(r => new TruthTableRow(r)).ToList());
                }

                return TruthTableService.GetTruthTableHex();

            }
            catch (Exception)
            {
                return null;
            }
        }

        //Simplified
        public TruthTableStructure GetSimplifiedTableService()
        {
            try
            {
                if (TruthTableService == null)
                {
                    var truthTable = GetTruthTable();
                    TruthTableService = new TruthTable(truthTable[0], truthTable.GetRange(1, truthTable.Count - 1).Select(r => new TruthTableRow(r)).ToList());
                }

                return TruthTableService.GetSimplified();

            } catch (Exception)
            {
                return null;
            }
        }

        //Normalized
        public string GetNormalizedService()
        {
            try
            {
                if (TruthTableService == null)
                {
                    var truthTable = GetTruthTable();
                    TruthTableService = new TruthTable(truthTable[0], truthTable.GetRange(1, truthTable.Count - 1).Select(r => new TruthTableRow(r)).ToList());
                }

                return TruthTableService.GetNormalized();

            }
            catch (Exception)
            {
                return null;
            }
        }

        public string GetNomarlizedPrefixService()
        {
            try
            {
                if (TruthTableService == null)
                {
                    var truthTable = GetTruthTable();
                    TruthTableService = new TruthTable(truthTable[0], truthTable.GetRange(1, truthTable.Count - 1).Select(r => new TruthTableRow(r)).ToList());
                }

                return TruthTableService.GetNormalizedPrefix();

            }
            catch (Exception)
            {
                return null;
            }
        }

        public string GetNormalizedSimplifiedService()
        {
            try
            {
                if (TruthTableService == null)
                {
                    var truthTable = GetTruthTable();
                    TruthTableService = new TruthTable(truthTable[0], truthTable.GetRange(1, truthTable.Count - 1).Select(r => new TruthTableRow(r)).ToList());
                }

                return TruthTableService.GetNormalizedSimplified();

            }
            catch (Exception)
            {
                return null;
            }
        }

        //NANDIFY
        public string GetNandifyService()
        {
            try
            {
                return PropositionNode.GetNandify();
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
