using Library_Management_System__LMS_;
using LibraryDashboard;
using MemberManagementApp;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace LoanManagement
{
    public partial class Loan : Form
    {
        private string connectionString = "Server=localhost;Database=librarydb;Uid=root;Pwd=;";

        public Loan()
        {
            InitializeComponent();
        }

        private void Loan_Load(object sender, EventArgs e)
        {
            LoadLoans();
        }

        private void LoadLoans()
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT Book, MemberID, CheckoutDate, Status FROM loans";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvLoans.DataSource = dt;
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void BtnNewLoan_Click(object sender, EventArgs e)
        {
            NewLoan newLoan = new NewLoan();
            newLoan.ShowDialog();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            FilterLoans();
        }

        private void CmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterLoans();
        }

        private void CmbSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortLoans();
        }

        private void DgvLoans_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void FilterLoans()
        {

        }

        private void SortLoans()
        {

        }


        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            new DashboardForm().Show();
            this.Close();
        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            new MemberManagementForm().Show();
            this.Close();
        }

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
            new Loan().Show();
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
