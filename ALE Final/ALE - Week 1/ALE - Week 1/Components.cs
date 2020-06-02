
namespace ALE___Week_1
{
   public class Operand:Node
    {
        public Operand(char operandChar) : base(operandChar)
        {
            Boolean = false;

            if (NodeValue == '1') Boolean = true;
        }

        public void SetBoolean(bool boolean)
        {
            if (NodeValue != '0' && NodeValue != '1') Boolean = boolean;
        }
    }

    public class Operator : Node
    {
        public Operator(char operatorChar) : base(operatorChar) { }
    }
}
