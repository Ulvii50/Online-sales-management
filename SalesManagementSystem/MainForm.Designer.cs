namespace SalesManagementSystem
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnlSidebar = new Panel();
            label1 = new Label();
            btnUsers = new Button();
            btnExitApp = new Button();
            btnLogout = new Button();
            btnReports = new Button();
            btnProducts = new Button();
            btnSales = new Button();
            btnDashboard = new Button();
            pnlHeader = new Panel();
            pnlHeaderBorder = new Panel();
            lblPageTitle = new Label();
            lblCurrentDateTime = new Label();
            lblUserName = new Label();
            pnlContent = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            pnlSidebar.SuspendLayout();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(30, 30, 46);
            pnlSidebar.Controls.Add(label1);
            pnlSidebar.Controls.Add(btnUsers);
            pnlSidebar.Controls.Add(btnExitApp);
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Controls.Add(btnReports);
            pnlSidebar.Controls.Add(btnProducts);
            pnlSidebar.Controls.Add(btnSales);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(280, 700);
            pnlSidebar.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(25, 39);
            label1.Name = "label1";
            label1.Size = new Size(238, 45);
            label1.TabIndex = 7;
            label1.Text = "SATIŞ SİSTEMİ";
            // 
            // btnUsers
            // 
            btnUsers.BackColor = Color.FromArgb(60, 64, 91);
            btnUsers.FlatAppearance.BorderSize = 0;
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Segoe UI", 12F);
            btnUsers.ForeColor = Color.White;
            btnUsers.Location = new Point(34, 301);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(214, 50);
            btnUsers.TabIndex = 6;
            btnUsers.Text = "İstifadəçilər";
            btnUsers.TextAlign = ContentAlignment.MiddleLeft;
            btnUsers.UseVisualStyleBackColor = false;
            btnUsers.Visible = false;
            // 
            // btnExitApp
            // 
            btnExitApp.BackColor = Color.FromArgb(51, 54, 76);
            btnExitApp.FlatAppearance.BorderSize = 0;
            btnExitApp.FlatStyle = FlatStyle.Flat;
            btnExitApp.Font = new Font("Segoe UI", 12F);
            btnExitApp.ForeColor = Color.White;
            btnExitApp.Location = new Point(34, 598);
            btnExitApp.Name = "btnExitApp";
            btnExitApp.Size = new Size(214, 50);
            btnExitApp.TabIndex = 5;
            btnExitApp.Text = "Proqramı bağla";
            btnExitApp.UseVisualStyleBackColor = false;
            btnExitApp.Click += btnExitApp_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(51, 54, 76);
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 12F);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(34, 542);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(214, 50);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Hesabdan çıx";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.FromArgb(60, 64, 91);
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI", 12F);
            btnReports.ForeColor = Color.White;
            btnReports.Location = new Point(34, 357);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(214, 50);
            btnReports.TabIndex = 3;
            btnReports.Text = "Hesabatlar";
            btnReports.TextAlign = ContentAlignment.MiddleLeft;
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Visible = false;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = Color.FromArgb(60, 64, 91);
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Segoe UI", 12F);
            btnProducts.ForeColor = Color.White;
            btnProducts.Location = new Point(34, 245);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(214, 50);
            btnProducts.TabIndex = 2;
            btnProducts.Text = "Məhsullar";
            btnProducts.TextAlign = ContentAlignment.MiddleLeft;
            btnProducts.UseVisualStyleBackColor = false;
            btnProducts.Visible = false;
            // 
            // btnSales
            // 
            btnSales.BackColor = Color.FromArgb(60, 64, 91);
            btnSales.FlatAppearance.BorderSize = 0;
            btnSales.FlatStyle = FlatStyle.Flat;
            btnSales.Font = new Font("Segoe UI", 12F);
            btnSales.ForeColor = Color.White;
            btnSales.Location = new Point(34, 189);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(214, 50);
            btnSales.TabIndex = 1;
            btnSales.Text = "Satış";
            btnSales.TextAlign = ContentAlignment.MiddleLeft;
            btnSales.UseVisualStyleBackColor = false;
            btnSales.Click += btnSales_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(93, 95, 239);
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 12F);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(34, 133);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(214, 50);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Əsas Səhifə";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(pnlHeaderBorder);
            pnlHeader.Controls.Add(lblPageTitle);
            pnlHeader.Controls.Add(lblCurrentDateTime);
            pnlHeader.Controls.Add(lblUserName);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(280, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1170, 60);
            pnlHeader.TabIndex = 1;
            // 
            // pnlHeaderBorder
            // 
            pnlHeaderBorder.BackColor = Color.Black;
            pnlHeaderBorder.Location = new Point(0, 50);
            pnlHeaderBorder.Name = "pnlHeaderBorder";
            pnlHeaderBorder.Size = new Size(1306, 6);
            pnlHeaderBorder.TabIndex = 0;
            // 
            // lblPageTitle
            // 
            lblPageTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblPageTitle.Location = new Point(484, 1);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(210, 46);
            lblPageTitle.TabIndex = 1;
            lblPageTitle.Text = "Əsas Səhifə";
            lblPageTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCurrentDateTime
            // 
            lblCurrentDateTime.AutoSize = true;
            lblCurrentDateTime.Font = new Font("Segoe UI", 10F);
            lblCurrentDateTime.Location = new Point(6, 14);
            lblCurrentDateTime.Name = "lblCurrentDateTime";
            lblCurrentDateTime.Size = new Size(269, 23);
            lblCurrentDateTime.TabIndex = 2;
            lblCurrentDateTime.Text = "14 Dekabr 2025, Bazar günü 12:51";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 11F);
            lblUserName.Location = new Point(980, 14);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(178, 25);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "Ulvi Akbarli | Admin";
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.White;
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(280, 60);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1170, 640);
            pnlContent.TabIndex = 2;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1450, 700);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSidebar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private Panel pnlHeader;
        private Panel pnlContent;
        private Button btnDashboard;
        private Button btnReports;
        private Button btnProducts;
        private Button btnSales;
        private Button btnExitApp;
        private Button btnLogout;
        private Button btnUsers;
        private Label label1;
        private Label lblUserName;
        private Label lblCurrentDateTime;
        private Label lblPageTitle;
        private Panel pnlHeaderBorder;
        private System.Windows.Forms.Timer timer1;
    }
}