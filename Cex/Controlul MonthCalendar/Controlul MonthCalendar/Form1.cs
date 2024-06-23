using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controlul_MonthCalendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void myMonthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            //in eticheta se afiseaza intervalul selectat
            this.myLabel.Text = " Intervalul selectat: Start = " + e.Start.ToShortDateString() + " End: " + e.End.ToShortDateString();

            //daca este selectata o singura zi
            if (e.Start.ToShortDateString() == e.End.ToShortDateString())

            {
                string x = e.Start.ToShortDateString();
                //respectiva data este adaugata in ComboBox, daca nu exista deja


                if (!myComboBox.Items.Contains(x))
                    myComboBox.Items.Add(x);
            }
        }
    }
}
