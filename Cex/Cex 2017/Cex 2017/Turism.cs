using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cex_2017
{
    public partial class Turism : Form
    {
        public Turism()
        {
            InitializeComponent();
        }

        Genereaza_Poster genereaza_poster = new Genereaza_Poster();
        string planificaripath = "C:\\Users\\spote\\source\\repos\\Cex 2017\\Cex 2017\\Resurse\\planificari.txt";
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\spote\\source\\repos\\Cex 2017\\Cex 2017\\Turism.mdf\";Integrated Security=True";

        private void InitializareBtn_Click(object sender, EventArgs e)
        {

            string textFileData = ReadTextFileContent(planificaripath);

            // Process each line in the text file
            List<string> processedLines = new List<string>();
            foreach (string line in textFileData.Split(new[] { Environment.NewLine }, StringSplitOptions.None))
            {
                string[] parts = line.Split('*');
                string cityName = parts[0].Trim();

                // Get the ID for the city name using the database
                int cityId = GetCityId(cityName);

                // Replace city name with ID in the first element
                parts[0] = cityId.ToString();

                // Rebuild the line with replaced city name
                string processedLine = string.Join("*", parts);
                processedLines.Add(processedLine);
            }

            string processedLinesContent = string.Join(Environment.NewLine, processedLines);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (StringReader sr = new StringReader(processedLinesContent))
                {
                    sr.ReadLine(); // Skip the header line

                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] fields = line.Split('*');

                        using (SqlCommand cmd = new SqlCommand("INSERT INTO Planificari (IDLocalitate, Frecventa, DataStart, DataStop, Ziua) VALUES (@IDLocalitate, @Frecventa, @DataStart, @DataStop, @Ziua)", connection))
                        {
                            cmd.Parameters.AddWithValue("@IDLocalitate", fields[0]);
                            cmd.Parameters.AddWithValue("@Frecventa", fields[1]);
                            if (fields[1].Trim() == "ocazional") // Assuming "ocazional" indicates data is present
                            {
                                DateTime dataStart = DateTime.ParseExact(fields[2].Trim(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
                                DateTime dataStop = DateTime.ParseExact(fields[3].Trim(), "dd.MM.yyyy", CultureInfo.InvariantCulture);


                                cmd.Parameters.AddWithValue("@DataStart", dataStart);
                                cmd.Parameters.AddWithValue("@DataStop", dataStop);
                                cmd.Parameters.AddWithValue("@Ziua", DBNull.Value);


                            }
                            else
                            {
                                // Set DataStart and DataStop to null (assuming null representation)
                                cmd.Parameters.AddWithValue("@DataStart", DBNull.Value); // Use DBNull.Value for null values
                                cmd.Parameters.AddWithValue("@DataStop", DBNull.Value);

                                cmd.Parameters.AddWithValue("@Ziua", fields[2]);
                            }


                            cmd.ExecuteNonQuery();
                        }

                    }
                }
            }



            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);

                    System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
                }
            }
            genereaza_poster.Show();
            this.Hide();
        }
        private int GetCityId(string cityName)
        {
            int cityId = -1; // Initialize to -1 to indicate not found

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Prepare a query to retrieve ID for the city name
                string query = "SELECT IDLocalitate FROM Localitati WHERE CAST(Nume AS nvarchar) = @CityName";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@CityName", cityName);

                    // Execute the query and get the first row (assuming unique city names)
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            cityId = (int)reader["IDLocalitate"]; // Cast to int
                        }
                    }
                }
            }

            return cityId;
        }
        public static string ReadTextFileContent(string filePath)
        {
            try
            {
                // Read all text content from the file
                string content = File.ReadAllText(filePath);
                return content;
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Error: File not found - {filePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file: {ex.Message}");
            }

            return null; // Indicate error if exceptions occur
        }

        private void Turism_Load(object sender, EventArgs e)
        {

        }
    }
}
