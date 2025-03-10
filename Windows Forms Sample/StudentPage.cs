using System;
using System.Windows.Forms;

namespace Windows_Forms_Sample
{
    public partial class StudentPage : Form
    {
        public StudentPage()
        {
            InitializeComponent();

            // Wire up button events
            AddImageBtn.Click += AddImageBtn_Click;
            ChangeImageBtn.Click += ChangeImageBtn_Click;
        }

        private void AddImageBtn_Click(object sender, EventArgs e)
        {
            UploadImage();
        }

        private void ChangeImageBtn_Click(object sender, EventArgs e)
        {
            UploadImage();
        }

        // Function to upload and display image
        private void UploadImage()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select an Image";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Load image into PictureBox
                    StudentPictureBox.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);
                    StudentPictureBox.SizeMode = PictureBoxSizeMode.StretchImage; // Adjust image to fit
                }
            }
        }

        private void EditUpdateBtn_Click(object sender, EventArgs e)
        {
            // Pass values to EditPage
            EditPage editPage = new EditPage(
                TextBoxes[0].Text, // Name
                TextBoxes[1].Text, // Age
                TextBoxes[2].Text, // Address
                TextBoxes[3].Text, // Contact Number
                TextBoxes[4].Text, // Email Address
                TextBoxes[5].Text.Split(' ')[0], // Course
                TextBoxes[5].Text.Split(' ')[1] + " " + TextBoxes[5].Text.Split(' ')[2], // Year (e.g., "3rd Year")
                TextBoxes[6].Text, // Guardian/Parent
                TextBoxes[7].Text, // Guardian Contact
                TextBoxes[8].Text, // Hobbies
                TextBoxes[9].Text  // Nickname
            );
            editPage.ShowDialog();
        }
    }
}
