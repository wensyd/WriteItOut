
namespace WriteItOut
{
    partial class Challenges
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Challenges));
            this.CloseBtn = new System.Windows.Forms.Button();
            this.QuotesPanel = new System.Windows.Forms.Panel();
            this.ChallengeBtn = new System.Windows.Forms.Button();
            this.ChallengeLbl = new System.Windows.Forms.Label();
            this.QuotesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.White;
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.Image = global::WriteItOut.Properties.Resources.Close_icon__2_;
            this.CloseBtn.Location = new System.Drawing.Point(532, 16);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(21, 31);
            this.CloseBtn.TabIndex = 29;
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // QuotesPanel
            // 
            this.QuotesPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.QuotesPanel.Controls.Add(this.ChallengeBtn);
            this.QuotesPanel.Controls.Add(this.ChallengeLbl);
            this.QuotesPanel.Location = new System.Drawing.Point(74, 72);
            this.QuotesPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.QuotesPanel.Name = "QuotesPanel";
            this.QuotesPanel.Size = new System.Drawing.Size(405, 388);
            this.QuotesPanel.TabIndex = 28;
            // 
            // ChallengeBtn
            // 
            this.ChallengeBtn.BackColor = System.Drawing.Color.White;
            this.ChallengeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChallengeBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChallengeBtn.Location = new System.Drawing.Point(98, 329);
            this.ChallengeBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChallengeBtn.Name = "ChallengeBtn";
            this.ChallengeBtn.Size = new System.Drawing.Size(209, 31);
            this.ChallengeBtn.TabIndex = 1;
            this.ChallengeBtn.Text = "My Challenges";
            this.ChallengeBtn.UseVisualStyleBackColor = false;
            this.ChallengeBtn.Click += new System.EventHandler(this.ChallengeBtn_Click);
            // 
            // ChallengeLbl
            // 
            this.ChallengeLbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ChallengeLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ChallengeLbl.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChallengeLbl.ForeColor = System.Drawing.Color.Black;
            this.ChallengeLbl.Location = new System.Drawing.Point(20, 20);
            this.ChallengeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ChallengeLbl.Name = "ChallengeLbl";
            this.ChallengeLbl.Size = new System.Drawing.Size(367, 298);
            this.ChallengeLbl.TabIndex = 0;
            this.ChallengeLbl.Text = "Daily Challenge:";
            // 
            // Challenges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(563, 521);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.QuotesPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Challenges";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Challenges";
            this.Load += new System.EventHandler(this.Challenges_Load);
            this.QuotesPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Panel QuotesPanel;
        private System.Windows.Forms.Button ChallengeBtn;
        private System.Windows.Forms.Label ChallengeLbl;
    }
}