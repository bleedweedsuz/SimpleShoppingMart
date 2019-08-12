namespace MartSolution.Master
{
    partial class ItemCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemCategory));
            this.NameText = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Delete = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.ICGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckGarbage = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ICGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(80, 39);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(175, 20);
            this.NameText.TabIndex = 0;
            this.NameText.Tag = "2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(33, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 15);
            this.label11.TabIndex = 75;
            this.label11.Text = "Name";
            // 
            // CID
            // 
            this.CID.Location = new System.Drawing.Point(80, 13);
            this.CID.Name = "CID";
            this.CID.ReadOnly = true;
            this.CID.Size = new System.Drawing.Size(175, 20);
            this.CID.TabIndex = 72;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 74;
            this.label1.Text = "Category ID";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel6.Controls.Add(this.Delete);
            this.panel6.Controls.Add(this.Clear);
            this.panel6.Controls.Add(this.Save);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 298);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(674, 53);
            this.panel6.TabIndex = 1;
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.Color.Black;
            this.Delete.Image = global::MartSolution.Properties.Resources.delete;
            this.Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Delete.Location = new System.Drawing.Point(214, 6);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(99, 44);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "Delete";
            this.Delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Visible = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.ForeColor = System.Drawing.Color.Blue;
            this.Clear.Image = global::MartSolution.Properties.Resources.recycle;
            this.Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Clear.Location = new System.Drawing.Point(109, 6);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(94, 44);
            this.Clear.TabIndex = 1;
            this.Clear.Text = "Clear";
            this.Clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ForeColor = System.Drawing.Color.Green;
            this.Save.Image = global::MartSolution.Properties.Resources.add;
            this.Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Save.Location = new System.Drawing.Point(5, 6);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(95, 44);
            this.Save.TabIndex = 0;
            this.Save.Text = "Save";
            this.Save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // SearchText
            // 
            this.SearchText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchText.Location = new System.Drawing.Point(362, 13);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(310, 20);
            this.SearchText.TabIndex = 79;
            this.SearchText.Tag = "2";
            this.SearchText.TextChanged += new System.EventHandler(this.SearchText_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(259, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 15);
            this.label15.TabIndex = 81;
            this.label15.Text = "Search [Name]";
            // 
            // ICGrid
            // 
            this.ICGrid.AllowUserToAddRows = false;
            this.ICGrid.AllowUserToResizeRows = false;
            this.ICGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ICGrid.BackgroundColor = System.Drawing.Color.White;
            this.ICGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ICGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.ICGrid.Location = new System.Drawing.Point(261, 56);
            this.ICGrid.MultiSelect = false;
            this.ICGrid.Name = "ICGrid";
            this.ICGrid.RowHeadersVisible = false;
            this.ICGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.ICGrid.Size = new System.Drawing.Size(411, 239);
            this.ICGrid.TabIndex = 80;
            this.ICGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ICGrid_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "CID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Category Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 300;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Status";
            this.Column3.Name = "Column3";
            this.Column3.Visible = false;
            // 
            // CheckGarbage
            // 
            this.CheckGarbage.AutoSize = true;
            this.CheckGarbage.ForeColor = System.Drawing.Color.Red;
            this.CheckGarbage.Location = new System.Drawing.Point(362, 37);
            this.CheckGarbage.Name = "CheckGarbage";
            this.CheckGarbage.Size = new System.Drawing.Size(169, 17);
            this.CheckGarbage.TabIndex = 83;
            this.CheckGarbage.Text = "Include Deleted Item Category";
            this.CheckGarbage.UseVisualStyleBackColor = true;
            this.CheckGarbage.CheckedChanged += new System.EventHandler(this.CheckGarbage_CheckedChanged);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 142);
            this.label2.TabIndex = 84;
            this.label2.Text = "Note*\r\n        Please carefully enter category name.\r\nAfter delete, it can\'t be u" +
    "ndo. You have to \r\nreenter it again.";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(258, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 287);
            this.panel1.TabIndex = 85;
            // 
            // ItemCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(674, 351);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CheckGarbage);
            this.Controls.Add(this.SearchText);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.ICGrid);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.CID);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(690, 390);
            this.Name = "ItemCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Category";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ItemCategory_FormClosed);
            this.Load += new System.EventHandler(this.ItemCategory_Load);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ICGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox CID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView ICGrid;
        private System.Windows.Forms.CheckBox CheckGarbage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Panel panel1;
    }
}