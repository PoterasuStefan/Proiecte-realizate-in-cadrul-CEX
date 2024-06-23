using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GOOD_FOOD_CEX
{
    public partial class Autentificare : Form
    {
        string email, parola;

        public Autentificare()
        {

            InitializeComponent();

        }
        static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\spote\\source\\repos\\GOOD FOOD CEX\\GOOD FOOD CEX\\Database1.mdf\";Integrated Security=True";

        private void button1_Click(object sender, EventArgs e)
        {
            email = EmailTextBox.Text;
            parola = PasswordTextbox.Text;
            if (ValidateUser(email, parola))
            {
                MessageBox.Show("Valid Email");
                int userId=GetUserId(email, parola);
                Optiuni optiuni = new Optiuni(userId);

                optiuni.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid email or adress");
            }

        }
        private void Autentificare_Load(object sender, EventArgs e)
        {

        }
        static bool ValidateUser(string email, string parola)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Query to retrieve data based on user input email
                string query = "SELECT COUNT(*) FROM [dbo].[Clienti] WHERE [email] = @UserEmail AND [parola] = @UserPassword";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserEmail", email);
                    command.Parameters.AddWithValue("@UserPassword", parola);

                    int matchingRecords = (int)command.ExecuteScalar();

                    if (matchingRecords > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        static int GetUserId(string email, string parola)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Query to retrieve user ID based on email and password
                string query = "SELECT [id_client] FROM [dbo].[Clienti] WHERE [email] = @UserEmail AND [parola] = @UserPassword";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserEmail", email);
                    command.Parameters.AddWithValue("@UserPassword", parola);

                    object userId = command.ExecuteScalar();
                    if (userId != null)
                    {
                        return Convert.ToInt32(userId);
                    }
                    else
                    {
                        // User not found or invalid credentials
                        return -1; // You can choose an appropriate value to indicate failure
                    }
                }
            }
        }
    }
}
