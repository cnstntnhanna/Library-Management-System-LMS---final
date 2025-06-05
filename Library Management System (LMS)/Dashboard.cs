using System;
using System.Windows.Forms;
using MemberManagementApp;
using LoanManagement;
using Library_Management_System__LMS_;


namespace LibraryDashboard
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void ViewAllActivityBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Viewing all activity...");
        }

        private void ViewAllBooksBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Viewing all books...");
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            MemberManagementForm form = new MemberManagementForm();
            form.Show();
            this.Close();
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DashboardForm form = new DashboardForm();
            form.Show();
            this.Close();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Loan form = new Loan();
            form.Show();
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            BookFormcs form = new BookFormcs();
            form.Show();
            this.Close();
        }
    }
}
