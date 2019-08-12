namespace MartSolution.Transaction
{
    partial class DayEndCloseOut
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DayEndCloseOut));
            this.label1 = new System.Windows.Forms.Label();
            this.CloseDate = new System.Windows.Forms.DateTimePicker();
            this.IGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExecuteBtn = new System.Windows.Forms.Button();
            this.CloseOutBtn = new System.Windows.Forms.Button();
            this.CloseOutProgress = new System.ComponentModel.BackgroundWorker();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CBackup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Close Date";
            // 
            // CloseDate
            // 
            this.CloseDate.Location = new System.Drawing.Point(64, 9);
            this.CloseDate.Name = "CloseDate";
            this.CloseDate.Size = new System.Drawing.Size(197, 20);
            this.CloseDate.TabIndex = 2;
            this.CloseDate.ValueChanged += new System.EventHandler(this.CloseDate_ValueChanged);
            // 
            // IGrid
            // 
            this.IGrid.AllowUserToAddRows = false;
            this.IGrid.AllowUserToResizeRows = false;
            this.IGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IGrid.BackgroundColor = System.Drawing.Color.White;
            this.IGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.IGrid.Location = new System.Drawing.Point(2, 49);
            this.IGrid.MultiSelect = false;
            this.IGrid.Name = "IGrid";
            this.IGrid.RowHeadersVisible = false;
            this.IGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            this.IGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.IGrid.Size = new System.Drawing.Size(735, 425);
            this.IGrid.TabIndex = 71;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "SN";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ID";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Visible = false;
            this.Column2.Width = 60;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Item Name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 110;
            // 
            // Column4
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column4.HeaderText = "Quantity";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column4.Width = 250;
            // 
            // Column5
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.NullValue = "----";
            this.Column5.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column5.HeaderText = "Purchase Amt";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column5.Width = 110;
            // 
            // Column6
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column6.HeaderText = "Sales Amt";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column6.Width = 110;
            // 
            // Column7
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column7.HeaderText = "Date";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ExecuteBtn
            // 
            this.ExecuteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExecuteBtn.Location = new System.Drawing.Point(264, 7);
            this.ExecuteBtn.Name = "ExecuteBtn";
            this.ExecuteBtn.Size = new System.Drawing.Size(88, 23);
            this.ExecuteBtn.TabIndex = 72;
            this.ExecuteBtn.Text = "&Execute";
            this.ExecuteBtn.UseVisualStyleBackColor = true;
            this.ExecuteBtn.Click += new System.EventHandler(this.ExecuteBtn_Click);
            // 
            // CloseOutBtn
            // 
            this.CloseOutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CloseOutBtn.Enabled = false;
            this.CloseOutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseOutBtn.Location = new System.Drawing.Point(2, 477);
            this.CloseOutBtn.Name = "CloseOutBtn";
            this.CloseOutBtn.Size = new System.Drawing.Size(118, 32);
            this.CloseOutBtn.TabIndex = 73;
            this.CloseOutBtn.Text = "&Close Out";
            this.CloseOutBtn.UseVisualStyleBackColor = true;
            this.CloseOutBtn.Click += new System.EventHandler(this.CloseOutBtn_Click);
            // 
            // CloseOutProgress
            // 
            this.CloseOutProgress.WorkerReportsProgress = true;
            this.CloseOutProgress.WorkerSupportsCancellation = true;
            this.CloseOutProgress.DoWork += new System.ComponentModel.DoWorkEventHandler(this.CloseOutProgress_DoWork);
            this.CloseOutProgress.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.CloseOutProgress_ProgressChanged);
            this.CloseOutProgress.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.CloseOutProgress_RunWorkerCompleted);
            // 
            // StatusLabel
            // 
            this.StatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.Location = new System.Drawing.Point(125, 477);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(604, 32);
            this.StatusLabel.TabIndex = 76;
            this.StatusLabel.Tag = "";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StatusLabel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(5, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(626, 13);
            this.label2.TabIndex = 79;
            this.label2.Text = "Closing Inventory Details [Quantity= (Opening Stock + Damage + Expired + Initial " +
    "Stock + Purchase + Sales Return) - (Lost + Sales)]";
            // 
            // CBackup
            // 
            this.CBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CBackup.Enabled = false;
            this.CBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBackup.Location = new System.Drawing.Point(619, 477);
            this.CBackup.Name = "CBackup";
            this.CBackup.Size = new System.Drawing.Size(118, 32);
            this.CBackup.TabIndex = 80;
            this.CBackup.Text = "Create Backup";
            this.CBackup.UseVisualStyleBackColor = true;
            this.CBackup.Visible = false;
            this.CBackup.Click += new System.EventHandler(this.CBackup_Click);
            // 
            // DayEndCloseOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(741, 511);
            this.Controls.Add(this.CBackup);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CloseOutBtn);
            this.Controls.Add(this.ExecuteBtn);
            this.Controls.Add(this.IGrid);
            this.Controls.Add(this.CloseDate);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(650, 550);
            this.Name = "DayEndCloseOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Day End Close Out";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DayEndCloseOut_FormClosing);
            this.Load += new System.EventHandler(this.DayEndCloseOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker CloseDate;
        private System.Windows.Forms.DataGridView IGrid;
        private System.Windows.Forms.Button ExecuteBtn;
        private System.Windows.Forms.Button CloseOutBtn;
        private System.ComponentModel.BackgroundWorker CloseOutProgress;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button CBackup;
    }
}