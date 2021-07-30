using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
