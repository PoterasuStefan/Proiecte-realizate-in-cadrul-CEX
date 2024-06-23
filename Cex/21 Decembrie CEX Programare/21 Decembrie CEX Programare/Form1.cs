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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string[] ore = { "8:00", "9:00", "10:00", "11:00", "12:00" };
        public static int[] ore_ocupate = { 0, 0, 0, 0, 0 };
        public static string[] nume = new string[20];
        public static string inf;
        public static int numarp;

        private void programeaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Programare prog = new Programare();
           prog.ShowDialog();
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void planificatiToolStripMenuItem_Click(object sender, EventArgs e)
        {
                inf = "";
            for (int i = 0; i < ore_ocupate.Length; i++)
            {
                if (ore_ocupate[i] == 1) inf += nume[i] + " ora " + ore[i] + "\n";

            }
            if (inf == "") inf = "Nu sunt programari azi";
            Afisare planif = new Afisare();
            planif.Text = "Planificati";
            planif.ShowDialog();
        }

        private void oreLibereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inf = "Ore libere:\n";
            for (int i = 0; i < ore_ocupate.Length; i++)
            {
                if (ore_ocupate[i]==0)
                {
                    inf += ore[i] + " \n";
                }
            }
            Afisare orelib = new Afisare();
            orelib.Text = "Ore Libere";
            orelib.ShowDialog();
        }

        private void clientiTotalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inf = "";
            numarp = 0;
            for (int i = 0;i< ore_ocupate.Length;i++)
            {
                if (ore_ocupate[i] == 1) numarp++;
                inf = "Nr pacienti programati azi " + numarp;
                Afisare totalp = new Afisare();
                totalp.Text = "Total programati";
                totalp.ShowDialog();
            }
        }
    }
}
