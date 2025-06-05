using LibraryDashboard;
using LoanManagement;
using MemberManagementApp;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Library_Management_System__LMS_
{
    public partial class BookFormcs : Form

    {
        private string connectionString = "Server=127.0.0.1;Database=librarydb;Uid=root;Pwd=;";

        private List<Book> allBooks = new List<Book>();

        public BookFormcs()
        {
            InitializeComponent();
            LoadBooks();
        }

      
        private void DisplayBooks(List<Book> books)
        {
            dgvBooks.DataSource = null;
            dgvBooks.DataSource = books.Select(b => new
            {
                b.Title,
                b.Author,
                b.Category
            }).ToList();
        }
        private void ApplyFilters()
        {
            string keyword = txtSearch.Text.ToLower();
            string selectedCategory = cmbCategory.SelectedItem?.ToString();

            var filtered = allBooks.Where(b =>
                (string.IsNullOrEmpty(keyword) ||
                 b.Title.ToLower().Contains(keyword) ||
                 b.Author.ToLower().Contains(keyword)) &&
                (selectedCategory == "All" || b.Category == selectedCategory)
            ).ToList();

            DisplayBooks(filtered);
        }

        public void LoadBooks()
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT title, author, category FROM books";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvBooks.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load books: " + ex.Message);
                }
            }
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            AddBook addForm = new AddBook();
            addForm.BookAdded += (s, args) => LoadBooks(); // 🔁 Refresh on event
            addForm.ShowDialog();
        }

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            new Loan().Show();
            this.Close();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            BookFormcs form = new BookFormcs();
            form.Show();
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            new MemberManagementForm().Show();
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            new DashboardForm().Show();
            this.Close();
        }

        private void BookFormcs_Load(object sender, EventArgs e)
        {

        }
    }

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
    }
}
