﻿
namespace WriteItOut
{
    partial class Journal_Search
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CloseBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.IdTxtBox = new System.Windows.Forms.TextBox();
            this.IdLbl = new System.Windows.Forms.Label();
            this.DateTxtBox = new System.Windows.Forms.TextBox();
            this.DateLbl = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.TitleTxtBox = new System.Windows.Forms.TextBox();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.FontBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ForeColorBtn = new System.Windows.Forms.ToolStripButton();
            this.BackColorBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.leftAlignBtn = new System.Windows.Forms.ToolStripButton();
            this.CenterAlignBtn = new System.Windows.Forms.ToolStripButton();
            this.RightAlignBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.decreaseIndentBtn = new System.Windows.Forms.ToolStripButton();
            this.IncreaseIndentBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.copyBtn = new System.Windows.Forms.ToolStripButton();
            this.pasteBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.undoBtn = new System.Windows.Forms.ToolStripButton();
            this.redoBtn = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.IdSearchLbl = new System.Windows.Forms.Label();
            this.IdSearchTxtBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.White;
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.Image = global::WriteItOut.Properties.Resources.Close_icon__2_;
            this.CloseBtn.Location = new System.Drawing.Point(721, 11);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(21, 31);
            this.CloseBtn.TabIndex = 28;
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.IdTxtBox);
            this.groupBox1.Controls.Add(this.IdLbl);
            this.groupBox1.Controls.Add(this.DateTxtBox);
            this.groupBox1.Controls.Add(this.DateLbl);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.TitleTxtBox);
            this.groupBox1.Controls.Add(this.TitleLbl);
            this.groupBox1.Controls.Add(this.toolStrip1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(205, 54);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(537, 481);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Journal Details";
            // 
            // IdTxtBox
            // 
            this.IdTxtBox.Location = new System.Drawing.Point(107, 25);
            this.IdTxtBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IdTxtBox.Name = "IdTxtBox";
            this.IdTxtBox.ReadOnly = true;
            this.IdTxtBox.Size = new System.Drawing.Size(60, 20);
            this.IdTxtBox.TabIndex = 6;
            // 
            // IdLbl
            // 
            this.IdLbl.AutoSize = true;
            this.IdLbl.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLbl.Location = new System.Drawing.Point(46, 25);
            this.IdLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IdLbl.Name = "IdLbl";
            this.IdLbl.Size = new System.Drawing.Size(54, 15);
            this.IdLbl.TabIndex = 5;
            this.IdLbl.Text = "Entry ID:";
            // 
            // DateTxtBox
            // 
            this.DateTxtBox.Location = new System.Drawing.Point(107, 71);
            this.DateTxtBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DateTxtBox.Name = "DateTxtBox";
            this.DateTxtBox.ReadOnly = true;
            this.DateTxtBox.Size = new System.Drawing.Size(378, 20);
            this.DateTxtBox.TabIndex = 4;
            // 
            // DateLbl
            // 
            this.DateLbl.AutoSize = true;
            this.DateLbl.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLbl.Location = new System.Drawing.Point(36, 71);
            this.DateLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(64, 15);
            this.DateLbl.TabIndex = 3;
            this.DateLbl.Text = "Entry Date:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.richTextBox1.Location = new System.Drawing.Point(7, 127);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(516, 340);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // TitleTxtBox
            // 
            this.TitleTxtBox.Location = new System.Drawing.Point(107, 48);
            this.TitleTxtBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TitleTxtBox.Name = "TitleTxtBox";
            this.TitleTxtBox.ReadOnly = true;
            this.TitleTxtBox.Size = new System.Drawing.Size(378, 20);
            this.TitleTxtBox.TabIndex = 2;
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.Location = new System.Drawing.Point(39, 48);
            this.TitleLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(64, 15);
            this.TitleLbl.TabIndex = 1;
            this.TitleLbl.Text = "Entry Title:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Lavender;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FontBtn,
            this.toolStripSeparator3,
            this.ForeColorBtn,
            this.BackColorBtn,
            this.toolStripSeparator2,
            this.leftAlignBtn,
            this.CenterAlignBtn,
            this.RightAlignBtn,
            this.toolStripSeparator1,
            this.decreaseIndentBtn,
            this.IncreaseIndentBtn,
            this.toolStripSeparator4,
            this.copyBtn,
            this.pasteBtn,
            this.toolStripSeparator5,
            this.undoBtn,
            this.redoBtn});
            this.toolStrip1.Location = new System.Drawing.Point(5, 103);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(512, 28);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Visible = false;
            // 
            // FontBtn
            // 
            this.FontBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FontBtn.Image = global::WriteItOut.Properties.Resources.fontIcon;
            this.FontBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.FontBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FontBtn.Name = "FontBtn";
            this.FontBtn.Size = new System.Drawing.Size(23, 25);
            this.FontBtn.Text = "toolStripButton1";
            this.FontBtn.ToolTipText = "Font";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 28);
            // 
            // ForeColorBtn
            // 
            this.ForeColorBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ForeColorBtn.Image = global::WriteItOut.Properties.Resources.textColorIcon;
            this.ForeColorBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ForeColorBtn.Name = "ForeColorBtn";
            this.ForeColorBtn.Size = new System.Drawing.Size(24, 25);
            this.ForeColorBtn.Text = "toolStripButton2";
            this.ForeColorBtn.ToolTipText = "Fore Color";
            // 
            // BackColorBtn
            // 
            this.BackColorBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BackColorBtn.Image = global::WriteItOut.Properties.Resources.backColorIcon;
            this.BackColorBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BackColorBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BackColorBtn.Name = "BackColorBtn";
            this.BackColorBtn.Size = new System.Drawing.Size(23, 25);
            this.BackColorBtn.Text = "toolStripButton1";
            this.BackColorBtn.ToolTipText = "Text Back Color";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // leftAlignBtn
            // 
            this.leftAlignBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.leftAlignBtn.Image = global::WriteItOut.Properties.Resources.text_align_left_icon;
            this.leftAlignBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.leftAlignBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.leftAlignBtn.Name = "leftAlignBtn";
            this.leftAlignBtn.Size = new System.Drawing.Size(23, 25);
            this.leftAlignBtn.Text = "toolStripButton1";
            this.leftAlignBtn.ToolTipText = "Left Align";
            // 
            // CenterAlignBtn
            // 
            this.CenterAlignBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CenterAlignBtn.Image = global::WriteItOut.Properties.Resources.text_align_center_icon;
            this.CenterAlignBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CenterAlignBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CenterAlignBtn.Name = "CenterAlignBtn";
            this.CenterAlignBtn.Size = new System.Drawing.Size(23, 25);
            this.CenterAlignBtn.Text = "toolStripButton2";
            this.CenterAlignBtn.ToolTipText = "Center Align";
            // 
            // RightAlignBtn
            // 
            this.RightAlignBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RightAlignBtn.Image = global::WriteItOut.Properties.Resources.text_align_right_icon;
            this.RightAlignBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RightAlignBtn.Name = "RightAlignBtn";
            this.RightAlignBtn.Size = new System.Drawing.Size(24, 25);
            this.RightAlignBtn.Text = "toolStripButton3";
            this.RightAlignBtn.ToolTipText = "Right Align";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // decreaseIndentBtn
            // 
            this.decreaseIndentBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.decreaseIndentBtn.Image = global::WriteItOut.Properties.Resources.indent_decrease_16_icon;
            this.decreaseIndentBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.decreaseIndentBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.decreaseIndentBtn.Name = "decreaseIndentBtn";
            this.decreaseIndentBtn.Size = new System.Drawing.Size(23, 25);
            this.decreaseIndentBtn.Text = "toolStripButton4";
            this.decreaseIndentBtn.ToolTipText = "Decrease Indent";
            // 
            // IncreaseIndentBtn
            // 
            this.IncreaseIndentBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.IncreaseIndentBtn.Image = global::WriteItOut.Properties.Resources.indent_increase_16_Icon;
            this.IncreaseIndentBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.IncreaseIndentBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.IncreaseIndentBtn.Name = "IncreaseIndentBtn";
            this.IncreaseIndentBtn.Size = new System.Drawing.Size(23, 25);
            this.IncreaseIndentBtn.Text = "toolStripButton5";
            this.IncreaseIndentBtn.ToolTipText = "Increase Indent";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 28);
            // 
            // copyBtn
            // 
            this.copyBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyBtn.Image = global::WriteItOut.Properties.Resources.ic_content_copy_48px_Icon_16;
            this.copyBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.copyBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.Size = new System.Drawing.Size(23, 25);
            this.copyBtn.Text = "toolStripButton1";
            this.copyBtn.ToolTipText = "Copy";
            // 
            // pasteBtn
            // 
            this.pasteBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteBtn.Image = global::WriteItOut.Properties.Resources.pasteIcon;
            this.pasteBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pasteBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteBtn.Name = "pasteBtn";
            this.pasteBtn.Size = new System.Drawing.Size(23, 25);
            this.pasteBtn.Text = "toolStripButton1";
            this.pasteBtn.ToolTipText = "Paste";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 28);
            // 
            // undoBtn
            // 
            this.undoBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.undoBtn.Image = global::WriteItOut.Properties.Resources.Undo_icon;
            this.undoBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.undoBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.undoBtn.Name = "undoBtn";
            this.undoBtn.Size = new System.Drawing.Size(23, 25);
            this.undoBtn.Text = "toolStripButton1";
            this.undoBtn.ToolTipText = "Undo";
            // 
            // redoBtn
            // 
            this.redoBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.redoBtn.Image = global::WriteItOut.Properties.Resources.Redo_Icon;
            this.redoBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.redoBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.redoBtn.Name = "redoBtn";
            this.redoBtn.Size = new System.Drawing.Size(23, 25);
            this.redoBtn.Text = "toolStripButton1";
            this.redoBtn.ToolTipText = "Redo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SearchBtn);
            this.groupBox2.Controls.Add(this.IdSearchLbl);
            this.groupBox2.Controls.Add(this.IdSearchTxtBox);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(10, 46);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(182, 489);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(118, 107);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(54, 19);
            this.SearchBtn.TabIndex = 3;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // IdSearchLbl
            // 
            this.IdSearchLbl.AutoSize = true;
            this.IdSearchLbl.Location = new System.Drawing.Point(2, 111);
            this.IdSearchLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IdSearchLbl.Name = "IdSearchLbl";
            this.IdSearchLbl.Size = new System.Drawing.Size(58, 13);
            this.IdSearchLbl.TabIndex = 2;
            this.IdSearchLbl.Text = "Journal ID:";
            // 
            // IdSearchTxtBox
            // 
            this.IdSearchTxtBox.Location = new System.Drawing.Point(64, 107);
            this.IdSearchTxtBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IdSearchTxtBox.Name = "IdSearchTxtBox";
            this.IdSearchTxtBox.Size = new System.Drawing.Size(50, 20);
            this.IdSearchTxtBox.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(4, 135);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(168, 342);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Journal_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(764, 558);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CloseBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Journal_Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Journal_Search";
            this.Load += new System.EventHandler(this.Journal_Search_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox IdTxtBox;
        private System.Windows.Forms.Label IdLbl;
        private System.Windows.Forms.TextBox DateTxtBox;
        private System.Windows.Forms.Label DateLbl;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox TitleTxtBox;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton FontBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton ForeColorBtn;
        private System.Windows.Forms.ToolStripButton BackColorBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton leftAlignBtn;
        private System.Windows.Forms.ToolStripButton CenterAlignBtn;
        private System.Windows.Forms.ToolStripButton RightAlignBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton decreaseIndentBtn;
        private System.Windows.Forms.ToolStripButton IncreaseIndentBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton copyBtn;
        private System.Windows.Forms.ToolStripButton pasteBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton undoBtn;
        private System.Windows.Forms.ToolStripButton redoBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label IdSearchLbl;
        private System.Windows.Forms.TextBox IdSearchTxtBox;
        private System.Windows.Forms.ListBox listBox1;
    }
}