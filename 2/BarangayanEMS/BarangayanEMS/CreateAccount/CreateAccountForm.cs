using System;
using System.Windows.Forms;

namespace BarangayanEMS
{
    public partial class CreateAccountForm : Form
    {
        public CreateAccountForm()
        {
            // This calls the Designer version ONLY (do not create another one here)
            InitializeComponent();
        }

        // CREATE ACCOUNT BUTTON CLICK
        private void btnCreate_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string pass = txtPassword.Text;
            string confirm = txtConfirm.Text;

            // Basic required fields check
            if (string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(pass) ||
                string.IsNullOrWhiteSpace(confirm))
            {
                MessageBox.Show(
                    "Please fill in all required fields:\nFirst name, Last name, Email, Password, Confirm Password.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (pass != confirm)
            {
                MessageBox.Show(
                    "Passwords do not match.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!chkTerms.Checked)
            {
                MessageBox.Show(
                    "Please agree to the Terms and Conditions.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // TODO: Hook this up to your actual database / account creation logic.
            MessageBox.Show(
                "Account creation demo only.\n\nHere you will insert the new user into the database.",
                "Create Account",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // After successful create, go back to LoginForm
            var login = new LoginForm();
            login.Show();
            this.Close();
        }

        // "Sign in" link – go back to LoginForm
        private void linkSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var login = new LoginForm();
            login.Show();
            this.Close();
        }
    }
}
