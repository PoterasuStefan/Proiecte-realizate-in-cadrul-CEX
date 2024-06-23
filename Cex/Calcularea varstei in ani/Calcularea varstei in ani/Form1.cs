using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcularea_varstei_in_ani
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int an_nastere;
        private void button2_Click(object sender, EventArgs e)
        {
            int varsta=calucleaza_an();
            if (radioButton1.Checked)
            {
                label2.Text = "Varsta in ani este:" + varsta.ToString();

            }
            else if (radioButton2.Checked)
            {
                label2.Text = "Varsta in ani este:" + varsta.ToString()+"luna"+luna();

            }

        }
        public int calucleaza_an()
        {
            DateTime an_nastere = monthCalendar1.SelectionRange.Start;
            var azi = DateTime.Today;
            int varsta = azi.Year - an_nastere.Year;
            int nrluni = azi.Month - an_nastere.Month;
            if (nrluni < 0)
            {
                nrluni = 12 - an_nastere.Month + azi.Month;
                if (an_nastere.AddYears(varsta) > azi)
                {
                    varsta--;
                }
            }
            return varsta;
        }
        public int luna()
        {
            DateTime an_nastere = monthCalendar1.SelectionRange.Start;
            var azi = DateTime.Today;

            int nrluni = azi.Month - an_nastere.Month;
            if(nrluni < 0)
            { nrluni += 12; }
            return nrluni;
        }
        private void button1_Click(object sender, EventArgs e)
        {
           DateTime an_nastere = monthCalendar1.SelectionRange.Start;
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
