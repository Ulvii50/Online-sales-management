namespace SalesManagementSystem
{
    partial class DashboardControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardControl));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            flowCards = new FlowLayoutPanel();
            panel1 = new Panel();
            lblTotalProductCount = new Label();
            label1 = new Label();
            panel2 = new Panel();
            lblTodaySalesCount = new Label();
            label4 = new Label();
            panel3 = new Panel();
            lblOutOfStockCount = new Label();
            label6 = new Label();
            panel4 = new Panel();
            lblTodayRevenue = new Label();
            label8 = new Label();
            panel8 = new Panel();
            lblTotalRevenue = new Label();
            label16 = new Label();
            lblCriticalStockTitle = new Label();
            lblRecentSalesTitle = new Label();
            pnlCriticalStock = new Panel();
            pictureBox1 = new PictureBox();
            dgvCriticalStock = new DataGridView();
            pnlRecentSales = new Panel();
            pictureBox2 = new PictureBox();
            dgvRecentSales = new DataGridView();
            flowCards.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel8.SuspendLayout();
            pnlCriticalStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCriticalStock).BeginInit();
            pnlRecentSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRecentSales).BeginInit();
            SuspendLayout();
            // 
            // flowCards
            // 
            flowCards.Controls.Add(panel1);
            flowCards.Controls.Add(panel2);
            flowCards.Controls.Add(panel3);
            flowCards.Controls.Add(panel4);
            flowCards.Controls.Add(panel8);
            flowCards.Dock = DockStyle.Right;
            flowCards.FlowDirection = FlowDirection.TopDown;
            flowCards.Location = new Point(872, 0);
            flowCards.Name = "flowCards";
            flowCards.Size = new Size(298, 640);
            flowCards.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 64, 0);
            panel1.Controls.Add(lblTotalProductCount);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.No;
            panel1.Size = new Size(290, 122);
            panel1.TabIndex = 0;
            // 
            // lblTotalProductCount
            // 
            lblTotalProductCount.Dock = DockStyle.Bottom;
            lblTotalProductCount.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTotalProductCount.ForeColor = Color.White;
            lblTotalProductCount.Location = new Point(0, 72);
            lblTotalProductCount.Name = "lblTotalProductCount";
            lblTotalProductCount.Size = new Size(290, 50);
            lblTotalProductCount.TabIndex = 1;
            lblTotalProductCount.Text = "300";
            lblTotalProductCount.TextAlign = ContentAlignment.TopRight;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(15, 0);
            label1.Name = "label1";
            label1.Size = new Size(175, 72);
            label1.TabIndex = 0;
            label1.Text = "Məhsul Sayı";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 0, 192);
            panel2.Controls.Add(lblTodaySalesCount);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(3, 131);
            panel2.Name = "panel2";
            panel2.RightToLeft = RightToLeft.No;
            panel2.Size = new Size(290, 122);
            panel2.TabIndex = 2;
            // 
            // lblTodaySalesCount
            // 
            lblTodaySalesCount.Dock = DockStyle.Bottom;
            lblTodaySalesCount.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTodaySalesCount.ForeColor = Color.White;
            lblTodaySalesCount.Location = new Point(0, 72);
            lblTodaySalesCount.Name = "lblTodaySalesCount";
            lblTodaySalesCount.Size = new Size(290, 50);
            lblTodaySalesCount.TabIndex = 1;
            lblTodaySalesCount.Text = "25";
            lblTodaySalesCount.TextAlign = ContentAlignment.TopRight;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(15, 0);
            label4.Name = "label4";
            label4.Size = new Size(175, 72);
            label4.TabIndex = 0;
            label4.Text = "Satış Sayı";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Red;
            panel3.Controls.Add(lblOutOfStockCount);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(3, 259);
            panel3.Name = "panel3";
            panel3.RightToLeft = RightToLeft.No;
            panel3.Size = new Size(290, 122);
            panel3.TabIndex = 3;
            // 
            // lblOutOfStockCount
            // 
            lblOutOfStockCount.Dock = DockStyle.Bottom;
            lblOutOfStockCount.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblOutOfStockCount.ForeColor = Color.White;
            lblOutOfStockCount.Location = new Point(0, 72);
            lblOutOfStockCount.Name = "lblOutOfStockCount";
            lblOutOfStockCount.Size = new Size(290, 50);
            lblOutOfStockCount.TabIndex = 1;
            lblOutOfStockCount.Text = "5";
            lblOutOfStockCount.TextAlign = ContentAlignment.TopRight;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(15, 0);
            label6.Name = "label6";
            label6.Size = new Size(175, 72);
            label6.TabIndex = 0;
            label6.Text = "Kritik Stok";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 192, 0);
            panel4.Controls.Add(lblTodayRevenue);
            panel4.Controls.Add(label8);
            panel4.Location = new Point(3, 387);
            panel4.Name = "panel4";
            panel4.RightToLeft = RightToLeft.No;
            panel4.Size = new Size(290, 122);
            panel4.TabIndex = 9;
            // 
            // lblTodayRevenue
            // 
            lblTodayRevenue.Dock = DockStyle.Bottom;
            lblTodayRevenue.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTodayRevenue.ForeColor = Color.White;
            lblTodayRevenue.Location = new Point(0, 72);
            lblTodayRevenue.Name = "lblTodayRevenue";
            lblTodayRevenue.Size = new Size(290, 50);
            lblTodayRevenue.TabIndex = 1;
            lblTodayRevenue.Text = "142₼";
            lblTodayRevenue.TextAlign = ContentAlignment.TopRight;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(15, 0);
            label8.Name = "label8";
            label8.Size = new Size(175, 72);
            label8.TabIndex = 0;
            label8.Text = "Günlük Gəlir";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(0, 64, 0);
            panel8.Controls.Add(lblTotalRevenue);
            panel8.Controls.Add(label16);
            panel8.Location = new Point(3, 515);
            panel8.Name = "panel8";
            panel8.Size = new Size(290, 122);
            panel8.TabIndex = 8;
            // 
            // lblTotalRevenue
            // 
            lblTotalRevenue.Dock = DockStyle.Bottom;
            lblTotalRevenue.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTotalRevenue.ForeColor = Color.Yellow;
            lblTotalRevenue.Location = new Point(0, 72);
            lblTotalRevenue.Name = "lblTotalRevenue";
            lblTotalRevenue.RightToLeft = RightToLeft.No;
            lblTotalRevenue.Size = new Size(290, 50);
            lblTotalRevenue.TabIndex = 1;
            lblTotalRevenue.Text = "142 ₼";
            lblTotalRevenue.TextAlign = ContentAlignment.TopRight;
            // 
            // label16
            // 
            label16.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label16.ForeColor = Color.White;
            label16.Location = new Point(15, 0);
            label16.Name = "label16";
            label16.Size = new Size(175, 72);
            label16.TabIndex = 0;
            label16.Text = "Ümumi Gəlir";
            label16.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCriticalStockTitle
            // 
            lblCriticalStockTitle.AutoSize = true;
            lblCriticalStockTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblCriticalStockTitle.Location = new Point(67, 22);
            lblCriticalStockTitle.Name = "lblCriticalStockTitle";
            lblCriticalStockTitle.Size = new Size(533, 35);
            lblCriticalStockTitle.TabIndex = 2;
            lblCriticalStockTitle.Text = "Kritik Stok Vəziyyəti (Təcili Təmin Olunmalı)";
            // 
            // lblRecentSalesTitle
            // 
            lblRecentSalesTitle.AutoSize = true;
            lblRecentSalesTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblRecentSalesTitle.Location = new Point(67, 11);
            lblRecentSalesTitle.Name = "lblRecentSalesTitle";
            lblRecentSalesTitle.Size = new Size(289, 35);
            lblRecentSalesTitle.TabIndex = 3;
            lblRecentSalesTitle.Text = "Son 10 Satış Əməliyyatı";
            // 
            // pnlCriticalStock
            // 
            pnlCriticalStock.Controls.Add(pictureBox1);
            pnlCriticalStock.Controls.Add(dgvCriticalStock);
            pnlCriticalStock.Controls.Add(lblCriticalStockTitle);
            pnlCriticalStock.Dock = DockStyle.Top;
            pnlCriticalStock.Location = new Point(0, 0);
            pnlCriticalStock.Name = "pnlCriticalStock";
            pnlCriticalStock.Size = new Size(872, 320);
            pnlCriticalStock.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(49, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // dgvCriticalStock
            // 
            dgvCriticalStock.AllowUserToAddRows = false;
            dgvCriticalStock.AllowUserToResizeRows = false;
            dgvCriticalStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCriticalStock.BackgroundColor = Color.White;
            dgvCriticalStock.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(93, 95, 239);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(30, 30, 46);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCriticalStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCriticalStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCriticalStock.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCriticalStock.EnableHeadersVisualStyles = false;
            dgvCriticalStock.Location = new Point(12, 67);
            dgvCriticalStock.MultiSelect = false;
            dgvCriticalStock.Name = "dgvCriticalStock";
            dgvCriticalStock.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvCriticalStock.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvCriticalStock.RowHeadersVisible = false;
            dgvCriticalStock.RowHeadersWidth = 51;
            dgvCriticalStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCriticalStock.Size = new Size(854, 233);
            dgvCriticalStock.TabIndex = 3;
            dgvCriticalStock.DataBindingComplete += dgvCriticalStock_DataBindingComplete;
            // 
            // pnlRecentSales
            // 
            pnlRecentSales.Controls.Add(pictureBox2);
            pnlRecentSales.Controls.Add(dgvRecentSales);
            pnlRecentSales.Controls.Add(lblRecentSalesTitle);
            pnlRecentSales.Dock = DockStyle.Fill;
            pnlRecentSales.Location = new Point(0, 320);
            pnlRecentSales.Name = "pnlRecentSales";
            pnlRecentSales.Size = new Size(872, 320);
            pnlRecentSales.TabIndex = 5;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 11);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(49, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // dgvRecentSales
            // 
            dgvRecentSales.AllowUserToAddRows = false;
            dgvRecentSales.AllowUserToResizeRows = false;
            dgvRecentSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecentSales.BackgroundColor = Color.White;
            dgvRecentSales.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(192, 64, 0);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(192, 64, 0);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvRecentSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvRecentSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = Color.White;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvRecentSales.DefaultCellStyle = dataGridViewCellStyle5;
            dgvRecentSales.EnableHeadersVisualStyles = false;
            dgvRecentSales.Location = new Point(12, 59);
            dgvRecentSales.Name = "dgvRecentSales";
            dgvRecentSales.ReadOnly = true;
            dgvRecentSales.RowHeadersVisible = false;
            dgvRecentSales.RowHeadersWidth = 51;
            dgvRecentSales.Size = new Size(854, 233);
            dgvRecentSales.TabIndex = 4;
            // 
            // DashboardControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlRecentSales);
            Controls.Add(pnlCriticalStock);
            Controls.Add(flowCards);
            Name = "DashboardControl";
            Size = new Size(1170, 640);
            Load += DashboardControl_Load;
            flowCards.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel8.ResumeLayout(false);
            pnlCriticalStock.ResumeLayout(false);
            pnlCriticalStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCriticalStock).EndInit();
            pnlRecentSales.ResumeLayout(false);
            pnlRecentSales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRecentSales).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowCards;
        private Panel panel1;
        private Label label1;
        private Label lblTotalProductCount;
        private Panel panel2;
        private Label lblTodaySalesCount;
        private Label label4;
        private Panel panel3;
        private Label lblOutOfStockCount;
        private Label label6;
        private Panel panel8;
        private Label lblTotalRevenue;
        private Label label16;
        private Panel panel4;
        private Label lblTodayRevenue;
        private Label label8;
        private Label lblCriticalStockTitle;
        private Label lblRecentSalesTitle;
        private Panel pnlCriticalStock;
        private DataGridView dgvCriticalStock;
        private Panel pnlRecentSales;
        private DataGridView dgvRecentSales;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
