using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

public partial class NewLoan : Form
{
    // Define event
    public event EventHandler LoanSaved;
    public NewLoan()
    {
        InitializeComponent();
        btnCancel.Click += (s, e) => this.Close();
    }


    private void AddMemberForm_Load(object sender, EventArgs e)
    {

    }

    private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
    {

    }

    private void btnSave_Click_1(object sender, EventArgs e)
    {
        string name = txtName.Text.Trim();
        string memberId = txtMember.Text.Trim();
        DateTime checkoutDate = DateTime.Now; 
        string status = guna2cbStatus.Text;

        if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(memberId) || string.IsNullOrEmpty(status))
        {
            MessageBox.Show("Please fill in all fields.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        string connectionString = "Server=localhost;Database=librarydb;Uid=root;Pwd=;";

        string query = "INSERT INTO loans (Book, MemberID, CheckoutDate, Status) VALUES (@Book, @MemberID, @CheckoutDate, @Status)";

        try
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Book", name);
                    cmd.Parameters.AddWithValue("@MemberID", memberId);
                    cmd.Parameters.AddWithValue("@CheckoutDate", checkoutDate); 
                    cmd.Parameters.AddWithValue("@Status", status);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Loan scheduled successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Raise event to notify parent
                LoanSaved?.Invoke(this, EventArgs.Empty);

                this.Close(); // Close modal
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error saving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
