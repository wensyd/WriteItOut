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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void QuoteBtn_Click(object sender, EventArgs e)
        {
            Quotes quotes = new Quotes();
            quotes.ShowDialog();
            this.Close();
        }

        private void ChallengeBtn_Click(object sender, EventArgs e)
        {
            Challenges challenges = new Challenges();
            challenges.ShowDialog();
            this.Close();
        }

        private void myJournalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Journal journal = new Journal();
            journal.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void searchEntriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Journal_Search journal_Search = new Journal_Search();
            journal_Search.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
