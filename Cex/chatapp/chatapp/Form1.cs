using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chatapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool firstline = true;


        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
            firstline = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (firstline == true)
            {
                firstline = false;
                richTextBox1.SelectionColor = Color.Red;

                richTextBox1.AppendText("Maria: " + richTextBox2.Text);

            }
            else 
            {
                richTextBox1.SelectionColor = Color.Red;
                richTextBox1.AppendText("\r\nMaria: " + richTextBox2.Text);

            }
        }



        private void SaveAsRTF(string filePath)
        {
            try
            {
                richTextBox1.SaveFile(filePath, RichTextBoxStreamType.RichText);

                MessageBox.Show("RTF file saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving RTF file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Rich Text Format (*.rtf)|*.rtf|All files (*.*)|*.*";
                saveFileDialog.Title = "Save RTF File";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    SaveAsRTF(saveFileDialog.FileName);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFile1 = new OpenFileDialog();
            if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK && openFile1.FileName.Length > 0)
            {
                // Load the contents of the file into the RichTextBox.
                richTextBox1.LoadFile(openFile1.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (firstline == true)
            {
                firstline = false;
                richTextBox1.SelectionColor = Color.Blue;

                richTextBox1.AppendText("Ionel: " + richTextBox2.Text);

            }
            else
            {
                richTextBox1.SelectionColor = Color.Blue;
                richTextBox1.AppendText("\r\nIonel: " + richTextBox2.Text);

            }
        }
    }
}
