using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WriteItOut
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4S8A66J\SQLEXPRESS;Initial Catalog=Wlogin;Integrated Security=True");
                con.Open();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error; " + ex.ToString());
            }
            
        }

        private void CreateNewAcctBtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (ConfirmTxtBox.Text != string.Empty || PasswordField.Text != string.Empty || UsernameField.Text != string.Empty)
                {
                    if (PasswordField.Text == ConfirmTxtBox.Text)
                    {
                        SqlConnection con = new SqlConnection(@"Data Source=
                        DESKTOP-4S8A66J\SQLEXPRESS;Initial Catalog=Wlogin;Integrated Security=True");
                        con.Open();
                        SqlCommand cmd = new SqlCommand("select * from Login where username='" + UsernameField.Text + "'", con);
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            dr.Close();
                            MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            dr.Close();
                            cmd = new SqlCommand("insert into Login values(@username,@password)", con);
                            cmd.Parameters.AddWithValue("username", UsernameField.Text);
                            cmd.Parameters.AddWithValue("password", PasswordField.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Your Account is created! Please login", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Passwords must match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }



                else
                {
                    MessageBox.Show("Please enter value in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error; " + ex.ToString());
            }




            
        }

        private void LogInLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.ShowDialog();
        }
    }
    }

        
      
       
    

