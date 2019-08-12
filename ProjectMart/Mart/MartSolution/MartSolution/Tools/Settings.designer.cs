namespace MartSolution
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.mode_ = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imgtextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BBrowseBtn = new System.Windows.Forms.Button();
            this.TControlTabs = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.U_FormState = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.U_FormMode = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.U_Update = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.B_AutoPrintINvoice = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.B_AutoNewTransaction = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.B_ShowPrintPreViewAfterSave = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BillPrinting_Update = new System.Windows.Forms.Button();
            this.B_BRWidthVal = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Barcode_Update = new System.Windows.Forms.Button();
            this.bLimitVal = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BClearBtn = new System.Windows.Forms.Button();
            this.BSave = new System.Windows.Forms.Button();
            this.TControlTabs.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.B_BRWidthVal)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bLimitVal)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mode_
            // 
            this.mode_.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mode_.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mode_.FormattingEnabled = true;
            this.mode_.Items.AddRange(new object[] {
            "None",
            "Center",
            "Stretch",
            "Tile",
            "Zoom"});
            this.mode_.Location = new System.Drawing.Point(145, 32);
            this.mode_.Name = "mode_";
            this.mode_.Size = new System.Drawing.Size(151, 21);
            this.mode_.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Background Image Setting";
            // 
            // imgtextbox
            // 
            this.imgtextbox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.imgtextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgtextbox.Location = new System.Drawing.Point(145, 6);
            this.imgtextbox.Name = "imgtextbox";
            this.imgtextbox.ReadOnly = true;
            this.imgtextbox.Size = new System.Drawing.Size(151, 20);
            this.imgtextbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Background Image";
            // 
            // BBrowseBtn
            // 
            this.BBrowseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BBrowseBtn.Location = new System.Drawing.Point(302, 5);
            this.BBrowseBtn.Name = "BBrowseBtn";
            this.BBrowseBtn.Size = new System.Drawing.Size(60, 23);
            this.BBrowseBtn.TabIndex = 5;
            this.BBrowseBtn.Text = "browse..";
            this.BBrowseBtn.UseVisualStyleBackColor = true;
            this.BBrowseBtn.Click += new System.EventHandler(this.BBrowseBtn_Click);
            // 
            // TControlTabs
            // 
            this.TControlTabs.Controls.Add(this.tabPage2);
            this.TControlTabs.Controls.Add(this.tabPage1);
            this.TControlTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TControlTabs.Location = new System.Drawing.Point(2, 2);
            this.TControlTabs.Name = "TControlTabs";
            this.TControlTabs.SelectedIndex = 0;
            this.TControlTabs.Size = new System.Drawing.Size(410, 317);
            this.TControlTabs.TabIndex = 7;
            this.TControlTabs.SelectedIndexChanged += new System.EventHandler(this.TControlTabs_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(402, 291);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Options";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(2, 275);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(255, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Note * To work properly you must resstart application";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.U_FormState);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.U_FormMode);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.U_Update);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(2, 189);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(398, 80);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "User Interface Setting";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(293, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 45);
            this.panel1.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(16, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(4, 37);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(20, 4);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(20, 4);
            this.panel2.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Maroon;
            this.label11.Location = new System.Drawing.Point(204, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 12);
            this.label11.TabIndex = 8;
            this.label11.Text = "default = Max / Full";
            // 
            // U_FormState
            // 
            this.U_FormState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.U_FormState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.U_FormState.FormattingEnabled = true;
            this.U_FormState.Items.AddRange(new object[] {
            "Normal",
            "Max / Full"});
            this.U_FormState.Location = new System.Drawing.Point(74, 48);
            this.U_FormState.Name = "U_FormState";
            this.U_FormState.Size = new System.Drawing.Size(127, 21);
            this.U_FormState.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Form State";
            // 
            // U_FormMode
            // 
            this.U_FormMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.U_FormMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.U_FormMode.FormattingEnabled = true;
            this.U_FormMode.Items.AddRange(new object[] {
            "Single",
            "Multiple"});
            this.U_FormMode.Location = new System.Drawing.Point(74, 21);
            this.U_FormMode.Name = "U_FormMode";
            this.U_FormMode.Size = new System.Drawing.Size(127, 21);
            this.U_FormMode.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(204, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "default = Single";
            // 
            // U_Update
            // 
            this.U_Update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.U_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.U_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.U_Update.Image = ((System.Drawing.Image)(resources.GetObject("U_Update.Image")));
            this.U_Update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.U_Update.Location = new System.Drawing.Point(319, 31);
            this.U_Update.Name = "U_Update";
            this.U_Update.Size = new System.Drawing.Size(75, 24);
            this.U_Update.TabIndex = 3;
            this.U_Update.Text = "Update";
            this.U_Update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.U_Update.UseVisualStyleBackColor = true;
            this.U_Update.Click += new System.EventHandler(this.U_Update_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Form Mode";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Controls.Add(this.B_AutoPrintINvoice);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.B_AutoNewTransaction);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.B_ShowPrintPreViewAfterSave);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.BillPrinting_Update);
            this.groupBox2.Controls.Add(this.B_BRWidthVal);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(2, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 136);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BIll Receipt (Preview) Setting";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Location = new System.Drawing.Point(293, 28);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(20, 80);
            this.panel5.TabIndex = 11;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(16, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(4, 72);
            this.panel6.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 76);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(20, 4);
            this.panel7.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Black;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(20, 4);
            this.panel8.TabIndex = 0;
            // 
            // B_AutoPrintINvoice
            // 
            this.B_AutoPrintINvoice.AutoSize = true;
            this.B_AutoPrintINvoice.Checked = true;
            this.B_AutoPrintINvoice.CheckState = System.Windows.Forms.CheckState.Checked;
            this.B_AutoPrintINvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_AutoPrintINvoice.ForeColor = System.Drawing.Color.Maroon;
            this.B_AutoPrintINvoice.Location = new System.Drawing.Point(155, 72);
            this.B_AutoPrintINvoice.Name = "B_AutoPrintINvoice";
            this.B_AutoPrintINvoice.Size = new System.Drawing.Size(141, 16);
            this.B_AutoPrintINvoice.TabIndex = 10;
            this.B_AutoPrintINvoice.Text = "default = True ( i.e. checked )";
            this.B_AutoPrintINvoice.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(7, 72);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Auto Print Invoice";
            // 
            // B_AutoNewTransaction
            // 
            this.B_AutoNewTransaction.AutoSize = true;
            this.B_AutoNewTransaction.Checked = true;
            this.B_AutoNewTransaction.CheckState = System.Windows.Forms.CheckState.Checked;
            this.B_AutoNewTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_AutoNewTransaction.ForeColor = System.Drawing.Color.Maroon;
            this.B_AutoNewTransaction.Location = new System.Drawing.Point(155, 50);
            this.B_AutoNewTransaction.Name = "B_AutoNewTransaction";
            this.B_AutoNewTransaction.Size = new System.Drawing.Size(141, 16);
            this.B_AutoNewTransaction.TabIndex = 8;
            this.B_AutoNewTransaction.Text = "default = True ( i.e. checked )";
            this.B_AutoNewTransaction.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(7, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Auto New Transaction";
            // 
            // B_ShowPrintPreViewAfterSave
            // 
            this.B_ShowPrintPreViewAfterSave.AutoSize = true;
            this.B_ShowPrintPreViewAfterSave.Checked = true;
            this.B_ShowPrintPreViewAfterSave.CheckState = System.Windows.Forms.CheckState.Checked;
            this.B_ShowPrintPreViewAfterSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_ShowPrintPreViewAfterSave.ForeColor = System.Drawing.Color.Maroon;
            this.B_ShowPrintPreViewAfterSave.Location = new System.Drawing.Point(155, 95);
            this.B_ShowPrintPreViewAfterSave.Name = "B_ShowPrintPreViewAfterSave";
            this.B_ShowPrintPreViewAfterSave.Size = new System.Drawing.Size(141, 16);
            this.B_ShowPrintPreViewAfterSave.TabIndex = 6;
            this.B_ShowPrintPreViewAfterSave.Text = "default = True ( i.e. checked )";
            this.B_ShowPrintPreViewAfterSave.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(7, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 26);
            this.label12.TabIndex = 5;
            this.label12.Text = "Show Receipt Preview After\r\nSave";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(230, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "default = 105";
            // 
            // BillPrinting_Update
            // 
            this.BillPrinting_Update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BillPrinting_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BillPrinting_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillPrinting_Update.Image = ((System.Drawing.Image)(resources.GetObject("BillPrinting_Update.Image")));
            this.BillPrinting_Update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BillPrinting_Update.Location = new System.Drawing.Point(319, 57);
            this.BillPrinting_Update.Name = "BillPrinting_Update";
            this.BillPrinting_Update.Size = new System.Drawing.Size(75, 24);
            this.BillPrinting_Update.TabIndex = 3;
            this.BillPrinting_Update.Text = "Update";
            this.BillPrinting_Update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BillPrinting_Update.UseVisualStyleBackColor = true;
            this.BillPrinting_Update.Click += new System.EventHandler(this.BillPrinting_Update_Click);
            // 
            // B_BRWidthVal
            // 
            this.B_BRWidthVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_BRWidthVal.Location = new System.Drawing.Point(155, 24);
            this.B_BRWidthVal.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.B_BRWidthVal.Name = "B_BRWidthVal";
            this.B_BRWidthVal.Size = new System.Drawing.Size(69, 20);
            this.B_BRWidthVal.TabIndex = 1;
            this.B_BRWidthVal.Value = new decimal(new int[] {
            105,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Printing Scale Width  ( px )";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Barcode_Update);
            this.groupBox1.Controls.Add(this.bLimitVal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 51);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Barcode Setting";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(195, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "default = 5";
            // 
            // Barcode_Update
            // 
            this.Barcode_Update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Barcode_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Barcode_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Barcode_Update.Image = global::MartSolution.Properties.Resources.add_2;
            this.Barcode_Update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Barcode_Update.Location = new System.Drawing.Point(319, 21);
            this.Barcode_Update.Name = "Barcode_Update";
            this.Barcode_Update.Size = new System.Drawing.Size(75, 24);
            this.Barcode_Update.TabIndex = 2;
            this.Barcode_Update.Text = "Update";
            this.Barcode_Update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Barcode_Update.UseVisualStyleBackColor = true;
            this.Barcode_Update.Click += new System.EventHandler(this.Barcode_Update_Click);
            // 
            // bLimitVal
            // 
            this.bLimitVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLimitVal.Location = new System.Drawing.Point(128, 23);
            this.bLimitVal.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.bLimitVal.Name = "bLimitVal";
            this.bLimitVal.Size = new System.Drawing.Size(61, 20);
            this.bLimitVal.TabIndex = 1;
            this.bLimitVal.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Barcode Minimum Limit";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.mode_);
            this.tabPage1.Controls.Add(this.BBrowseBtn);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.imgtextbox);
            this.tabPage1.Controls.Add(this.BClearBtn);
            this.tabPage1.Controls.Add(this.BSave);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(402, 291);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Background Setting";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BClearBtn
            // 
            this.BClearBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BClearBtn.Image = global::MartSolution.Properties.Resources.Reset;
            this.BClearBtn.Location = new System.Drawing.Point(368, 5);
            this.BClearBtn.Name = "BClearBtn";
            this.BClearBtn.Size = new System.Drawing.Size(29, 23);
            this.BClearBtn.TabIndex = 6;
            this.BClearBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BClearBtn.UseVisualStyleBackColor = true;
            this.BClearBtn.Click += new System.EventHandler(this.BClearBtn_Click);
            // 
            // BSave
            // 
            this.BSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BSave.Image = global::MartSolution.Properties.Resources.add_2;
            this.BSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BSave.Location = new System.Drawing.Point(145, 59);
            this.BSave.Name = "BSave";
            this.BSave.Size = new System.Drawing.Size(61, 31);
            this.BSave.TabIndex = 2;
            this.BSave.Text = "Save";
            this.BSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BSave.UseVisualStyleBackColor = true;
            this.BSave.Click += new System.EventHandler(this.BSave_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(414, 321);
            this.Controls.Add(this.TControlTabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.BackgroundImageSetting_Load);
            this.TControlTabs.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.B_BRWidthVal)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bLimitVal)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox mode_;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BSave;
        private System.Windows.Forms.TextBox imgtextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BBrowseBtn;
        private System.Windows.Forms.Button BClearBtn;
        private System.Windows.Forms.TabControl TControlTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown bLimitVal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown B_BRWidthVal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Barcode_Update;
        private System.Windows.Forms.Button BillPrinting_Update;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button U_Update;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox U_FormMode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox U_FormState;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox B_ShowPrintPreViewAfterSave;
        private System.Windows.Forms.CheckBox B_AutoNewTransaction;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox B_AutoPrintINvoice;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
    }
}