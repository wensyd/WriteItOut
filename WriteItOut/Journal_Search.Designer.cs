
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Journal_Search));
            System.Windows.Forms.Label entry_Id_Label;
            System.Windows.Forms.Label entry_Title_Label;
            System.Windows.Forms.Label entry_Date_Label;
            this.dataSet1 = new WriteItOut.Dataset.DataSet1();
            this.journal_EntriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.journal_EntriesTableAdapter = new WriteItOut.Dataset.DataSet1TableAdapters.Journal_EntriesTableAdapter();
            this.tableAdapterManager = new WriteItOut.Dataset.DataSet1TableAdapters.TableAdapterManager();
            this.journal_EntriesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.journal_EntriesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entry_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.entry_Id_TextBox = new System.Windows.Forms.TextBox();
            this.entry_Title_TextBox = new System.Windows.Forms.TextBox();
            this.entry_Date_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            entry_Id_Label = new System.Windows.Forms.Label();
            entry_Title_Label = new System.Windows.Forms.Label();
            entry_Date_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.journal_EntriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.journal_EntriesBindingNavigator)).BeginInit();
            this.journal_EntriesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.journal_EntriesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // journal_EntriesBindingSource
            // 
            this.journal_EntriesBindingSource.DataMember = "Journal Entries";
            this.journal_EntriesBindingSource.DataSource = this.dataSet1;
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
            // journal_EntriesBindingNavigator
            // 
            this.journal_EntriesBindingNavigator.AddNewItem = null;
            this.journal_EntriesBindingNavigator.AutoSize = false;
            this.journal_EntriesBindingNavigator.BackColor = System.Drawing.Color.Transparent;
            this.journal_EntriesBindingNavigator.BindingSource = this.journal_EntriesBindingSource;
            this.journal_EntriesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.journal_EntriesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.journal_EntriesBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.journal_EntriesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.journal_EntriesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorDeleteItem,
            this.toolStripSeparator1});
            this.journal_EntriesBindingNavigator.Location = new System.Drawing.Point(3, 2);
            this.journal_EntriesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.journal_EntriesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.journal_EntriesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.journal_EntriesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.journal_EntriesBindingNavigator.Name = "journal_EntriesBindingNavigator";
            this.journal_EntriesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.journal_EntriesBindingNavigator.Size = new System.Drawing.Size(1017, 52);
            this.journal_EntriesBindingNavigator.TabIndex = 29;
            this.journal_EntriesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 49);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 49);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 52);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 49);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 52);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 49);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 49);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 52);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.AutoSize = false;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(92, 49);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // journal_EntriesDataGridView
            // 
            this.journal_EntriesDataGridView.AutoGenerateColumns = false;
            this.journal_EntriesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.journal_EntriesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.journal_EntriesDataGridView.DataSource = this.journal_EntriesBindingSource;
            this.journal_EntriesDataGridView.Location = new System.Drawing.Point(3, 330);
            this.journal_EntriesDataGridView.Name = "journal_EntriesDataGridView";
            this.journal_EntriesDataGridView.RowHeadersWidth = 51;
            this.journal_EntriesDataGridView.RowTemplate.Height = 24;
            this.journal_EntriesDataGridView.Size = new System.Drawing.Size(555, 345);
            this.journal_EntriesDataGridView.TabIndex = 29;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Entry_Id:";
            this.dataGridViewTextBoxColumn1.HeaderText = "Entry_Id:";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Entry_Title:";
            this.dataGridViewTextBoxColumn2.HeaderText = "Entry_Title:";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Entry_Date:";
            this.dataGridViewTextBoxColumn3.HeaderText = "Entry_Date:";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Entry:";
            this.dataGridViewTextBoxColumn4.HeaderText = "Entry:";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // entry_RichTextBox
            // 
            this.entry_RichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.journal_EntriesBindingSource, "Entry:", true));
            this.entry_RichTextBox.Location = new System.Drawing.Point(564, 63);
            this.entry_RichTextBox.Name = "entry_RichTextBox";
            this.entry_RichTextBox.Size = new System.Drawing.Size(464, 612);
            this.entry_RichTextBox.TabIndex = 30;
            this.entry_RichTextBox.Text = "";
            // 
            // entry_Id_Label
            // 
            entry_Id_Label.AutoSize = true;
            entry_Id_Label.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            entry_Id_Label.Location = new System.Drawing.Point(42, 120);
            entry_Id_Label.Name = "entry_Id_Label";
            entry_Id_Label.Size = new System.Drawing.Size(68, 19);
            entry_Id_Label.TabIndex = 30;
            entry_Id_Label.Text = "Entry Id:";
            // 
            // entry_Id_TextBox
            // 
            this.entry_Id_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.journal_EntriesBindingSource, "Entry_Id:", true));
            this.entry_Id_TextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entry_Id_TextBox.Location = new System.Drawing.Point(118, 112);
            this.entry_Id_TextBox.Name = "entry_Id_TextBox";
            this.entry_Id_TextBox.Size = new System.Drawing.Size(100, 27);
            this.entry_Id_TextBox.TabIndex = 31;
            // 
            // entry_Title_Label
            // 
            entry_Title_Label.AutoSize = true;
            entry_Title_Label.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            entry_Title_Label.Location = new System.Drawing.Point(26, 152);
            entry_Title_Label.Name = "entry_Title_Label";
            entry_Title_Label.Size = new System.Drawing.Size(86, 19);
            entry_Title_Label.TabIndex = 31;
            entry_Title_Label.Text = "Entry Title:";
            // 
            // entry_Title_TextBox
            // 
            this.entry_Title_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.journal_EntriesBindingSource, "Entry_Title:", true));
            this.entry_Title_TextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entry_Title_TextBox.Location = new System.Drawing.Point(118, 144);
            this.entry_Title_TextBox.Name = "entry_Title_TextBox";
            this.entry_Title_TextBox.Size = new System.Drawing.Size(364, 27);
            this.entry_Title_TextBox.TabIndex = 32;
            // 
            // entry_Date_Label
            // 
            entry_Date_Label.AutoSize = true;
            entry_Date_Label.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            entry_Date_Label.Location = new System.Drawing.Point(23, 184);
            entry_Date_Label.Name = "entry_Date_Label";
            entry_Date_Label.Size = new System.Drawing.Size(87, 19);
            entry_Date_Label.TabIndex = 32;
            entry_Date_Label.Text = "Entry Date:";
            // 
            // entry_Date_DateTimePicker
            // 
            this.entry_Date_DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.journal_EntriesBindingSource, "Entry_Date:", true));
            this.entry_Date_DateTimePicker.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entry_Date_DateTimePicker.Location = new System.Drawing.Point(118, 176);
            this.entry_Date_DateTimePicker.Name = "entry_Date_DateTimePicker";
            this.entry_Date_DateTimePicker.Size = new System.Drawing.Size(364, 27);
            this.entry_Date_DateTimePicker.TabIndex = 33;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 52);
            // 
            // Journal_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1048, 695);
            this.Controls.Add(entry_Date_Label);
            this.Controls.Add(this.entry_Date_DateTimePicker);
            this.Controls.Add(entry_Title_Label);
            this.Controls.Add(this.entry_Title_TextBox);
            this.Controls.Add(entry_Id_Label);
            this.Controls.Add(this.entry_Id_TextBox);
            this.Controls.Add(this.entry_RichTextBox);
            this.Controls.Add(this.journal_EntriesDataGridView);
            this.Controls.Add(this.journal_EntriesBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Journal_Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Journal_Search";
            this.Load += new System.EventHandler(this.Journal_Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.journal_EntriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.journal_EntriesBindingNavigator)).EndInit();
            this.journal_EntriesBindingNavigator.ResumeLayout(false);
            this.journal_EntriesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.journal_EntriesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Dataset.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource journal_EntriesBindingSource;
        private Dataset.DataSet1TableAdapters.Journal_EntriesTableAdapter journal_EntriesTableAdapter;
        private Dataset.DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator journal_EntriesBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridView journal_EntriesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.RichTextBox entry_RichTextBox;
        private System.Windows.Forms.TextBox entry_Id_TextBox;
        private System.Windows.Forms.TextBox entry_Title_TextBox;
        private System.Windows.Forms.DateTimePicker entry_Date_DateTimePicker;
    }
}