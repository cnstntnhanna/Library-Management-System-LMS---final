using System;
using System.Windows.Forms;
using LibraryDashboard;

namespace Library_Management_System__LMS_
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            cmbUserType.Items.Clear();
            cmbUserType.Items.Add("Select User Type");
            cmbUserType.Items.Add("Admin");
            cmbUserType.Items.Add("Librarian");
            cmbUserType.SelectedIndex = 0;
            txtUsername.Enabled = false;
            txtPassword.Enabled = false;

            lblError.Visible = false;

            cmbUserType.SelectedIndexChanged += cmbUserType_SelectedIndexChanged;
        }

        private void cmbUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string userType = cmbUserType.SelectedItem?.ToString();

            if (userType == "Librarian" || userType == "Admin")
            {
                txtUsername.Enabled = true;
                txtPassword.Enabled = true;
                txtUsername.Focus();
            }
            else
            {
                txtUsername.Enabled = false;
                txtPassword.Enabled = false;
                txtUsername.Clear();
                txtPassword.Clear();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userType = cmbUserType.SelectedItem?.ToString();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (userType == "Select User Type" || string.IsNullOrEmpty(userType))
            {
                lblError.Text = "Please select a user type.";
                lblError.Visible = true;
                return;
            }

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                lblError.Text = "Please enter both username and password.";
                lblError.Visible = true;
                return;
            }

            if (userType == "Librarian" && username == "Librarian" && password == "libpass")
            {
                lblError.Visible = false;

                DashboardForm librarianDashboard = new DashboardForm();
                librarianDashboard.Show();
                this.Hide();
            }
            else if (userType == "Admin" && username == "Admin" && password == "adminpass")
            {
                lblError.Visible = false;
                MessageBox.Show("Welcome Admin!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DashboardForm form = new DashboardForm();
                form.Show();
                this.Close();
            }
            else
            {
                lblError.Text = "Access denied or invalid credentials.";
                lblError.Visible = true;
            }
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox1.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }

            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
