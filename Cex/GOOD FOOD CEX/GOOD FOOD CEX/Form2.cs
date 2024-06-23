using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOOD_FOOD_CEX
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        bool ValidPass, ValidMail;
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\spote\\source\\repos\\GOOD FOOD CEX\\GOOD FOOD CEX\\Database1.mdf\";Integrated Security=True";

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (ValidateUsingMailAddress(textBox6.Text))
            {
                label7.Text = "Adresa valida";
                ValidMail = true;
            }
            else { label7.Text = "Adresa invalida";
                ValidMail = false;
            }
        }
        public bool ValidateUsingMailAddress(string emailAddress)
        {
            try
            {
                var email = new MailAddress(emailAddress);
                return email.Address == emailAddress.Trim();
            }
            catch
            {
                return false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (PasswordTextbox.Text == ConfirmPasswordTextbox.Text)
            {
                ValidPass = true;
            }
            else { ValidPass = false; }

            if (ValidMail&&ValidPass)
                {
                string nume = textBox1.Text;
                string prenume = textBox2.Text;
                string parola = PasswordTextbox.Text;
                string adresa = AdresaTextbox.Text; 
                string email = textBox6.Text;
                string sql = @"INSERT INTO [dbo].[Clienti] (nume, prenume, parola, adresa, email) VALUES (@nume, @prenume, @parola, @adresa, @email)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@nume", nume);
                        command.Parameters.AddWithValue("@prenume", prenume);
                        command.Parameters.AddWithValue("@parola", parola);
                        command.Parameters.AddWithValue("@adresa", adresa);
                        command.Parameters.AddWithValue("@email", email);

                        command.ExecuteNonQuery();
                    }
                }

                // Show a success message (optional)
                MessageBox.Show("Client creat cu succes!");
            }
            else if (ValidPass == false)
            {
                MessageBox.Show("Parola invalida");

            }
            else if (ValidMail == false)
            {
                MessageBox.Show("Mail invalid");

            }
            


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
