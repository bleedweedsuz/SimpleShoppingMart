namespace MartSolution.Master
{
    partial class SearchInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchInvoice));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.FilterBy = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.InvoiceType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TSCombo = new System.Windows.Forms.ComboBox();
            this.DateBtnPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.DateBtnB = new System.Windows.Forms.DateTimePicker();
            this.DateBtnA = new System.Windows.Forms.DateTimePicker();
            this.SingleDatePanel = new System.Windows.Forms.Panel();
            this.SingleDate = new System.Windows.Forms.DateTimePicker();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.IGrid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.DateBtnPanel.SuspendLayout();
            this.SingleDatePanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SearchBtn);
            this.panel1.Controls.Add(this.FilterBy);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.InvoiceType);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 88);
            this.panel1.TabIndex = 0;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.Image = global::MartSolution.Properties.Resources.search;
            this.SearchBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchBtn.Location = new System.Drawing.Point(220, 54);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(98, 32);
            this.SearchBtn.TabIndex = 7;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // FilterBy
            // 
            this.FilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterBy.FormattingEnabled = true;
            this.FilterBy.Location = new System.Drawing.Point(76, 30);
            this.FilterBy.Name = "FilterBy";
            this.FilterBy.Size = new System.Drawing.Size(142, 21);
            this.FilterBy.TabIndex = 2;
            this.FilterBy.SelectedIndexChanged += new System.EventHandler(this.FilterBy_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Filter By";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // InvoiceType
            // 
            this.InvoiceType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InvoiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InvoiceType.FormattingEnabled = true;
            this.InvoiceType.Items.AddRange(new object[] {
            "Purchase Invoice",
            "Sales Invoice"});
            this.InvoiceType.Location = new System.Drawing.Point(76, 3);
            this.InvoiceType.Name = "InvoiceType";
            this.InvoiceType.Size = new System.Drawing.Size(759, 21);
            this.InvoiceType.TabIndex = 1;
            this.InvoiceType.SelectedIndexChanged += new System.EventHandler(this.InvoiceType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoice Type";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.TSCombo);
            this.panel3.Controls.Add(this.DateBtnPanel);
            this.panel3.Controls.Add(this.SingleDatePanel);
            this.panel3.Controls.Add(this.SearchText);
            this.panel3.Location = new System.Drawing.Point(220, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(615, 30);
            this.panel3.TabIndex = 0;
            // 
            // TSCombo
            // 
            this.TSCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TSCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TSCombo.FormattingEnabled = true;
            this.TSCombo.Location = new System.Drawing.Point(3, 6);
            this.TSCombo.Name = "TSCombo";
            this.TSCombo.Size = new System.Drawing.Size(607, 21);
            this.TSCombo.TabIndex = 1;
            // 
            // DateBtnPanel
            // 
            this.DateBtnPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DateBtnPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.DateBtnPanel.Controls.Add(this.label4);
            this.DateBtnPanel.Controls.Add(this.DateBtnB);
            this.DateBtnPanel.Controls.Add(this.DateBtnA);
            this.DateBtnPanel.Location = new System.Drawing.Point(3, 6);
            this.DateBtnPanel.Name = "DateBtnPanel";
            this.DateBtnPanel.Size = new System.Drawing.Size(608, 23);
            this.DateBtnPanel.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "to";
            // 
            // DateBtnB
            // 
            this.DateBtnB.Location = new System.Drawing.Point(230, 1);
            this.DateBtnB.Name = "DateBtnB";
            this.DateBtnB.Size = new System.Drawing.Size(200, 20);
            this.DateBtnB.TabIndex = 1;
            // 
            // DateBtnA
            // 
            this.DateBtnA.Location = new System.Drawing.Point(1, 1);
            this.DateBtnA.Name = "DateBtnA";
            this.DateBtnA.Size = new System.Drawing.Size(200, 20);
            this.DateBtnA.TabIndex = 0;
            // 
            // SingleDatePanel
            // 
            this.SingleDatePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SingleDatePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.SingleDatePanel.Controls.Add(this.SingleDate);
            this.SingleDatePanel.Location = new System.Drawing.Point(3, 6);
            this.SingleDatePanel.Name = "SingleDatePanel";
            this.SingleDatePanel.Size = new System.Drawing.Size(608, 23);
            this.SingleDatePanel.TabIndex = 0;
            // 
            // SingleDate
            // 
            this.SingleDate.Location = new System.Drawing.Point(1, 1);
            this.SingleDate.Name = "SingleDate";
            this.SingleDate.Size = new System.Drawing.Size(200, 20);
            this.SingleDate.TabIndex = 0;
            // 
            // SearchText
            // 
            this.SearchText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchText.Location = new System.Drawing.Point(3, 6);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(609, 22);
            this.SearchText.TabIndex = 0;
            this.SearchText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchText_KeyDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.IGrid);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(838, 371);
            this.panel2.TabIndex = 1;
            // 
            // IGrid
            // 
            this.IGrid.AllowUserToAddRows = false;
            this.IGrid.AllowUserToResizeRows = false;
            this.IGrid.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.IGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.IGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IGrid.Location = new System.Drawing.Point(0, 0);
            this.IGrid.MultiSelect = false;
            this.IGrid.Name = "IGrid";
            this.IGrid.RowHeadersVisible = false;
            this.IGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.IGrid.Size = new System.Drawing.Size(838, 371);
            this.IGrid.TabIndex = 1;
            this.IGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.IGrid_CellDoubleClick);
            // 
            // SearchInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(838, 459);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchInvoice";
            this.Text = "Search Invoice";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchInvoice_FormClosed);
            this.Load += new System.EventHandler(this.SearchInvoice_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.DateBtnPanel.ResumeLayout(false);
            this.DateBtnPanel.PerformLayout();
            this.SingleDatePanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView IGrid;
        private System.Windows.Forms.ComboBox InvoiceType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.ComboBox FilterBy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel SingleDatePanel;
        private System.Windows.Forms.DateTimePicker SingleDate;
        private System.Windows.Forms.Panel DateBtnPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DateBtnB;
        private System.Windows.Forms.DateTimePicker DateBtnA;
        private System.Windows.Forms.ComboBox TSCombo;
    }
}