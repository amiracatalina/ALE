using System.Collections.Generic;
using System.Linq;

namespace ALE___Week_1
{
    public class TruthTableStructure
    {
        public List<string> Description { get; set; }

        public List<TruthTableRow> TableRows { get; set; }

        public TruthTableStructure(List<string> description, List<TruthTableRow> rows)
        {
            this.Description = description;
            this.TableRows = rows;
        }
    }

    public class TruthTableRow
    {
        public bool IsSimplified { get; set; }

        public List<string> OutputValues { get; set; }

        public string FinalResult { get; set; }

        public TruthTableRow(List<string> row)
        {
            this.IsSimplified = false;
            this.OutputValues = row.GetRange(0, row.Count - 1);
            this.FinalResult = row.Last();
        }

        public TruthTableRow(string result, List<string> values)
        {
            this.IsSimplified = false;
            this.OutputValues = values;
            this.FinalResult = result;
        }

        public bool IsPositive()
        {
            if (this.FinalResult == "1")
            {
                return true;
            }

            return false;
        }
        public TruthTableRow CompareRow(TruthTableRow anotherRow)
        {
            List<string> finalResult = new List<string>();
            int count = 0;

            for (int i = 0; i < this.OutputValues.Count; i++)
            {
                if (this.OutputValues[i] == anotherRow.OutputValues[i])
                {
                    finalResult.Add(this.OutputValues[i]);
                }
                else
                {
                    finalResult.Add("*");
                    count++;
                }
            }

            if(count==1)
            {
                return new TruthTableRow("1", finalResult);
            }
            else
            {
                return null;
            }
        }

        public bool CheckEquality(TruthTableRow other)
        {
            for (int i = 0; i < this.OutputValues.Count; i++)
            {
                if (this.OutputValues[i] != other.OutputValues[i]) return false;
            }
            return true;
        }

        public int GetNumberOfPositiveValues() => OutputValues.Count(v => v == "1");
    }
}
