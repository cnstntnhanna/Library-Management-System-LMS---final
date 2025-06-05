using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace MemberManagementApp
{
    public partial class MemberManagementForm : Form
    {
        private List<Member> members;

        public MemberManagementForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(MemberManagementForm_Load);
        }

        private void MemberManagementForm_Load(object sender, EventArgs e)
        {
            LoadMembers();
        }

        private void LoadMembers()
        {
            string connectionString = "server=localhost;database=librarydb;user=root;password=";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string query = "SELECT ID, Name, Contact, Join_Date FROM members";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    guna2DataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load members: " + ex.Message);
                }
            }
        }


        private void guna2Button6_Click(object sender, EventArgs e)
        {
            AddMember addMember = new AddMember();
            if (addMember.ShowDialog() == DialogResult.OK)
            {
                LoadMembers();
            }
        }
    }

    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string MembershipId { get; set; }
        public string Status { get; set; }
        public int CurrentLoans { get; set; }
        public int Age { get; set; }
        public DateTime Birthday { get; set; }
    }
}