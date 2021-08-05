
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
            this.DesktopBtn = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.JournalBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.myJournalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchEntriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChallengeBtn = new System.Windows.Forms.ToolStripButton();
            this.QuoteBtn = new System.Windows.Forms.ToolStripButton();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.MinimizeBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.DesktopBtn);
            this.panel1.Controls.Add(this.logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 586);
            this.panel1.TabIndex = 28;
            // 
            // DesktopBtn
            // 
            this.DesktopBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DesktopBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DesktopBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DesktopBtn.Location = new System.Drawing.Point(3, 552);
            this.DesktopBtn.Name = "DesktopBtn";
            this.DesktopBtn.Size = new System.Drawing.Size(110, 29);
            this.DesktopBtn.TabIndex = 8;
            this.DesktopBtn.Text = "Show Desktop";
            this.DesktopBtn.UseVisualStyleBackColor = true;
            this.DesktopBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.Location = new System.Drawing.Point(3, 10);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(64, 64);
            this.logo.TabIndex = 27;
            this.logo.TabStop = false;
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
            this.toolStrip1.Location = new System.Drawing.Point(124, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(720, 65);
            this.toolStrip1.TabIndex = 29;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // JournalBtn
            // 
            this.JournalBtn.AutoSize = false;
            this.JournalBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myJournalToolStripMenuItem,
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
            // myJournalToolStripMenuItem
            // 
            this.myJournalToolStripMenuItem.Name = "myJournalToolStripMenuItem";
            this.myJournalToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.myJournalToolStripMenuItem.Text = "My Journal";
            this.myJournalToolStripMenuItem.Click += new System.EventHandler(this.myJournalToolStripMenuItem_Click);
            // 
            // searchEntriesToolStripMenuItem
            // 
            this.searchEntriesToolStripMenuItem.Name = "searchEntriesToolStripMenuItem";
            this.searchEntriesToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.searchEntriesToolStripMenuItem.Text = "Search Entries";
            this.searchEntriesToolStripMenuItem.Click += new System.EventHandler(this.searchEntriesToolStripMenuItem_Click);
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
            // CloseBtn
            // 
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.Image = global::WriteItOut.Properties.Resources.Close_icon__2_;
            this.CloseBtn.Location = new System.Drawing.Point(813, 11);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(21, 31);
            this.CloseBtn.TabIndex = 26;
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeBtn.Image = global::WriteItOut.Properties.Resources.minimize_icon3;
            this.MinimizeBtn.Location = new System.Drawing.Point(790, 11);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(21, 31);
            this.MinimizeBtn.TabIndex = 25;
            this.MinimizeBtn.UseVisualStyleBackColor = true;
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(61)))), ((int)(((byte)(96)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(844, 586);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.MinimizeBtn);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button MinimizeBtn;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button DesktopBtn;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton QuoteBtn;
        private System.Windows.Forms.ToolStripDropDownButton JournalBtn;
        private System.Windows.Forms.ToolStripMenuItem searchEntriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton ChallengeBtn;
        private System.Windows.Forms.ToolStripMenuItem myJournalToolStripMenuItem;
    }
}