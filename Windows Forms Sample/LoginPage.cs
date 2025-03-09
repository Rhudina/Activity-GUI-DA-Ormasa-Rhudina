using System;
using System.Windows.Forms;

namespace Windows_Forms_Sample
{
    public partial class LoginPage : Form
    {
        // Track failed login attempts
        private int failedAttempts = 0;
        private const int maxAttempts = 5;

        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            // Mock credentials
            string userName = "Hani";
            string passWord = "strive123";

            // Clear previous errors
            ErrorProvider1.Clear();

            // Check if fields are empty
            if (string.IsNullOrEmpty(UsernameTxtbox.Text))
            {
                ErrorProvider1.SetError(UsernameTxtbox, "Username is required!");
                UsernameTxtbox.Focus();
                return;
            }

            if (string.IsNullOrEmpty(PasswordTxtBox.Text))
            {
                ErrorProvider1.SetError(PasswordTxtBox, "Password is required!");
                PasswordTxtBox.Focus();
                return;
            }

            // Validate username and password
            if (UsernameTxtbox.Text == userName && PasswordTxtBox.Text == passWord)
            {
                // Login successful - Open StudentPage and hide LoginPage
                StudentPage studentPage = new StudentPage();
                studentPage.Show();
                this.Hide();  // Hide Login Page
            }
            else
            {
                // Increment failed attempts
                failedAttempts++;

                // Check if max attempts reached
                if (failedAttempts >= maxAttempts)
                {
                    MessageBox.Show("Too many failed attempts! Click OK to reset your password.\n\nReset Password: https://example.com/reset",
                        "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // Reset failed attempts (optional)
                    failedAttempts = 0;
                    return;
                }

                // Show error message for incorrect credentials
                ErrorProvider1.SetError(UsernameTxtbox, "Incorrect username or password!");
                ErrorProvider1.SetError(PasswordTxtBox, "Incorrect username or password!");
                UsernameTxtbox.Focus();
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
