using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Puzzle_Poterasu_Stefan
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }


        int tableSpaces = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            tableSpaces = 4;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.RowCount = 2;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedImagePath = openFileDialog.FileName;

                try
                {
                    if (pictureBox1.Image != null)
                        pictureBox1.Image.Dispose();

                    pictureBox1.Image = Image.FromFile(selectedImagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            Image originalImage = pictureBox1.Image;
            Image[] splitImages = SplitImage4(originalImage);

            // Clear existing controls from the TableLayoutPanel
            tableLayoutPanel1.Controls.Clear();

            // Add PictureBox controls to the TableLayoutPanel
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    PictureBox picBox = new PictureBox();
                    picBox.Dock = DockStyle.Fill;
                    picBox.SizeMode = PictureBoxSizeMode.Zoom;
                    picBox.Image = splitImages[row * 2 + col];
                    tableLayoutPanel1.Controls.Add(picBox, col, row);

                    // Assign the event handler to the Click event
                    picBox.Click += PictureBox_Click;
                }
            }
        }
        private Image[] SplitImage4(Image originalImage)
        {
            // Get the size of each quadrant
            int quadrantWidth = originalImage.Width / 2;
            int quadrantHeight = originalImage.Height / 2;

            // Create four separate images for each quadrant
            Image[] splitImages = new Image[4];

            for (int i = 0; i < 4; i++)
            {
                // Create a new bitmap for the current quadrant
                splitImages[i] = new Bitmap(quadrantWidth, quadrantHeight);

                // Create a graphics object from the new bitmap
                using (Graphics g = Graphics.FromImage(splitImages[i]))
                {
                    // Draw the portion of the original image into the new bitmap
                    g.DrawImage(originalImage, new Rectangle(0, 0, quadrantWidth, quadrantHeight),
                        new Rectangle(i % 2 * quadrantWidth, i / 2 * quadrantHeight, quadrantWidth, quadrantHeight),
                        GraphicsUnit.Pixel);
                }
            }
            RandomizeArray(splitImages);

            return splitImages;
        }
        private Image[] SplitImage9(Image originalImage)
        {
            // Get the size of each quadrant
            int quadrantWidth = originalImage.Width / 3;
            int quadrantHeight = originalImage.Height / 3;

            // Create four separate images for each quadrant
            Image[] splitImages = new Image[9];

            for (int i = 0; i < 9; i++)
            {
                // Create a new bitmap for the current quadrant
                splitImages[i] = new Bitmap(quadrantWidth, quadrantHeight);

                // Create a graphics object from the new bitmap
                using (Graphics g = Graphics.FromImage(splitImages[i]))
                {
                    // Draw the portion of the original image into the new bitmap
                    g.DrawImage(originalImage, new Rectangle(0, 0, quadrantWidth, quadrantHeight),
                        new Rectangle(i % 3 * quadrantWidth, i / 3 * quadrantHeight, quadrantWidth, quadrantHeight),
                        GraphicsUnit.Pixel);
                }
            }
            RandomizeArray(splitImages);


            return splitImages;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            tableSpaces = 9;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.RowCount = 3;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedImagePath = openFileDialog.FileName;

                try
                {
                    if (pictureBox1.Image != null)
                        pictureBox1.Image.Dispose();

                    pictureBox1.Image = Image.FromFile(selectedImagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            Image originalImage = pictureBox1.Image;
            Image[] splitImages = SplitImage9(originalImage);
            RandomizeArray(splitImages);

            // Clear existing controls from the TableLayoutPanel
            tableLayoutPanel1.Controls.Clear();

            // Add PictureBox controls to the TableLayoutPanel
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    PictureBox picBox = new PictureBox();
                    picBox.Dock = DockStyle.Fill;
                    picBox.SizeMode = PictureBoxSizeMode.Zoom;
                    picBox.Image = splitImages[row * 3 + col];
                    tableLayoutPanel1.Controls.Add(picBox, col, row);

                    // Assign the event handler to the Click event
                    picBox.Click += PictureBox_Click;
                }
            }
        }

        private PictureBox lastClickedPictureBox = null;
        private PictureBox NextTolastClickedPictureBox = null;

        private void PictureBox_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox clickedPictureBox)
            {
                if (lastClickedPictureBox == null)
                {
                    lastClickedPictureBox = clickedPictureBox;
                }
                else if (lastClickedPictureBox != clickedPictureBox)
                {
                    // Swap the images between the clicked PictureBox controls
                    Image tempImage = lastClickedPictureBox.Image;
                    lastClickedPictureBox.Image = clickedPictureBox.Image;
                    clickedPictureBox.Image = tempImage;

                    // Reset the lastClickedPictureBox
                    lastClickedPictureBox = null;
                }
            }
            bool isRightOrder = AreImagesInRightOrder();

            if (isRightOrder)
            {
                MessageBox.Show("Congratulations! The images are in the right order.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }




        private void RandomizeArray<T>(T[] array)
        {
            Random random = new Random();

            for (int i = array.Length - 1; i > 0; i--) 
            {
                int j = random.Next(0, i + 1);
                T temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }


            





        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox clickedPictureBox)
            {
                if (lastClickedPictureBox == null)
                {
                    lastClickedPictureBox = clickedPictureBox;
                }
                else if (lastClickedPictureBox != clickedPictureBox)
                {

                    lastClickedPictureBox = null;
                }
            }
        }
        private bool AreImagesInRightOrder()
        {
            int numControls = tableLayoutPanel1.Controls.Count;
            Image[] originalImages;

            // Determine the original split images based on the current layout
            if (tableLayoutPanel1.ColumnCount == 2 && tableLayoutPanel1.RowCount == 2)
            {
                originalImages = SplitImage4(pictureBox1.Image);
            }
            else if (tableLayoutPanel1.ColumnCount == 3 && tableLayoutPanel1.RowCount == 3)
            {
                originalImages = SplitImage9(pictureBox1.Image);
                RandomizeArray(originalImages); // If they were shuffled before
            }
            else
            {
                // Handle other layout configurations if needed
                return false;
            }

            // Compare the images in the TableLayoutPanel with the original order
            for (int i = 0; i < numControls; i++)
            {
                if (tableLayoutPanel1.Controls[i] is PictureBox picBox)
                {
                    // Get the index of the corresponding image in the original order
                    int originalIndex;
                    if (tableLayoutPanel1.ColumnCount == 2 && tableLayoutPanel1.RowCount == 2)
                    {
                        originalIndex = tableLayoutPanel1.GetRow(picBox) * 2 + tableLayoutPanel1.GetColumn(picBox);
                    }
                    else
                    {
                        originalIndex = tableLayoutPanel1.GetRow(picBox) * 3 + tableLayoutPanel1.GetColumn(picBox);
                    }

                    // Compare the current image with the corresponding image in the original order
                    if (picBox.Image != originalImages[originalIndex])
                    {
                        return false; // Images are not in the right order
                    }
                }
            }

            return true; // All images are in the right order
        }


    }
}
