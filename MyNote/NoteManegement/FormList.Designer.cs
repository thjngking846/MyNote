namespace MyNote.NoteManegement
{
    partial class FormList
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
            this.lstNotes = new System.Windows.Forms.DataGridView();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetodoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notecontentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnD = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpS = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lstNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstNotes
            // 
            this.lstNotes.AllowUserToAddRows = false;
            this.lstNotes.AllowUserToDeleteRows = false;
            this.lstNotes.AutoGenerateColumns = false;
            this.lstNotes.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.lstNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstNotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.datetodoDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.notecontentDataGridViewTextBoxColumn});
            this.lstNotes.DataSource = this.noteBindingSource;
            this.lstNotes.Location = new System.Drawing.Point(0, 100);
            this.lstNotes.Name = "lstNotes";
            this.lstNotes.ReadOnly = true;
            this.lstNotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lstNotes.Size = new System.Drawing.Size(661, 355);
            this.lstNotes.TabIndex = 0;
            this.lstNotes.DoubleClick += new System.EventHandler(this.lstNotes_DoubleClick);
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datetodoDataGridViewTextBoxColumn
            // 
            this.datetodoDataGridViewTextBoxColumn.DataPropertyName = "Datetodo";
            this.datetodoDataGridViewTextBoxColumn.HeaderText = "Datetodo";
            this.datetodoDataGridViewTextBoxColumn.Name = "datetodoDataGridViewTextBoxColumn";
            this.datetodoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // notecontentDataGridViewTextBoxColumn
            // 
            this.notecontentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.notecontentDataGridViewTextBoxColumn.DataPropertyName = "notecontent";
            this.notecontentDataGridViewTextBoxColumn.FillWeight = 10F;
            this.notecontentDataGridViewTextBoxColumn.HeaderText = "notecontent";
            this.notecontentDataGridViewTextBoxColumn.Name = "notecontentDataGridViewTextBoxColumn";
            this.notecontentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noteBindingSource
            // 
            this.noteBindingSource.DataSource = typeof(MyNote.Note);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btAdd,
            this.refreshToolStripMenuItem,
            this.btnD,
            this.btnEdit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(661, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btAdd
            // 
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(41, 20);
            this.btAdd.Text = "Add";
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // btnD
            // 
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(52, 20);
            this.btnD.Text = "Delete";
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(39, 20);
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 62);
            this.label1.TabIndex = 2;
            this.label1.Text = "MyNote";
            // 
            // dtpS
            // 
            this.dtpS.CustomFormat = "dd-MM-yyyy";
            this.dtpS.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpS.Location = new System.Drawing.Point(558, 77);
            this.dtpS.Name = "dtpS";
            this.dtpS.Size = new System.Drawing.Size(91, 20);
            this.dtpS.TabIndex = 4;
            this.dtpS.Value = new System.DateTime(2018, 6, 5, 0, 0, 0, 0);
            this.dtpS.ValueChanged += new System.EventHandler(this.dtpS_ValueChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(492, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Search";
            // 
            // FormList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(661, 446);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstNotes);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormList";
            this.Text = "FormList";
            this.Load += new System.EventHandler(this.FormList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lstNotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView lstNotes;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btAdd;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem btnEdit;
        private System.Windows.Forms.BindingSource noteBindingSource;
        private System.Windows.Forms.DateTimePicker dtpS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetodoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notecontentDataGridViewTextBoxColumn;
    }
}