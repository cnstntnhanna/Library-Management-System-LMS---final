using System;
using System.Windows.Forms;

namespace Library_Management_System__LMS_
{
    public partial class NewLoanForm : Form
    {
        public NewLoanForm()
        {
            InitializeComponent();
        }

        private void btnConfirmLoan_Click(object sender, EventArgs e)
        {
            try
            {
                int bookId = int.Parse(txtBookId.Text);
                int memberId = int.Parse(txtMemberId.Text);
                DateTime dueDate = dtpDueDate.Value;

                CreateNewLoan(bookId, memberId, dueDate);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void CreateNewLoan(int bookId, int memberId, DateTime dueDate)
        {
            // TODO: Replace with actual DB logic
            MessageBox.Show($"Book ID {bookId} loaned to Member ID {memberId} until {dueDate.ToShortDateString()}", "Loan Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
