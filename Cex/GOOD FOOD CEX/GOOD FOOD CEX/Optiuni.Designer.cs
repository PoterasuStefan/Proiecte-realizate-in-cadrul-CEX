namespace GOOD_FOOD_CEX
{
    partial class Optiuni
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CalculeazaBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GreutateTextbox = new System.Windows.Forms.TextBox();
            this.InaltimeTextbox = new System.Windows.Forms.TextBox();
            this.VarstaTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TotalKcalTextbox = new System.Windows.Forms.TextBox();
            this.PretTotalTextbox = new System.Windows.Forms.TextBox();
            this.NecesarZilnicTextbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idcomandaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denumireprodusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kcalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.felulDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantitate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meniuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new GOOD_FOOD_CEX.Database1DataSet();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.meniuTableAdapter = new GOOD_FOOD_CEX.Database1DataSetTableAdapters.MeniuTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meniuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(963, 426);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.CalculeazaBtn);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.GreutateTextbox);
            this.tabPage1.Controls.Add(this.InaltimeTextbox);
            this.tabPage1.Controls.Add(this.VarstaTextbox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(955, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CalculatorKcal";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // CalculeazaBtn
            // 
            this.CalculeazaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculeazaBtn.Location = new System.Drawing.Point(230, 213);
            this.CalculeazaBtn.Name = "CalculeazaBtn";
            this.CalculeazaBtn.Size = new System.Drawing.Size(175, 46);
            this.CalculeazaBtn.TabIndex = 8;
            this.CalculeazaBtn.Text = "Calculeaza";
            this.CalculeazaBtn.UseVisualStyleBackColor = true;
            this.CalculeazaBtn.Click += new System.EventHandler(this.CalculeazaBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(429, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "----";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Necesar zilnic:";
            // 
            // GreutateTextbox
            // 
            this.GreutateTextbox.Location = new System.Drawing.Point(160, 141);
            this.GreutateTextbox.Name = "GreutateTextbox";
            this.GreutateTextbox.Size = new System.Drawing.Size(100, 22);
            this.GreutateTextbox.TabIndex = 5;
            // 
            // InaltimeTextbox
            // 
            this.InaltimeTextbox.Location = new System.Drawing.Point(160, 111);
            this.InaltimeTextbox.Name = "InaltimeTextbox";
            this.InaltimeTextbox.Size = new System.Drawing.Size(100, 22);
            this.InaltimeTextbox.TabIndex = 4;
            // 
            // VarstaTextbox
            // 
            this.VarstaTextbox.Location = new System.Drawing.Point(160, 80);
            this.VarstaTextbox.Name = "VarstaTextbox";
            this.VarstaTextbox.Size = new System.Drawing.Size(100, 22);
            this.VarstaTextbox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Greutate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Inaltime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Varsta";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TotalKcalTextbox);
            this.tabPage2.Controls.Add(this.PretTotalTextbox);
            this.tabPage2.Controls.Add(this.NecesarZilnicTextbox);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(955, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Comanda";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TotalKcalTextbox
            // 
            this.TotalKcalTextbox.Location = new System.Drawing.Point(348, 362);
            this.TotalKcalTextbox.Name = "TotalKcalTextbox";
            this.TotalKcalTextbox.ReadOnly = true;
            this.TotalKcalTextbox.Size = new System.Drawing.Size(100, 22);
            this.TotalKcalTextbox.TabIndex = 7;
            // 
            // PretTotalTextbox
            // 
            this.PretTotalTextbox.Location = new System.Drawing.Point(572, 362);
            this.PretTotalTextbox.Name = "PretTotalTextbox";
            this.PretTotalTextbox.ReadOnly = true;
            this.PretTotalTextbox.Size = new System.Drawing.Size(100, 22);
            this.PretTotalTextbox.TabIndex = 7;
            // 
            // NecesarZilnicTextbox
            // 
            this.NecesarZilnicTextbox.Location = new System.Drawing.Point(110, 365);
            this.NecesarZilnicTextbox.Name = "NecesarZilnicTextbox";
            this.NecesarZilnicTextbox.ReadOnly = true;
            this.NecesarZilnicTextbox.Size = new System.Drawing.Size(100, 22);
            this.NecesarZilnicTextbox.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(501, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Pret Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(276, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Total kcal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Necesar zilnic";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(678, 362);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 22);
            this.button2.TabIndex = 2;
            this.button2.Text = "Comanda";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcomandaDataGridViewTextBoxColumn,
            this.denumireprodusDataGridViewTextBoxColumn,
            this.descriereDataGridViewTextBoxColumn,
            this.pretDataGridViewTextBoxColumn,
            this.kcalDataGridViewTextBoxColumn,
            this.felulDataGridViewTextBoxColumn,
            this.Cantitate});
            this.dataGridView1.DataSource = this.meniuBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(943, 286);
            this.dataGridView1.TabIndex = 0;
            // 
            // idcomandaDataGridViewTextBoxColumn
            // 
            this.idcomandaDataGridViewTextBoxColumn.DataPropertyName = "id_comanda";
            this.idcomandaDataGridViewTextBoxColumn.HeaderText = "id_comanda";
            this.idcomandaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idcomandaDataGridViewTextBoxColumn.Name = "idcomandaDataGridViewTextBoxColumn";
            this.idcomandaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idcomandaDataGridViewTextBoxColumn.Width = 125;
            // 
            // denumireprodusDataGridViewTextBoxColumn
            // 
            this.denumireprodusDataGridViewTextBoxColumn.DataPropertyName = "denumire_produs";
            this.denumireprodusDataGridViewTextBoxColumn.HeaderText = "denumire_produs";
            this.denumireprodusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.denumireprodusDataGridViewTextBoxColumn.Name = "denumireprodusDataGridViewTextBoxColumn";
            this.denumireprodusDataGridViewTextBoxColumn.ReadOnly = true;
            this.denumireprodusDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriereDataGridViewTextBoxColumn
            // 
            this.descriereDataGridViewTextBoxColumn.DataPropertyName = "descriere";
            this.descriereDataGridViewTextBoxColumn.HeaderText = "descriere";
            this.descriereDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriereDataGridViewTextBoxColumn.Name = "descriereDataGridViewTextBoxColumn";
            this.descriereDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriereDataGridViewTextBoxColumn.Width = 125;
            // 
            // pretDataGridViewTextBoxColumn
            // 
            this.pretDataGridViewTextBoxColumn.DataPropertyName = "pret";
            this.pretDataGridViewTextBoxColumn.HeaderText = "pret";
            this.pretDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pretDataGridViewTextBoxColumn.Name = "pretDataGridViewTextBoxColumn";
            this.pretDataGridViewTextBoxColumn.ReadOnly = true;
            this.pretDataGridViewTextBoxColumn.Width = 125;
            // 
            // kcalDataGridViewTextBoxColumn
            // 
            this.kcalDataGridViewTextBoxColumn.DataPropertyName = "kcal";
            this.kcalDataGridViewTextBoxColumn.HeaderText = "kcal";
            this.kcalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kcalDataGridViewTextBoxColumn.Name = "kcalDataGridViewTextBoxColumn";
            this.kcalDataGridViewTextBoxColumn.ReadOnly = true;
            this.kcalDataGridViewTextBoxColumn.Width = 125;
            // 
            // felulDataGridViewTextBoxColumn
            // 
            this.felulDataGridViewTextBoxColumn.DataPropertyName = "felul";
            this.felulDataGridViewTextBoxColumn.HeaderText = "felul";
            this.felulDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.felulDataGridViewTextBoxColumn.Name = "felulDataGridViewTextBoxColumn";
            this.felulDataGridViewTextBoxColumn.ReadOnly = true;
            this.felulDataGridViewTextBoxColumn.Width = 125;
            // 
            // Cantitate
            // 
            this.Cantitate.HeaderText = "Cantitate";
            this.Cantitate.MinimumWidth = 6;
            this.Cantitate.Name = "Cantitate";
            this.Cantitate.ReadOnly = true;
            this.Cantitate.Width = 125;
            // 
            // meniuBindingSource
            // 
            this.meniuBindingSource.DataMember = "Meniu";
            this.meniuBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(955, 397);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Generare Meniu";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(955, 397);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = " Grafic Kcal";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // meniuTableAdapter
            // 
            this.meniuTableAdapter.ClearBeforeFill = true;
            // 
            // Optiuni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Optiuni";
            this.Text = "Optiuni";
            this.Load += new System.EventHandler(this.Optiuni_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meniuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox GreutateTextbox;
        private System.Windows.Forms.TextBox InaltimeTextbox;
        private System.Windows.Forms.TextBox VarstaTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button CalculeazaBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TotalKcalTextbox;
        private System.Windows.Forms.TextBox PretTotalTextbox;
        private System.Windows.Forms.TextBox NecesarZilnicTextbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource meniuBindingSource;
        private Database1DataSetTableAdapters.MeniuTableAdapter meniuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcomandaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireprodusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriereDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kcalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn felulDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantitate;
    }
}