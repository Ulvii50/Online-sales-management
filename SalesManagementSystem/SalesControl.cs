using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagementSystem
{
    public partial class SalesControl : UserControl
    {
        public SalesControl()
        {
            InitializeComponent();
        }

        DataTable dtCart = new DataTable();
        string paymentMethod = "Nağd"; 
        private void SalesControl_Load(object sender, EventArgs e)
        {
            LoadProducts();

            if (dtCart.Columns.Count == 0)
            {
                dtCart.Columns.Add("Id", typeof(int));
                dtCart.Columns.Add("Name", typeof(string));
                dtCart.Columns.Add("Price", typeof(double));
                dtCart.Columns.Add("Quantity", typeof(int));
                dtCart.Columns.Add("Total", typeof(double));
            }

            dgvCart.DataSource = dtCart;

            if (!dgvCart.Columns.Contains("Delete"))
            {
                DataGridViewButtonColumn deleteBtn = new DataGridViewButtonColumn();
                deleteBtn.HeaderText = "";
                deleteBtn.Name = "Delete";
                deleteBtn.Text = "X";
                deleteBtn.UseColumnTextForButtonValue = true;
                deleteBtn.Width = 20;

                deleteBtn.DefaultCellStyle.BackColor = Color.IndianRed;
                deleteBtn.DefaultCellStyle.ForeColor = Color.White;
                deleteBtn.DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);

                dgvCart.Columns.Add(deleteBtn);
            }

            dgvCart.Columns["Name"].HeaderText = "Məhsul";
            dgvCart.Columns["Price"].HeaderText = "Qiymət";
            dgvCart.Columns["Quantity"].HeaderText = "Say";
            dgvCart.Columns["Total"].HeaderText = "Cəm (AZN)";

            dgvCart.Columns["Id"].Visible = false;

            UpdateButtonColors();
        }



        private void LoadProducts()
        {
            string sql = "SELECT Id, Name, Barcode, Price, Stock FROM Products ";
            dgvProducts.DataSource = DBAccess.GetTable(sql);

            dgvProducts.Columns["Name"].HeaderText = "Məhsul Adı";
            dgvProducts.Columns["Barcode"].HeaderText = "Barkod";
            dgvProducts.Columns["Price"].HeaderText = "Qiymət";
            dgvProducts.Columns["Stock"].HeaderText = "Stok";

            if (dgvProducts.Columns.Contains("Id")) dgvProducts.Columns["Id"].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string barcode = txtSearch.Text.Trim();
            int count = Convert.ToInt32(numCount.Value);
            if (count <= 0) count = 1;

         
            if (!string.IsNullOrEmpty(barcode))
            {
                string query = $"SELECT Id FROM Products WHERE Barcode = '{barcode}'";
                DataTable dt = DBAccess.GetTable(query);

                if (dt != null && dt.Rows.Count > 0)
                {
                    string id = dt.Rows[0]["Id"].ToString();

                    AddToCart(id, count);

             
                    txtSearch.Clear();
                    txtSearch.Focus();
                    numCount.Value = 1;
                    return; 
                }
                else
                {
                    MessageBox.Show("Barkod tapılmadı!", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

          
            if (dgvProducts.CurrentRow != null && dgvProducts.CurrentRow.Index > -1)
            {
                try
                {
         
                    var cellValue = dgvProducts.CurrentRow.Cells[0].Value;

                    if (cellValue != null)
                    {
                        AddToCart(cellValue.ToString(), count);
                        numCount.Value = 1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xəta: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Zəhmət olmasa siyahıdan məhsul seçin!", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void AddToCart(string productId, int quantityToAdd)
        {
           
            string sql = $"SELECT * FROM Products WHERE Id = {productId}";
            DataTable dt = DBAccess.GetTable(sql);

            if (dt.Rows.Count > 0)
            {
                DataRow product = dt.Rows[0];
                int pId = Convert.ToInt32(product["Id"]);
                string pName = product["Name"].ToString();
                double pPrice = Convert.ToDouble(product["Price"]);
                int stockInDb = Convert.ToInt32(product["Stock"]); 

            
                int currentQtyInCart = 0;
                foreach (DataRow row in dtCart.Rows)
                {
                    if (Convert.ToInt32(row["Id"]) == pId)
                    {
                        currentQtyInCart = Convert.ToInt32(row["Quantity"]);
                        break;
                    }
                }

            
                if ((currentQtyInCart + quantityToAdd) > stockInDb)
                {
                    MessageBox.Show($"Stokda kifayət qədər məhsul yoxdur!\nBazadakı Stok: {stockInDb}\nSəbətdə: {currentQtyInCart}",
                                    "Stok Xətası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

              
                bool alreadyInCart = false;
                foreach (DataRow row in dtCart.Rows)
                {
                    if (Convert.ToInt32(row["Id"]) == pId)
                    {
                        row["Quantity"] = currentQtyInCart + quantityToAdd;
                        row["Total"] = (currentQtyInCart + quantityToAdd) * pPrice;
                        alreadyInCart = true;
                        break;
                    }
                }

                if (!alreadyInCart)
                {
                    dtCart.Rows.Add(pId, pName, pPrice, quantityToAdd, (pPrice * quantityToAdd));
                }


                foreach (DataGridViewRow productRow in dgvProducts.Rows)
                {
                    
                    if (productRow.Cells[0].Value.ToString() == productId)
                    {
                        int currentStock = Convert.ToInt32(productRow.Cells["Stock"].Value);

                        productRow.Cells["Stock"].Value = currentStock - quantityToAdd;
                        break;
                    }
                }

              
                CalculateTotalAmount();
            }
        }

        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (dgvCart.Columns[e.ColumnIndex].Name == "Delete" && e.RowIndex >= 0)
            {
                DialogResult r = MessageBox.Show("Səbətdən silinsin?", "Təsdiq", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    try
                    {
                        DataRow row = dtCart.Rows[e.RowIndex];
                        string deletedId = row["Id"].ToString();
                        int deletedQty = Convert.ToInt32(row["Quantity"]);

                        foreach (DataGridViewRow productRow in dgvProducts.Rows)
                        {
                            if (productRow.Cells[0].Value.ToString() == deletedId)
                            {
                                int currentStock = Convert.ToInt32(productRow.Cells["Stock"].Value);

                                productRow.Cells["Stock"].Value = currentStock + deletedQty;
                                break;
                            }
                        }
                       
                        row.Delete();
                        CalculateTotalAmount();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Xəta: " + ex.Message);
                    }
                }
            }
        }

       
        private void btnClearCart_Click(object sender, EventArgs e)
        {
            if (dtCart.Rows.Count == 0) return;

            if (MessageBox.Show("Bütün səbəti təmizləmək istəyirsiniz?", "Təsdiq", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                foreach (DataRow cartRow in dtCart.Rows)
                {
                    if (cartRow.RowState == DataRowState.Deleted) continue;

                    string id = cartRow["Id"].ToString();
                    int qty = Convert.ToInt32(cartRow["Quantity"]);

                    foreach (DataGridViewRow prodRow in dgvProducts.Rows)
                    {
                        if (prodRow.Cells[0].Value.ToString() == id)
                        {
                            int currentStock = Convert.ToInt32(prodRow.Cells["Stock"].Value);
                            prodRow.Cells["Stock"].Value = currentStock + qty; 
                            break;
                        }
                    }
                }

                
                dtCart.Rows.Clear();
                txtPaid.Clear();
                lblChange.Text = "0.00 ₼";
                CalculateTotalAmount(); 
            }
        }
        private void CalculateTotalAmount()
        {
            double total = 0;
            foreach (DataRow row in dtCart.Rows)
            {
                total += Convert.ToDouble(row["Total"]);
            }
            lblTotalAmount.Text = total.ToString("N2") + " ₼";
            CalculateChange(); 
        }

        private void CalculateChangeRealTime()
        {
            try
            {
                double totalAmount = 0;
                string totalStr = lblTotalAmount.Text.Replace("₼", "").Trim();
                if (!string.IsNullOrEmpty(totalStr))
                {
                    totalAmount = Convert.ToDouble(totalStr);
                }

               
                double paidAmount = 0;

               
                if (paymentMethod == "Kart")
                {
                    paidAmount = totalAmount;
                    txtPaid.Text = totalAmount.ToString(); 
                    txtPaid.Enabled = false; 
                }
                else 
                {
                    txtPaid.Enabled = true;
                    if (!string.IsNullOrEmpty(txtPaid.Text))
                    {
                        
                        string paidStr = txtPaid.Text.Replace(".", ",");
                        paidAmount = Convert.ToDouble(paidStr);
                    }
                }

               
                double change = paidAmount - totalAmount;
                lblChange.Text = change.ToString("N2") + " ₼";

                
                if (change < 0)
                    lblChange.ForeColor = Color.Red;
                else
                    lblChange.ForeColor = Color.Green;
            }
            catch
            {
               
                lblChange.Text = "0.00 ₼";
            }
        }

        private void txtPaid_TextChanged(object sender, EventArgs e)
        {
            
            CalculateChangeRealTime();
        }
        private void CalculateChange()
        {
            try
            {
                double grandTotal = 0;
                string totalText = lblTotalAmount.Text.Replace("₼", "").Trim();
                if (totalText != "") grandTotal = Convert.ToDouble(totalText);

                double paidAmount = 0;
                if (!string.IsNullOrEmpty(txtPaid.Text))
                {
                    paidAmount = Convert.ToDouble(txtPaid.Text);
                }

                double change = paidAmount - grandTotal;
                lblChange.Text = change.ToString("N2") + " ₼";

                if (change < 0) lblChange.ForeColor = Color.Red;
                else lblChange.ForeColor = Color.Green;
            }
            catch
            {
                lblChange.Text = "0.00 ₼";
            }
        }

       

          




        private void UpdateButtonColors()
        {
            if (paymentMethod == "Nağd")
            {
                btnCash.BackColor = Color.Green;
                btnCash.ForeColor = Color.White;
                btnCard.BackColor = Color.LightGray;
                btnCard.ForeColor = Color.Black;
                txtPaid.Enabled = true; 
            }
            else 
            {
                btnCard.BackColor = Color.Green;
                btnCard.ForeColor = Color.White;
                btnCash.BackColor = Color.LightGray;
                btnCash.ForeColor = Color.Black;

                
                string totalStr = lblTotalAmount.Text.Replace("₼", "").Trim();
                txtPaid.Text = totalStr;
                txtPaid.Enabled = false;
            }
        }
    }
}
