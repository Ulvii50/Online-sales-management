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
    public partial class DashboardControl : UserControl
    {
        public DashboardControl()
        {
            InitializeComponent();
        }

        private void DashboardControl_Load(object sender, EventArgs e)
        {
            RefreshDashboard();
            FormatTable();
        }

        public void RefreshDashboard()
        {


            DataTable dt;
            dt = DBAccess.GetTable("Select Count(*) from products where stock >0");
            lblTotalProductCount.Text = dt.Rows[0][0].ToString();

            dt = DBAccess.GetTable("select count(*) from sales");
            lblTodaySalesCount.Text = dt.Rows[0][0].ToString();

            dt = DBAccess.GetTable("select count(*) from products where stock <= 5");
            lblOutOfStockCount.Text = dt.Rows[0][0].ToString();

            dt = DBAccess.GetTable("select sum(totalAmount) from sales where date(transactionDate) = date('now') ");
            lblTodayRevenue.Text = dt.Rows[0][0].ToString() + " ₼";

            dt = DBAccess.GetTable("select sum(totalAmount) from sales ");
            lblTotalRevenue.Text = dt.Rows[0][0].ToString() + " ₼";



            dt = DBAccess.GetTable("select name as 'Məhsulun adı' , category 'Kateqoriya', stock 'Qalan Miqdar' from products where stock<=5");
            dgvCriticalStock.DataSource = dt;

            dt=DBAccess.GetTable("select id as 'Qəbz No', sellerId 'Satıcı No', transactionDate as 'Tarix/Saat', totalAmount 'Məbləğ (₼)'  from sales order by transactionDate limit 10");
            dgvRecentSales.DataSource = dt;





        }

        private void FormatTable()
        {
            //dgvCriticalStock.Columns["Qalan Miqdar"].Width = 200;
            dgvCriticalStock.Columns["Qalan Miqdar"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvRecentSales.Columns["Məbləğ (₼)"].DefaultCellStyle.Alignment= DataGridViewContentAlignment.MiddleRight;
        }
        private void dgvCriticalStock_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvCriticalStock.ClearSelection();
            dgvCriticalStock.CurrentCell = null;
        }
    }
}
