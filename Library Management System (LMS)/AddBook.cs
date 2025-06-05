using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Library_Management_System__LMS_
{
    public partial class AddBook : Form
    {
        public string connectionString = "Server=127.0.0.1;Database=librarydb;Uid=root;Pwd=;";
        public event EventHandler BookAdded;

        public AddBook()
        {
            InitializeComponent();
        }

        private void AddBook_Load(object sender, EventArgs e)
        {

        }

        private void guna2TxtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();
            string author = txtAuthor.Text.Trim();
            string category = txtCategory.Text.Trim();

            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(author) || string.IsNullOrWhiteSpace(category))
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }


            using (MySqlConnection con = new MySqlConnection(connectionString)) {
                try
                {
                    con.Open();
                    string query = "INSERT INTO books (title, author, category) VALUES (@title, @author, @category)";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@title", title);
                        cmd.Parameters.AddWithValue("@author", author);
                        cmd.Parameters.AddWithValue("@category", category);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Book Saved succesfully!");
                            txtTitle.Clear();
                            txtAuthor.Clear();
                            txtCategory.Clear();
                            BookAdded?.Invoke(this, EventArgs.Empty);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed to Save.");
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
