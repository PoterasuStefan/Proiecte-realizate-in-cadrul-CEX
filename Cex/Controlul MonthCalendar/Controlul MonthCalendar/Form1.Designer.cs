namespace Controlul_MonthCalendar
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
            this.myMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.myComboBox = new System.Windows.Forms.ComboBox();
            this.myLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // myMonthCalendar
            // 
            this.myMonthCalendar.Location = new System.Drawing.Point(282, 106);
            this.myMonthCalendar.Name = "myMonthCalendar";
            this.myMonthCalendar.TabIndex = 0;
            this.myMonthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.myMonthCalendar_DateSelected);
            // 
            // myComboBox
            // 
            this.myComboBox.FormattingEnabled = true;
            this.myComboBox.Location = new System.Drawing.Point(578, 120);
            this.myComboBox.Name = "myComboBox";
            this.myComboBox.Size = new System.Drawing.Size(121, 24);
            this.myComboBox.TabIndex = 1;
            // 
            // myLabel
            // 
            this.myLabel.AutoSize = true;
            this.myLabel.Location = new System.Drawing.Point(136, 47);
            this.myLabel.Name = "myLabel";
            this.myLabel.Size = new System.Drawing.Size(44, 16);
            this.myLabel.TabIndex = 2;
            this.myLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.myLabel);
            this.Controls.Add(this.myComboBox);
            this.Controls.Add(this.myMonthCalendar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar myMonthCalendar;
        private System.Windows.Forms.ComboBox myComboBox;
        private System.Windows.Forms.Label myLabel;
    }
}

