using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Registration_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string gender = cmbGender.SelectedItem?.ToString();
            string country = cmbCountry.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || !chkAcceptTerms.Checked)
            {
                MessageBox.Show("Please fill all fields and accept the terms.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show($"Registration Successful!\nName: {name}\nEmail: {email}\nGender: {gender}\nCountry: {country}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUploadPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picProfile.Image = new System.Drawing.Bitmap(openFileDialog.FileName);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}