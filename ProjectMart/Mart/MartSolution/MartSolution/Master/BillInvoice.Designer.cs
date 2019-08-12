namespace MartSolution.Master
{
    partial class BillInvoice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillInvoice));
            this.BGrid = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Main_ = new System.Windows.Forms.Panel();
            this.RemoveAll = new System.Windows.Forms.CheckBox();
            this.InputCodeDisplaySelected = new System.Windows.Forms.Label();
            this._InputCode = new System.Windows.Forms.TextBox();
            this.DisAmount = new System.Windows.Forms.RadioButton();
            this.DisPercentage = new System.Windows.Forms.RadioButton();
            this.DisAmountVal = new System.Windows.Forms.NumericUpDown();
            this.DisPercentageVal = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.GrandTotal = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.TLabel = new System.Windows.Forms.Label();
            this.GrossTotal = new System.Windows.Forms.TextBox();
            this.Footer = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PrintPreviewPanel = new System.Windows.Forms.Panel();
            this.R_PrintLayout = new System.Windows.Forms.RadioButton();
            this.R_NLayout = new System.Windows.Forms.RadioButton();
            this.R_Wlayout = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ShowPrintPreview = new System.Windows.Forms.CheckBox();
            this.AutoTransaction = new System.Windows.Forms.CheckBox();
            this.AutoPrintInvoice = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.TransactionMode = new System.Windows.Forms.ComboBox();
            this.Remarks = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ReturnAmount = new System.Windows.Forms.TextBox();
            this.TenderAmount = new System.Windows.Forms.TextBox();
            this.Header_ = new System.Windows.Forms.Panel();
            this.SampleDate = new System.Windows.Forms.TextBox();
            this.BillNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EntryDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.BillSavedMessage = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.PrintPreview = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.ItemInPanel = new System.Windows.Forms.Panel();
            this._AutoAdd = new System.Windows.Forms.CheckBox();
            this.ReloadItemNameAutoComplete = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.S_ItemName = new System.Windows.Forms.RadioButton();
            this.S_ItemCode = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.S_ItemBarCode = new System.Windows.Forms.RadioButton();
            this.QuantityData = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.BillMessageTimer = new System.Windows.Forms.Timer(this.components);
            this.panel8 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.BGrid)).BeginInit();
            this.Main_.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisAmountVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisPercentageVal)).BeginInit();
            this.Footer.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PrintPreviewPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Header_.SuspendLayout();
            this.panel6.SuspendLayout();
            this.BillSavedMessage.SuspendLayout();
            this.ItemInPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityData)).BeginInit();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // BGrid
            // 
            this.BGrid.AllowUserToAddRows = false;
            this.BGrid.AllowUserToResizeColumns = false;
            this.BGrid.AllowUserToResizeRows = false;
            this.BGrid.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.BGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column1,
            this.Column10,
            this.Column2,
            this.Column3,
            this.Column12,
            this.Column4,
            this.Column8});
            this.BGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BGrid.Location = new System.Drawing.Point(2, 2);
            this.BGrid.MultiSelect = false;
            this.BGrid.Name = "BGrid";
            this.BGrid.RowHeadersVisible = false;
            this.BGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.BGrid.Size = new System.Drawing.Size(773, 203);
            this.BGrid.TabIndex = 0;
            this.BGrid.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.BGrid_CellBeginEdit);
            this.BGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BGrid_CellClick);
            this.BGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.BGrid_CellEndEdit);
            this.BGrid.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.BGrid_EditingControlShowing);
            // 
            // Column9
            // 
            this.Column9.HeaderText = "";
            this.Column9.Name = "Column9";
            this.Column9.ToolTipText = "Click To Delete Items";
            this.Column9.Width = 32;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "SN";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "ItemID";
            this.Column10.Name = "Column10";
            this.Column10.Visible = false;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Item Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Column3.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column3.HeaderText = "Quantity";
            this.Column3.Name = "Column3";
            this.Column3.Width = 80;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Unit";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 50;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Rate (Rs.)";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Total (Rs.)";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 150;
            // 
            // Main_
            // 
            this.Main_.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Main_.BackColor = System.Drawing.Color.White;
            this.Main_.Controls.Add(this.RemoveAll);
            this.Main_.Controls.Add(this.BGrid);
            this.Main_.Location = new System.Drawing.Point(5, 120);
            this.Main_.Name = "Main_";
            this.Main_.Padding = new System.Windows.Forms.Padding(2);
            this.Main_.Size = new System.Drawing.Size(777, 207);
            this.Main_.TabIndex = 9;
            // 
            // RemoveAll
            // 
            this.RemoveAll.AutoSize = true;
            this.RemoveAll.Location = new System.Drawing.Point(11, 7);
            this.RemoveAll.Name = "RemoveAll";
            this.RemoveAll.Size = new System.Drawing.Size(15, 14);
            this.RemoveAll.TabIndex = 1;
            this.RemoveAll.UseVisualStyleBackColor = true;
            // 
            // InputCodeDisplaySelected
            // 
            this.InputCodeDisplaySelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputCodeDisplaySelected.Location = new System.Drawing.Point(7, 8);
            this.InputCodeDisplaySelected.Name = "InputCodeDisplaySelected";
            this.InputCodeDisplaySelected.Size = new System.Drawing.Size(117, 16);
            this.InputCodeDisplaySelected.TabIndex = 4;
            this.InputCodeDisplaySelected.Text = "Item Barcode";
            this.InputCodeDisplaySelected.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _InputCode
            // 
            this._InputCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._InputCode.BackColor = System.Drawing.Color.Bisque;
            this._InputCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._InputCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._InputCode.Location = new System.Drawing.Point(130, 6);
            this._InputCode.Name = "_InputCode";
            this._InputCode.Size = new System.Drawing.Size(643, 40);
            this._InputCode.TabIndex = 0;
            this._InputCode.TextChanged += new System.EventHandler(this.Bar_ItemCode_TextChanged);
            this._InputCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Bar_ItemCode_KeyDown);
            // 
            // DisAmount
            // 
            this.DisAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DisAmount.AutoSize = true;
            this.DisAmount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DisAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisAmount.Location = new System.Drawing.Point(723, 32);
            this.DisAmount.Name = "DisAmount";
            this.DisAmount.Size = new System.Drawing.Size(44, 17);
            this.DisAmount.TabIndex = 4;
            this.DisAmount.Text = "Rs.";
            this.DisAmount.UseVisualStyleBackColor = false;
            this.DisAmount.CheckedChanged += new System.EventHandler(this.DisAmount_CheckedChanged);
            // 
            // DisPercentage
            // 
            this.DisPercentage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DisPercentage.AutoSize = true;
            this.DisPercentage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DisPercentage.Checked = true;
            this.DisPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisPercentage.Location = new System.Drawing.Point(608, 31);
            this.DisPercentage.Name = "DisPercentage";
            this.DisPercentage.Size = new System.Drawing.Size(39, 20);
            this.DisPercentage.TabIndex = 2;
            this.DisPercentage.TabStop = true;
            this.DisPercentage.Text = "%";
            this.DisPercentage.UseVisualStyleBackColor = false;
            this.DisPercentage.CheckedChanged += new System.EventHandler(this.DisPercentage_CheckedChanged);
            // 
            // DisAmountVal
            // 
            this.DisAmountVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DisAmountVal.DecimalPlaces = 2;
            this.DisAmountVal.Enabled = false;
            this.DisAmountVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisAmountVal.Location = new System.Drawing.Point(648, 30);
            this.DisAmountVal.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.DisAmountVal.Name = "DisAmountVal";
            this.DisAmountVal.Size = new System.Drawing.Size(72, 21);
            this.DisAmountVal.TabIndex = 3;
            this.DisAmountVal.ValueChanged += new System.EventHandler(this.DisAmountVal_ValueChanged);
            // 
            // DisPercentageVal
            // 
            this.DisPercentageVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DisPercentageVal.DecimalPlaces = 2;
            this.DisPercentageVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisPercentageVal.Location = new System.Drawing.Point(532, 30);
            this.DisPercentageVal.Name = "DisPercentageVal";
            this.DisPercentageVal.Size = new System.Drawing.Size(72, 21);
            this.DisPercentageVal.TabIndex = 1;
            this.DisPercentageVal.ValueChanged += new System.EventHandler(this.DisPercentageVal_ValueChanged);
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(443, 59);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(86, 18);
            this.label20.TabIndex = 11;
            this.label20.Text = "Grand Total";
            // 
            // GrandTotal
            // 
            this.GrandTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GrandTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrandTotal.Location = new System.Drawing.Point(532, 56);
            this.GrandTotal.Name = "GrandTotal";
            this.GrandTotal.ReadOnly = true;
            this.GrandTotal.Size = new System.Drawing.Size(238, 24);
            this.GrandTotal.TabIndex = 6;
            this.GrandTotal.Text = "0.00";
            this.GrandTotal.TextChanged += new System.EventHandler(this.GrandTotal_TextChanged);
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(481, 34);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 13);
            this.label17.TabIndex = 7;
            this.label17.Text = "Discount";
            // 
            // TLabel
            // 
            this.TLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TLabel.AutoSize = true;
            this.TLabel.Location = new System.Drawing.Point(470, 7);
            this.TLabel.Name = "TLabel";
            this.TLabel.Size = new System.Drawing.Size(61, 13);
            this.TLabel.TabIndex = 4;
            this.TLabel.Text = "Gross Total";
            // 
            // GrossTotal
            // 
            this.GrossTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GrossTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GrossTotal.Location = new System.Drawing.Point(532, 5);
            this.GrossTotal.Name = "GrossTotal";
            this.GrossTotal.ReadOnly = true;
            this.GrossTotal.Size = new System.Drawing.Size(238, 20);
            this.GrossTotal.TabIndex = 0;
            this.GrossTotal.Text = "0.00";
            // 
            // Footer
            // 
            this.Footer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Footer.BackColor = System.Drawing.Color.White;
            this.Footer.Controls.Add(this.panel5);
            this.Footer.Controls.Add(this.panel2);
            this.Footer.Controls.Add(this.panel1);
            this.Footer.Controls.Add(this.panel3);
            this.Footer.Controls.Add(this.label5);
            this.Footer.Controls.Add(this.label4);
            this.Footer.Controls.Add(this.ReturnAmount);
            this.Footer.Controls.Add(this.TenderAmount);
            this.Footer.Controls.Add(this.DisAmount);
            this.Footer.Controls.Add(this.DisPercentage);
            this.Footer.Controls.Add(this.DisAmountVal);
            this.Footer.Controls.Add(this.DisPercentageVal);
            this.Footer.Controls.Add(this.label20);
            this.Footer.Controls.Add(this.GrandTotal);
            this.Footer.Controls.Add(this.label17);
            this.Footer.Controls.Add(this.TLabel);
            this.Footer.Controls.Add(this.GrossTotal);
            this.Footer.Location = new System.Drawing.Point(5, 329);
            this.Footer.Name = "Footer";
            this.Footer.Size = new System.Drawing.Size(777, 205);
            this.Footer.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel5.Location = new System.Drawing.Point(337, 112);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(433, 1);
            this.panel5.TabIndex = 82;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.PrintPreviewPanel);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.ShowPrintPreview);
            this.panel2.Controls.Add(this.AutoTransaction);
            this.panel2.Controls.Add(this.AutoPrintInvoice);
            this.panel2.Location = new System.Drawing.Point(5, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 120);
            this.panel2.TabIndex = 81;
            // 
            // PrintPreviewPanel
            // 
            this.PrintPreviewPanel.BackColor = System.Drawing.Color.MistyRose;
            this.PrintPreviewPanel.Controls.Add(this.R_PrintLayout);
            this.PrintPreviewPanel.Controls.Add(this.R_NLayout);
            this.PrintPreviewPanel.Controls.Add(this.R_Wlayout);
            this.PrintPreviewPanel.Location = new System.Drawing.Point(6, 67);
            this.PrintPreviewPanel.Name = "PrintPreviewPanel";
            this.PrintPreviewPanel.Size = new System.Drawing.Size(219, 49);
            this.PrintPreviewPanel.TabIndex = 12;
            // 
            // R_PrintLayout
            // 
            this.R_PrintLayout.AutoSize = true;
            this.R_PrintLayout.Location = new System.Drawing.Point(98, 4);
            this.R_PrintLayout.Name = "R_PrintLayout";
            this.R_PrintLayout.Size = new System.Drawing.Size(81, 17);
            this.R_PrintLayout.TabIndex = 2;
            this.R_PrintLayout.Text = "Print Layout";
            this.R_PrintLayout.UseVisualStyleBackColor = true;
            // 
            // R_NLayout
            // 
            this.R_NLayout.AutoSize = true;
            this.R_NLayout.Checked = true;
            this.R_NLayout.Location = new System.Drawing.Point(4, 26);
            this.R_NLayout.Name = "R_NLayout";
            this.R_NLayout.Size = new System.Drawing.Size(93, 17);
            this.R_NLayout.TabIndex = 1;
            this.R_NLayout.TabStop = true;
            this.R_NLayout.Text = "Normal Layout";
            this.R_NLayout.UseVisualStyleBackColor = true;
            // 
            // R_Wlayout
            // 
            this.R_Wlayout.AutoSize = true;
            this.R_Wlayout.Location = new System.Drawing.Point(4, 4);
            this.R_Wlayout.Name = "R_Wlayout";
            this.R_Wlayout.Size = new System.Drawing.Size(88, 17);
            this.R_Wlayout.TabIndex = 0;
            this.R_Wlayout.Text = "Width Layout";
            this.R_Wlayout.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Location = new System.Drawing.Point(5, 63);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(220, 1);
            this.panel4.TabIndex = 7;
            // 
            // ShowPrintPreview
            // 
            this.ShowPrintPreview.AutoSize = true;
            this.ShowPrintPreview.Checked = true;
            this.ShowPrintPreview.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowPrintPreview.Location = new System.Drawing.Point(6, 43);
            this.ShowPrintPreview.Name = "ShowPrintPreview";
            this.ShowPrintPreview.Size = new System.Drawing.Size(118, 17);
            this.ShowPrintPreview.TabIndex = 11;
            this.ShowPrintPreview.Text = "Show Print Preview";
            this.ShowPrintPreview.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ShowPrintPreview.UseVisualStyleBackColor = true;
            this.ShowPrintPreview.CheckedChanged += new System.EventHandler(this.ShowPrintPreview_CheckedChanged);
            // 
            // AutoTransaction
            // 
            this.AutoTransaction.AutoSize = true;
            this.AutoTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoTransaction.ForeColor = System.Drawing.Color.Red;
            this.AutoTransaction.Location = new System.Drawing.Point(5, 4);
            this.AutoTransaction.Name = "AutoTransaction";
            this.AutoTransaction.Size = new System.Drawing.Size(132, 17);
            this.AutoTransaction.TabIndex = 7;
            this.AutoTransaction.Text = "Auto New Transaction";
            this.AutoTransaction.UseVisualStyleBackColor = true;
            // 
            // AutoPrintInvoice
            // 
            this.AutoPrintInvoice.AutoSize = true;
            this.AutoPrintInvoice.Checked = true;
            this.AutoPrintInvoice.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AutoPrintInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoPrintInvoice.ForeColor = System.Drawing.Color.Green;
            this.AutoPrintInvoice.Location = new System.Drawing.Point(5, 23);
            this.AutoPrintInvoice.Name = "AutoPrintInvoice";
            this.AutoPrintInvoice.Size = new System.Drawing.Size(110, 17);
            this.AutoPrintInvoice.TabIndex = 8;
            this.AutoPrintInvoice.Text = "Auto Print Invoice";
            this.AutoPrintInvoice.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TransactionMode);
            this.panel1.Controls.Add(this.Remarks);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 73);
            this.panel1.TabIndex = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 76;
            this.label2.Text = "Modes";
            // 
            // TransactionMode
            // 
            this.TransactionMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TransactionMode.FormattingEnabled = true;
            this.TransactionMode.Items.AddRange(new object[] {
            "Cash",
            "Credit"});
            this.TransactionMode.Location = new System.Drawing.Point(54, 2);
            this.TransactionMode.Name = "TransactionMode";
            this.TransactionMode.Size = new System.Drawing.Size(173, 21);
            this.TransactionMode.TabIndex = 77;
            // 
            // Remarks
            // 
            this.Remarks.Location = new System.Drawing.Point(54, 29);
            this.Remarks.Name = "Remarks";
            this.Remarks.Size = new System.Drawing.Size(173, 38);
            this.Remarks.TabIndex = 79;
            this.Remarks.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 78;
            this.label6.Text = "Remarks";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Location = new System.Drawing.Point(341, 150);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 2);
            this.panel3.TabIndex = 75;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Snow;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(333, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 31);
            this.label5.TabIndex = 15;
            this.label5.Text = "Return Amount";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(331, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 31);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tender Amount";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ReturnAmount
            // 
            this.ReturnAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReturnAmount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ReturnAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReturnAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnAmount.Location = new System.Drawing.Point(532, 161);
            this.ReturnAmount.Name = "ReturnAmount";
            this.ReturnAmount.ReadOnly = true;
            this.ReturnAmount.Size = new System.Drawing.Size(238, 40);
            this.ReturnAmount.TabIndex = 13;
            this.ReturnAmount.Text = "0.00";
            // 
            // TenderAmount
            // 
            this.TenderAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TenderAmount.BackColor = System.Drawing.Color.Azure;
            this.TenderAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TenderAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenderAmount.Location = new System.Drawing.Point(532, 117);
            this.TenderAmount.Name = "TenderAmount";
            this.TenderAmount.Size = new System.Drawing.Size(238, 40);
            this.TenderAmount.TabIndex = 12;
            this.TenderAmount.Text = "0.00";
            this.TenderAmount.TextChanged += new System.EventHandler(this.TenderAmount_TextChanged);
            this.TenderAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TenderAmount_KeyDown);
            // 
            // Header_
            // 
            this.Header_.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Header_.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.Header_.Controls.Add(this.SampleDate);
            this.Header_.Controls.Add(this.BillNo);
            this.Header_.Controls.Add(this.label1);
            this.Header_.Controls.Add(this.EntryDate);
            this.Header_.Controls.Add(this.label3);
            this.Header_.Location = new System.Drawing.Point(5, 3);
            this.Header_.Name = "Header_";
            this.Header_.Size = new System.Drawing.Size(777, 30);
            this.Header_.TabIndex = 6;
            // 
            // SampleDate
            // 
            this.SampleDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SampleDate.BackColor = System.Drawing.Color.White;
            this.SampleDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SampleDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SampleDate.ForeColor = System.Drawing.Color.Black;
            this.SampleDate.Location = new System.Drawing.Point(665, 4);
            this.SampleDate.Name = "SampleDate";
            this.SampleDate.ReadOnly = true;
            this.SampleDate.Size = new System.Drawing.Size(108, 22);
            this.SampleDate.TabIndex = 5;
            // 
            // BillNo
            // 
            this.BillNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.BillNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BillNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillNo.ForeColor = System.Drawing.Color.Maroon;
            this.BillNo.Location = new System.Drawing.Point(75, 8);
            this.BillNo.Name = "BillNo";
            this.BillNo.ReadOnly = true;
            this.BillNo.Size = new System.Drawing.Size(268, 15);
            this.BillNo.TabIndex = 0;
            this.BillNo.Text = "101";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoice No.";
            // 
            // EntryDate
            // 
            this.EntryDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EntryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EntryDate.Location = new System.Drawing.Point(521, 4);
            this.EntryDate.Name = "EntryDate";
            this.EntryDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EntryDate.Size = new System.Drawing.Size(106, 20);
            this.EntryDate.TabIndex = 1;
            this.EntryDate.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(633, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.BillSavedMessage);
            this.panel6.Controls.Add(this.PrintPreview);
            this.panel6.Controls.Add(this.Clear);
            this.panel6.Controls.Add(this.Save);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 535);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(787, 46);
            this.panel6.TabIndex = 11;
            // 
            // BillSavedMessage
            // 
            this.BillSavedMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BillSavedMessage.Controls.Add(this.label11);
            this.BillSavedMessage.Location = new System.Drawing.Point(315, 4);
            this.BillSavedMessage.Name = "BillSavedMessage";
            this.BillSavedMessage.Size = new System.Drawing.Size(160, 38);
            this.BillSavedMessage.TabIndex = 7;
            this.BillSavedMessage.Visible = false;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkRed;
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 38);
            this.label11.TabIndex = 0;
            this.label11.Text = "Invoice Data Saved";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PrintPreview
            // 
            this.PrintPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PrintPreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrintPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintPreview.ForeColor = System.Drawing.Color.Black;
            this.PrintPreview.Image = global::MartSolution.Properties.Resources.print;
            this.PrintPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PrintPreview.Location = new System.Drawing.Point(634, 1);
            this.PrintPreview.Name = "PrintPreview";
            this.PrintPreview.Size = new System.Drawing.Size(148, 44);
            this.PrintPreview.TabIndex = 6;
            this.PrintPreview.Text = "&PrintPreview";
            this.PrintPreview.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PrintPreview.UseVisualStyleBackColor = true;
            this.PrintPreview.Click += new System.EventHandler(this.PrintPreview_Click);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.ForeColor = System.Drawing.Color.Blue;
            this.Clear.Image = global::MartSolution.Properties.Resources.recycle;
            this.Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Clear.Location = new System.Drawing.Point(106, 1);
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
            this.Save.Enabled = false;
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ForeColor = System.Drawing.Color.Green;
            this.Save.Image = global::MartSolution.Properties.Resources.add;
            this.Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Save.Location = new System.Drawing.Point(5, 1);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(95, 44);
            this.Save.TabIndex = 0;
            this.Save.Text = "&Save";
            this.Save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // ItemInPanel
            // 
            this.ItemInPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemInPanel.BackColor = System.Drawing.Color.White;
            this.ItemInPanel.Controls.Add(this.panel8);
            this.ItemInPanel.Controls.Add(this._AutoAdd);
            this.ItemInPanel.Controls.Add(this.label8);
            this.ItemInPanel.Controls.Add(this.label10);
            this.ItemInPanel.Controls.Add(this.label9);
            this.ItemInPanel.Controls.Add(this.QuantityData);
            this.ItemInPanel.Controls.Add(this.label7);
            this.ItemInPanel.Controls.Add(this._InputCode);
            this.ItemInPanel.Controls.Add(this.InputCodeDisplaySelected);
            this.ItemInPanel.Location = new System.Drawing.Point(5, 35);
            this.ItemInPanel.Name = "ItemInPanel";
            this.ItemInPanel.Size = new System.Drawing.Size(776, 82);
            this.ItemInPanel.TabIndex = 8;
            // 
            // _AutoAdd
            // 
            this._AutoAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._AutoAdd.AutoSize = true;
            this._AutoAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this._AutoAdd.Checked = true;
            this._AutoAdd.CheckState = System.Windows.Forms.CheckState.Checked;
            this._AutoAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._AutoAdd.Location = new System.Drawing.Point(522, 55);
            this._AutoAdd.Name = "_AutoAdd";
            this._AutoAdd.Size = new System.Drawing.Size(70, 17);
            this._AutoAdd.TabIndex = 85;
            this._AutoAdd.Text = "Auto Add\r\n";
            this._AutoAdd.UseVisualStyleBackColor = false;
            // 
            // ReloadItemNameAutoComplete
            // 
            this.ReloadItemNameAutoComplete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReloadItemNameAutoComplete.Dock = System.Windows.Forms.DockStyle.Left;
            this.ReloadItemNameAutoComplete.Enabled = false;
            this.ReloadItemNameAutoComplete.Image = global::MartSolution.Properties.Resources.refresh;
            this.ReloadItemNameAutoComplete.Location = new System.Drawing.Point(253, 1);
            this.ReloadItemNameAutoComplete.Name = "ReloadItemNameAutoComplete";
            this.ReloadItemNameAutoComplete.Size = new System.Drawing.Size(25, 22);
            this.ReloadItemNameAutoComplete.TabIndex = 84;
            this.toolTip1.SetToolTip(this.ReloadItemNameAutoComplete, "Reload Item Name (Refresh)");
            this.ReloadItemNameAutoComplete.UseVisualStyleBackColor = true;
            this.ReloadItemNameAutoComplete.Visible = false;
            this.ReloadItemNameAutoComplete.Click += new System.EventHandler(this.ReloadItemNameAutoComplete_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(19, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 13);
            this.label8.TabIndex = 83;
            this.label8.Text = "Use ( F4 or ALT + i  )";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(23, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 13);
            this.label10.TabIndex = 82;
            this.label10.Text = "Use (ALT + 1 or 2 or 3)";
            // 
            // S_ItemName
            // 
            this.S_ItemName.AutoSize = true;
            this.S_ItemName.Dock = System.Windows.Forms.DockStyle.Left;
            this.S_ItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S_ItemName.Location = new System.Drawing.Point(172, 1);
            this.S_ItemName.Name = "S_ItemName";
            this.S_ItemName.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.S_ItemName.Size = new System.Drawing.Size(81, 22);
            this.S_ItemName.TabIndex = 81;
            this.S_ItemName.Text = "Item Name";
            this.toolTip1.SetToolTip(this.S_ItemName, "Item Name ( ALT + 3 )");
            this.S_ItemName.UseVisualStyleBackColor = true;
            this.S_ItemName.CheckedChanged += new System.EventHandler(this.S_ItemName_CheckedChanged);
            // 
            // S_ItemCode
            // 
            this.S_ItemCode.AutoSize = true;
            this.S_ItemCode.Dock = System.Windows.Forms.DockStyle.Left;
            this.S_ItemCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S_ItemCode.Location = new System.Drawing.Point(94, 1);
            this.S_ItemCode.Name = "S_ItemCode";
            this.S_ItemCode.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.S_ItemCode.Size = new System.Drawing.Size(78, 22);
            this.S_ItemCode.TabIndex = 80;
            this.S_ItemCode.Text = "Item Code";
            this.toolTip1.SetToolTip(this.S_ItemCode, "Item Code ( ALT + 2 )");
            this.S_ItemCode.UseVisualStyleBackColor = true;
            this.S_ItemCode.CheckedChanged += new System.EventHandler(this.S_ItemCode_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(45, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 79;
            this.label9.Text = "Selection Mode";
            // 
            // S_ItemBarCode
            // 
            this.S_ItemBarCode.AutoSize = true;
            this.S_ItemBarCode.BackColor = System.Drawing.Color.Bisque;
            this.S_ItemBarCode.Checked = true;
            this.S_ItemBarCode.Dock = System.Windows.Forms.DockStyle.Left;
            this.S_ItemBarCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S_ItemBarCode.Location = new System.Drawing.Point(1, 1);
            this.S_ItemBarCode.Name = "S_ItemBarCode";
            this.S_ItemBarCode.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.S_ItemBarCode.Size = new System.Drawing.Size(93, 22);
            this.S_ItemBarCode.TabIndex = 78;
            this.S_ItemBarCode.TabStop = true;
            this.S_ItemBarCode.Text = "Item Barcode";
            this.toolTip1.SetToolTip(this.S_ItemBarCode, "Item Barcode ( ALT + 1 )");
            this.S_ItemBarCode.UseVisualStyleBackColor = false;
            this.S_ItemBarCode.CheckedChanged += new System.EventHandler(this.S_BarCode_CheckedChanged);
            // 
            // QuantityData
            // 
            this.QuantityData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.QuantityData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityData.Location = new System.Drawing.Point(655, 50);
            this.QuantityData.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.QuantityData.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.QuantityData.Name = "QuantityData";
            this.QuantityData.Size = new System.Drawing.Size(118, 26);
            this.QuantityData.TabIndex = 1;
            this.QuantityData.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.QuantityData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.QuantityData_KeyDown);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(593, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 15);
            this.label7.TabIndex = 77;
            this.label7.Text = "Quantity";
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel7.Location = new System.Drawing.Point(7, 533);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(775, 1);
            this.panel7.TabIndex = 83;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // BillMessageTimer
            // 
            this.BillMessageTimer.Interval = 1200;
            this.BillMessageTimer.Tick += new System.EventHandler(this.BillMessageTimer_Tick);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.ReloadItemNameAutoComplete);
            this.panel8.Controls.Add(this.S_ItemName);
            this.panel8.Controls.Add(this.S_ItemCode);
            this.panel8.Controls.Add(this.S_ItemBarCode);
            this.panel8.Location = new System.Drawing.Point(144, 51);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(1);
            this.panel8.Size = new System.Drawing.Size(372, 24);
            this.panel8.TabIndex = 86;
            // 
            // BillInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(787, 581);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.Main_);
            this.Controls.Add(this.Footer);
            this.Controls.Add(this.Header_);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.ItemInPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(803, 620);
            this.Name = "BillInvoice";
            this.Text = "Bill Invoice";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BillInvoice_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BillInvoice_FormClosed);
            this.Load += new System.EventHandler(this.BillInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BGrid)).EndInit();
            this.Main_.ResumeLayout(false);
            this.Main_.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisAmountVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisPercentageVal)).EndInit();
            this.Footer.ResumeLayout(false);
            this.Footer.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.PrintPreviewPanel.ResumeLayout(false);
            this.PrintPreviewPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Header_.ResumeLayout(false);
            this.Header_.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.BillSavedMessage.ResumeLayout(false);
            this.ItemInPanel.ResumeLayout(false);
            this.ItemInPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityData)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView BGrid;
        private System.Windows.Forms.Panel Main_;
        private System.Windows.Forms.Label InputCodeDisplaySelected;
        private System.Windows.Forms.TextBox _InputCode;
        private System.Windows.Forms.RadioButton DisAmount;
        private System.Windows.Forms.RadioButton DisPercentage;
        private System.Windows.Forms.NumericUpDown DisAmountVal;
        private System.Windows.Forms.NumericUpDown DisPercentageVal;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox GrandTotal;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label TLabel;
        private System.Windows.Forms.TextBox GrossTotal;
        private System.Windows.Forms.Panel Footer;
        private System.Windows.Forms.Panel Header_;
        private System.Windows.Forms.TextBox BillNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker EntryDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button PrintPreview;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel ItemInPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ReturnAmount;
        private System.Windows.Forms.TextBox TenderAmount;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox TransactionMode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox Remarks;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox AutoTransaction;
        private System.Windows.Forms.CheckBox AutoPrintInvoice;
        private System.Windows.Forms.CheckBox ShowPrintPreview;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown QuantityData;
        private System.Windows.Forms.CheckBox RemoveAll;
        private System.Windows.Forms.DataGridViewImageColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel PrintPreviewPanel;
        private System.Windows.Forms.RadioButton R_NLayout;
        private System.Windows.Forms.RadioButton R_Wlayout;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.RadioButton R_PrintLayout;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton S_ItemBarCode;
        private System.Windows.Forms.RadioButton S_ItemName;
        private System.Windows.Forms.RadioButton S_ItemCode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox SampleDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ReloadItemNameAutoComplete;
        private System.Windows.Forms.CheckBox _AutoAdd;
        private System.Windows.Forms.Timer BillMessageTimer;
        private System.Windows.Forms.Panel BillSavedMessage;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel8;

    }
}