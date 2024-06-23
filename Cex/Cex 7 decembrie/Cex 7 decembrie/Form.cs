using MiniCalculator;

namespace Cex_7_decembrie
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void btn_click_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Acesta este un messagebox!", "My first messagebox");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void btncopy_Click(object sender, EventArgs e)
        {
            string mystr;
            mystr = textBox1.Text;
            textBox2.Text = mystr;
        }
        Form1 secondform = new Form1();

        private void btn_next_Click(object sender, EventArgs e)
        {
          //  Form2 secondform = new Form2();
          secondform.Show();
        }
    }
}