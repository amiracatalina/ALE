namespace ALE___Week_1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.submit = new System.Windows.Forms.Button();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.simplified_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.nandify_box = new System.Windows.Forms.TextBox();
            this.normalize_simplified_box = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.normalize_prefix_box = new System.Windows.Forms.TextBox();
            this.normalize_box = new System.Windows.Forms.TextBox();
            this.hex_box = new System.Windows.Forms.TextBox();
            this.variables_box = new System.Windows.Forms.TextBox();
            this.output_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.variable_label = new System.Windows.Forms.Label();
            this.output_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.truthTable_lb = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.truthTableSimplified_lb = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.propositions_lb = new System.Windows.Forms.ListBox();
            this.btn_showProps = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.graph_Box = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.preview_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graph_Box)).BeginInit();
            this.SuspendLayout();
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.OrangeRed;
            this.submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submit.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.submit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.submit.Location = new System.Drawing.Point(435, 37);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(185, 46);
            this.submit.TabIndex = 0;
            this.submit.Text = "Create";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // inputBox
            // 
            this.inputBox.AcceptsReturn = true;
            this.inputBox.Location = new System.Drawing.Point(14, 56);
            this.inputBox.Multiline = true;
            this.inputBox.Name = "inputBox";
            this.inputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputBox.Size = new System.Drawing.Size(267, 27);
            this.inputBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox1.Controls.Add(this.simplified_btn);
            this.groupBox1.Controls.Add(this.submit);
            this.groupBox1.Controls.Add(this.inputBox);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(23, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(641, 130);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // simplified_btn
            // 
            this.simplified_btn.BackColor = System.Drawing.Color.OrangeRed;
            this.simplified_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.simplified_btn.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.simplified_btn.Location = new System.Drawing.Point(451, 88);
            this.simplified_btn.Name = "simplified_btn";
            this.simplified_btn.Size = new System.Drawing.Size(151, 36);
            this.simplified_btn.TabIndex = 2;
            this.simplified_btn.Text = "Generate Simplified";
            this.simplified_btn.UseVisualStyleBackColor = false;
            this.simplified_btn.Click += new System.EventHandler(this.simplified_btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.nandify_box);
            this.groupBox2.Controls.Add(this.normalize_simplified_box);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.normalize_prefix_box);
            this.groupBox2.Controls.Add(this.normalize_box);
            this.groupBox2.Controls.Add(this.hex_box);
            this.groupBox2.Controls.Add(this.variables_box);
            this.groupBox2.Controls.Add(this.output_box);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.variable_label);
            this.groupBox2.Controls.Add(this.output_label);
            this.groupBox2.Location = new System.Drawing.Point(23, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(641, 363);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(10, 322);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 27);
            this.label10.TabIndex = 18;
            this.label10.Text = "Nandify";
            // 
            // nandify_box
            // 
            this.nandify_box.AcceptsReturn = true;
            this.nandify_box.Location = new System.Drawing.Point(228, 322);
            this.nandify_box.Multiline = true;
            this.nandify_box.Name = "nandify_box";
            this.nandify_box.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.nandify_box.Size = new System.Drawing.Size(401, 32);
            this.nandify_box.TabIndex = 17;
            // 
            // normalize_simplified_box
            // 
            this.normalize_simplified_box.AcceptsReturn = true;
            this.normalize_simplified_box.Location = new System.Drawing.Point(228, 272);
            this.normalize_simplified_box.Multiline = true;
            this.normalize_simplified_box.Name = "normalize_simplified_box";
            this.normalize_simplified_box.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.normalize_simplified_box.Size = new System.Drawing.Size(401, 34);
            this.normalize_simplified_box.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(10, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(212, 27);
            this.label9.TabIndex = 15;
            this.label9.Text = "Normalized Simplified";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(10, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 27);
            this.label8.TabIndex = 14;
            this.label8.Text = "Normalized Prefix";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(10, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 27);
            this.label7.TabIndex = 13;
            this.label7.Text = "Normalize";
            // 
            // normalize_prefix_box
            // 
            this.normalize_prefix_box.AcceptsReturn = true;
            this.normalize_prefix_box.Location = new System.Drawing.Point(228, 220);
            this.normalize_prefix_box.Multiline = true;
            this.normalize_prefix_box.Name = "normalize_prefix_box";
            this.normalize_prefix_box.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.normalize_prefix_box.Size = new System.Drawing.Size(401, 37);
            this.normalize_prefix_box.TabIndex = 11;
            // 
            // normalize_box
            // 
            this.normalize_box.AcceptsReturn = true;
            this.normalize_box.Location = new System.Drawing.Point(228, 173);
            this.normalize_box.Multiline = true;
            this.normalize_box.Name = "normalize_box";
            this.normalize_box.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.normalize_box.Size = new System.Drawing.Size(401, 35);
            this.normalize_box.TabIndex = 10;
            // 
            // hex_box
            // 
            this.hex_box.AcceptsReturn = true;
            this.hex_box.Location = new System.Drawing.Point(228, 125);
            this.hex_box.Multiline = true;
            this.hex_box.Name = "hex_box";
            this.hex_box.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.hex_box.Size = new System.Drawing.Size(401, 36);
            this.hex_box.TabIndex = 9;
            // 
            // variables_box
            // 
            this.variables_box.AcceptsReturn = true;
            this.variables_box.Location = new System.Drawing.Point(228, 74);
            this.variables_box.Multiline = true;
            this.variables_box.Name = "variables_box";
            this.variables_box.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.variables_box.Size = new System.Drawing.Size(401, 37);
            this.variables_box.TabIndex = 8;
            // 
            // output_box
            // 
            this.output_box.AcceptsReturn = true;
            this.output_box.Location = new System.Drawing.Point(228, 26);
            this.output_box.Multiline = true;
            this.output_box.Name = "output_box";
            this.output_box.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.output_box.Size = new System.Drawing.Size(401, 35);
            this.output_box.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(10, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Hex Value";
            // 
            // variable_label
            // 
            this.variable_label.AutoSize = true;
            this.variable_label.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold);
            this.variable_label.Location = new System.Drawing.Point(10, 82);
            this.variable_label.Name = "variable_label";
            this.variable_label.Size = new System.Drawing.Size(97, 27);
            this.variable_label.TabIndex = 2;
            this.variable_label.Text = "Variables";
            // 
            // output_label
            // 
            this.output_label.AutoSize = true;
            this.output_label.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold);
            this.output_label.Location = new System.Drawing.Point(10, 30);
            this.output_label.Name = "output_label";
            this.output_label.Size = new System.Drawing.Size(75, 27);
            this.output_label.TabIndex = 1;
            this.output_label.Text = "Output";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Proposition";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1239, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 38);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tree";
            // 
            // truthTable_lb
            // 
            this.truthTable_lb.BackColor = System.Drawing.Color.LightSeaGreen;
            this.truthTable_lb.FormattingEnabled = true;
            this.truthTable_lb.HorizontalScrollbar = true;
            this.truthTable_lb.ItemHeight = 16;
            this.truthTable_lb.Location = new System.Drawing.Point(670, 71);
            this.truthTable_lb.Name = "truthTable_lb";
            this.truthTable_lb.Size = new System.Drawing.Size(523, 324);
            this.truthTable_lb.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(833, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 38);
            this.label3.TabIndex = 9;
            this.label3.Text = "Truth Table";
            // 
            // truthTableSimplified_lb
            // 
            this.truthTableSimplified_lb.BackColor = System.Drawing.Color.LightSeaGreen;
            this.truthTableSimplified_lb.FormattingEnabled = true;
            this.truthTableSimplified_lb.HorizontalScrollbar = true;
            this.truthTableSimplified_lb.ItemHeight = 16;
            this.truthTableSimplified_lb.Location = new System.Drawing.Point(1368, 69);
            this.truthTableSimplified_lb.Name = "truthTableSimplified_lb";
            this.truthTableSimplified_lb.Size = new System.Drawing.Size(553, 324);
            this.truthTableSimplified_lb.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(1505, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(318, 38);
            this.label5.TabIndex = 11;
            this.label5.Text = "Truth Table Simplified";
            // 
            // propositions_lb
            // 
            this.propositions_lb.BackColor = System.Drawing.Color.LightSeaGreen;
            this.propositions_lb.FormattingEnabled = true;
            this.propositions_lb.ItemHeight = 16;
            this.propositions_lb.Location = new System.Drawing.Point(108, 642);
            this.propositions_lb.Name = "propositions_lb";
            this.propositions_lb.Size = new System.Drawing.Size(350, 244);
            this.propositions_lb.TabIndex = 12;
            this.propositions_lb.SelectedIndexChanged += new System.EventHandler(this.propositions_lb_SelectedIndexChanged);
            // 
            // btn_showProps
            // 
            this.btn_showProps.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_showProps.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_showProps.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.btn_showProps.Location = new System.Drawing.Point(177, 892);
            this.btn_showProps.Name = "btn_showProps";
            this.btn_showProps.Size = new System.Drawing.Size(205, 74);
            this.btn_showProps.TabIndex = 13;
            this.btn_showProps.Text = "Show list with propositions";
            this.btn_showProps.UseVisualStyleBackColor = false;
            this.btn_showProps.Click += new System.EventHandler(this.btn_showProps_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(200, 598);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 38);
            this.label6.TabIndex = 14;
            this.label6.Text = "Propositions";
            // 
            // graph_Box
            // 
            this.graph_Box.Location = new System.Drawing.Point(670, 448);
            this.graph_Box.Name = "graph_Box";
            this.graph_Box.Size = new System.Drawing.Size(1242, 550);
            this.graph_Box.TabIndex = 5;
            this.graph_Box.TabStop = false;
            // 
            // preview_btn
            // 
            this.preview_btn.BackColor = System.Drawing.Color.OrangeRed;
            this.preview_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.preview_btn.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.preview_btn.Location = new System.Drawing.Point(553, 908);
            this.preview_btn.Name = "preview_btn";
            this.preview_btn.Size = new System.Drawing.Size(111, 58);
            this.preview_btn.TabIndex = 15;
            this.preview_btn.Text = "Preview image";
            this.preview_btn.UseVisualStyleBackColor = false;
            this.preview_btn.Click += new System.EventHandler(this.preview_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 1008);
            this.Controls.Add(this.preview_btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_showProps);
            this.Controls.Add(this.propositions_lb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.truthTableSimplified_lb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.truthTable_lb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.graph_Box);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "ALE Application";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graph_Box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label variable_label;
        private System.Windows.Forms.Label output_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox truthTable_lb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox truthTableSimplified_lb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox propositions_lb;
        private System.Windows.Forms.Button btn_showProps;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button simplified_btn;
        private System.Windows.Forms.PictureBox graph_Box;
        private System.Windows.Forms.TextBox output_box;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox normalize_prefix_box;
        private System.Windows.Forms.TextBox normalize_box;
        private System.Windows.Forms.TextBox hex_box;
        private System.Windows.Forms.TextBox variables_box;
        private System.Windows.Forms.TextBox normalize_simplified_box;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox nandify_box;
        private System.Windows.Forms.Button preview_btn;
    }
}

