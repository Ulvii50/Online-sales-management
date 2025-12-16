using System.Data;

namespace SalesManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if(username == "" ||  password == "")
            {
                MessageBox.Show("Zəhmət olmasa həm istifadəçi adını, həm də şifrəni daxil edin!",
                        "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (username == "") txtUsername.Focus();
                else txtPassword.Focus();

                return;
            }
            string query = $"Select * FROM USERS WHERE Username = '{username}' AND Password = '{password}'";
            DataTable dt = DBAccess.GetTable(query);

            if(dt != null && dt.Rows.Count >0)
            {
                UserSession.Username = dt.Rows[0]["Username"].ToString();
                UserSession.Id = Convert.ToInt32(dt.Rows[0]["Id"]);
                UserSession.Role = dt.Rows[0]["Role"].ToString();

                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("İstifadəçi adı və ya şifrə yanlışdır!", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
