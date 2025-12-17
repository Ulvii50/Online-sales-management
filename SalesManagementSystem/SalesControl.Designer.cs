namespace SalesManagementSystem
{
    partial class SalesControl
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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            txtSearch = new TextBox();
            dgvProducts = new DataGridView();
            dgvCart = new DataGridView();
            numCount = new NumericUpDown();
            btnAdd = new Button();
            panel1 = new Panel();
            label4 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            btnClearCart = new Button();
            btnCard = new Button();
            btnCash = new Button();
            label2 = new Label();
            txtPaid = new TextBox();
            lblChange = new Label();
            lblTotalAmount = new Label();
            label3 = new Label();
            label1 = new Label();
            label5 = new Label();
            btnFinishSale = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCount).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 11F);
            txtSearch.Location = new Point(16, 544);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(456, 32);
            txtSearch.TabIndex = 0;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToResizeRows = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.BorderStyle = BorderStyle.None;
            dgvProducts.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProducts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(30, 30, 46);
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = Color.White;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(30, 30, 46);
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Cursor = Cursors.Hand;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Window;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle10.ForeColor = Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = Color.SeaGreen;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dgvProducts.DefaultCellStyle = dataGridViewCellStyle10;
            dgvProducts.EnableHeadersVisualStyles = false;
            dgvProducts.GridColor = Color.FromArgb(230, 230, 230);
            dgvProducts.Location = new Point(16, 69);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(570, 464);
            dgvProducts.TabIndex = 1;
            // 
            // dgvCart
            // 
            dgvCart.AllowUserToAddRows = false;
            dgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCart.BackgroundColor = Color.White;
            dgvCart.BorderStyle = BorderStyle.None;
            dgvCart.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCart.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(192, 0, 0);
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = Color.White;
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(192, 0, 0);
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dgvCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = SystemColors.Window;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle12.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = Color.White;
            dataGridViewCellStyle12.SelectionForeColor = Color.Black;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            dgvCart.DefaultCellStyle = dataGridViewCellStyle12;
            dgvCart.EnableHeadersVisualStyles = false;
            dgvCart.GridColor = Color.FromArgb(230, 230, 230);
            dgvCart.Location = new Point(16, 69);
            dgvCart.MultiSelect = false;
            dgvCart.Name = "dgvCart";
            dgvCart.ReadOnly = true;
            dgvCart.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvCart.RowHeadersVisible = false;
            dgvCart.RowHeadersWidth = 51;
            dgvCart.RowTemplate.ReadOnly = true;
            dgvCart.Size = new Size(535, 333);
            dgvCart.TabIndex = 2;
            dgvCart.CellContentClick += dgvCart_CellContentClick;
            dgvCart.CellFormatting += dgvCart_CellFormatting;
            // 
            // numCount
            // 
            numCount.Font = new Font("Segoe UI", 11F);
            numCount.Location = new Point(478, 544);
            numCount.Name = "numCount";
            numCount.Size = new Size(108, 32);
            numCount.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(41, 128, 185);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(16, 582);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(570, 43);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Səbətə Əlavə Et";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(dgvProducts);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(numCount);
            panel1.Controls.Add(txtSearch);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(604, 640);
            panel1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(30, 30, 46);
            label4.Location = new Point(222, 19);
            label4.Name = "label4";
            label4.Size = new Size(131, 35);
            label4.TabIndex = 5;
            label4.Text = "Məhsullar";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(btnFinishSale);
            panel2.Controls.Add(dgvCart);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(604, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(566, 640);
            panel2.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(btnClearCart);
            panel3.Controls.Add(btnCard);
            panel3.Controls.Add(btnCash);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtPaid);
            panel3.Controls.Add(lblChange);
            panel3.Controls.Add(lblTotalAmount);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(16, 408);
            panel3.Name = "panel3";
            panel3.Size = new Size(535, 168);
            panel3.TabIndex = 9;
            // 
            // btnClearCart
            // 
            btnClearCart.BackColor = Color.FromArgb(192, 0, 0);
            btnClearCart.FlatAppearance.BorderSize = 0;
            btnClearCart.FlatStyle = FlatStyle.Flat;
            btnClearCart.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClearCart.ForeColor = Color.White;
            btnClearCart.Location = new Point(404, 12);
            btnClearCart.Name = "btnClearCart";
            btnClearCart.Size = new Size(128, 43);
            btnClearCart.TabIndex = 10;
            btnClearCart.Text = "Ləğv Et";
            btnClearCart.UseVisualStyleBackColor = false;
            btnClearCart.Click += btnClearCart_Click;
            // 
            // btnCard
            // 
            btnCard.BackColor = Color.White;
            btnCard.FlatAppearance.BorderSize = 0;
            btnCard.FlatStyle = FlatStyle.Flat;
            btnCard.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCard.Location = new Point(281, 76);
            btnCard.Name = "btnCard";
            btnCard.Size = new Size(251, 36);
            btnCard.TabIndex = 10;
            btnCard.Text = "KART";
            btnCard.UseVisualStyleBackColor = false;
            btnCard.Click += btnCard_Click;
            // 
            // btnCash
            // 
            btnCash.BackColor = Color.MediumSeaGreen;
            btnCash.FlatAppearance.BorderSize = 0;
            btnCash.FlatStyle = FlatStyle.Flat;
            btnCash.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCash.ForeColor = Color.White;
            btnCash.Location = new Point(12, 76);
            btnCash.Name = "btnCash";
            btnCash.Size = new Size(263, 36);
            btnCash.TabIndex = 9;
            btnCash.Text = "NAĞD";
            btnCash.UseVisualStyleBackColor = false;
            btnCash.Click += btnCash_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(3, 130);
            label2.Name = "label2";
            label2.Size = new Size(179, 35);
            label2.TabIndex = 6;
            label2.Text = "Ödənilən Pul :";
            // 
            // txtPaid
            // 
            txtPaid.BorderStyle = BorderStyle.FixedSingle;
            txtPaid.Font = new Font("Segoe UI", 12F);
            txtPaid.Location = new Point(188, 133);
            txtPaid.Name = "txtPaid";
            txtPaid.Size = new Size(111, 34);
            txtPaid.TabIndex = 5;
            txtPaid.TextChanged += txtPaid_TextChanged;
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblChange.ForeColor = Color.Firebrick;
            lblChange.Location = new Point(394, 136);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(76, 28);
            lblChange.TabIndex = 8;
            lblChange.Text = "0.00 ₼";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTotalAmount.ForeColor = Color.DarkGreen;
            lblTotalAmount.Location = new Point(217, 20);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(92, 35);
            lblTotalAmount.TabIndex = 4;
            lblTotalAmount.Text = "0.00 ₼";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(305, 128);
            label3.Name = "label3";
            label3.Size = new Size(99, 37);
            label3.TabIndex = 7;
            label3.Text = "Qalıq :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(3, 15);
            label1.Name = "label1";
            label1.Size = new Size(228, 40);
            label1.TabIndex = 3;
            label1.Text = "Yekun Məbləğ: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(30, 30, 46);
            label5.Location = new Point(253, 19);
            label5.Name = "label5";
            label5.Size = new Size(83, 35);
            label5.TabIndex = 6;
            label5.Text = "Səbət";
            // 
            // btnFinishSale
            // 
            btnFinishSale.BackColor = Color.Green;
            btnFinishSale.FlatAppearance.BorderSize = 0;
            btnFinishSale.FlatStyle = FlatStyle.Flat;
            btnFinishSale.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnFinishSale.ForeColor = Color.White;
            btnFinishSale.Location = new Point(16, 582);
            btnFinishSale.Name = "btnFinishSale";
            btnFinishSale.Size = new Size(532, 43);
            btnFinishSale.TabIndex = 5;
            btnFinishSale.Text = "SATIŞI TAMAMLA";
            btnFinishSale.UseVisualStyleBackColor = false;
            btnFinishSale.Click += btnFinishSale_Click;
            // 
            // SalesControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "SalesControl";
            Size = new Size(1170, 640);
            Load += SalesControl_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCount).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtSearch;
        private DataGridView dgvProducts;
        private DataGridView dgvCart;
        private NumericUpDown numCount;
        private Button btnAdd;
        private Panel panel1;
        private Panel panel2;
        private Label lblTotalAmount;
        private Label label1;
        private Label label3;
        private Button btnFinishSale;
        private Label lblChange;
        private Label label4;
        private Label label5;
        private Panel panel3;
        private Label label2;
        private TextBox txtPaid;
        private Button btnCard;
        private Button btnCash;
        private Button btnClearCart;
    }
}
