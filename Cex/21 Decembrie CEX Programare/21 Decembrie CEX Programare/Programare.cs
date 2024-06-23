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
    public partial class Programare : Form
    {
        public Programare()
        {
            InitializeComponent();
            for (int i = 0; i < Form1.ore.Length; i++)
                if (Form1.ore_ocupate[i] == 0) comboBox1.Items.Add(Form1.ore[i]);
        }


        private void button2_Click(object sender, EventArgs e)
        {
          this.Close(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex == -1) throw new Exception("Selectati ora");
                string orai = Convert.ToString(comboBox1.SelectedItem);
                if (textBox1.Text.Trim() == "") throw new Exception("Completati numele pacientului");
                label1.Text = textBox1.Text + " Sunteti programati la " + orai;
                for (int i = 0; i < Form1.ore_ocupate.Length; i++)
                {
                    if (Form1.ore[i]== orai)
                    {
                        Form1.ore_ocupate[i] = 1;
                        Form1.nume[i] = textBox1.Text.Trim();
                    }
                    
                }
                textBox1.Text = null;
                comboBox1.Items.Clear();
                comboBox1.Text = null;
                for (int i = 0;i<Form1.ore.Length;i++)
                {
                    if (Form1.ore_ocupate[i]==0)
                    {
                        comboBox1.Items.Add(Form1.ore[i]);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
