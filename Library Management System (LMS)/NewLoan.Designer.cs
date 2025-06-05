using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

partial class NewLoan
{
    private Guna2TextBox txtName;
    private Guna2TextBox txtMember;
    private Guna2Button btnSave;
    private Guna2Button btnCancel;
    private Guna2HtmlLabel lblName;
    private Guna2HtmlLabel lblMember;

    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            this.lblName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMember = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtMember = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2dtpCheckout = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2cbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.lblName.Location = new System.Drawing.Point(18, 31);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 30);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Book:";
            // 
            // txtName
            // 
            this.txtName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.txtName.BorderRadius = 10;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtName.Location = new System.Drawing.Point(120, 25);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderText = "";
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(250, 36);
            this.txtName.TabIndex = 1;
            // 
            // lblMember
            // 
            this.lblMember.BackColor = System.Drawing.Color.Transparent;
            this.lblMember.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.lblMember.Location = new System.Drawing.Point(13, 86);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(81, 30);
            this.lblMember.TabIndex = 2;
            this.lblMember.Text = "Member:";
            // 
            // txtMember
            // 
            this.txtMember.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.txtMember.BorderRadius = 10;
            this.txtMember.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMember.DefaultText = "";
            this.txtMember.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMember.Location = new System.Drawing.Point(120, 80);
            this.txtMember.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMember.Name = "txtMember";
            this.txtMember.PlaceholderText = "";
            this.txtMember.SelectedText = "";
            this.txtMember.Size = new System.Drawing.Size(250, 36);
            this.txtMember.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 6;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(164, 252);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 36);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.BorderRadius = 6;
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(201)))), ((int)(((byte)(190)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.btnCancel.Location = new System.Drawing.Point(270, 252);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 36);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 25;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2dtpCheckout
            // 
            this.guna2dtpCheckout.BorderRadius = 10;
            this.guna2dtpCheckout.Checked = true;
            this.guna2dtpCheckout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(236)))));
            this.guna2dtpCheckout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2dtpCheckout.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2dtpCheckout.Location = new System.Drawing.Point(120, 139);
            this.guna2dtpCheckout.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2dtpCheckout.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2dtpCheckout.Name = "guna2dtpCheckout";
            this.guna2dtpCheckout.Size = new System.Drawing.Size(250, 36);
            this.guna2dtpCheckout.TabIndex = 7;
            this.guna2dtpCheckout.Value = new System.DateTime(2025, 6, 5, 4, 1, 56, 485);
            this.guna2dtpCheckout.ValueChanged += new System.EventHandler(this.guna2DateTimePicker1_ValueChanged);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(13, 145);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(89, 30);
            this.guna2HtmlLabel1.TabIndex = 8;
            this.guna2HtmlLabel1.Text = "Checkout:";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(13, 203);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(61, 30);
            this.guna2HtmlLabel2.TabIndex = 9;
            this.guna2HtmlLabel2.Text = "Status:";
            // 
            // guna2cbStatus
            // 
            this.guna2cbStatus.BackColor = System.Drawing.Color.Transparent;
            this.guna2cbStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.guna2cbStatus.BorderRadius = 10;
            this.guna2cbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2cbStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2cbStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2cbStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2cbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2cbStatus.ItemHeight = 30;
            this.guna2cbStatus.Items.AddRange(new object[] {
            "Reserved",
            "Not Available"});
            this.guna2cbStatus.Location = new System.Drawing.Point(120, 197);
            this.guna2cbStatus.Name = "guna2cbStatus";
            this.guna2cbStatus.Size = new System.Drawing.Size(250, 36);
            this.guna2cbStatus.TabIndex = 10;
            // 
            // NewLoan
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(397, 314);
            this.Controls.Add(this.guna2cbStatus);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2dtpCheckout);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblMember);
            this.Controls.Add(this.txtMember);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewLoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Member";
            this.Load += new System.EventHandler(this.AddMemberForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private Guna2BorderlessForm guna2BorderlessForm1;
    private System.ComponentModel.IContainer components;
    private Guna2DateTimePicker guna2dtpCheckout;
    private Guna2HtmlLabel guna2HtmlLabel1;
    private Guna2ComboBox guna2cbStatus;
    private Guna2HtmlLabel guna2HtmlLabel2;
}
