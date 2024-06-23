namespace Cex25
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            textBox_CodeUniv = new TextBox();
            label4 = new Label();
            textBox_City = new TextBox();
            label3 = new Label();
            listBox1_Fac = new ListBox();
            label2 = new Label();
            listBox1_Univ = new ListBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox_CodeUniv);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox_City);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(listBox1_Fac);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(listBox1_Univ);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(85, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(655, 363);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "ExempluDB";
            // 
            // textBox_CodeUniv
            // 
            textBox_CodeUniv.Location = new Point(470, 206);
            textBox_CodeUniv.Name = "textBox_CodeUniv";
            textBox_CodeUniv.Size = new Size(125, 27);
            textBox_CodeUniv.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(467, 166);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 6;
            label4.Text = "Cod Univ";
            // 
            // textBox_City
            // 
            textBox_City.Location = new Point(473, 131);
            textBox_City.Name = "textBox_City";
            textBox_City.Size = new Size(125, 27);
            textBox_City.TabIndex = 5;
            textBox_City.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(470, 91);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 4;
            label3.Text = "Oras";
            // 
            // listBox1_Fac
            // 
            listBox1_Fac.FormattingEnabled = true;
            listBox1_Fac.ItemHeight = 20;
            listBox1_Fac.Location = new Point(252, 129);
            listBox1_Fac.Name = "listBox1_Fac";
            listBox1_Fac.Size = new Size(150, 104);
            listBox1_Fac.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(268, 86);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 2;
            label2.Text = "Facultati";
            // 
            // listBox1_Univ
            // 
            listBox1_Univ.FormattingEnabled = true;
            listBox1_Univ.ItemHeight = 20;
            listBox1_Univ.Location = new Point(76, 135);
            listBox1_Univ.Name = "listBox1_Univ";
            listBox1_Univ.Size = new Size(150, 104);
            listBox1_Univ.TabIndex = 1;
            listBox1_Univ.SelectedIndexChanged += listBox1_Univ_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 86);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 0;
            label1.Text = "Universitati";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox listBox1_Univ;
        private Label label1;
        private ListBox listBox1_Fac;
        private Label label2;
        private TextBox textBox_CodeUniv;
        private Label label4;
        private TextBox textBox_City;
        private Label label3;
    }
}