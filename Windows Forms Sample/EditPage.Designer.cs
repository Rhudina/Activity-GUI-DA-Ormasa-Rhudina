namespace Windows_Forms_Sample
{
    partial class EditPage
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.SaveBtn = new System.Windows.Forms.Button();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.AgeTxt = new System.Windows.Forms.TextBox();
            this.AddressTxt = new System.Windows.Forms.TextBox();
            this.ContactTxt = new System.Windows.Forms.TextBox();
            this.EmailTxt = new System.Windows.Forms.TextBox();
            this.CourseDropdown = new System.Windows.Forms.ComboBox();
            this.YearDropdown = new System.Windows.Forms.ComboBox();
            this.GuardianTxt = new System.Windows.Forms.TextBox();
            this.GuardianContactTxt = new System.Windows.Forms.TextBox();
            this.HobbiesTxt = new System.Windows.Forms.TextBox();
            this.NicknameTxt = new System.Windows.Forms.TextBox();

            string[] labels = { "Name:", "Age:", "Address:", "Contact Number:", "Email Address:",
                                "Course:", "Year:", "Guardian/Parent:", "Guardian Contact:", "Hobbies:", "Nickname:" };

            System.Windows.Forms.Label[] fieldLabels = new System.Windows.Forms.Label[labels.Length];

            int labelX = 20, textBoxX = 180, startY = 20, spacing = 35, textBoxWidth = 250;

            for (int i = 0; i < labels.Length; i++)
            {
                fieldLabels[i] = new System.Windows.Forms.Label();
                fieldLabels[i].Text = labels[i];
                fieldLabels[i].Location = new System.Drawing.Point(labelX, startY + spacing * i);
                fieldLabels[i].AutoSize = true;
                this.Controls.Add(fieldLabels[i]);
            }

            // Textbox Properties
            this.NameTxt.Location = new System.Drawing.Point(textBoxX, startY);
            this.AgeTxt.Location = new System.Drawing.Point(textBoxX, startY + spacing);
            this.AddressTxt.Location = new System.Drawing.Point(textBoxX, startY + spacing * 2);
            this.ContactTxt.Location = new System.Drawing.Point(textBoxX, startY + spacing * 3);
            this.EmailTxt.Location = new System.Drawing.Point(textBoxX, startY + spacing * 4);
            this.CourseDropdown.Location = new System.Drawing.Point(textBoxX, startY + spacing * 5);
            this.YearDropdown.Location = new System.Drawing.Point(textBoxX, startY + spacing * 6);
            this.GuardianTxt.Location = new System.Drawing.Point(textBoxX, startY + spacing * 7);
            this.GuardianContactTxt.Location = new System.Drawing.Point(textBoxX, startY + spacing * 8);
            this.HobbiesTxt.Location = new System.Drawing.Point(textBoxX, startY + spacing * 9);
            this.NicknameTxt.Location = new System.Drawing.Point(textBoxX, startY + spacing * 10);

            // Set common width
            System.Windows.Forms.Control[] fields = { NameTxt, AgeTxt, AddressTxt, ContactTxt, EmailTxt, GuardianTxt, GuardianContactTxt, HobbiesTxt, NicknameTxt };
            foreach (var field in fields) field.Size = new System.Drawing.Size(textBoxWidth, 20);

            // Course Dropdown
            this.CourseDropdown.Items.AddRange(new string[] { "ABEL", "BSBA", "BSIT", "BPA" });
            this.CourseDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // Year Dropdown (Fixed as First, Second, Third, Fourth)
            this.YearDropdown.Items.AddRange(new string[] { "First", "Second", "Third", "Fourth" });
            this.YearDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // Save Button
            this.SaveBtn.Text = "Save";
            this.SaveBtn.Location = new System.Drawing.Point(textBoxX, startY + spacing * 11);
            this.SaveBtn.Size = new System.Drawing.Size(120, 30);
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            this.Controls.Add(this.SaveBtn);

            // Add components to form
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.AgeTxt);
            this.Controls.Add(this.AddressTxt);
            this.Controls.Add(this.ContactTxt);
            this.Controls.Add(this.EmailTxt);
            this.Controls.Add(this.CourseDropdown);
            this.Controls.Add(this.YearDropdown);
            this.Controls.Add(this.GuardianTxt);
            this.Controls.Add(this.GuardianContactTxt);
            this.Controls.Add(this.HobbiesTxt);
            this.Controls.Add(this.NicknameTxt);

            // Form Settings
            this.ClientSize = new System.Drawing.Size(500, startY + spacing * 13);
            this.Text = "Edit Student Profile";
        }

        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.TextBox AgeTxt;
        private System.Windows.Forms.TextBox AddressTxt;
        private System.Windows.Forms.TextBox ContactTxt;
        private System.Windows.Forms.TextBox EmailTxt;
        private System.Windows.Forms.ComboBox CourseDropdown;
        private System.Windows.Forms.ComboBox YearDropdown;
        private System.Windows.Forms.TextBox GuardianTxt;
        private System.Windows.Forms.TextBox GuardianContactTxt;
        private System.Windows.Forms.TextBox HobbiesTxt;
        private System.Windows.Forms.TextBox NicknameTxt;
        private System.Windows.Forms.Button SaveBtn;

        #endregion
    }
}
