using System;
using System.Collections.Generic;
using System.Linq;

namespace ALE___Week_1
{
    public class TruthTable: TruthTableStructure
    {
        public List<TruthTableRow> SRows { get; set; }

        public bool IsSimplified { get; set; }

        public TruthTable(List<string> description, List<TruthTableRow> rows) : base(description, rows)
        {
            IsSimplified = false;
        }

        public TruthTableStructure GetTruthTable()
        {
            return new TruthTableStructure(Description, TableRows);
        }

        public string GetTruthTableHex()
        {
            return GetHex(GetBinary());
        }

        public virtual string GetBinary()
        {
            string binaryValue = "";

            for (int i = TableRows.Count - 1; i >= 0; i--)
            {
                binaryValue += TableRows[i].FinalResult;
            }

            return binaryValue;
        }

        // The code used for creating this was from http://qaru.site/questions/430508/converting-long-string-of-binary-to-hex-c
        private string GetHex(string binary)
        {
            if (binary == null) throw new ArgumentNullException("Ups, you did something wrong!");

            int mod4Len = binary.Length % 8;
            if (mod4Len != 0)
            {
                binary = binary.PadLeft(((binary.Length / 8) + 1) * 8, '0');
            }

            int bit = 8;
            string hex = string.Empty;
            for (int i = 0; i < binary.Length; i += bit)
            {
                string eightBits = binary.Substring(i, bit);
                hex += $"{Convert.ToByte(eightBits, 2):X2}";
            }

            return hex;
        }

        //Simplified
        public TruthTableStructure GetSimplified()
        {
            IsSimplified = false;

            List<List<TruthTableRow>> pos = PosRows().GroupBy(r => r.GetNumberOfPositiveValues()).Select(r => r.ToList()).ToList();

            if (pos.Count != 0)
            {
                while (!IsSimplified)
                {
                    GetSimplifiedRows(ref pos);
                }
            }

            SRows = new List<TruthTableRow>();

            SRows.AddRange(NegRows());

            foreach (List<TruthTableRow> PositiveResult in pos)
            {
                foreach (TruthTableRow tableRow in PositiveResult)
                {
                    if (!this.SRows.Any(r => r.CheckEquality(tableRow))) SRows.Add(tableRow);
                }
            }
            return new TruthTableStructure(Description, SRows);
        }

        private void GetSimplifiedRows(ref List<List<TruthTableRow>> groupList)
        {
            List<List<TruthTableRow>> temporaryList = new List<List<TruthTableRow>>();
            
            int com = 0;

            for (int i = 0; i < groupList.Count - 1; i++)
            {
                List<TruthTableRow> rows = new List<TruthTableRow>();

                foreach (var x in groupList[i])
                {
                    int counter = 0;

                    foreach (var y in groupList[i + 1])
                    {
                        TruthTableRow mixRow = x.CompareRow(y);

                        if (mixRow != null)
                        {
                            mixRow.IsSimplified = true;

                            if (!rows.Any(r => r.CheckEquality(mixRow))) rows.Add(mixRow);
                            if (rows.Any(r => r.CheckEquality(mixRow)) && !mixRow.CheckEquality(y) && !rows.Any(r => r.CheckEquality(x))) counter++;
                        }
                    }

                    if (counter == 0 && !rows.Any(r => r.CheckEquality(x)) && x.IsSimplified) rows.Add(x);

                    com += counter;
                }

                temporaryList.Add(rows);
            }
            IsSimplified = com == 0;

            if (!IsSimplified) groupList = temporaryList;
        }

        private List<TruthTableRow> PosRows()
        {
            return TableRows.Where(row => row.IsPositive()).ToList();
        }

        private List<TruthTableRow> NegRows()
        {
            return TableRows.Where(row => !row.IsPositive()).ToList();
        }

        //NORMALIZED
        public string GetNormalized()
        {
            string normalizeValue = "";

            List<string> normalizedVariables = Description.Where(c => !c.Contains("(")).ToList();

            List<TruthTableRow> positiveRows = PosRows();

            for (int i = 0; i < positiveRows.Count; i++)
            {
                normalizeValue += "(";

                for (int j = 0; j < normalizedVariables.Count; j++)
                {
                    string value = positiveRows[i].OutputValues[j];

                    if (value == "1")
                    {
                        if (normalizedVariables[j] == normalizedVariables.Last())
                        {
                            normalizeValue += $"{normalizedVariables[j]}";
                        }
                        else
                        {
                            normalizeValue += $"{normalizedVariables[j]}&";
                        }
                    }
                    else
                    {
                        if (normalizedVariables[j] == normalizedVariables.Last())
                        {
                            normalizeValue += $"~({normalizedVariables[j]})";
                        }
                        else
                        {
                            normalizeValue += $"~({normalizedVariables[j]})&";
                        }
                    }

                }

                if (i == positiveRows.Count - 1)
                {
                    normalizeValue += $")";
                }
                else
                {
                    normalizeValue += $") | ";
                }
            }

            return normalizeValue;
        }

        public string GetNormalizedSimplified()
        {
            var simplified = GetSimplified();

            var positiveRows = simplified.TableRows.Where(r => r.IsPositive()).ToList();

            string normalizedSimplified = "";

            List<string> variables = Description.Where(c => !c.Contains("(")).ToList();

            for (int i = 0; i < positiveRows.Count; i++)
            {
                normalizedSimplified += "(";
                for (int j = 0; j < variables.Count; j++)
                {
                    string value = positiveRows[i].OutputValues[j];
                    if (value=="1")
                    {
                        if (variables[j] == variables.Last())
                        {
                            normalizedSimplified += $"{variables[j]}";
                        }
                        else
                        {
                            normalizedSimplified += $"{variables[j]}&";
                        }
                    }

                    if (value=="0")
                    {
                        if (variables[j] == variables.Last())
                        {
                            normalizedSimplified += $"~({variables[j]})";
                        }
                        else
                        {
                            normalizedSimplified += $"~({variables[j]})&";
                        }
                    }
                }

                if (i == positiveRows.Count - 1)
                {
                    normalizedSimplified += $")";
                }
                else
                {
                    normalizedSimplified += $") | ";
                }
            }

            normalizedSimplified = normalizedSimplified.Replace("&)", ")");

            return normalizedSimplified;
        }

        private string NormalizedPrefix(TruthTableRow rowParameter)
        {
            string x = "";
            string row = "";

            for (int i = 0; i < rowParameter.OutputValues.Count; i++)
            {
                if(rowParameter.OutputValues[i] == "0")
                {
                    row = $"~({Description[i]})";
                } else
                    row = Description[i];
 
                if(i==0)
                {
                    x = row;
                } else
                    x = $"&({x}, {row})";   
            }

            return x;
        }

        public string GetNormalizedPrefix()
        {
            string x = "";
            string rowVar = "";
            bool boolean = false;
            var positiveRows = PosRows();

            foreach (TruthTableRow row in positiveRows)
            {
                rowVar = NormalizedPrefix(row);

                if (boolean == false)
                {
                    x = rowVar;
                    boolean = true;
                }
                else
                {
                    x = $"|({x}, {rowVar})";
                }
            }

            return x;
        }
    }
}
