using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzle_Poterasu_Stefan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            groupBoxAdministrator.Hide();
            groupBoxJucator.Hide();
            buttonJocNou.Hide();
        }
        private string ParolaAdministrator = "ParolaAdministrator";
        private string ParolaJucator = "ParolaJucator";
        public string UsernameJucator = "jucator";
        public string UsernameAdministrator = "administrator";

        private void BtnJucator_Click(object sender, EventArgs e)
        {
            BtnJucator.Hide();
            BtnAdmin.Hide();
            groupBoxJucator.Visible = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            BtnJucator.Hide();
            BtnAdmin.Hide();
            groupBoxJucator.Visible = false;
        }

        private void LoginJucator_Click(object sender, EventArgs e)
        {
            if (textBoxNumeJucator.Text == UsernameJucator && textBoxParolaJucator.Text == ParolaJucator)
            {
                buttonJocNou.Show();
            }
            else MessageBox.Show("Wrong password or username", "Error");
        }

        private void LoginAdministrator_Click(object sender, EventArgs e)
        {
            if (textBoxNumeAdministrator.Text == UsernameAdministrator && textBoxParolaAdministrator.Text == ParolaAdministrator)
            {

            }
            else MessageBox.Show("Wrong password or username", "Error");

        }

        private void buttonJocNou_Click(object sender, EventArgs e)
        {
            Form2 FormJucator = new Form2();
            FormJucator.Visible = true;
            this.Hide();
        }
    }
}
