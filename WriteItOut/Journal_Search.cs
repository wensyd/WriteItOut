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
    public partial class Journal_Search : Form
    {
        public Journal_Search()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Journal_Search_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Journal_Entries' table. You can move, or remove it, as needed.
            this.journal_EntriesTableAdapter.Fill(this.dataSet1.Journal_Entries);
            
        }

  
        private void journal_EntriesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.journal_EntriesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }
    }
}
