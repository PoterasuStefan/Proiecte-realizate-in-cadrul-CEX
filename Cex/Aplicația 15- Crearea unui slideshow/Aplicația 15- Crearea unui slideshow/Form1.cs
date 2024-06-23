using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicația_15__Crearea_unui_slideshow
{
    public partial class Form1 : Form
    {
        int x = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x++;
            pictureBox1.Image = imageList1.Images[x%4];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            x--;
            if (x < 0) x = 0;
            pictureBox1.Image= imageList1.Images[x%4];
        }
    }

}
