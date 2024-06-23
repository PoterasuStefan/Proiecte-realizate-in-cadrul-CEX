using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicația_14__Ceas_analogic
{
    public partial class Form1 : Form

    {

        int w, h; float hh, mm,

        ss;//ora,minut,secunda 

        float r;//raza 

        int x0, y0;//centrul Image img; 

        Graphics g; System.Drawing.Font f; SizeF ms;



        public Form1()

        {

            InitializeComponent();

        }



        private void label1_Click(object sender, EventArgs e)

        {

            Application.Exit();

        }

        private void label3_Click(object sender, EventArgs e)

        {

            this.WindowState = FormWindowState.Minimized;

        }

        private void timer1_Tick(object sender, EventArgs e)

        {



            deseneaza();

        }

        private void Form1_Load(object sender, EventArgs e)

        {

            f = new System.Drawing.Font("Time New Roman", 18, fontStyle.Bold);



            timer1.Start(); deseneaza();


        }

        void deseneaza()

        {

            hh = DateTime.Now.Hour; mm = DateTime.Now.Minute; ss = DateTime.Now.Second; w = 400;

            h = 400;

            img = new Bitmap(w, h); g = Graphics.FromImage(img);

            x0 = w / 2; y0 = h / 2; r = 170;

            p.Location = new Point(2, 34); p.Width = w;

            p.Height = h;

            //sterg desenul g.Clear(Color.White); 

            //cercul 

            g.DrawEllipse(new Pen(Color.DarkRed, 3), x0 - r, y0 - r, 2 * r, 2 * r);

            //orele 12, 6, 3, 9 

            StringFormat sf = new StringFormat(); sf.Alignment = StringAlignment.Center; ms = g.MeasureString("12", f);

            RectangleF r1 = new RectangleF(x0 - ms.Width / 2, y0 - r - ms.Height, ms.Width, ms.Height);

            g.DrawString("12", f, Brushes.DarkRed, r1, sf); ms = g.MeasureString("6", f);

            RectangleF r2 = new RectangleF(x0 - ms.Width / 2, y0 + r, ms.Width, ms.Height);

            g.DrawString("6", f, Brushes.DarkRed, r2, sf); ms = g.MeasureString("3", f);

            RectangleF r3 = new RectangleF(x0 + r, y0 - ms.Height / 2, ms.Width, ms.Height);

            g.DrawString("3", f, Brushes.DarkRed, r3, sf); ms = g.MeasureString("9", f);

            RectangleF r4 = new RectangleF(x0 - r - ms.Width, y0 - ms.Height / 2, ms.Width, ms.Height);

            g.DrawString("9", f, Brushes.DarkRed, r4, sf);

            //punctele minutelor 

            for (int i = 0; i < 60; i++)

            {

                Point PP1 = new Point((int)(x0 + r * 0.97 * Math.Cos(i * Math.PI / 30)), (int)(y0 + r * 0.97 * Math.Sin(i * Math.PI / 30)));

                Point PP2 = new Point((int)(x0 + r * Math.Cos(i * Math.PI / 30)), (int)(y0 + r * Math.Sin(i * Math.PI / 30)));

                g.DrawLine(new Pen(Color.DarkRed, 2), PP1, PP2);

            }

            //punctele orelor 

            for (int i = 0; i < 12; i++)

            {

                Point Pp1 = new Point((int)(x0 + r * 0.92 * Math.Cos(i * Math.PI / 6)), (int)(y0 + r * 0.92 * Math.Sin(i * Math.PI / 6)));

                Point Pp2 = new Point((int)(x0 + r * Math.Cos(i * Math.PI / 6)), (int)(y0 + r * Math.Sin(i * Math.PI / 6)));

                //g.DrawLine(new Pen(Color.DarkRed, 4), Pp1, Pp2); g.DrawEllipse(new Pen(Color.DarkRed, 5), Pp2.X-3,Pp2.Y-3,6,6); 

            }

            hh = hh - 3 + mm / 60; mm = mm - 15; ss = ss - 15;

            //orar 

            Point P1 = new Point((int)(x0 - r * 0.05 * Math.Cos(hh * Math.PI / 6)), (int)(y0 - r * 0.05 * Math.Sin(hh * Math.PI / 6)));

            Point P2 = new Point((int)(x0 + r * 0.5 * Math.Cos(hh * Math.PI / 6)), (int)(y0 + r * 0.5 * Math.Sin(hh * Math.PI / 6))); g.DrawLine(new Pen(Color.DarkRed, 6), P1, P2);

            //minutar 

            Point P3 = new Point((int)(x0 - r * 0.07 * Math.Cos(mm * Math.PI / 30)), (int)(y0 - r * 0.07 * Math.Sin(mm * Math.PI / 30)));

            Point P4 = new Point((int)(x0 + r * 0.7 * Math.Cos(mm * Math.PI / 30)), (int)(y0 + r * 0.7 * Math.Sin(mm * Math.PI / 30))); g.DrawLine(new Pen(Color.DarkRed, 4), P3, P4);

            //secundar 

            Point P5 = new Point((int)(x0 - r * 0.09 * Math.Cos(ss * Math.PI / 30)), (int)(y0 - r * 0.09 * Math.Sin(ss * Math.PI / 30)));

            Point P6 = new Point((int)(x0 + r * 0.9 * Math.Cos(ss * Math.PI / 30)), (int)(y0 + r * 0.9 * Math.Sin(ss * Math.PI / 30))); g.DrawLine(new Pen(Color.DarkRed, 2), P5, P6); g.FillEllipse(Brushes.DarkRed, x0 - 4, y0 - 4, 8, 8);

            this.Refresh();

        }

        private void p_Paint_1(object sender, PaintEventArgs e)

        {
            e.Graphics.DrawImage(img, 0, 0, w, h);

        }
    }
} 

 
           
