using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MiniCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int operand = 0;
        double op1;
        double op2;
        String s = "";

        private void button9_Click(object sender, EventArgs e)
        {
            s += "2" ;
            TextBox1.Text = s;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            s += "0" ;
            TextBox1.Text = s;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            s += "1" ;
            TextBox1.Text = s;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            s += "5" ;
            TextBox1.Text = s;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            s += "3" ;
            TextBox1.Text = s;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            s += "4" ;
            TextBox1.Text = s;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            s += "6" ;
            TextBox1.Text = s;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            s += "7" ;
            TextBox1.Text = s;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            s += "8" ;
            TextBox1.Text = s;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            s += "9" ;
            TextBox1.Text = s;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            operand = 1;
            op1 = Double.Parse(s);
            s = "" ;
            TextBox1.Text = s;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            operand = 2;
            op1 = Double.Parse(s);
            s = "" ;
            TextBox1.Text = s;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            operand = 3;
            op1 = Double.Parse(s);
            s = "" ;
            TextBox1.Text = s;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            operand = 4;
            op1 = Double.Parse(s);
            s = "" ;
            TextBox1.Text = s;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            s = "" ;
            TextBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            op2 =
            Double.Parse(s);
            s = "" ;
            TextBox1.Text = s;
            if (operand == 1)
                s += (double)op1 + (double)op2;
            else
            if (operand == 2)
                s +=(double)op1 - (double)op2;
            else
            if (operand == 3)

                s +=(double)op1 * (double)op2;
            else
            {

                if (op2.CompareTo(0) == 0) s = "Err - Division by zero" ;

            else
                    s += (double)op1 / (double)op2;
            }
            TextBox1.Text = s;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            s += "," ;
            TextBox1.Text = s;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            operand = 5;
            op1 =
            Double.Parse(s);
            if (op1 >= 0)
            {
                double c =

                Math.Sqrt(op1);
                s = "" ;
                s += c;
            }
            else
                s = "Err - sqrt from negative number" ;
            TextBox1.Text = s;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            s += "-" ;
            TextBox1.Text = s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
