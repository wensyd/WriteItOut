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
    public partial class Challenges : Form
    {
        public Challenges()
        {
            InitializeComponent();
        }

        private void Challenges_Load(object sender, EventArgs e)
        {

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.ShowDialog();
            this.Close();
        }

        private void ChallengeBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
