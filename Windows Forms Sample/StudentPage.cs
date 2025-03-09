using System;
using System.Windows.Forms;

namespace Windows_Forms_Sample
{
    public partial class StudentPage : Form
    {
        public StudentPage()
        {
            InitializeComponent();
        }

        private void EditUpdateBtn_Click(object sender, EventArgs e)
        {
            // Open Edit Page
            EditPage editPage = new EditPage();
            editPage.Show();
        }
    }
}
