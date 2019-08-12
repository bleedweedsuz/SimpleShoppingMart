namespace MartSolution.Master
{
    partial class SupplierInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierInformation));
            this.CheckGarbage = new System.Windows.Forms.CheckBox();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.Delete = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Address = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Remarks = new System.Windows.Forms.RichTextBox();
            this.PanNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.SearchPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.SGrid)).BeginInit();
            this.buttonPanel.SuspendLayout();
            this.inputPanel.SuspendLayout();
            this.SearchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CheckGarbage
            // 
            this.CheckGarbage.AutoSize = true;
            this.CheckGarbage.ForeColor = System.Drawing.Color.Red;
            this.CheckGarbage.Location = new System.Drawing.Point(96, 28);
            this.CheckGarbage.Name = "CheckGarbage";
            this.CheckGarbage.Size = new System.Drawing.Size(197, 17);
            this.CheckGarbage.TabIndex = 79;
            this.CheckGarbage.Text = "Include Deleted Supplier Information";
            this.CheckGarbage.UseVisualStyleBackColor = true;
            this.CheckGarbage.CheckedChanged += new System.EventHandler(this.CheckGarbage_CheckedChanged);
            // 
            // SearchText
            // 
            this.SearchText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchText.Location = new System.Drawing.Point(96, 6);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(329, 20);
            this.SearchText.TabIndex = 7;
            this.SearchText.Tag = "2";
            this.SearchText.TextChanged += new System.EventHandler(this.SearchText_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(7, 7);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 15);
            this.label15.TabIndex = 78;
            this.label15.Text = "Search [Name]";
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(87, 29);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(217, 20);
            this.NameText.TabIndex = 0;
            this.NameText.Tag = "2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(40, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 15);
            this.label11.TabIndex = 72;
            this.label11.Text = "Name*";
            // 
            // SGrid
            // 
            this.SGrid.AllowUserToAddRows = false;
            this.SGrid.AllowUserToResizeRows = false;
            this.SGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SGrid.BackgroundColor = System.Drawing.Color.White;
            this.SGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column8,
            this.Column5,
            this.Column6,
            this.Column7});
            this.SGrid.Location = new System.Drawing.Point(4, 45);
            this.SGrid.MultiSelect = false;
            this.SGrid.Name = "SGrid";
            this.SGrid.RowHeadersVisible = false;
            this.SGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.SGrid.Size = new System.Drawing.Size(421, 214);
            this.SGrid.TabIndex = 70;
            this.SGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SGrid_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Supplier ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 90;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Phone No.";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Address";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Pan No.";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Email";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Remarks";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Status";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // buttonPanel
            // 
            this.buttonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonPanel.Controls.Add(this.Delete);
            this.buttonPanel.Controls.Add(this.Clear);
            this.buttonPanel.Controls.Add(this.Save);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonPanel.Location = new System.Drawing.Point(0, 262);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(735, 53);
            this.buttonPanel.TabIndex = 6;
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
            this.Clear.Text = "&Clear";
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
            this.Save.Text = "&Save";
            this.Save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(87, 81);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(217, 20);
            this.Address.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 15);
            this.label8.TabIndex = 69;
            this.label8.Text = "Address";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(88, 133);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(217, 20);
            this.Email.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(42, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 15);
            this.label9.TabIndex = 66;
            this.label9.Text = "Email";
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(87, 55);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(217, 20);
            this.Phone.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 15);
            this.label6.TabIndex = 62;
            this.label6.Text = "Phone No.";
            // 
            // SID
            // 
            this.SID.Location = new System.Drawing.Point(87, 3);
            this.SID.Name = "SID";
            this.SID.ReadOnly = true;
            this.SID.Size = new System.Drawing.Size(217, 20);
            this.SID.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 46;
            this.label1.Text = "Supplier ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 82;
            this.label3.Text = "Remarks";
            // 
            // Remarks
            // 
            this.Remarks.Location = new System.Drawing.Point(87, 159);
            this.Remarks.MaxLength = 200;
            this.Remarks.Name = "Remarks";
            this.Remarks.Size = new System.Drawing.Size(216, 58);
            this.Remarks.TabIndex = 5;
            this.Remarks.Text = "";
            // 
            // PanNo
            // 
            this.PanNo.Location = new System.Drawing.Point(87, 107);
            this.PanNo.Name = "PanNo";
            this.PanNo.Size = new System.Drawing.Size(217, 20);
            this.PanNo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 85;
            this.label2.Text = "Pan No.";
            // 
            // inputPanel
            // 
            this.inputPanel.Controls.Add(this.SID);
            this.inputPanel.Controls.Add(this.PanNo);
            this.inputPanel.Controls.Add(this.label1);
            this.inputPanel.Controls.Add(this.label2);
            this.inputPanel.Controls.Add(this.label6);
            this.inputPanel.Controls.Add(this.Remarks);
            this.inputPanel.Controls.Add(this.Phone);
            this.inputPanel.Controls.Add(this.label3);
            this.inputPanel.Controls.Add(this.label9);
            this.inputPanel.Controls.Add(this.Email);
            this.inputPanel.Controls.Add(this.label8);
            this.inputPanel.Controls.Add(this.Address);
            this.inputPanel.Controls.Add(this.NameText);
            this.inputPanel.Controls.Add(this.label11);
            this.inputPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.inputPanel.Location = new System.Drawing.Point(0, 0);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(307, 262);
            this.inputPanel.TabIndex = 0;
            // 
            // SearchPanel
            // 
            this.SearchPanel.Controls.Add(this.label15);
            this.SearchPanel.Controls.Add(this.SGrid);
            this.SearchPanel.Controls.Add(this.CheckGarbage);
            this.SearchPanel.Controls.Add(this.SearchText);
            this.SearchPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchPanel.Location = new System.Drawing.Point(307, 0);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(428, 262);
            this.SearchPanel.TabIndex = 80;
            // 
            // SupplierInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(735, 315);
            this.Controls.Add(this.SearchPanel);
            this.Controls.Add(this.inputPanel);
            this.Controls.Add(this.buttonPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SupplierInformation";
            this.Text = "Supplier Information";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SupplierInformation_FormClosed);
            this.Load += new System.EventHandler(this.SupplierInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SGrid)).EndInit();
            this.buttonPanel.ResumeLayout(false);
            this.inputPanel.ResumeLayout(false);
            this.inputPanel.PerformLayout();
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox CheckGarbage;
        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView SGrid;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox Remarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.TextBox PanNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel inputPanel;
        private System.Windows.Forms.Panel SearchPanel;
    }
}