namespace Puzzle_Poterasu_Stefan
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnJucator = new System.Windows.Forms.Button();
            this.BtnAdmin = new System.Windows.Forms.Button();
            this.textBoxNumeJucator = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxParolaJucator = new System.Windows.Forms.TextBox();
            this.groupBoxJucator = new System.Windows.Forms.GroupBox();
            this.LoginJucator = new System.Windows.Forms.Button();
            this.groupBoxAdministrator = new System.Windows.Forms.GroupBox();
            this.LoginAdministrator = new System.Windows.Forms.Button();
            this.textBoxParolaAdministrator = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNumeAdministrator = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonJocNou = new System.Windows.Forms.Button();
            this.groupBoxJucator.SuspendLayout();
            this.groupBoxAdministrator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Autentificare:";
            // 
            // BtnJucator
            // 
            this.BtnJucator.Location = new System.Drawing.Point(304, 139);
            this.BtnJucator.Name = "BtnJucator";
            this.BtnJucator.Size = new System.Drawing.Size(148, 23);
            this.BtnJucator.TabIndex = 1;
            this.BtnJucator.Text = "Cont Jucator";
            this.BtnJucator.UseVisualStyleBackColor = true;
            this.BtnJucator.Click += new System.EventHandler(this.BtnJucator_Click);
            // 
            // BtnAdmin
            // 
            this.BtnAdmin.Location = new System.Drawing.Point(304, 178);
            this.BtnAdmin.Name = "BtnAdmin";
            this.BtnAdmin.Size = new System.Drawing.Size(148, 23);
            this.BtnAdmin.TabIndex = 2;
            this.BtnAdmin.Text = "Cont Administrator";
            this.BtnAdmin.UseVisualStyleBackColor = true;
            this.BtnAdmin.Click += new System.EventHandler(this.BtnAdmin_Click);
            // 
            // textBoxNumeJucator
            // 
            this.textBoxNumeJucator.Location = new System.Drawing.Point(69, 26);
            this.textBoxNumeJucator.Name = "textBoxNumeJucator";
            this.textBoxNumeJucator.Size = new System.Drawing.Size(186, 22);
            this.textBoxNumeJucator.TabIndex = 3;
            this.textBoxNumeJucator.Text = "jucator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nume :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Parola: ";
            // 
            // textBoxParolaJucator
            // 
            this.textBoxParolaJucator.Location = new System.Drawing.Point(69, 54);
            this.textBoxParolaJucator.Name = "textBoxParolaJucator";
            this.textBoxParolaJucator.Size = new System.Drawing.Size(186, 22);
            this.textBoxParolaJucator.TabIndex = 5;
            this.textBoxParolaJucator.Text = "ParolaJucator";
            // 
            // groupBoxJucator
            // 
            this.groupBoxJucator.Controls.Add(this.LoginJucator);
            this.groupBoxJucator.Controls.Add(this.textBoxParolaJucator);
            this.groupBoxJucator.Controls.Add(this.label3);
            this.groupBoxJucator.Controls.Add(this.textBoxNumeJucator);
            this.groupBoxJucator.Controls.Add(this.label2);
            this.groupBoxJucator.Location = new System.Drawing.Point(215, 207);
            this.groupBoxJucator.Name = "groupBoxJucator";
            this.groupBoxJucator.Size = new System.Drawing.Size(352, 86);
            this.groupBoxJucator.TabIndex = 7;
            this.groupBoxJucator.TabStop = false;
            this.groupBoxJucator.Text = "Cont jucator";
            this.groupBoxJucator.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // LoginJucator
            // 
            this.LoginJucator.Location = new System.Drawing.Point(261, 39);
            this.LoginJucator.Name = "LoginJucator";
            this.LoginJucator.Size = new System.Drawing.Size(75, 23);
            this.LoginJucator.TabIndex = 9;
            this.LoginJucator.Text = "Login";
            this.LoginJucator.UseVisualStyleBackColor = true;
            this.LoginJucator.Click += new System.EventHandler(this.LoginJucator_Click);
            // 
            // groupBoxAdministrator
            // 
            this.groupBoxAdministrator.Controls.Add(this.LoginAdministrator);
            this.groupBoxAdministrator.Controls.Add(this.textBoxParolaAdministrator);
            this.groupBoxAdministrator.Controls.Add(this.label4);
            this.groupBoxAdministrator.Controls.Add(this.textBoxNumeAdministrator);
            this.groupBoxAdministrator.Controls.Add(this.label5);
            this.groupBoxAdministrator.Location = new System.Drawing.Point(215, 313);
            this.groupBoxAdministrator.Name = "groupBoxAdministrator";
            this.groupBoxAdministrator.Size = new System.Drawing.Size(356, 85);
            this.groupBoxAdministrator.TabIndex = 8;
            this.groupBoxAdministrator.TabStop = false;
            this.groupBoxAdministrator.Text = "Cont Administrator";
            // 
            // LoginAdministrator
            // 
            this.LoginAdministrator.Location = new System.Drawing.Point(261, 40);
            this.LoginAdministrator.Name = "LoginAdministrator";
            this.LoginAdministrator.Size = new System.Drawing.Size(75, 23);
            this.LoginAdministrator.TabIndex = 10;
            this.LoginAdministrator.Text = "Login";
            this.LoginAdministrator.UseVisualStyleBackColor = true;
            this.LoginAdministrator.Click += new System.EventHandler(this.LoginAdministrator_Click);
            // 
            // textBoxParolaAdministrator
            // 
            this.textBoxParolaAdministrator.Location = new System.Drawing.Point(69, 54);
            this.textBoxParolaAdministrator.Name = "textBoxParolaAdministrator";
            this.textBoxParolaAdministrator.Size = new System.Drawing.Size(186, 22);
            this.textBoxParolaAdministrator.TabIndex = 5;
            this.textBoxParolaAdministrator.Text = "ParolaAdministrator";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Parola: ";
            // 
            // textBoxNumeAdministrator
            // 
            this.textBoxNumeAdministrator.Location = new System.Drawing.Point(69, 26);
            this.textBoxNumeAdministrator.Name = "textBoxNumeAdministrator";
            this.textBoxNumeAdministrator.Size = new System.Drawing.Size(186, 22);
            this.textBoxNumeAdministrator.TabIndex = 3;
            this.textBoxNumeAdministrator.Text = "administrator";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nume :";
            // 
            // buttonJocNou
            // 
            this.buttonJocNou.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonJocNou.Location = new System.Drawing.Point(573, 213);
            this.buttonJocNou.Name = "buttonJocNou";
            this.buttonJocNou.Size = new System.Drawing.Size(215, 80);
            this.buttonJocNou.TabIndex = 9;
            this.buttonJocNou.Text = "Joc Nou ->";
            this.buttonJocNou.UseVisualStyleBackColor = true;
            this.buttonJocNou.Click += new System.EventHandler(this.buttonJocNou_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonJocNou);
            this.Controls.Add(this.groupBoxAdministrator);
            this.Controls.Add(this.groupBoxJucator);
            this.Controls.Add(this.BtnAdmin);
            this.Controls.Add(this.BtnJucator);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxJucator.ResumeLayout(false);
            this.groupBoxJucator.PerformLayout();
            this.groupBoxAdministrator.ResumeLayout(false);
            this.groupBoxAdministrator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnJucator;
        private System.Windows.Forms.Button BtnAdmin;
        private System.Windows.Forms.TextBox textBoxNumeJucator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxParolaJucator;
        private System.Windows.Forms.GroupBox groupBoxJucator;
        private System.Windows.Forms.GroupBox groupBoxAdministrator;
        private System.Windows.Forms.TextBox textBoxParolaAdministrator;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNumeAdministrator;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button LoginJucator;
        private System.Windows.Forms.Button LoginAdministrator;
        private System.Windows.Forms.Button buttonJocNou;
    }
}

