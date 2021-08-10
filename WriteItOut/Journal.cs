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
            // TODO: This line of code loads data into the 'dataSet1.Journal_Entries' table. You can move, or remove it, as needed.
            this.journal_EntriesTableAdapter.Fill(this.dataSet1.Journal_Entries);
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
            this.entry_RichTextBox.SelectionFont = this.fontDialog1.Font;
        }

        private void ForeColorBtn_Click(object sender, EventArgs e)
        {
            this.colorDialog1.ShowDialog();
            this.entry_RichTextBox.SelectionColor = this.colorDialog1.Color;
        }

        private void BackColorBtn_Click(object sender, EventArgs e)
        {
            this.colorDialog1.ShowDialog();
            this.entry_RichTextBox.SelectionBackColor = this.colorDialog1.Color;
        }

        private void leftAlignBtn_Click(object sender, EventArgs e)
        {
            this.entry_RichTextBox.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void CenterAlignBtn_Click(object sender, EventArgs e)
        {
            this.entry_RichTextBox.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void RightAlignBtn_Click(object sender, EventArgs e)
        {
            this.entry_RichTextBox.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void decreaseIndentBtn_Click(object sender, EventArgs e)
        {
            Int32 i;
            i = this.entry_RichTextBox.SelectionIndent;
            i = i - 10;
            this.entry_RichTextBox.SelectionIndent = i;
        }

        private void IncreaseIndentBtn_Click(object sender, EventArgs e)
        {
            Int32 i;
            i = this.entry_RichTextBox.SelectionIndent;
            i = i + 10;
            this.entry_RichTextBox.SelectionIndent = i;
        }

        private void copyBtn_Click(object sender, EventArgs e)
        {
            this.entry_RichTextBox.Copy();
        }

        private void pasteBtn_Click(object sender, EventArgs e)
        {
            this.entry_RichTextBox.Paste();
        }

        private void undoBtn_Click(object sender, EventArgs e)
        {
            this.entry_RichTextBox.Undo();
        }

        private void redoBtn_Click(object sender, EventArgs e)
        {
            this.entry_RichTextBox.Redo();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            WriteItOut.Properties.Settings.Default.last_journal_id = 0;
            WriteItOut.Properties.Settings.Default.Save();
        }

        private void journal_EntriesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.groupBox1.Enabled = false;
            this.SaveBtn.Enabled = false;
            this.NewEntryBtn.Enabled = true;

            this.Validate();
            this.journal_EntriesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);
            MessageBox.Show("Your Entry is saved!");
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.groupBox1.Enabled = true;
            this.NewEntryBtn.Enabled = false;
            this.SaveBtn.Enabled = true;



            this.entry_Title_TextBox.Text = "";
            this.entry_Date_DateTimePicker.ResetText();
            this.entry_RichTextBox.Text = "";
        }

        private void CloseBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Home home = new Home();
            home.ShowDialog();
        }
    }
}
