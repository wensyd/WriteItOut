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
    public partial class Journal : Form
    {
        public Journal()
        {
            InitializeComponent();
        }

        private void Journal_Load(object sender, EventArgs e)
        {
            this.groupBox1.Enabled = false;
            this.SaveBtn.Enabled = false;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.ShowDialog();
            this.Close();
        }

        private void FontBtn_Click(object sender, EventArgs e)
        {
            this.fontDialog1.ShowDialog();
            this.richTextBox1.SelectionFont = this.fontDialog1.Font;
        }

        private void ForeColorBtn_Click(object sender, EventArgs e)
        {
            this.colorDialog1.ShowDialog();
            this.richTextBox1.SelectionColor = this.colorDialog1.Color;
        }

        private void BackColorBtn_Click(object sender, EventArgs e)
        {
            this.colorDialog1.ShowDialog();
            this.richTextBox1.SelectionBackColor = this.colorDialog1.Color;
        }

        private void leftAlignBtn_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void CenterAlignBtn_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void RightAlignBtn_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void decreaseIndentBtn_Click(object sender, EventArgs e)
        {
            Int32 i;
            i = this.richTextBox1.SelectionIndent;
            i = i - 10;
            this.richTextBox1.SelectionIndent = i;
        }

        private void IncreaseIndentBtn_Click(object sender, EventArgs e)
        {
            Int32 i;
            i = this.richTextBox1.SelectionIndent;
            i = i + 10;
            this.richTextBox1.SelectionIndent = i;
        }

        private void copyBtn_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Copy();
        }

        private void pasteBtn_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Paste();
        }

        private void undoBtn_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Undo();
        }

        private void redoBtn_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Redo();
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            this.groupBox1.Enabled = true;
            this.NewBtn.Enabled = false;
            this.SaveBtn.Enabled = true;

            //--------------------------------

            Int32 i;
            i = WriteItOut.Properties.Settings.Default.last_journal_id + 0;
            this.IdTxtBox.Text = i.ToString();

            //---------------------------------

            this.TitleTxtBox.Text = "";
            this.DateTxtBox.ResetText();
            this.richTextBox1.Text = ""; 
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            this.groupBox1.Enabled = false;
            this.SaveBtn.Enabled = false;
            this.NewBtn.Enabled = true;

            //---------------------------------
            Int32 last_id;
            last_id = WriteItOut.Properties.Settings.Default.last_journal_id;
            last_id = last_id + 1;
            //--------------------------------
            WriteItOut.Properties.Settings.Default.last_journal_id = last_id;
            WriteItOut.Properties.Settings.Default.Save();
            //---------------------------------
            string fn;
            string fn_title;
            string fn_date;
            fn = Application.StartupPath + "\\data\\docs\\" + last_id.ToString() + ".rtf";
            fn_title = Application.StartupPath + "\\data\\docs\\title_" + last_id.ToString() + ".txt";
            fn_date = Application.StartupPath + "\\data\\docs\\date_" + last_id.ToString() + ".txt";
            //-----------------------------------
            System.IO.File.WriteAllText(fn_title, this.TitleTxtBox.Text, Encoding.UTF8);
            System.IO.File.WriteAllText(fn_date, this.DateTxtBox.Text, Encoding.UTF8);



            //------------------------------------
            this.richTextBox1.SaveFile(fn);
            MessageBox.Show("Your entry is saved!");
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            WriteItOut.Properties.Settings.Default.last_journal_id = 0;
            WriteItOut.Properties.Settings.Default.Save();
        }
    }
}
