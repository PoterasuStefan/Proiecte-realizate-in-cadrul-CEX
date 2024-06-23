using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LungimeaUnda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double W, W1, W2; double electron; double m, h, e0, c, lam;

            electron = -1.6 * Math.Pow(10, -19); c = W1 = 3 * Math.Pow(10, 8);

            m = 9.1 * Math.Pow(10, -31);

            e0 = 8.86 * Math.Pow(10, -12);

            h = 6.6 * Math.Pow(10, -34);

            W1 = (-1 * (Math.Pow(electron, 4) * m) / 8 * Math.Pow(e0, 2) * h) / Math.Pow(double.Parse(textBox1.Text), 2);

            W2 = (-1 * (Math.Pow(electron, 4) * m) / 8 * Math.Pow(e0, 2) * h) / Math.Pow(double.Parse(textBox2.Text), 2);

            W = W2 - W1;





            lam = (c / W) * h; labelRezultat.Text = lam.ToString();


        }
    }
}
