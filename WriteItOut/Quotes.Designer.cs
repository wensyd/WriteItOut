
namespace WriteItOut
{
    partial class Quotes
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
            this.QuotesPanel = new System.Windows.Forms.Panel();
            this.QuoteBtn = new System.Windows.Forms.Button();
            this.QuoteLbl = new System.Windows.Forms.Label();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.QuotesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // QuotesPanel
            // 
            this.QuotesPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.QuotesPanel.Controls.Add(this.QuoteBtn);
            this.QuotesPanel.Controls.Add(this.QuoteLbl);
            this.QuotesPanel.Location = new System.Drawing.Point(100, 82);
            this.QuotesPanel.Name = "QuotesPanel";
            this.QuotesPanel.Size = new System.Drawing.Size(539, 477);
            this.QuotesPanel.TabIndex = 0;
            // 
            // QuoteBtn
            // 
            this.QuoteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.QuoteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QuoteBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuoteBtn.Location = new System.Drawing.Point(130, 405);
            this.QuoteBtn.Name = "QuoteBtn";
            this.QuoteBtn.Size = new System.Drawing.Size(279, 38);
            this.QuoteBtn.TabIndex = 1;
            this.QuoteBtn.Text = "Quote of the Day";
            this.QuoteBtn.UseVisualStyleBackColor = false;
            this.QuoteBtn.Click += new System.EventHandler(this.QuoteBtn_Click);
            // 
            // QuoteLbl
            // 
            this.QuoteLbl.BackColor = System.Drawing.Color.White;
            this.QuoteLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.QuoteLbl.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuoteLbl.Location = new System.Drawing.Point(26, 24);
            this.QuoteLbl.Name = "QuoteLbl";
            this.QuoteLbl.Size = new System.Drawing.Size(489, 367);
            this.QuoteLbl.TabIndex = 0;
            this.QuoteLbl.Text = "Quote:";
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.White;
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.Image = global::WriteItOut.Properties.Resources.Close_icon__2_;
            this.CloseBtn.Location = new System.Drawing.Point(710, 13);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(28, 38);
            this.CloseBtn.TabIndex = 27;
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // Quotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(751, 641);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.QuotesPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Quotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quotes";
            this.Load += new System.EventHandler(this.Quotes_Load);
            this.QuotesPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel QuotesPanel;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label QuoteLbl;
        private System.Windows.Forms.Button QuoteBtn;
    }
}