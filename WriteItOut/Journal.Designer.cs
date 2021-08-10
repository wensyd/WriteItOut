
namespace WriteItOut
{
    partial class Journal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Journal));
            System.Windows.Forms.Label entry_Id_Label;
            System.Windows.Forms.Label entry_Title_Label;
            System.Windows.Forms.Label entry_Date_Label;
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.journal_EntriesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.NewEntryBtn = new System.Windows.Forms.ToolStripButton();
            this.DeleteBtn = new System.Windows.Forms.ToolStripButton();
            this.SaveBtn = new System.Windows.Forms.ToolStripButton();
            this.entry_Id_TextBox = new System.Windows.Forms.TextBox();
            this.entry_Title_TextBox = new System.Windows.Forms.TextBox();
            this.entry_Date_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.entry_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.journal_EntriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new WriteItOut.Dataset.DataSet1();
            this.journal_EntriesTableAdapter = new WriteItOut.Dataset.DataSet1TableAdapters.Journal_EntriesTableAdapter();
            this.tableAdapterManager = new WriteItOut.Dataset.DataSet1TableAdapters.TableAdapterManager();
            entry_Id_Label = new System.Windows.Forms.Label();
            entry_Title_Label = new System.Windows.Forms.Label();
            entry_Date_Label = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.journal_EntriesBindingNavigator)).BeginInit();
            this.journal_EntriesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.journal_EntriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
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
            this.toolStrip1.Location = new System.Drawing.Point(13, 157);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(683, 34);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // FontBtn
            // 
            this.FontBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FontBtn.Image = global::WriteItOut.Properties.Resources.fontIcon;
            this.FontBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.FontBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FontBtn.Name = "FontBtn";
            this.FontBtn.Size = new System.Drawing.Size(29, 31);
            this.FontBtn.Text = "toolStripButton1";
            this.FontBtn.ToolTipText = "Font";
            this.FontBtn.Click += new System.EventHandler(this.FontBtn_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 34);
            // 
            // ForeColorBtn
            // 
            this.ForeColorBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ForeColorBtn.Image = global::WriteItOut.Properties.Resources.textColorIcon;
            this.ForeColorBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ForeColorBtn.Name = "ForeColorBtn";
            this.ForeColorBtn.Size = new System.Drawing.Size(29, 31);
            this.ForeColorBtn.Text = "toolStripButton2";
            this.ForeColorBtn.ToolTipText = "Fore Color";
            this.ForeColorBtn.Click += new System.EventHandler(this.ForeColorBtn_Click);
            // 
            // BackColorBtn
            // 
            this.BackColorBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BackColorBtn.Image = global::WriteItOut.Properties.Resources.backColorIcon;
            this.BackColorBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BackColorBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BackColorBtn.Name = "BackColorBtn";
            this.BackColorBtn.Size = new System.Drawing.Size(29, 31);
            this.BackColorBtn.Text = "toolStripButton1";
            this.BackColorBtn.ToolTipText = "Text Back Color";
            this.BackColorBtn.Click += new System.EventHandler(this.BackColorBtn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 34);
            // 
            // leftAlignBtn
            // 
            this.leftAlignBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.leftAlignBtn.Image = global::WriteItOut.Properties.Resources.text_align_left_icon;
            this.leftAlignBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.leftAlignBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.leftAlignBtn.Name = "leftAlignBtn";
            this.leftAlignBtn.Size = new System.Drawing.Size(29, 31);
            this.leftAlignBtn.Text = "toolStripButton1";
            this.leftAlignBtn.ToolTipText = "Left Align";
            this.leftAlignBtn.Click += new System.EventHandler(this.leftAlignBtn_Click);
            // 
            // CenterAlignBtn
            // 
            this.CenterAlignBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CenterAlignBtn.Image = global::WriteItOut.Properties.Resources.text_align_center_icon;
            this.CenterAlignBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CenterAlignBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CenterAlignBtn.Name = "CenterAlignBtn";
            this.CenterAlignBtn.Size = new System.Drawing.Size(29, 31);
            this.CenterAlignBtn.Text = "toolStripButton2";
            this.CenterAlignBtn.ToolTipText = "Center Align";
            this.CenterAlignBtn.Click += new System.EventHandler(this.CenterAlignBtn_Click);
            // 
            // RightAlignBtn
            // 
            this.RightAlignBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RightAlignBtn.Image = global::WriteItOut.Properties.Resources.text_align_right_icon;
            this.RightAlignBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RightAlignBtn.Name = "RightAlignBtn";
            this.RightAlignBtn.Size = new System.Drawing.Size(29, 31);
            this.RightAlignBtn.Text = "toolStripButton3";
            this.RightAlignBtn.ToolTipText = "Right Align";
            this.RightAlignBtn.Click += new System.EventHandler(this.RightAlignBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // decreaseIndentBtn
            // 
            this.decreaseIndentBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.decreaseIndentBtn.Image = global::WriteItOut.Properties.Resources.indent_decrease_16_icon;
            this.decreaseIndentBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.decreaseIndentBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.decreaseIndentBtn.Name = "decreaseIndentBtn";
            this.decreaseIndentBtn.Size = new System.Drawing.Size(29, 31);
            this.decreaseIndentBtn.Text = "toolStripButton4";
            this.decreaseIndentBtn.ToolTipText = "Decrease Indent";
            this.decreaseIndentBtn.Click += new System.EventHandler(this.decreaseIndentBtn_Click);
            // 
            // IncreaseIndentBtn
            // 
            this.IncreaseIndentBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.IncreaseIndentBtn.Image = global::WriteItOut.Properties.Resources.indent_increase_16_Icon;
            this.IncreaseIndentBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.IncreaseIndentBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.IncreaseIndentBtn.Name = "IncreaseIndentBtn";
            this.IncreaseIndentBtn.Size = new System.Drawing.Size(29, 31);
            this.IncreaseIndentBtn.Text = "toolStripButton5";
            this.IncreaseIndentBtn.ToolTipText = "Increase Indent";
            this.IncreaseIndentBtn.Click += new System.EventHandler(this.IncreaseIndentBtn_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 34);
            // 
            // copyBtn
            // 
            this.copyBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyBtn.Image = global::WriteItOut.Properties.Resources.ic_content_copy_48px_Icon_16;
            this.copyBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.copyBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.Size = new System.Drawing.Size(29, 31);
            this.copyBtn.Text = "toolStripButton1";
            this.copyBtn.ToolTipText = "Copy";
            this.copyBtn.Click += new System.EventHandler(this.copyBtn_Click);
            // 
            // pasteBtn
            // 
            this.pasteBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteBtn.Image = global::WriteItOut.Properties.Resources.pasteIcon;
            this.pasteBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pasteBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteBtn.Name = "pasteBtn";
            this.pasteBtn.Size = new System.Drawing.Size(29, 31);
            this.pasteBtn.Text = "toolStripButton1";
            this.pasteBtn.ToolTipText = "Paste";
            this.pasteBtn.Click += new System.EventHandler(this.pasteBtn_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 34);
            // 
            // undoBtn
            // 
            this.undoBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.undoBtn.Image = global::WriteItOut.Properties.Resources.Undo_icon;
            this.undoBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.undoBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.undoBtn.Name = "undoBtn";
            this.undoBtn.Size = new System.Drawing.Size(29, 31);
            this.undoBtn.Text = "toolStripButton1";
            this.undoBtn.ToolTipText = "Undo";
            this.undoBtn.Click += new System.EventHandler(this.undoBtn_Click);
            // 
            // redoBtn
            // 
            this.redoBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.redoBtn.Image = global::WriteItOut.Properties.Resources.Redo_Icon;
            this.redoBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.redoBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.redoBtn.Name = "redoBtn";
            this.redoBtn.Size = new System.Drawing.Size(29, 31);
            this.redoBtn.Text = "toolStripButton1";
            this.redoBtn.ToolTipText = "Redo";
            this.redoBtn.Click += new System.EventHandler(this.redoBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.journal_EntriesBindingNavigator);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(47, 37);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(787, 629);
            this.panel2.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(entry_Id_Label);
            this.groupBox1.Controls.Add(this.entry_Id_TextBox);
            this.groupBox1.Controls.Add(entry_Title_Label);
            this.groupBox1.Controls.Add(this.toolStrip1);
            this.groupBox1.Controls.Add(this.entry_Title_TextBox);
            this.groupBox1.Controls.Add(entry_Date_Label);
            this.groupBox1.Controls.Add(this.entry_Date_DateTimePicker);
            this.groupBox1.Controls.Add(this.entry_RichTextBox);
            this.groupBox1.Location = new System.Drawing.Point(39, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(709, 525);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Journal Entry";
            // 
            // journal_EntriesBindingNavigator
            // 
            this.journal_EntriesBindingNavigator.AddNewItem = this.NewEntryBtn;
            this.journal_EntriesBindingNavigator.AutoSize = false;
            this.journal_EntriesBindingNavigator.BackColor = System.Drawing.Color.Transparent;
            this.journal_EntriesBindingNavigator.BindingSource = this.journal_EntriesBindingSource;
            this.journal_EntriesBindingNavigator.CountItem = null;
            this.journal_EntriesBindingNavigator.DeleteItem = this.DeleteBtn;
            this.journal_EntriesBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.journal_EntriesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.journal_EntriesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator8,
            this.NewEntryBtn,
            this.bindingNavigatorSeparator2,
            this.DeleteBtn,
            this.toolStripSeparator6,
            this.SaveBtn,
            this.toolStripSeparator7});
            this.journal_EntriesBindingNavigator.Location = new System.Drawing.Point(6, 8);
            this.journal_EntriesBindingNavigator.MoveFirstItem = null;
            this.journal_EntriesBindingNavigator.MoveLastItem = null;
            this.journal_EntriesBindingNavigator.MoveNextItem = null;
            this.journal_EntriesBindingNavigator.MovePreviousItem = null;
            this.journal_EntriesBindingNavigator.Name = "journal_EntriesBindingNavigator";
            this.journal_EntriesBindingNavigator.PositionItem = null;
            this.journal_EntriesBindingNavigator.Size = new System.Drawing.Size(777, 42);
            this.journal_EntriesBindingNavigator.TabIndex = 28;
            this.journal_EntriesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 42);
            // 
            // NewEntryBtn
            // 
            this.NewEntryBtn.AutoSize = false;
            this.NewEntryBtn.Image = ((System.Drawing.Image)(resources.GetObject("NewEntryBtn.Image")));
            this.NewEntryBtn.Name = "bindingNavigatorAddNewItem";
            this.NewEntryBtn.RightToLeftAutoMirrorImage = true;
            this.NewEntryBtn.Size = new System.Drawing.Size(92, 39);
            this.NewEntryBtn.Text = "New Entry";
            this.NewEntryBtn.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.AutoSize = false;
            this.DeleteBtn.Image = ((System.Drawing.Image)(resources.GetObject("DeleteBtn.Image")));
            this.DeleteBtn.Name = "bindingNavigatorDeleteItem";
            this.DeleteBtn.RightToLeftAutoMirrorImage = true;
            this.DeleteBtn.Size = new System.Drawing.Size(92, 39);
            this.DeleteBtn.Text = "Delete";
            // 
            // SaveBtn
            // 
            this.SaveBtn.AutoSize = false;
            this.SaveBtn.Image = ((System.Drawing.Image)(resources.GetObject("SaveBtn.Image")));
            this.SaveBtn.Name = "journal_EntriesBindingNavigatorSaveItem";
            this.SaveBtn.Size = new System.Drawing.Size(92, 39);
            this.SaveBtn.Text = "Save";
            this.SaveBtn.Click += new System.EventHandler(this.journal_EntriesBindingNavigatorSaveItem_Click);
            // 
            // entry_Id_Label
            // 
            entry_Id_Label.AutoSize = true;
            entry_Id_Label.Location = new System.Drawing.Point(52, 46);
            entry_Id_Label.Name = "entry_Id_Label";
            entry_Id_Label.Size = new System.Drawing.Size(60, 17);
            entry_Id_Label.TabIndex = 0;
            entry_Id_Label.Text = "Entry Id:";
            // 
            // entry_Id_TextBox
            // 
            this.entry_Id_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.journal_EntriesBindingSource, "Entry_Id:", true));
            this.entry_Id_TextBox.Location = new System.Drawing.Point(137, 43);
            this.entry_Id_TextBox.Name = "entry_Id_TextBox";
            this.entry_Id_TextBox.ReadOnly = true;
            this.entry_Id_TextBox.Size = new System.Drawing.Size(78, 22);
            this.entry_Id_TextBox.TabIndex = 1;
            // 
            // entry_Title_Label
            // 
            entry_Title_Label.AutoSize = true;
            entry_Title_Label.Location = new System.Drawing.Point(52, 74);
            entry_Title_Label.Name = "entry_Title_Label";
            entry_Title_Label.Size = new System.Drawing.Size(76, 17);
            entry_Title_Label.TabIndex = 2;
            entry_Title_Label.Text = "Entry Title:";
            // 
            // entry_Title_TextBox
            // 
            this.entry_Title_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.journal_EntriesBindingSource, "Entry_Title:", true));
            this.entry_Title_TextBox.Location = new System.Drawing.Point(137, 71);
            this.entry_Title_TextBox.Name = "entry_Title_TextBox";
            this.entry_Title_TextBox.Size = new System.Drawing.Size(558, 22);
            this.entry_Title_TextBox.TabIndex = 3;
            // 
            // entry_Date_Label
            // 
            entry_Date_Label.AutoSize = true;
            entry_Date_Label.Location = new System.Drawing.Point(52, 103);
            entry_Date_Label.Name = "entry_Date_Label";
            entry_Date_Label.Size = new System.Drawing.Size(79, 17);
            entry_Date_Label.TabIndex = 4;
            entry_Date_Label.Text = "Entry Date:";
            // 
            // entry_Date_DateTimePicker
            // 
            this.entry_Date_DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.journal_EntriesBindingSource, "Entry_Date:", true));
            this.entry_Date_DateTimePicker.Location = new System.Drawing.Point(137, 99);
            this.entry_Date_DateTimePicker.Name = "entry_Date_DateTimePicker";
            this.entry_Date_DateTimePicker.Size = new System.Drawing.Size(558, 22);
            this.entry_Date_DateTimePicker.TabIndex = 5;
            // 
            // entry_RichTextBox
            // 
            this.entry_RichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.journal_EntriesBindingSource, "Entry:", true));
            this.entry_RichTextBox.Location = new System.Drawing.Point(13, 194);
            this.entry_RichTextBox.Name = "entry_RichTextBox";
            this.entry_RichTextBox.Size = new System.Drawing.Size(682, 307);
            this.entry_RichTextBox.TabIndex = 7;
            this.entry_RichTextBox.Text = "";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 42);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 42);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 42);
            // 
            // journal_EntriesBindingSource
            // 
            this.journal_EntriesBindingSource.DataMember = "Journal Entries";
            this.journal_EntriesBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // journal_EntriesTableAdapter
            // 
            this.journal_EntriesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Journal_EntriesTableAdapter = this.journal_EntriesTableAdapter;
            this.tableAdapterManager.UpdateOrder = WriteItOut.Dataset.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Journal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(883, 706);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Journal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Journal";
            this.Load += new System.EventHandler(this.Journal_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.journal_EntriesBindingNavigator)).EndInit();
            this.journal_EntriesBindingNavigator.ResumeLayout(false);
            this.journal_EntriesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.journal_EntriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton FontBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripButton ForeColorBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
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
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Dataset.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource journal_EntriesBindingSource;
        private Dataset.DataSet1TableAdapters.Journal_EntriesTableAdapter journal_EntriesTableAdapter;
        private Dataset.DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator journal_EntriesBindingNavigator;
        private System.Windows.Forms.ToolStripButton NewEntryBtn;
        private System.Windows.Forms.ToolStripButton DeleteBtn;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton SaveBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.TextBox entry_Id_TextBox;
        private System.Windows.Forms.TextBox entry_Title_TextBox;
        private System.Windows.Forms.DateTimePicker entry_Date_DateTimePicker;
        private System.Windows.Forms.RichTextBox entry_RichTextBox;
    }
}