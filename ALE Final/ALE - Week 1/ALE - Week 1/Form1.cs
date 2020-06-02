using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ALE___Week_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Service service;

        private void submit_Click(object sender, EventArgs e)
        {
            //Clear Simplified Truth Table 
            truthTableSimplified_lb.Items.Clear();

            //Clear Truth Table Label
            truthTable_lb.Items.Clear();

            //Service Instance
            service = new Service();

            // Proposition
            string result = service.Proposition(inputBox.Text.ToLower());
            if (result == null)
            {
                MessageBox.Show("Ups, you did something wrong!");
            }
            else
            {
                try {
                    // Truth Table Export
                    TruthTableStructure table = service.GetTableService();

                    truthTable_lb.Items.Add(string.Join("\t", table.Description));

                    foreach (TruthTableRow row in table.TableRows)
                    {
                        string oneRow = string.Join("\t", row.OutputValues);
                        oneRow += $"\t{row.FinalResult}";
                        truthTable_lb.Items.Add(oneRow);
                    }

                    hex_box.Text = service.TruthTableHexService();

                    // Proposition Result Export
                    output_box.Text = result;

                    // Variables Export
                    variables_box.Text = string.Join(", ", service.GetVariables());

                    // Normalize Export
                    normalize_box.Text = service.GetNormalizedService();

                    //Normalize Prefix Export
                    normalize_prefix_box.Text = service.GetNomarlizedPrefixService();

                    //Normalize Simplified Export
                    normalize_simplified_box.Text = service.GetNormalizedSimplifiedService();

                    //Nandify Export
                    nandify_box.Text = service.GetNandifyService();

                    // Generate Tree
                    graph_Box.SizeMode = PictureBoxSizeMode.CenterImage;
                    graph_Box.ImageLocation = $@"./{service.GetGraphService()}";
                }catch
                {
                    MessageBox.Show("Ups, you did something wrong!");
                }
 
            }
        }

        // Show propositions
        private void btn_showProps_Click(object sender, EventArgs e)
        {
            propositions_lb.Items.Clear();

            foreach (string s in Propositions())
            {
                propositions_lb.Items.Add(s);
            }
        }

        // Method with propositions
        public List<string> Propositions()
        {
            List<string> propositions = new List<string>();
            string firstProp = "&(a,b)";
            string percentProp = "%(a,b)";
            string secondProp = ">(a,b)";
            string thirdProp = "|(a,b)";
            string fourthProp = "=(a,b)";
            string fifthProp = "=(|(a,b),c)";
            string anotherPercentProp = "%(|(a,b),c)";
            string sixthProp = "=(>(a,b),c)";
            string seventhProp = "|(~(a),&(b,c))";
            string eightProp = "&(>(a,b),=(a,b))";
            string ninthProp = "=(~(a),~(b))";
            string tenthProp = "=(&(~(b), a),|(=(c,d),>(e,f)))";
            propositions.Add(firstProp);
            propositions.Add(percentProp);
            propositions.Add(secondProp);
            propositions.Add(thirdProp);
            propositions.Add(fourthProp);
            propositions.Add(fifthProp);
            propositions.Add(sixthProp);
            propositions.Add(anotherPercentProp);
            propositions.Add(seventhProp);
            propositions.Add(eightProp);
            propositions.Add(ninthProp);
            propositions.Add(tenthProp);
            return propositions;
        }

        private void propositions_lb_SelectedIndexChanged(object sender, EventArgs e)
        {
            inputBox.Text = propositions_lb.GetItemText(propositions_lb.SelectedItem);
        }

        private void simplified_btn_Click(object sender, EventArgs e)
        {
            //Clear Simplified Label
            truthTableSimplified_lb.Items.Clear();

            //Service Instance
            service = new Service();

            // Proposition
            string result = service.Proposition(inputBox.Text.ToLower());

            if (result == null)
            {
                MessageBox.Show("Ups, you did something wrong!");
            }
            else
            {
                try
                {
                    TruthTableStructure simplifiedTable = service.GetSimplifiedTableService();
                    truthTableSimplified_lb.Items.Add(string.Join("\t", simplifiedTable.Description));
                    foreach (TruthTableRow row in simplifiedTable.TableRows)
                    {
                        string oneRow;
                        oneRow = string.Join("\t", row.OutputValues);
                        oneRow += $"\t{row.FinalResult}";
                        truthTableSimplified_lb.Items.Add(oneRow);
                    }
                } catch (Exception)
                {
                    MessageBox.Show("Ups, you did something wrong!");
                }
            }
        }

        private void preview_btn_Click(object sender, EventArgs e)
        {
            Process process = new Process();

            process.StartInfo.FileName = "abc.png";
            process.StartInfo.Arguments = ($"-Tpng -o ./abc.png ./abc.dot");
            process.Start();
            
        }
    }
}
