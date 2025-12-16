using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagementSystem
{
    public partial class MainForm : Form
    {


        private List<Button> menuButtons = new List<Button>();
        public MainForm()
        {
            InitializeComponent();

            menuButtons.Add(btnDashboard);
            menuButtons.Add(btnProducts);
            menuButtons.Add(btnSales);
            menuButtons.Add(btnUsers);
            menuButtons.Add(btnReports);
        }

        private void setActiveButton(Button button)
        {
            foreach (Button btn in menuButtons)
            {
                btn.BackColor = Color.FromArgb(60, 64, 91);
            }

            button.BackColor = Color.FromArgb(93, 95, 239);
        }

        private void ShowControl(UserControl userControl)
        {
            pnlContent.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(userControl);
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            DashboardControl dashboardControl = new DashboardControl();
            ShowControl(dashboardControl);
            setActiveButton(btnDashboard);
            timer1.Start();

            lblUserName.Text = UserSession.Username + " | " + UserSession.Role;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            DashboardControl dashboardControl = new DashboardControl();
            ShowControl(dashboardControl);
            setActiveButton(btnDashboard);

            lblPageTitle.Text = btnDashboard.Text;
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            SalesControl salesControl = new SalesControl();
            ShowControl(salesControl);
            setActiveButton(btnSales);
            lblPageTitle.Text = btnSales.Text;
        }
        private void btnExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            CultureInfo azCulture = new CultureInfo("az-Latn-AZ");
            lblCurrentDateTime.Text = azCulture.TextInfo.ToTitleCase(currentTime.ToString("dd MMMM yyyy | dddd | HH:mm:ss",azCulture));
        }
    }
}
