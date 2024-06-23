using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_Decembrie_CEX_Programare
{
    public partial class Afisare : Form
    {
        public Afisare()
        {
            InitializeComponent();
            label1.Text = Form1.inf;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Afisare_Load(object sender, EventArgs e)
        {

        }
    }
}
