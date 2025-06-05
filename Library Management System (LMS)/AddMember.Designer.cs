using System;
using System.Windows.Forms;

namespace MemberManagementApp
{
    partial class AddMember
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnOK;
        private Button btnCancel;
        private Label lblName;
        private Label lblAge;
        private Label lblContact;
        private Label lblBirthday;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.guna2TxtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextAge = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextContact = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2DateBirthday = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.btnOK.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(210, 349);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(93, 36);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "Confirm";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(309, 349);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 36);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.lblName.Location = new System.Drawing.Point(33, 121);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(67, 34);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblAge
            // 
            this.lblAge.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.lblAge.Location = new System.Drawing.Point(33, 177);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(67, 34);
            this.lblAge.TabIndex = 1;
            this.lblAge.Text = "Age:";
            this.lblAge.Click += new System.EventHandler(this.lblAge_Click);
            // 
            // lblContact
            // 
            this.lblContact.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.lblContact.Location = new System.Drawing.Point(18, 234);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(92, 32);
            this.lblContact.TabIndex = 2;
            this.lblContact.Text = "Contact:";
            this.lblContact.Click += new System.EventHandler(this.lblContact_Click);
            // 
            // lblBirthday
            // 
            this.lblBirthday.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.lblBirthday.Location = new System.Drawing.Point(18, 295);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(92, 35);
            this.lblBirthday.TabIndex = 3;
            this.lblBirthday.Text = "Birthday:";
            this.lblBirthday.Click += new System.EventHandler(this.lblBirthday_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 25;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.label1.Location = new System.Drawing.Point(76, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 42);
            this.label1.TabIndex = 10;
            this.label1.Text = "Register Member";
            // 
            // guna2TxtName
            // 
            this.guna2TxtName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.guna2TxtName.BorderRadius = 8;
            this.guna2TxtName.BorderThickness = 2;
            this.guna2TxtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TxtName.DefaultText = "";
            this.guna2TxtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TxtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TxtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TxtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TxtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TxtName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TxtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TxtName.Location = new System.Drawing.Point(115, 121);
            this.guna2TxtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TxtName.Name = "guna2TxtName";
            this.guna2TxtName.PlaceholderText = "";
            this.guna2TxtName.SelectedText = "";
            this.guna2TxtName.Size = new System.Drawing.Size(268, 34);
            this.guna2TxtName.TabIndex = 11;
            // 
            // guna2TextAge
            // 
            this.guna2TextAge.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.guna2TextAge.BorderRadius = 8;
            this.guna2TextAge.BorderThickness = 2;
            this.guna2TextAge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextAge.DefaultText = "";
            this.guna2TextAge.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextAge.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextAge.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextAge.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextAge.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextAge.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextAge.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextAge.Location = new System.Drawing.Point(116, 177);
            this.guna2TextAge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextAge.Name = "guna2TextAge";
            this.guna2TextAge.PlaceholderText = "";
            this.guna2TextAge.SelectedText = "";
            this.guna2TextAge.Size = new System.Drawing.Size(268, 34);
            this.guna2TextAge.TabIndex = 12;
            // 
            // guna2TextContact
            // 
            this.guna2TextContact.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.guna2TextContact.BorderRadius = 8;
            this.guna2TextContact.BorderThickness = 2;
            this.guna2TextContact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextContact.DefaultText = "";
            this.guna2TextContact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextContact.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextContact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextContact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextContact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextContact.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextContact.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextContact.Location = new System.Drawing.Point(116, 234);
            this.guna2TextContact.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextContact.Name = "guna2TextContact";
            this.guna2TextContact.PlaceholderText = "";
            this.guna2TextContact.SelectedText = "";
            this.guna2TextContact.Size = new System.Drawing.Size(268, 32);
            this.guna2TextContact.TabIndex = 13;
            // 
            // guna2DateBirthday
            // 
            this.guna2DateBirthday.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.guna2DateBirthday.BorderRadius = 8;
            this.guna2DateBirthday.BorderThickness = 2;
            this.guna2DateBirthday.Checked = true;
            this.guna2DateBirthday.FillColor = System.Drawing.Color.White;
            this.guna2DateBirthday.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateBirthday.Location = new System.Drawing.Point(116, 294);
            this.guna2DateBirthday.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateBirthday.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateBirthday.Name = "guna2DateBirthday";
            this.guna2DateBirthday.Size = new System.Drawing.Size(267, 36);
            this.guna2DateBirthday.TabIndex = 14;
            this.guna2DateBirthday.Value = new System.DateTime(2025, 6, 4, 9, 38, 19, 850);
            // 
            // AddMember
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(415, 415);
            this.Controls.Add(this.guna2DateBirthday);
            this.Controls.Add(this.guna2TextContact);
            this.Controls.Add(this.guna2TextAge);
            this.Controls.Add(this.guna2TxtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Member";
            this.Load += new System.EventHandler(this.AddMember_Load);
            this.ResumeLayout(false);

        }

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TxtName;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextAge;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextContact;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateBirthday;
    }
}
