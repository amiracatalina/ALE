
namespace ALE___Week_1
{
   public class Node
    {
        public char NodeValue { get; set; }

        // For tree
        public int NodeNo { get; set; }
        public static int no;

        // For truth table
        public bool Boolean { get; set; }

        public Node(char node)
        {
            // For tree
            NodeNo = no;
            no++;

            NodeValue = node;
        }
    }
}
