using System;
using System.Linq;
using System.Windows.Forms;

namespace Windows_Forms_Sample
{
    public partial class EditPage : Form
    {
        public EditPage(
            string name, string age, string address, string contact, string email,
            string course, string year, string guardian, string guardianContact, string hobbies, string nickname)
        {
            InitializeComponent();

            // Assign passed values to respective fields
            NameTxt.Text = name;
            AgeTxt.Text = age;
            AddressTxt.Text = address;
            ContactTxt.Text = contact;
            EmailTxt.Text = email;
            CourseDropdown.SelectedItem = course;
            YearDropdown.SelectedItem = year;
            GuardianTxt.Text = guardian;
            GuardianContactTxt.Text = guardianContact;
            HobbiesTxt.Text = hobbies;
            NicknameTxt.Text = nickname;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            // Check required fields
            if (string.IsNullOrWhiteSpace(NameTxt.Text) ||
                string.IsNullOrWhiteSpace(AgeTxt.Text) ||
                string.IsNullOrWhiteSpace(AddressTxt.Text) ||
                string.IsNullOrWhiteSpace(ContactTxt.Text) ||
                CourseDropdown.SelectedItem == null ||
                YearDropdown.SelectedItem == null ||
                string.IsNullOrWhiteSpace(EmailTxt.Text) ||
                string.IsNullOrWhiteSpace(GuardianTxt.Text) ||
                string.IsNullOrWhiteSpace(GuardianContactTxt.Text))
            {
                MessageBox.Show("Please complete all required fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Age and Contact Numbers (numbers only)
            if (!AgeTxt.Text.All(char.IsDigit))
            {
                MessageBox.Show("Age field must contain only numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ContactTxt.Text.All(char.IsDigit))
            {
                MessageBox.Show("Contact Number field must contain only numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!GuardianContactTxt.Text.All(char.IsDigit))
            {
                MessageBox.Show("Guardian Contact Number field must contain only numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // If all validations pass
            MessageBox.Show("Information updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
