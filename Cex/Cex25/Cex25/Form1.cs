using Microsoft.Data.SqlClient;
using System.Data;

namespace Cex25
{
    public partial class Form1 : Form
    {
        SqlConnection myCon = new SqlConnection();
        DataSet dsUniv;
        DataSet dsFac;
        public Form1()
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


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_Univ_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1_Fac.Items.Clear(); //ca sa evitam incarcarea listei cu elementele 
            
            //textBox_City.Clear(); 
            int code = 0;
            //memoram in variabila UnivSelected itemul selectat din tabela Univ
            String UnivSelected = listBox1_Univ.SelectedItem.ToString();
            //parcurgem elementele din tabela Universitati
            foreach (DataRow dr in dsUniv.Tables["Universitati"].Rows)
            {
                if (UnivSelected == dr.ItemArray.GetValue(1).ToString())
                {
                    textBox_City.Text = dr.ItemArray.GetValue(2).ToString();
                    code = Convert.ToInt16(dr.ItemArray.GetValue(3));
                    textBox_CodeUniv.Text = code.ToString();
                }
            }
            foreach (DataRow dr in dsFac.Tables["Facultati"].Rows)
            {
                if (code == Convert.ToInt16(dr.ItemArray.GetValue(1)))
                {
                    String nameFac = dr.ItemArray.GetValue(2).ToString();
                    listBox1_Fac.Items.Add(nameFac);
                }
            }
            
        }
        
    }
}