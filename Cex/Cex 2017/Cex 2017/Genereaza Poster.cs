using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cex_2017
{
    public partial class Genereaza_Poster : Form
    {
        public Genereaza_Poster()
        {
            InitializeComponent();
        }

        private void Genereaza_Poster_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'turismDataSet.Localitati' table. You can move, or remove it, as needed.
            this.localitatiTableAdapter.Fill(this.turismDataSet.Localitati);

        }
    }
}
