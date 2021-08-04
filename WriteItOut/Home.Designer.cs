
namespace WriteItOut
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.MinimizeBtn = new System.Windows.Forms.Button();
            this.JournalBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.searchEntriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChallengeBtn = new System.Windows.Forms.ToolStripButton();
            this.QuoteBtn = new System.Windows.Forms.ToolStripButton();
            this.logo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 721);
            this.panel1.TabIndex = 28;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(14, 675);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(190, 36);
            this.button3.TabIndex = 8;
            this.button3.Text = "Show Desktop";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.JournalBtn,
            this.ChallengeBtn,
            this.QuoteBtn});
            this.toolStrip1.Location = new System.Drawing.Point(215, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(910, 80);
            this.toolStrip1.TabIndex = 29;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // CloseBtn
            // 
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.Image = global::WriteItOut.Properties.Resources.Close_icon__2_;
            this.CloseBtn.Location = new System.Drawing.Point(1084, 13);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(28, 38);
            this.CloseBtn.TabIndex = 26;
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeBtn.Image = global::WriteItOut.Properties.Resources.minimize_icon3;
            this.MinimizeBtn.Location = new System.Drawing.Point(1054, 13);
            this.MinimizeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(28, 38);
            this.MinimizeBtn.TabIndex = 25;
            this.MinimizeBtn.UseVisualStyleBackColor = true;
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // JournalBtn
            // 
            this.JournalBtn.AutoSize = false;
            this.JournalBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchEntriesToolStripMenuItem});
            this.JournalBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.JournalBtn.Image = global::WriteItOut.Properties.Resources.penIcon;
            this.JournalBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.JournalBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.JournalBtn.Name = "JournalBtn";
            this.JournalBtn.Size = new System.Drawing.Size(130, 77);
            this.JournalBtn.Text = "My Journal";
            this.JournalBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.JournalBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.JournalBtn.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // searchEntriesToolStripMenuItem
            // 
            this.searchEntriesToolStripMenuItem.Name = "searchEntriesToolStripMenuItem";
            this.searchEntriesToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.searchEntriesToolStripMenuItem.Text = "Search Entries";
            // 
            // ChallengeBtn
            // 
            this.ChallengeBtn.AutoSize = false;
            this.ChallengeBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ChallengeBtn.Image = global::WriteItOut.Properties.Resources.ChallengesIcon;
            this.ChallengeBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ChallengeBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ChallengeBtn.Name = "ChallengeBtn";
            this.ChallengeBtn.Size = new System.Drawing.Size(130, 77);
            this.ChallengeBtn.Text = "My Challenges";
            this.ChallengeBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ChallengeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ChallengeBtn.Click += new System.EventHandler(this.ChallengeBtn_Click);
            // 
            // QuoteBtn
            // 
            this.QuoteBtn.AutoSize = false;
            this.QuoteBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.QuoteBtn.Image = global::WriteItOut.Properties.Resources.QuotesIcon;
            this.QuoteBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.QuoteBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.QuoteBtn.Name = "QuoteBtn";
            this.QuoteBtn.Size = new System.Drawing.Size(130, 77);
            this.QuoteBtn.Text = "Quote of The Day";
            this.QuoteBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.QuoteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.QuoteBtn.Click += new System.EventHandler(this.QuoteBtn_Click);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.Location = new System.Drawing.Point(4, 12);
            this.logo.Margin = new System.Windows.Forms.Padding(4);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(85, 79);
            this.logo.TabIndex = 27;
            this.logo.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(61)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(1125, 721);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.MinimizeBtn);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button MinimizeBtn;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton QuoteBtn;
        private System.Windows.Forms.ToolStripDropDownButton JournalBtn;
        private System.Windows.Forms.ToolStripMenuItem searchEntriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton ChallengeBtn;
    }
}