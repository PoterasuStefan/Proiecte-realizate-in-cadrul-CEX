using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicația_17__Generarea_fractalilor
{
    public partial class Form1 : Form
    {
        int m = 8;
        public Form1()
        {
            InitializeComponent();
        }
        void patrat (int n , int x, int y, int l)
        {
            if(n>1)
            {
                patrat(n - 1, x - l / 4, y - l / 4, l / 2);
                patrat(n - 1, x + 3 * l / 4, y - l / 4, l / 2);
                patrat(n - 1, x - l / 4, y + 3 * l / 4, l / 2);
                patrat(n - 1, x + 3 * l / 4, y + 3 * l / 4, l / 2);
            }
            Pen penc;
            if (n % 2 == 0)
                penc = new Pen(Color.Red, 3);
            else penc=new Pen (Color.Blue, 3);
            Point[] p = new Point[4];
            p[0].X = x;
            p[0].Y = y;
            p[1].X = x;
            p[1].Y = y+l;
            p[2].X = x+l;
            p[2].Y = y + l;
            p[3].X = x + l;
            p[3].Y = y;
            Graphics g =this.CreateGraphics();
            g.DrawPolygon(penc, p);


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (m <= 8)
            {
                int x = 200, y = 200, l = 150;
                patrat(m, x, y, l);
                m = m + 1;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
