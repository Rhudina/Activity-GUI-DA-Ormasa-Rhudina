using System;
using System.Linq;
using System.Windows.Forms;

namespace Windows_Forms_Sample
{
    public partial class EditPage : Form
    {
        public EditPage()
        {
            InitializeComponent();
            SaveBtn.Click += new EventHandler(SaveBtn_Click);
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            // Validate Required Fields
            if (string.IsNullOrWhiteSpace(NameTxt.Text) ||
                string.IsNullOrWhiteSpace(AgeTxt.Text) ||
                string.IsNullOrWhiteSpace(AddressTxt.Text) ||
                string.IsNullOrWhiteSpace(ContactTxt.Text) ||
                string.IsNullOrWhiteSpace(EmailTxt.Text) ||
                string.IsNullOrWhiteSpace(GuardianTxt.Text) ||
                string.IsNullOrWhiteSpace(GuardianContactTxt.Text) ||
                CourseDropdown.SelectedIndex == -1 ||
                YearDropdown.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all required fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Age (Numbers Only)
            if (!int.TryParse(AgeTxt.Text, out _))
            {
                MessageBox.Show("Age must be a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Contact Numbers (Numbers Only)
            if (!long.TryParse(ContactTxt.Text, out _) || !long.TryParse(GuardianContactTxt.Text, out _))
            {
                MessageBox.Show("Contact numbers must contain only numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Success Message
            MessageBox.Show("Profile successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
