using System.Drawing;
using Guna.UI2.WinForms;

namespace Library_Management_System__LMS_
{
    partial class NewLoanForm
    {
        private Guna2TextBox txtBookId;
        private Guna2TextBox txtMemberId;
        private Guna2DateTimePicker dtpDueDate;
        private Guna2Button btnConfirmLoan;

        private void InitializeComponent()
        {
            this.txtBookId = new Guna2TextBox();
            this.txtMemberId = new Guna2TextBox();
            this.dtpDueDate = new Guna2DateTimePicker();
            this.btnConfirmLoan = new Guna2Button();

            // Form
            this.BackColor = Color.FromArgb(241, 239, 236);
            this.ClientSize = new Size(300, 280);
            this.Name = "NewLoanForm";
            this.Text = "New Loan";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // txtBookId
            this.txtBookId.PlaceholderText = "Enter Book ID";
            this.txtBookId.Location = new Point(40, 30);
            this.txtBookId.Size = new Size(220, 36);
            this.txtBookId.FillColor = Color.FromArgb(212, 201, 190);
            this.txtBookId.ForeColor = Color.FromArgb(3, 3, 3);
            this.txtBookId.BorderColor = Color.FromArgb(18, 52, 88);
            this.txtBookId.PlaceholderForeColor = Color.FromArgb(18, 52, 88);
            this.txtBookId.BorderRadius = 8;

            // txtMemberId
            this.txtMemberId.PlaceholderText = "Enter Member ID";
            this.txtMemberId.Location = new Point(40, 80);
            this.txtMemberId.Size = new Size(220, 36);
            this.txtMemberId.FillColor = Color.FromArgb(212, 201, 190);
            this.txtMemberId.ForeColor = Color.FromArgb(3, 3, 3);
            this.txtMemberId.BorderColor = Color.FromArgb(18, 52, 88);
            this.txtMemberId.PlaceholderForeColor = Color.FromArgb(18, 52, 88);
            this.txtMemberId.BorderRadius = 8;

            // dtpDueDate
            this.dtpDueDate.Location = new Point(40, 130);
            this.dtpDueDate.Size = new Size(220, 36);
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDueDate.FillColor = Color.FromArgb(212, 201, 190);
            this.dtpDueDate.ForeColor = Color.FromArgb(3, 3, 3);
            this.dtpDueDate.BorderColor = Color.FromArgb(18, 52, 88);
            this.dtpDueDate.BorderRadius = 8;

            // btnConfirmLoan
            this.btnConfirmLoan.Text = "Confirm Loan";
            this.btnConfirmLoan.Location = new Point(40, 190);
            this.btnConfirmLoan.Size = new Size(220, 45);
            this.btnConfirmLoan.FillColor = Color.FromArgb(18, 52, 88);
            this.btnConfirmLoan.ForeColor = Color.FromArgb(241, 239, 236);
            this.btnConfirmLoan.BorderRadius = 12;
            this.btnConfirmLoan.Click += new System.EventHandler(this.btnConfirmLoan_Click);

            // Add controls to form
            this.Controls.Add(this.txtBookId);
            this.Controls.Add(this.txtMemberId);
            this.Controls.Add(this.dtpDueDate);
            this.Controls.Add(this.btnConfirmLoan);
        }
    }
}
