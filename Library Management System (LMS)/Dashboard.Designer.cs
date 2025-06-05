namespace LibraryDashboard
{
    partial class DashboardForm
    {
        private Guna.UI2.WinForms.Guna2Panel headerPanel;
        private Guna.UI2.WinForms.Guna2Panel totalBooksCard;
        private Guna.UI2.WinForms.Guna2Panel recentActivityCard;
        private Guna.UI2.WinForms.Guna2Button viewAllActivityBtn;
        private Guna.UI2.WinForms.Guna2Panel popularBooksCard;
        private Guna.UI2.WinForms.Guna2Button viewAllBooksBtn;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.headerPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.totalBooksCard = new Guna.UI2.WinForms.Guna2Panel();
            this.recentActivityCard = new Guna.UI2.WinForms.Guna2Panel();
            this.viewAllActivityBtn = new Guna.UI2.WinForms.Guna2Button();
            this.popularBooksCard = new Guna.UI2.WinForms.Guna2Panel();
            this.viewAllBooksBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.headerPanel.SuspendLayout();
            this.recentActivityCard.SuspendLayout();
            this.popularBooksCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.headerPanel.Controls.Add(this.guna2Button4);
            this.headerPanel.Controls.Add(this.guna2Button2);
            this.headerPanel.Controls.Add(this.guna2Button1);
            this.headerPanel.Controls.Add(this.guna2Button3);
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(800, 60);
            this.headerPanel.TabIndex = 0;
            // 
            // guna2Button4
            // 
            this.guna2Button4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Location = new System.Drawing.Point(350, 12);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(105, 35);
            this.guna2Button4.TabIndex = 17;
            this.guna2Button4.Text = "Loans";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(239, 12);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(105, 35);
            this.guna2Button2.TabIndex = 15;
            this.guna2Button2.Text = "Books";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(17, 12);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(105, 35);
            this.guna2Button1.TabIndex = 14;
            this.guna2Button1.Text = "Dashboard";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(128, 12);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(128, 35);
            this.guna2Button3.TabIndex = 16;
            this.guna2Button3.Text = "Members";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // totalBooksCard
            // 
            this.totalBooksCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(201)))), ((int)(((byte)(190)))));
            this.totalBooksCard.BorderRadius = 10;
            this.totalBooksCard.Location = new System.Drawing.Point(30, 80);
            this.totalBooksCard.Name = "totalBooksCard";
            this.totalBooksCard.Size = new System.Drawing.Size(250, 150);
            this.totalBooksCard.TabIndex = 1;
            // 
            // recentActivityCard
            // 
            this.recentActivityCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(201)))), ((int)(((byte)(190)))));
            this.recentActivityCard.BorderRadius = 10;
            this.recentActivityCard.Controls.Add(this.viewAllActivityBtn);
            this.recentActivityCard.Location = new System.Drawing.Point(30, 250);
            this.recentActivityCard.Name = "recentActivityCard";
            this.recentActivityCard.Size = new System.Drawing.Size(362, 150);
            this.recentActivityCard.TabIndex = 2;
            // 
            // viewAllActivityBtn
            // 
            this.viewAllActivityBtn.BorderRadius = 10;
            this.viewAllActivityBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.viewAllActivityBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.viewAllActivityBtn.ForeColor = System.Drawing.Color.White;
            this.viewAllActivityBtn.Location = new System.Drawing.Point(20, 100);
            this.viewAllActivityBtn.Name = "viewAllActivityBtn";
            this.viewAllActivityBtn.Size = new System.Drawing.Size(325, 30);
            this.viewAllActivityBtn.TabIndex = 0;
            this.viewAllActivityBtn.Text = "View All Activity";
            this.viewAllActivityBtn.Click += new System.EventHandler(this.ViewAllActivityBtn_Click);
            // 
            // popularBooksCard
            // 
            this.popularBooksCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(201)))), ((int)(((byte)(190)))));
            this.popularBooksCard.BorderRadius = 10;
            this.popularBooksCard.Controls.Add(this.viewAllBooksBtn);
            this.popularBooksCard.Location = new System.Drawing.Point(407, 250);
            this.popularBooksCard.Name = "popularBooksCard";
            this.popularBooksCard.Size = new System.Drawing.Size(362, 150);
            this.popularBooksCard.TabIndex = 3;
            // 
            // viewAllBooksBtn
            // 
            this.viewAllBooksBtn.BorderRadius = 10;
            this.viewAllBooksBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.viewAllBooksBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.viewAllBooksBtn.ForeColor = System.Drawing.Color.White;
            this.viewAllBooksBtn.Location = new System.Drawing.Point(20, 100);
            this.viewAllBooksBtn.Name = "viewAllBooksBtn";
            this.viewAllBooksBtn.Size = new System.Drawing.Size(327, 30);
            this.viewAllBooksBtn.TabIndex = 0;
            this.viewAllBooksBtn.Text = "View All Books";
            this.viewAllBooksBtn.Click += new System.EventHandler(this.ViewAllBooksBtn_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 20;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // DashboardForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.popularBooksCard);
            this.Controls.Add(this.totalBooksCard);
            this.Controls.Add(this.recentActivityCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.headerPanel.ResumeLayout(false);
            this.recentActivityCard.ResumeLayout(false);
            this.popularBooksCard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.ComponentModel.IContainer components;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
    }
}
