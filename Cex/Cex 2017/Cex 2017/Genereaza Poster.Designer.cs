namespace Cex_2017
{
    partial class Genereaza_Poster
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
            this.components = new System.ComponentModel.Container();
            this.comboBoxLocalitati = new System.Windows.Forms.ComboBox();
            this.turismDataSet = new Cex_2017.TurismDataSet();
            this.localitatiTableAdapter = new Cex_2017.TurismDataSetTableAdapters.LocalitatiTableAdapter();
            this.localitatiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.turismDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localitatiBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxLocalitati
            // 
            this.comboBoxLocalitati.DataSource = this.localitatiBindingSource1;
            this.comboBoxLocalitati.DisplayMember = "Nume";
            this.comboBoxLocalitati.FormattingEnabled = true;
            this.comboBoxLocalitati.Location = new System.Drawing.Point(12, 12);
            this.comboBoxLocalitati.Name = "comboBoxLocalitati";
            this.comboBoxLocalitati.Size = new System.Drawing.Size(121, 24);
            this.comboBoxLocalitati.TabIndex = 0;
            // 
            // turismDataSet
            // 
            this.turismDataSet.DataSetName = "TurismDataSet";
            this.turismDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // localitatiTableAdapter
            // 
            this.localitatiTableAdapter.ClearBeforeFill = true;
            // 
            // localitatiBindingSource1
            // 
            this.localitatiBindingSource1.DataMember = "Localitati";
            this.localitatiBindingSource1.DataSource = this.turismDataSet;
            // 
            // Genereaza_Poster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxLocalitati);
            this.Name = "Genereaza_Poster";
            this.Text = "Genereaza_Poster";
            this.Load += new System.EventHandler(this.Genereaza_Poster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.turismDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localitatiBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxLocalitati;
        private TurismDataSet turismDataSet;
        private TurismDataSetTableAdapters.LocalitatiTableAdapter localitatiTableAdapter;
        private System.Windows.Forms.BindingSource localitatiBindingSource1;
    }
}