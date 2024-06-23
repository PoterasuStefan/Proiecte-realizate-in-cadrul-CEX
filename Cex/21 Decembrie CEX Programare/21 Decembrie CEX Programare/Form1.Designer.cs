namespace _21_Decembrie_CEX_Programare
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pacientiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programeaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planificatiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientiTotalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oreLibereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacientiToolStripMenuItem,
            this.listareToolStripMenuItem,
            this.iesireToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pacientiToolStripMenuItem
            // 
            this.pacientiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programeaToolStripMenuItem,
            this.oreLibereToolStripMenuItem});
            this.pacientiToolStripMenuItem.Name = "pacientiToolStripMenuItem";
            this.pacientiToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.pacientiToolStripMenuItem.Text = "Pacienti";
            // 
            // listareToolStripMenuItem
            // 
            this.listareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.planificatiToolStripMenuItem});
            this.listareToolStripMenuItem.Name = "listareToolStripMenuItem";
            this.listareToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.listareToolStripMenuItem.Text = "Listare";
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.iesireToolStripMenuItem.Text = "Iesire";
            this.iesireToolStripMenuItem.Click += new System.EventHandler(this.iesireToolStripMenuItem_Click);
            // 
            // programeaToolStripMenuItem
            // 
            this.programeaToolStripMenuItem.Name = "programeaToolStripMenuItem";
            this.programeaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.programeaToolStripMenuItem.Text = "Programeaza";
            this.programeaToolStripMenuItem.Click += new System.EventHandler(this.programeaToolStripMenuItem_Click);
            // 
            // planificatiToolStripMenuItem
            // 
            this.planificatiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientiTotalToolStripMenuItem});
            this.planificatiToolStripMenuItem.Name = "planificatiToolStripMenuItem";
            this.planificatiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.planificatiToolStripMenuItem.Text = "Planificati";
            this.planificatiToolStripMenuItem.Click += new System.EventHandler(this.planificatiToolStripMenuItem_Click);
            // 
            // clientiTotalToolStripMenuItem
            // 
            this.clientiTotalToolStripMenuItem.Name = "clientiTotalToolStripMenuItem";
            this.clientiTotalToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.clientiTotalToolStripMenuItem.Text = "Clienti total";
            this.clientiTotalToolStripMenuItem.Click += new System.EventHandler(this.clientiTotalToolStripMenuItem_Click);
            // 
            // oreLibereToolStripMenuItem
            // 
            this.oreLibereToolStripMenuItem.Name = "oreLibereToolStripMenuItem";
            this.oreLibereToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.oreLibereToolStripMenuItem.Text = "Ore Libere";
            this.oreLibereToolStripMenuItem.Click += new System.EventHandler(this.oreLibereToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pacientiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programeaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planificatiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientiTotalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oreLibereToolStripMenuItem;
    }
}

