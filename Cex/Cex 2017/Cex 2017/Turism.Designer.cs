namespace Cex_2017
{
    partial class Turism
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
            this.InitializareBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // InitializareBtn
            // 
            this.InitializareBtn.Location = new System.Drawing.Point(12, 12);
            this.InitializareBtn.Name = "InitializareBtn";
            this.InitializareBtn.Size = new System.Drawing.Size(261, 68);
            this.InitializareBtn.TabIndex = 0;
            this.InitializareBtn.Text = "Initializare";
            this.InitializareBtn.UseVisualStyleBackColor = true;
            this.InitializareBtn.Click += new System.EventHandler(this.InitializareBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Turism
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 92);
            this.Controls.Add(this.InitializareBtn);
            this.Name = "Turism";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Turism_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button InitializareBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

