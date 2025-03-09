namespace Windows_Forms_Sample
{
    partial class StudentPage
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

            this.StudentPictureBox = new System.Windows.Forms.PictureBox();
            this.AddImageBtn = new System.Windows.Forms.Button();
            this.ChangeImageBtn = new System.Windows.Forms.Button();
            this.EditUpdateBtn = new System.Windows.Forms.Button();

            // Student details fields
            string[] fieldNames = {
                "Name", "Age", "Address", "Contact Number", "Email Address",
                "Course and Year", "Name of Parent/Guardian", "Parent/Guardian Contact Number",
                "Hobbies", "Nickname"
            };

            string[] defaultValues = {
                "Rhudina", "21", "123 Main St, Bayambang", "09123456789", "hani_doll@email.com",
                "BSIT 3rd Year", "Flor Ormasa", "09876543210", "Watching Films, Coding", "Inah"
            };

            this.Labels = new System.Windows.Forms.Label[fieldNames.Length];
            this.TextBoxes = new System.Windows.Forms.TextBox[fieldNames.Length];

            int labelX = 160, textBoxX = 400, startY = 20, spacing = 35, textBoxWidth = 200;

            for (int i = 0; i < fieldNames.Length; i++)
            {
                this.Labels[i] = new System.Windows.Forms.Label();
                this.TextBoxes[i] = new System.Windows.Forms.TextBox();

                // Label settings
                this.Labels[i].Text = fieldNames[i] + ":";
                this.Labels[i].Location = new System.Drawing.Point(labelX, startY + spacing * i);
                this.Labels[i].AutoSize = true;
                this.Controls.Add(this.Labels[i]);

                // TextBox settings
                this.TextBoxes[i].Location = new System.Drawing.Point(textBoxX, startY + spacing * i);
                this.TextBoxes[i].Width = textBoxWidth;
                this.TextBoxes[i].Text = defaultValues[i];  // Set default content
                this.TextBoxes[i].ReadOnly = true;  // Make it non-editable initially
                this.Controls.Add(this.TextBoxes[i]);
            }

            // Student Image Placeholder
            this.StudentPictureBox.Location = new System.Drawing.Point(20, 20);
            this.StudentPictureBox.Size = new System.Drawing.Size(120, 120);
            this.StudentPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.StudentPictureBox);

            // Add Image Button
            this.AddImageBtn.Text = "Add Image";
            this.AddImageBtn.Location = new System.Drawing.Point(20, 150);
            this.AddImageBtn.Size = new System.Drawing.Size(120, 30);
            this.Controls.Add(this.AddImageBtn);

            // Change Image Button
            this.ChangeImageBtn.Text = "Change";
            this.ChangeImageBtn.Location = new System.Drawing.Point(20, 185);
            this.ChangeImageBtn.Size = new System.Drawing.Size(120, 30);
            this.Controls.Add(this.ChangeImageBtn);

            // Edit/Update Button
            this.EditUpdateBtn.Text = "Edit/Update";
            this.EditUpdateBtn.Location = new System.Drawing.Point(textBoxX, startY + spacing * fieldNames.Length);
            this.EditUpdateBtn.Size = new System.Drawing.Size(120, 30);
            this.EditUpdateBtn.Click += new System.EventHandler(this.EditUpdateBtn_Click);
            this.Controls.Add(this.EditUpdateBtn);

            // Form Properties
            this.ClientSize = new System.Drawing.Size(700, startY + spacing * (fieldNames.Length + 1));
            this.Text = "Student Page";
        }

        private System.Windows.Forms.PictureBox StudentPictureBox;
        private System.Windows.Forms.Button AddImageBtn;
        private System.Windows.Forms.Button ChangeImageBtn;
        private System.Windows.Forms.Button EditUpdateBtn;
        private System.Windows.Forms.Label[] Labels;
        private System.Windows.Forms.TextBox[] TextBoxes;

        #endregion
    }
}
