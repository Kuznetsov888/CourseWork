namespace PersonnelManager
{
    partial class PersonnelManager
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripButtonNew = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.ToolStripButtonSearch = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButtonBack = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToolStripButtonEdit = new System.Windows.Forms.Button();
            this.ToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripButtonNew,
            this.ToolStripButtonOpen,
            this.ToolStripButtonSave,
            this.ToolStripSeparator1,
            this.ToolStripLabel1,
            this.ToolStripTextBox1,
            this.ToolStripButtonSearch,
            this.ToolStripSeparator2,
            this.ToolStripButtonBack,
            this.ToolStripSeparator3,
            this.ToolStripButtonDelete});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(835, 25);
            this.ToolStrip1.TabIndex = 0;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // ToolStripButtonNew
            // 
            this.ToolStripButtonNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonNew.Image = global::PersonnelManager.Properties.Resources.Actions_document_new_icon;
            this.ToolStripButtonNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonNew.Name = "ToolStripButtonNew";
            this.ToolStripButtonNew.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButtonNew.Text = "New";
            this.ToolStripButtonNew.Click += new System.EventHandler(this.ToolStripButtonNew_Click);
            // 
            // ToolStripButtonOpen
            // 
            this.ToolStripButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonOpen.Image = global::PersonnelManager.Properties.Resources._62917_open_file_folder_icon;
            this.ToolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonOpen.Name = "ToolStripButtonOpen";
            this.ToolStripButtonOpen.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButtonOpen.Text = "Open";
            this.ToolStripButtonOpen.Click += new System.EventHandler(this.ToolStripButtonOpen_Click);
            // 
            // ToolStripButtonSave
            // 
            this.ToolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonSave.Image = global::PersonnelManager.Properties.Resources.Floppy_Small_icon;
            this.ToolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonSave.Name = "ToolStripButtonSave";
            this.ToolStripButtonSave.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButtonSave.Text = "Save";
            this.ToolStripButtonSave.Click += new System.EventHandler(this.ToolStripButtonSave_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripLabel1
            // 
            this.ToolStripLabel1.Name = "ToolStripLabel1";
            this.ToolStripLabel1.Size = new System.Drawing.Size(62, 22);
            this.ToolStripLabel1.Text = "Search For";
            // 
            // ToolStripTextBox1
            // 
            this.ToolStripTextBox1.Name = "ToolStripTextBox1";
            this.ToolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            // 
            // ToolStripButtonSearch
            // 
            this.ToolStripButtonSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonSearch.Image = global::PersonnelManager.Properties.Resources.Zoom_icon;
            this.ToolStripButtonSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonSearch.Name = "ToolStripButtonSearch";
            this.ToolStripButtonSearch.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButtonSearch.Text = "Search";
            this.ToolStripButtonSearch.Click += new System.EventHandler(this.ToolStripButtonSearch_Click);
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripButtonBack
            // 
            this.ToolStripButtonBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonBack.Image = global::PersonnelManager.Properties.Resources.Go_back_icon;
            this.ToolStripButtonBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonBack.Name = "ToolStripButtonBack";
            this.ToolStripButtonBack.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButtonBack.Text = "Back";
            this.ToolStripButtonBack.Click += new System.EventHandler(this.ToolStripButtonBack_Click);
            // 
            // ToolStripSeparator3
            // 
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripButtonDelete
            // 
            this.ToolStripButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonDelete.Image = global::PersonnelManager.Properties.Resources.Windows_Close_Program_icon;
            this.ToolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonDelete.Name = "ToolStripButtonDelete";
            this.ToolStripButtonDelete.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButtonDelete.Text = "Delete Row";
            this.ToolStripButtonDelete.Click += new System.EventHandler(this.ToolStripButtonDelete_Click);
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Department,
            this.Position,
            this.DGName,
            this.Surname});
            this.dataGridViewData.Enabled = false;
            this.dataGridViewData.Location = new System.Drawing.Point(13, 29);
            this.dataGridViewData.MultiSelect = false;
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.Size = new System.Drawing.Size(810, 403);
            this.dataGridViewData.TabIndex = 1;
            // 
            // Department
            // 
            this.Department.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Department.HeaderText = "Department";
            this.Department.Name = "Department";
            this.Department.Width = 87;
            // 
            // Position
            // 
            this.Position.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Position.HeaderText = "Position";
            this.Position.Name = "Position";
            this.Position.Width = 69;
            // 
            // DGName
            // 
            this.DGName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DGName.HeaderText = "Name";
            this.DGName.Name = "DGName";
            // 
            // Surname
            // 
            this.Surname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Surname.HeaderText = "Surname";
            this.Surname.Name = "Surname";
            // 
            // ToolStripButtonEdit
            // 
            this.ToolStripButtonEdit.BackColor = System.Drawing.Color.Red;
            this.ToolStripButtonEdit.Location = new System.Drawing.Point(333, 0);
            this.ToolStripButtonEdit.Name = "ToolStripButtonEdit";
            this.ToolStripButtonEdit.Size = new System.Drawing.Size(36, 23);
            this.ToolStripButtonEdit.TabIndex = 2;
            this.ToolStripButtonEdit.Text = "Edit";
            this.ToolStripButtonEdit.UseVisualStyleBackColor = false;
            this.ToolStripButtonEdit.Click += new System.EventHandler(this.ToolStripButtonEdit_Click);
            // 
            // PersonnelManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 474);
            this.Controls.Add(this.ToolStripButtonEdit);
            this.Controls.Add(this.dataGridViewData);
            this.Controls.Add(this.ToolStrip1);
            this.MinimumSize = new System.Drawing.Size(460, 200);
            this.Name = "PersonnelManager";
            this.Text = "Personnel Manager";
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ToolStrip1;
        private System.Windows.Forms.ToolStripButton ToolStripButtonNew;
        private System.Windows.Forms.ToolStripButton ToolStripButtonOpen;
        private System.Windows.Forms.ToolStripButton ToolStripButtonSave;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel ToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox ToolStripTextBox1;
        private System.Windows.Forms.ToolStripButton ToolStripButtonSearch;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.ToolStripButton ToolStripButtonBack;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator3;
        private System.Windows.Forms.ToolStripButton ToolStripButtonDelete;
        private System.Windows.Forms.Button ToolStripButtonEdit;
    }
}

