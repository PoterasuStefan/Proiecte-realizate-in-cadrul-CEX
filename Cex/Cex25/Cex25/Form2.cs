using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Identity.Client.NativeInterop;
using System.Security.Cryptography;

namespace Cex25
{
    public partial class Form2 : Form
    {
        SqlConnection myCon = new SqlConnection();
        DataSet dsUniv;
        DataSet dsFac;
        public Form2()
        {
            InitializeComponent();
            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\cex\cex25.01\cex25.01\Database1.mdf;Integrated Security=True";
            myCon.Open();
            dsUniv = new DataSet();
            dsFac = new DataSet();
            SqlDataAdapter daUniv = new SqlDataAdapter("SELECT*FROM Universitati", myCon);
            SqlDataAdapter daFac = new SqlDataAdapter("SELECT * FROM Facultati", myCon);
            daFac.Fill(dsFac, "Facultati");
            foreach (DataRow dr in dsUniv.Tables["Universitati"].Rows)
            {
                String name = dr.ItemArray.GetValue(1).ToString();
                listBox1_Univ.Items.Add(name);
            }
            myCon.Close();
        }


        private void button_Insert_Click(object sender, EventArgs e)
        {
            myCon.Open();
            // DataAdapter permite interschimbarea datelor între cursoare (data set) şi baza de date
            SqlDataAdapter adUniv = new SqlDataAdapter();

            try
            {
                // Clasa DbCommand implementează metode de interacțiune primară cu baza de date.
                SqlCommand command = new SqlCommand("INSERT INTO Universitati(Id, NameUniv, City, Code) VALUES(@Id, @NameUniv, @City,@Code)", myCon);


                command.Parameters.Add("@Id", SqlDbType.Int).Value =
               textBox_id.Text;
                command.Parameters.Add("@NameUniv", SqlDbType.Text).Value =
               textBox_Name.Text;
                command.Parameters.Add("@City", SqlDbType.Text).Value =
               textBox_City2.Text;
                command.Parameters.Add("@Code", SqlDbType.Int).Value =
               int.Parse(textBox_Code.Text);
                // DataAdapter permite interschimbarea datelor între data set şi baza de date
                adUniv.InsertCommand = command;
                adUniv.InsertCommand.ExecuteNonQuery();
                //// Metoda DbCommand.ExecuteNonQuery() – nu returnează nici un rezultat;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            myCon.Close(); //inchidem conexiunea la db
            textBox_id.Text = "";
            textBox_Name.Text = "";
            textBox_City2.Text = "";
            textBox_Code.Text = "";
            MessageBox.Show("Universitatea a fost adaugata cu succes ! ");
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {

        }
    }
}

