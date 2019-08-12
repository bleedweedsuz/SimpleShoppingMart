namespace MartSolution.Master
{
    partial class ItemInformation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemInformation));
            this.SearchText = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.IGrid = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.Delete = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Code = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.IID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ItemCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Description = new System.Windows.Forms.RichTextBox();
            this.NameText = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CheckGarbage = new System.Windows.Forms.CheckBox();
            this.CategoryPanel = new System.Windows.Forms.Panel();
            this.Unit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TTip = new System.Windows.Forms.ToolTip(this.components);
            this.RefreshCategoryList = new System.Windows.Forms.PictureBox();
            this.AddItemCategory = new System.Windows.Forms.PictureBox();
            this.ItemCodeClear = new System.Windows.Forms.Button();
            this.BarcodeClear = new System.Windows.Forms.Button();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DQuantity = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BarCode = new System.Windows.Forms.TextBox();
            this.SearchPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.IGrid)).BeginInit();
            this.buttonPanel.SuspendLayout();
            this.CategoryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshCategoryList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddItemCategory)).BeginInit();
            this.inputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DQuantity)).BeginInit();
            this.SearchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchText
            // 
            this.SearchText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchText.Location = new System.Drawing.Point(97, 6);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(499, 20);
            this.SearchText.TabIndex = 10;
            this.SearchText.Tag = "2";
            this.SearchText.TextChanged += new System.EventHandler(this.SearchText_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(8, 7);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 15);
            this.label15.TabIndex = 77;
            this.label15.Text = "Search [Name]";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(20, 216);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 15);
            this.label13.TabIndex = 72;
            this.label13.Text = "Detail Description";
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
            this.Column7,
            this.Column6,
            this.Column2,
            this.Column3,
            this.Column9,
            this.Column4,
            this.Column8,
            this.Column10,
            this.Column5,
            this.Column1});
            this.IGrid.Location = new System.Drawing.Point(5, 46);
            this.IGrid.MultiSelect = false;
            this.IGrid.Name = "IGrid";
            this.IGrid.RowHeadersVisible = false;
            this.IGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.IGrid.Size = new System.Drawing.Size(591, 370);
            this.IGrid.TabIndex = 12;
            this.IGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.IGrid_CellClick);
            // 
            // Column7
            // 
            this.Column7.HeaderText = "CID";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Category";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Item ID";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ITEM CODE";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 130;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "BARCODE";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 120;
            // 
            // Column4
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Column4.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column4.HeaderText = "Name";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Unit";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Default Quantity";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 120;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Detail Description";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 180;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "IStatus";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // buttonPanel
            // 
            this.buttonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonPanel.Controls.Add(this.Delete);
            this.buttonPanel.Controls.Add(this.Clear);
            this.buttonPanel.Controls.Add(this.Save);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonPanel.Location = new System.Drawing.Point(0, 419);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(922, 53);
            this.buttonPanel.TabIndex = 9;
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
            // Code
            // 
            this.Code.Location = new System.Drawing.Point(105, 91);
            this.Code.MaxLength = 6;
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(170, 20);
            this.Code.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 15);
            this.label6.TabIndex = 61;
            this.label6.Text = "Item CODE**";
            // 
            // IID
            // 
            this.IID.Location = new System.Drawing.Point(105, 40);
            this.IID.Name = "IID";
            this.IID.ReadOnly = true;
            this.IID.Size = new System.Drawing.Size(213, 20);
            this.IID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 45;
            this.label1.Text = "Item ID";
            // 
            // ItemCategory
            // 
            this.ItemCategory.BackColor = System.Drawing.SystemColors.Control;
            this.ItemCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ItemCategory.FormattingEnabled = true;
            this.ItemCategory.Location = new System.Drawing.Point(4, 3);
            this.ItemCategory.Name = "ItemCategory";
            this.ItemCategory.Size = new System.Drawing.Size(152, 21);
            this.ItemCategory.TabIndex = 1;
            this.ItemCategory.SelectedIndexChanged += new System.EventHandler(this.ItemCategory_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 80;
            this.label2.Text = "Category";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(10, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(306, 1);
            this.panel2.TabIndex = 81;
            // 
            // Description
            // 
            this.Description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Description.Location = new System.Drawing.Point(18, 233);
            this.Description.MaxLength = 200;
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(299, 180);
            this.Description.TabIndex = 8;
            this.Description.Text = "";
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(105, 65);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(213, 20);
            this.NameText.TabIndex = 3;
            this.NameText.Tag = "2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(57, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 15);
            this.label11.TabIndex = 71;
            this.label11.Text = "Name*";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(10, 208);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 1);
            this.panel1.TabIndex = 82;
            // 
            // CheckGarbage
            // 
            this.CheckGarbage.AutoSize = true;
            this.CheckGarbage.ForeColor = System.Drawing.Color.Red;
            this.CheckGarbage.Location = new System.Drawing.Point(97, 29);
            this.CheckGarbage.Name = "CheckGarbage";
            this.CheckGarbage.Size = new System.Drawing.Size(179, 17);
            this.CheckGarbage.TabIndex = 11;
            this.CheckGarbage.Text = "Include Deleted Item Information";
            this.CheckGarbage.UseVisualStyleBackColor = true;
            this.CheckGarbage.CheckedChanged += new System.EventHandler(this.CheckGarbage_CheckedChanged);
            // 
            // CategoryPanel
            // 
            this.CategoryPanel.Controls.Add(this.ItemCategory);
            this.CategoryPanel.Location = new System.Drawing.Point(105, 2);
            this.CategoryPanel.Name = "CategoryPanel";
            this.CategoryPanel.Size = new System.Drawing.Size(159, 27);
            this.CategoryPanel.TabIndex = 0;
            // 
            // Unit
            // 
            this.Unit.Location = new System.Drawing.Point(105, 143);
            this.Unit.Name = "Unit";
            this.Unit.Size = new System.Drawing.Size(213, 20);
            this.Unit.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 86;
            this.label3.Text = "Unit*";
            // 
            // TTip
            // 
            this.TTip.AutoPopDelay = 5000;
            this.TTip.InitialDelay = 100;
            this.TTip.IsBalloon = true;
            this.TTip.ReshowDelay = 100;
            // 
            // RefreshCategoryList
            // 
            this.RefreshCategoryList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RefreshCategoryList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshCategoryList.Image = global::MartSolution.Properties.Resources.Reset;
            this.RefreshCategoryList.Location = new System.Drawing.Point(267, 3);
            this.RefreshCategoryList.Name = "RefreshCategoryList";
            this.RefreshCategoryList.Size = new System.Drawing.Size(25, 25);
            this.RefreshCategoryList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.RefreshCategoryList.TabIndex = 84;
            this.RefreshCategoryList.TabStop = false;
            this.TTip.SetToolTip(this.RefreshCategoryList, "Reload Category List [Ctrl + R]");
            this.RefreshCategoryList.Click += new System.EventHandler(this.RefreshCategoryList_Click);
            // 
            // AddItemCategory
            // 
            this.AddItemCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddItemCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddItemCategory.Image = global::MartSolution.Properties.Resources.add_2;
            this.AddItemCategory.Location = new System.Drawing.Point(293, 3);
            this.AddItemCategory.Name = "AddItemCategory";
            this.AddItemCategory.Size = new System.Drawing.Size(25, 25);
            this.AddItemCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.AddItemCategory.TabIndex = 79;
            this.AddItemCategory.TabStop = false;
            this.TTip.SetToolTip(this.AddItemCategory, "Add New Category [Ctrl + N]");
            this.AddItemCategory.Click += new System.EventHandler(this.AddItemCategory_Click);
            // 
            // ItemCodeClear
            // 
            this.ItemCodeClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ItemCodeClear.Image = global::MartSolution.Properties.Resources.clear_2;
            this.ItemCodeClear.Location = new System.Drawing.Point(279, 89);
            this.ItemCodeClear.Name = "ItemCodeClear";
            this.ItemCodeClear.Size = new System.Drawing.Size(24, 24);
            this.ItemCodeClear.TabIndex = 92;
            this.TTip.SetToolTip(this.ItemCodeClear, "Item Code Clear");
            this.ItemCodeClear.UseVisualStyleBackColor = true;
            this.ItemCodeClear.Click += new System.EventHandler(this.ItemCodeClear_Click);
            // 
            // BarcodeClear
            // 
            this.BarcodeClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BarcodeClear.Image = global::MartSolution.Properties.Resources.clear_2;
            this.BarcodeClear.Location = new System.Drawing.Point(279, 115);
            this.BarcodeClear.Name = "BarcodeClear";
            this.BarcodeClear.Size = new System.Drawing.Size(24, 24);
            this.BarcodeClear.TabIndex = 93;
            this.TTip.SetToolTip(this.BarcodeClear, "Barcode Clear");
            this.BarcodeClear.UseVisualStyleBackColor = true;
            this.BarcodeClear.Click += new System.EventHandler(this.BarcodeClear_Click);
            // 
            // inputPanel
            // 
            this.inputPanel.Controls.Add(this.BarcodeClear);
            this.inputPanel.Controls.Add(this.ItemCodeClear);
            this.inputPanel.Controls.Add(this.pictureBox1);
            this.inputPanel.Controls.Add(this.DQuantity);
            this.inputPanel.Controls.Add(this.label5);
            this.inputPanel.Controls.Add(this.label4);
            this.inputPanel.Controls.Add(this.BarCode);
            this.inputPanel.Controls.Add(this.AddItemCategory);
            this.inputPanel.Controls.Add(this.Unit);
            this.inputPanel.Controls.Add(this.label1);
            this.inputPanel.Controls.Add(this.label3);
            this.inputPanel.Controls.Add(this.IID);
            this.inputPanel.Controls.Add(this.CategoryPanel);
            this.inputPanel.Controls.Add(this.label6);
            this.inputPanel.Controls.Add(this.RefreshCategoryList);
            this.inputPanel.Controls.Add(this.Code);
            this.inputPanel.Controls.Add(this.label11);
            this.inputPanel.Controls.Add(this.NameText);
            this.inputPanel.Controls.Add(this.Description);
            this.inputPanel.Controls.Add(this.label13);
            this.inputPanel.Controls.Add(this.panel1);
            this.inputPanel.Controls.Add(this.label2);
            this.inputPanel.Controls.Add(this.panel2);
            this.inputPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.inputPanel.Location = new System.Drawing.Point(0, 0);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(323, 419);
            this.inputPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MartSolution.Properties.Resources.GroupBox;
            this.pictureBox1.Location = new System.Drawing.Point(306, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 91;
            this.pictureBox1.TabStop = false;
            // 
            // DQuantity
            // 
            this.DQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DQuantity.Location = new System.Drawing.Point(105, 171);
            this.DQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DQuantity.Name = "DQuantity";
            this.DQuantity.Size = new System.Drawing.Size(213, 21);
            this.DQuantity.TabIndex = 7;
            this.DQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 90;
            this.label5.Text = "Default Quantity*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 88;
            this.label4.Text = "BARCODE**";
            // 
            // BarCode
            // 
            this.BarCode.Location = new System.Drawing.Point(105, 117);
            this.BarCode.Name = "BarCode";
            this.BarCode.Size = new System.Drawing.Size(170, 20);
            this.BarCode.TabIndex = 5;
            // 
            // SearchPanel
            // 
            this.SearchPanel.Controls.Add(this.label15);
            this.SearchPanel.Controls.Add(this.IGrid);
            this.SearchPanel.Controls.Add(this.CheckGarbage);
            this.SearchPanel.Controls.Add(this.SearchText);
            this.SearchPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchPanel.Location = new System.Drawing.Point(323, 0);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(599, 419);
            this.SearchPanel.TabIndex = 78;
            // 
            // ItemInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(922, 472);
            this.Controls.Add(this.SearchPanel);
            this.Controls.Add(this.inputPanel);
            this.Controls.Add(this.buttonPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(850, 400);
            this.Name = "ItemInformation";
            this.Text = "Item Information";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ItemInformation_FormClosed);
            this.Load += new System.EventHandler(this.ItemInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IGrid)).EndInit();
            this.buttonPanel.ResumeLayout(false);
            this.CategoryPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RefreshCategoryList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddItemCategory)).EndInit();
            this.inputPanel.ResumeLayout(false);
            this.inputPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DQuantity)).EndInit();
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView IGrid;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.TextBox Code;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox IID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ItemCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox Description;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox AddItemCategory;
        private System.Windows.Forms.CheckBox CheckGarbage;
        private System.Windows.Forms.PictureBox RefreshCategoryList;
        private System.Windows.Forms.Panel CategoryPanel;
        private System.Windows.Forms.TextBox Unit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip TTip;
        private System.Windows.Forms.Panel inputPanel;
        private System.Windows.Forms.Panel SearchPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox BarCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown DQuantity;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BarcodeClear;
        private System.Windows.Forms.Button ItemCodeClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}