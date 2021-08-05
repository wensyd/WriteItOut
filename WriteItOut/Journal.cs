﻿using System;
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
    }
}
