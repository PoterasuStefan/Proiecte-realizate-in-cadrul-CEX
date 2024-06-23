using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicatia_13_Ceasuri
{
    public partial class Form1 : Form
    {
        Graphics G;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            G = this.CreateGraphics();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            G.Clear(Color.White);
            ceas c1 = new ceas(100, 170, 150, DateTime.Now);
            c1.desenez(G);
            ceas c2 = new ceas(300, 170, 150, DateTime.Now.AddHours(-2));
            c2.desenez(G);
            ceas c3 = new ceas(500, 170, 150, DateTime.Now.AddHours(-10));
            c3.desenez(G);
        }
        public class ceas
        {
            int x, y, size;
            DateTime time;

            public ceas(int x, int y, int size, DateTime time)
            {
                this.x = x;
                this.y = y;
                this.size = size;
                this.time = time;
            }
            public void desenez(Graphics graphics)
            {
                // Draw the outer circle
                graphics.DrawEllipse(Pens.Black, x - size / 2, y - size / 2, size, size);

                // Draw the hour hand
                double hourAngle = (time.Hour % 12 + time.Minute / 60.0) * 30 * Math.PI / 180; // Convert to radians
                graphics.DrawLine(Pens.Black, x, y, (float)(x + size / 4 * Math.Sin(hourAngle)), (float)(y - size / 4 * Math.Cos(hourAngle)));

                // Draw the minute hand
                double minuteAngle = time.Minute * 6 * Math.PI / 180; // Convert to radians
                graphics.DrawLine(Pens.Black, x, y, (float)(x + (size / 2 * Math.Sin(minuteAngle))), (float)(y - size / 2 * Math.Cos(minuteAngle)));
            }

        }
    }
}
