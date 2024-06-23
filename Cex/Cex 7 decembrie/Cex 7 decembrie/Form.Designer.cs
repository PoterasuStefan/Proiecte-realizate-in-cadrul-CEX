namespace Cex_7_decembrie
{
    partial class Form
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
            btn_click = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            btncopy = new Button();
            btn_next = new Button();
            SuspendLayout();
            // 
            // btn_click
            // 
            btn_click.Location = new Point(537, 369);
            btn_click.Name = "btn_click";
            btn_click.Size = new Size(94, 29);
            btn_click.TabIndex = 0;
            btn_click.Text = "Click";
            btn_click.UseVisualStyleBackColor = true;
            btn_click.Click += btn_click_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(379, 191);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(339, 194);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 2;
            label1.Text = "text";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(299, 231);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 4;
            label2.Text = "Copy Text";
            label2.Click += label2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(379, 224);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // btncopy
            // 
            btncopy.Location = new Point(384, 369);
            btncopy.Name = "btncopy";
            btncopy.Size = new Size(94, 29);
            btncopy.TabIndex = 5;
            btncopy.Text = "Copy";
            btncopy.UseVisualStyleBackColor = true;
            btncopy.Click += btncopy_Click;
            // 
            // btn_next
            // 
            btn_next.Location = new Point(233, 369);
            btn_next.Name = "btn_next";
            btn_next.Size = new Size(94, 29);
            btn_next.TabIndex = 6;
            btn_next.Text = "Next";
            btn_next.UseVisualStyleBackColor = true;
            btn_next.Click += btn_next_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_next);
            Controls.Add(btncopy);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(btn_click);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_click;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Button btncopy;
        private Button btn_next;
    }
}