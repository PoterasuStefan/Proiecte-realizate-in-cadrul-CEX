using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOOD_FOOD_CEX
{
    public partial class Optiuni : Form
    {
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\spote\\source\\repos\\GOOD FOOD CEX\\GOOD FOOD CEX\\Database1.mdf\";Integrated Security=True";
        string meniupath = "C:\\Users\\spote\\source\\repos\\GOOD FOOD CEX\\GOOD FOOD CEX\\Resources\\meniu.txt";
        Autentificare autentificare = new Autentificare();
        public Optiuni(int userId)
        {
            InitializeComponent();
            _userId=userId;
            
        }
        int _userId;
        int varsta, inaltime, greutate, kcal;


        bool loaded = false;
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (loaded == false)
            {
                try
                {
                   
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        using (StreamReader sr = new StreamReader(meniupath))
                        {
                            sr.ReadLine(); // Skip the header line

                            string line;
                            while ((line = sr.ReadLine()) != null)
                            {
                                string[] fields = line.Split(';');
                                
                                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Meniu (id_comanda, denumire_produs, descriere, pret, kcal, felul) VALUES (@id_produs, @denumire_produs, @descriere, @pret, @Kcal, @felul)", connection))
                                    {
                                        cmd.Parameters.AddWithValue("@id_produs", fields[0]);
                                        cmd.Parameters.AddWithValue("@denumire_produs", fields[1]);
                                        cmd.Parameters.AddWithValue("@descriere", fields[2]);
                                        cmd.Parameters.AddWithValue("@pret", fields[3]);
                                        cmd.Parameters.AddWithValue("@Kcal", fields[4]);
                                        cmd.Parameters.AddWithValue("@felul", fields[5]);

                                        cmd.ExecuteNonQuery();
                                    }
                                
                            }
                        }
                    }


                    foreach (DataGridView row in dataGridView1.Rows)
                    {
                        
                    }
                   


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                   // MessageBox.Show($"Error: {ex.Message}");

                }
                loaded =true;

                if (dataGridView1.Columns.Contains("Cantitate"))  // Check if column exists
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        dataGridView1.Rows[i].Cells["Cantitate"].Value = 1;


                    }
                }
                else
                {
                    // Handle the case where the "Cantitate" column is not found
                    MessageBox.Show("Could not find a column named 'Cantitate'.");
                }
            }


            //Comanda

            dataGridView1.AutoGenerateColumns = false;
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Adauga";
            
            dataGridView1.Columns.Add(buttonColumn);
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            



        }

        private SqlDataAdapter menuAdapter;

        private void Optiuni_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Meniu' table. You can move, or remove it, as needed.
            this.meniuTableAdapter.Fill(this.database1DataSet.Meniu);




        }


        int totalkcal, totalpret;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is a button column and the button was clicked
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && // Ensure valid indices
                dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.ColumnIndex == ((DataGridViewButtonColumn)dataGridView1.Columns[e.ColumnIndex]).DisplayIndex)
            {
                // Handle button click logic here

                int cantitate = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["cantitate"].Value);
                int kcal = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["kcalDataGridViewTextBoxColumn"].Value);
                int pret = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["pretDataGridViewTextBoxColumn"].Value);

                totalkcal += kcal * cantitate;
                totalpret += pret * cantitate;

                TotalKcalTextbox.Text = totalkcal.ToString();
                PretTotalTextbox.Text=totalpret.ToString();



            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void CalculeazaBtn_Click(object sender, EventArgs e)
        {
            inaltime = int.Parse(InaltimeTextbox.Text);
            varsta = int.Parse(VarstaTextbox.Text);
            greutate = int.Parse(GreutateTextbox.Text);

            int s = inaltime + varsta + greutate;

            if (s < 250)
            {
                kcal = 1800;
            }
            else if (s < 275 && s > 250)
            {
                kcal = 2200;
            }
            else { kcal = 2500;
            }

            string sql = @"UPDATE [dbo].[Clienti] 
                            SET kcal_zilnice = @kcal_zilnice
                            WHERE [id_client] = @id_client;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@kcal_zilnice", kcal);
                    command.Parameters.AddWithValue("@id_client", _userId);


                    command.ExecuteNonQuery();

                }



            }
            label5.Text = kcal.ToString();
            NecesarZilnicTextbox.Text = kcal.ToString();

        }

    }
}
