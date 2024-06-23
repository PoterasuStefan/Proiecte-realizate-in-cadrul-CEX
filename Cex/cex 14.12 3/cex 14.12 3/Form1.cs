using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cex_14._12_3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            var lines = textBox1.Lines.ToList();

            int i = 0;
            int j = 0;
            for (i=1;i<3;i++)
            {
                
                if(checkedListBox1.CheckedItems!=null ) {
                    j++;
                    lines[j] = "da";//checkedListBox1.CheckedItems[i].ToString();
                    checkedListBox1.CheckedItems[1] = null;
                }
                
            }

        }
    }
}
