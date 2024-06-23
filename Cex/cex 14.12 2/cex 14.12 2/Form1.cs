using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cex_14._12_2
{
    public partial class Form1 : Form
    {
        int minute =0, second =0;
        public Form1()
        {
            InitializeComponent();
           
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0; progressBar1.Maximum = 60;
            progressBar1.Value = second;
            if (timer1.Enabled == true)
            {

                if (second == 60)
                {
                    minute++;
                    second = 0;
                }
                else
                {
                    second++;
                }
                label3.Text=second.ToString();
                label4.Text = minute.ToString();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            second = 0;
            minute = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }
        
    }
}
