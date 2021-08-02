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

            SqlConnection con = new SqlConnection(@"Data Source=
            DESKTOP-4S8A66J\SQLEXPRESS;Initial Catalog=Wlogin;Integrated Security=True");
            con.Open();
        }

        private void CreateNewAcctBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registration = new RegisterForm();
            registration.ShowDialog();
           
        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            if (PasswordTxtBox.Text != string.Empty || UsernameTxtBox.Text != string.Empty)
            {
                SqlCommand cmd = new SqlCommand();
                SqlConnection con = new SqlConnection(@"Data Source=
            DESKTOP-4S8A66J\SQLEXPRESS;Initial Catalog=Wlogin;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("select * from Login where username='" + UsernameTxtBox.Text + "' and password='" + PasswordTxtBox.Text + "'", con);
                SqlDataReader  dr= cmd.ExecuteReader();
                
                if (dr.Read())
                {
                    dr.Close();
                    this.Hide();
                    Home Home = new Home();
                    Home.ShowDialog();
                }

                else
                {
                    dr.Close();
                    MessageBox.Show("Account is not available with this username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            else
            {
                MessageBox.Show("Invalid Username or Password");
            }

        }
    }
}
    

