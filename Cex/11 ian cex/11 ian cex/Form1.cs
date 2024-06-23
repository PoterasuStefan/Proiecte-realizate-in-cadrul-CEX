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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 form2 = new Form2();

        private string numeutilizator = "candidat";
        private string parola="cia2012";
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == numeutilizator && textBox2.Text == parola)
            {
                this.Hide();
                form2.Show();

            }
        }
    }
}
