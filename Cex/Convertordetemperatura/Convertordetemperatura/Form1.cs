using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convertordetemperatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool Farenheit = true;
        private void button1_Click(object sender, EventArgs e)
        {
            if (Farenheit)
            {
                double C, F;
                F = double.Parse(textBox1.Text);
                C = (F - 32)*(5.0 / 9.0)  ;
                textBox2.Text = C.ToString();

            }
            else
            {
                double C, F;
                C= double.Parse(textBox2.Text);
                F = C * 9 / 5 + 32;
                textBox1.Text= F.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(Farenheit) {
                textBox1.Text = "";
                textBox1.ReadOnly = true;
                textBox2.ReadOnly = false;
                Farenheit = false;
            }
            else
            {
                textBox2.Text = "";
                textBox2.ReadOnly = true;
                textBox1.ReadOnly = false;
                Farenheit = true;
            }
            
            
        }
    }
}
