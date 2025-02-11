using System;
using System.Windows.Forms;

namespace Registration_form
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Declare controls for the form 
        private Label lblTitle;
        private Label lblName;
        private TextBox txtName;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnRegister;
        private Label lblBirthDate;
        private DateTimePicker dtpBirthDate;
        private Label lblGender;
        private ComboBox cmbGender;
        private Label lblCountry;
        private ComboBox cmbCountry;
        private Label lblProfilePic;
        private PictureBox picProfile;
        private Button btnUploadPic;
        private RadioButton rbMale;
        private RadioButton rbFemale;
        private CheckBox chkAcceptTerms;
        private ToolTip toolTip;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.lblName = new Label();
            this.txtName = new TextBox();
            this.lblEmail = new Label();
            this.txtEmail = new TextBox();
            this.lblPassword = new Label();
            this.txtPassword = new TextBox();
            this.btnRegister = new Button();
            this.lblBirthDate = new Label();
            this.dtpBirthDate = new DateTimePicker();
            this.lblGender = new Label();
            this.cmbGender = new ComboBox();
            this.lblCountry = new Label();
            this.cmbCountry = new ComboBox();
            this.lblProfilePic = new Label();
            this.picProfile = new PictureBox();
            this.btnUploadPic = new Button();
            this.rbMale = new RadioButton();
            this.rbFemale = new RadioButton();
            this.chkAcceptTerms = new CheckBox();
            this.toolTip = new ToolTip();

            // Setting up the form controls and properties 
            this.SuspendLayout();

            // Title Label 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(100, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(200, 31);
            this.lblTitle.Text = "Registration Form";

            // Name Label and TextBox 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 80);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.Text = "Name:";
            this.txtName.Location = new System.Drawing.Point(120, 80);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 22);

            // Email Label and TextBox 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(30, 120);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 17);
            this.lblEmail.Text = "Email:";
            this.txtEmail.Location = new System.Drawing.Point(120, 120);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 22);
            this.toolTip.SetToolTip(this.txtEmail, "Enter a valid email address.");

            // Password Label and TextBox 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(30, 160);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(72, 17);
            this.lblPassword.Text = "Password:";
            this.txtPassword.Location = new System.Drawing.Point(120, 160);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(200, 22);
            this.toolTip.SetToolTip(this.txtPassword, "Enter a strong password.");

            // Birth Date Label and DateTimePicker 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(30, 200);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(73, 17);
            this.lblBirthDate.Text = "Birth Date:";
            this.dtpBirthDate.Location = new System.Drawing.Point(120, 200);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(200, 22);

            // Gender Label and ComboBox 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(30, 240);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(55, 17);
            this.lblGender.Text = "Gender:";
            this.cmbGender.Location = new System.Drawing.Point(120, 240);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            this.cmbGender.Size = new System.Drawing.Size(200, 24);

            // Country Label and ComboBox 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(30, 280);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(60, 17);
            this.lblCountry.Text = "Country:";
            this.cmbCountry.Location = new System.Drawing.Point(120, 280);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Items.AddRange(new object[] { "USA", "Canada", "UK", "India" });
            this.cmbCountry.Size = new System.Drawing.Size(200, 24);

            // Profile Picture Label and PictureBox 
            this.lblProfilePic.AutoSize = true;
            this.lblProfilePic.Location = new System.Drawing.Point(30, 320);
            this.lblProfilePic.Name = "lblProfilePic";
            this.lblProfilePic.Size = new System.Drawing.Size(98, 17);
            this.lblProfilePic.Text = "Profile Picture:";
            this.picProfile.Location = new System.Drawing.Point(120, 320);
            this.picProfile.Name = "picProfile";
            this.picProfile.Size = new System.Drawing.Size(100, 100);
            this.picProfile.BorderStyle = BorderStyle.FixedSingle;

            // Upload Profile Picture Button 
            this.btnUploadPic.Location = new System.Drawing.Point(230, 320);
            this.btnUploadPic.Name = "btnUploadPic";
            this.btnUploadPic.Size = new System.Drawing.Size(90, 30);
            this.btnUploadPic.Text = "Upload";
            this.btnUploadPic.UseVisualStyleBackColor = true;
            this.btnUploadPic.Click += new EventHandler(this.btnUploadPic_Click);

            // Male and Female RadioButtons 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(120, 360);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(58, 21);
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;

            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(200, 360);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(75, 21);
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;

            // Terms and Conditions CheckBox 
            this.chkAcceptTerms.AutoSize = true;
            this.chkAcceptTerms.Location = new System.Drawing.Point(120, 400);
            this.chkAcceptTerms.Name = "chkAcceptTerms";
            this.chkAcceptTerms.Size = new System.Drawing.Size(148, 21);
            this.chkAcceptTerms.Text = "Accept Terms & Conditions";
            this.chkAcceptTerms.UseVisualStyleBackColor = true;

            // Register Button 
            this.btnRegister.Location = new System.Drawing.Point(120, 440);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(200, 30);
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new EventHandler(this.btnRegister_Click);

            // Form Properties 
            this.ClientSize = new System.Drawing.Size(350, 490);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.chkAcceptTerms);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.btnUploadPic);
            this.Controls.Add(this.picProfile);
            this.Controls.Add(this.lblProfilePic);
            this.Controls.Add(this.cmbCountry);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Registration Form";

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // Event Handlers 
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            // Validate the inputs and register logic 
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtEmail.Text) ||
                string.IsNullOrEmpty(txtPassword.Text) || !chkAcceptTerms.Checked)
            {
                MessageBox.Show("Please fill in all fields and accept the terms.");
            }
            else
            {
                MessageBox.Show("Registration Successful!");
            }
        }

        private void BtnUploadPic_Click(object sender, EventArgs e)
        {
            // Open file dialog to upload a profile picture 
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picProfile.Image = new System.Drawing.Bitmap(openFileDialog.FileName);
            }
        }
    }
}