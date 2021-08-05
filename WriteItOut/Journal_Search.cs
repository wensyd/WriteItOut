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
            try
            {
                Int32 ic;
                ic = WriteItOut.Properties.Settings.Default.last_journal_id;

                Int32 i;
                for (i = 1; i < ic; i++)
                {
                    this.listBox1.Items.Add(i.ToString());
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error; " + ex.ToString());
            }
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //---------------------------------
                string fn;
                string fn_title;
                string fn_date;
                Int32 last_id;
                Int32.TryParse(this.listBox1.Text, out last_id);

                fn = Application.StartupPath + "\\data\\docs\\" + last_id.ToString() + ".rtf";
                fn_title = Application.StartupPath + "\\data\\docs\\title_" + last_id.ToString() + ".txt";
                fn_date = Application.StartupPath + "\\data\\docs\\date_" + last_id.ToString() + ".txt";
                //-----------------------------------

                this.richTextBox1.LoadFile(fn);
                this.TitleTxtBox.Text = System.IO.File.ReadAllText(fn_title, Encoding.UTF8);
                this.DateTxtBox.Text = System.IO.File.ReadAllText(fn_date, Encoding.UTF8);
                this.IdTxtBox.Text = last_id.ToString();

                //-----------------------------------
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error; " + ex.ToString());
            }
            
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 i;
                i = this.listBox1.FindStringExact(this.IdSearchTxtBox.Text);
                this.listBox1.SelectedIndex = i;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error; " + ex.ToString());
            }
           
        }
    }
}
