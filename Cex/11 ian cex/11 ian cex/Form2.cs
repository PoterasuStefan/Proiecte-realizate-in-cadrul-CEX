using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_ian_cex
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int NrIntrebare = 1;
        private void Form2_Load(object sender, EventArgs e)
        {

            Question1();
        }
        public void Question1()
        {
            groupBox2.Show();
            groupBox1.Hide();
            label1.Text = "Care dintre tipurile de date de mai jos nu apartin limbajului C++? ";
            checkBox1.Text = "int";
            checkBox2.Text = "decimal";
            checkBox3.Text = "char";
            checkBox4.Text = "float";

        }
        public void Question2()
        {
            groupBox1.Show();
            groupBox2.Hide();
            label1.Text = "In urma carei operatii de atribuire, data b va avea valoarea ultimei cifre a numarului intreg a?  ";
            checkBox1.Text = "b=a div b ";
            checkBox2.Text = "b=a*a div b ";
            checkBox3.Text = "b=a%10 ";
            checkBox4.Text = "b=b/a ";

        }


        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(NrIntrebare == 2)
            {
                
            }
        }
    }
}
