using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WriteItOut
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You are about to exit", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit(); //is the code for the entire app to be closed, when a user doesn't login successfully

                //this.Close();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void CreateNewAcctBtn_Click(object sender, EventArgs e)
        {
            RegisterForm registration = new RegisterForm();
            registration.ShowDialog();
            Visible = false;
        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-4S8A66J\SQLEXPRESS;Initial Catalog=Wlogin;Integrated Security=True");
            SqlConnection con = sqlConnection;
            SqlCommand cmd = new SqlCommand("select * from login where username='"+UsernameTxtBox.Text+"' and password='"+PasswordTxtBox.Text+"'", con);
            SqlDataAdapter sqlData = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqlData.Fill(dt);
            if(dt.Rows.Count == 1)
            {
                Home Home = new Home();

                this.Hide();

                Home.Show();


            }

        }
    }
}
