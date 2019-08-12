namespace MartSolution.Report
{
    partial class AllReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllReportForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ShowPrintLayout = new System.Windows.Forms.CheckBox();
            this.PBar = new CircularProgressBar.CircularProgressBar();
            this.panel5 = new System.Windows.Forms.Panel();
            this.RunBtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TransactionPanel = new System.Windows.Forms.Panel();
            this.TransactionG = new System.Windows.Forms.GroupBox();
            this.TransactionMode = new System.Windows.Forms.ComboBox();
            this.TransactionCheck = new System.Windows.Forms.CheckBox();
            this.SupplierPanel = new System.Windows.Forms.Panel();
            this.SupplierG = new System.Windows.Forms.GroupBox();
            this.browserSupplier = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SupplierName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SupplierID = new System.Windows.Forms.TextBox();
            this.SupplierCheck = new System.Windows.Forms.CheckBox();
            this.ItemPanel = new System.Windows.Forms.Panel();
            this.ItemG = new System.Windows.Forms.GroupBox();
            this.browseItem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ItemName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ItemID = new System.Windows.Forms.TextBox();
            this.ItemCheck = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DateB = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.DateA = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.MainBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.TransactionPanel.SuspendLayout();
            this.TransactionG.SuspendLayout();
            this.SupplierPanel.SuspendLayout();
            this.SupplierG.SuspendLayout();
            this.ItemPanel.SuspendLayout();
            this.ItemG.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.TransactionPanel);
            this.panel1.Controls.Add(this.SupplierPanel);
            this.panel1.Controls.Add(this.ItemPanel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 323);
            this.panel1.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel3);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 268);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(4);
            this.panel7.Size = new System.Drawing.Size(500, 54);
            this.panel7.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ShowPrintLayout);
            this.panel3.Controls.Add(this.PBar);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.RunBtn);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(2);
            this.panel3.Size = new System.Drawing.Size(492, 47);
            this.panel3.TabIndex = 8;
            // 
            // ShowPrintLayout
            // 
            this.ShowPrintLayout.AutoSize = true;
            this.ShowPrintLayout.Location = new System.Drawing.Point(383, 2);
            this.ShowPrintLayout.Name = "ShowPrintLayout";
            this.ShowPrintLayout.Size = new System.Drawing.Size(109, 17);
            this.ShowPrintLayout.TabIndex = 8;
            this.ShowPrintLayout.Text = "Show PrintLayout";
            this.ShowPrintLayout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ShowPrintLayout.UseVisualStyleBackColor = true;
            // 
            // PBar
            // 
            this.PBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.PBar.AnimationSpeed = 500;
            this.PBar.BackColor = System.Drawing.Color.Transparent;
            this.PBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.PBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.PBar.ForeColor = System.Drawing.Color.White;
            this.PBar.InnerColor = System.Drawing.Color.White;
            this.PBar.InnerMargin = 2;
            this.PBar.InnerWidth = -1;
            this.PBar.Location = new System.Drawing.Point(203, 2);
            this.PBar.MarqueeAnimationSpeed = 2000;
            this.PBar.Name = "PBar";
            this.PBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.PBar.OuterMargin = -25;
            this.PBar.OuterWidth = 26;
            this.PBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.PBar.ProgressWidth = 5;
            this.PBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.PBar.Size = new System.Drawing.Size(44, 43);
            this.PBar.StartAngle = 270;
            this.PBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PBar.SubscriptColor = System.Drawing.Color.White;
            this.PBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -20, 0, 0);
            this.PBar.SubscriptText = ".23";
            this.PBar.SuperscriptColor = System.Drawing.Color.White;
            this.PBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.PBar.SuperscriptText = "°C";
            this.PBar.TabIndex = 7;
            this.PBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.PBar.Value = 68;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(193, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 43);
            this.panel5.TabIndex = 6;
            // 
            // RunBtn
            // 
            this.RunBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RunBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.RunBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunBtn.Image = global::MartSolution.Properties.Resources.run;
            this.RunBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RunBtn.Location = new System.Drawing.Point(27, 2);
            this.RunBtn.Name = "RunBtn";
            this.RunBtn.Size = new System.Drawing.Size(166, 43);
            this.RunBtn.TabIndex = 5;
            this.RunBtn.Text = "Run Variables";
            this.RunBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RunBtn.UseVisualStyleBackColor = true;
            this.RunBtn.Click += new System.EventHandler(this.RunBtn_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(25, 43);
            this.panel4.TabIndex = 0;
            // 
            // TransactionPanel
            // 
            this.TransactionPanel.Controls.Add(this.TransactionG);
            this.TransactionPanel.Controls.Add(this.TransactionCheck);
            this.TransactionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TransactionPanel.Location = new System.Drawing.Point(0, 205);
            this.TransactionPanel.Name = "TransactionPanel";
            this.TransactionPanel.Padding = new System.Windows.Forms.Padding(4);
            this.TransactionPanel.Size = new System.Drawing.Size(500, 63);
            this.TransactionPanel.TabIndex = 15;
            // 
            // TransactionG
            // 
            this.TransactionG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TransactionG.Controls.Add(this.TransactionMode);
            this.TransactionG.Enabled = false;
            this.TransactionG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionG.Location = new System.Drawing.Point(27, 6);
            this.TransactionG.Name = "TransactionG";
            this.TransactionG.Size = new System.Drawing.Size(466, 50);
            this.TransactionG.TabIndex = 1;
            this.TransactionG.TabStop = false;
            this.TransactionG.Text = "Transaction Mode";
            // 
            // TransactionMode
            // 
            this.TransactionMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TransactionMode.FormattingEnabled = true;
            this.TransactionMode.Location = new System.Drawing.Point(6, 17);
            this.TransactionMode.Name = "TransactionMode";
            this.TransactionMode.Size = new System.Drawing.Size(455, 24);
            this.TransactionMode.TabIndex = 0;
            this.TransactionMode.SelectedIndexChanged += new System.EventHandler(this.TransactionMode_SelectedIndexChanged);
            // 
            // TransactionCheck
            // 
            this.TransactionCheck.AutoSize = true;
            this.TransactionCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionCheck.Location = new System.Drawing.Point(6, 28);
            this.TransactionCheck.Name = "TransactionCheck";
            this.TransactionCheck.Size = new System.Drawing.Size(15, 14);
            this.TransactionCheck.TabIndex = 7;
            this.TransactionCheck.UseVisualStyleBackColor = true;
            this.TransactionCheck.CheckedChanged += new System.EventHandler(this.TransactionCheck_CheckedChanged);
            // 
            // SupplierPanel
            // 
            this.SupplierPanel.Controls.Add(this.SupplierG);
            this.SupplierPanel.Controls.Add(this.SupplierCheck);
            this.SupplierPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SupplierPanel.Location = new System.Drawing.Point(0, 142);
            this.SupplierPanel.Name = "SupplierPanel";
            this.SupplierPanel.Padding = new System.Windows.Forms.Padding(4);
            this.SupplierPanel.Size = new System.Drawing.Size(500, 63);
            this.SupplierPanel.TabIndex = 14;
            // 
            // SupplierG
            // 
            this.SupplierG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SupplierG.Controls.Add(this.browserSupplier);
            this.SupplierG.Controls.Add(this.label6);
            this.SupplierG.Controls.Add(this.SupplierName);
            this.SupplierG.Controls.Add(this.label7);
            this.SupplierG.Controls.Add(this.SupplierID);
            this.SupplierG.Enabled = false;
            this.SupplierG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierG.Location = new System.Drawing.Point(27, 6);
            this.SupplierG.Name = "SupplierG";
            this.SupplierG.Size = new System.Drawing.Size(466, 50);
            this.SupplierG.TabIndex = 1;
            this.SupplierG.TabStop = false;
            this.SupplierG.Text = "Supplier";
            // 
            // browserSupplier
            // 
            this.browserSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browserSupplier.Location = new System.Drawing.Point(396, 21);
            this.browserSupplier.Name = "browserSupplier";
            this.browserSupplier.Size = new System.Drawing.Size(64, 23);
            this.browserSupplier.TabIndex = 9;
            this.browserSupplier.Text = "browse..";
            this.browserSupplier.UseVisualStyleBackColor = true;
            this.browserSupplier.Click += new System.EventHandler(this.browserSupplier_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(114, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Supplier Name";
            // 
            // SupplierName
            // 
            this.SupplierName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SupplierName.Location = new System.Drawing.Point(190, 21);
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.ReadOnly = true;
            this.SupplierName.Size = new System.Drawing.Size(199, 22);
            this.SupplierName.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Sup ID";
            // 
            // SupplierID
            // 
            this.SupplierID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SupplierID.Location = new System.Drawing.Point(54, 21);
            this.SupplierID.Name = "SupplierID";
            this.SupplierID.ReadOnly = true;
            this.SupplierID.Size = new System.Drawing.Size(56, 22);
            this.SupplierID.TabIndex = 5;
            // 
            // SupplierCheck
            // 
            this.SupplierCheck.AutoSize = true;
            this.SupplierCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierCheck.Location = new System.Drawing.Point(6, 30);
            this.SupplierCheck.Name = "SupplierCheck";
            this.SupplierCheck.Size = new System.Drawing.Size(15, 14);
            this.SupplierCheck.TabIndex = 7;
            this.SupplierCheck.UseVisualStyleBackColor = true;
            this.SupplierCheck.CheckedChanged += new System.EventHandler(this.SupplierCheck_CheckedChanged);
            // 
            // ItemPanel
            // 
            this.ItemPanel.Controls.Add(this.ItemG);
            this.ItemPanel.Controls.Add(this.ItemCheck);
            this.ItemPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ItemPanel.Location = new System.Drawing.Point(0, 79);
            this.ItemPanel.Name = "ItemPanel";
            this.ItemPanel.Padding = new System.Windows.Forms.Padding(4);
            this.ItemPanel.Size = new System.Drawing.Size(500, 63);
            this.ItemPanel.TabIndex = 13;
            // 
            // ItemG
            // 
            this.ItemG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemG.Controls.Add(this.browseItem);
            this.ItemG.Controls.Add(this.label5);
            this.ItemG.Controls.Add(this.ItemName);
            this.ItemG.Controls.Add(this.label4);
            this.ItemG.Controls.Add(this.ItemID);
            this.ItemG.Enabled = false;
            this.ItemG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemG.Location = new System.Drawing.Point(27, 6);
            this.ItemG.Name = "ItemG";
            this.ItemG.Size = new System.Drawing.Size(466, 50);
            this.ItemG.TabIndex = 1;
            this.ItemG.TabStop = false;
            this.ItemG.Text = "Filter Item";
            // 
            // browseItem
            // 
            this.browseItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseItem.Location = new System.Drawing.Point(396, 22);
            this.browseItem.Name = "browseItem";
            this.browseItem.Size = new System.Drawing.Size(64, 23);
            this.browseItem.TabIndex = 4;
            this.browseItem.Text = "browse..";
            this.browseItem.UseVisualStyleBackColor = true;
            this.browseItem.Click += new System.EventHandler(this.browseItem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(130, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Item Name";
            // 
            // ItemName
            // 
            this.ItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemName.Location = new System.Drawing.Point(190, 23);
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Size = new System.Drawing.Size(199, 22);
            this.ItemName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Item ID";
            // 
            // ItemID
            // 
            this.ItemID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemID.Location = new System.Drawing.Point(54, 23);
            this.ItemID.Name = "ItemID";
            this.ItemID.ReadOnly = true;
            this.ItemID.Size = new System.Drawing.Size(56, 22);
            this.ItemID.TabIndex = 0;
            // 
            // ItemCheck
            // 
            this.ItemCheck.AutoSize = true;
            this.ItemCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemCheck.Location = new System.Drawing.Point(6, 32);
            this.ItemCheck.Name = "ItemCheck";
            this.ItemCheck.Size = new System.Drawing.Size(15, 14);
            this.ItemCheck.TabIndex = 7;
            this.ItemCheck.UseVisualStyleBackColor = true;
            this.ItemCheck.CheckedChanged += new System.EventHandler(this.ItemCheck_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(4);
            this.panel2.Size = new System.Drawing.Size(500, 79);
            this.panel2.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.DateB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DateA);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date Range";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(259, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "use date range for filter";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MartSolution.Properties.Resources.GroupBox;
            this.pictureBox1.Location = new System.Drawing.Point(241, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(12, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // DateB
            // 
            this.DateB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateB.Location = new System.Drawing.Point(40, 46);
            this.DateB.Name = "DateB";
            this.DateB.Size = new System.Drawing.Size(200, 20);
            this.DateB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "to";
            // 
            // DateA
            // 
            this.DateA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateA.Location = new System.Drawing.Point(40, 19);
            this.DateA.Name = "DateA";
            this.DateA.Size = new System.Drawing.Size(200, 20);
            this.DateA.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date";
            // 
            // MainBackgroundWorker
            // 
            this.MainBackgroundWorker.WorkerReportsProgress = true;
            this.MainBackgroundWorker.WorkerSupportsCancellation = true;
            this.MainBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.MainBackgroundWorker_DoWork);
            this.MainBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.MainBackgroundWorker_ProgressChanged);
            this.MainBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.MainBackgroundWorker_RunWorkerCompleted);
            // 
            // AllReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 323);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AllReportForm";
            this.Text = "AllReportForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AllReportForm_FormClosing);
            this.Load += new System.EventHandler(this.AllReportForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.TransactionPanel.ResumeLayout(false);
            this.TransactionPanel.PerformLayout();
            this.TransactionG.ResumeLayout(false);
            this.SupplierPanel.ResumeLayout(false);
            this.SupplierPanel.PerformLayout();
            this.SupplierG.ResumeLayout(false);
            this.SupplierG.PerformLayout();
            this.ItemPanel.ResumeLayout(false);
            this.ItemPanel.PerformLayout();
            this.ItemG.ResumeLayout(false);
            this.ItemG.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button RunBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel TransactionPanel;
        private System.Windows.Forms.GroupBox TransactionG;
        private System.Windows.Forms.CheckBox TransactionCheck;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel SupplierPanel;
        private System.Windows.Forms.GroupBox SupplierG;
        private System.Windows.Forms.CheckBox SupplierCheck;
        private System.Windows.Forms.DateTimePicker DateB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DateA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox TransactionMode;
        private System.ComponentModel.BackgroundWorker MainBackgroundWorker;
        private CircularProgressBar.CircularProgressBar PBar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button browserSupplier;
        private System.Windows.Forms.CheckBox ShowPrintLayout;
        private System.Windows.Forms.Panel ItemPanel;
        private System.Windows.Forms.GroupBox ItemG;
        private System.Windows.Forms.Button browseItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ItemCheck;
        public System.Windows.Forms.TextBox ItemName;
        public System.Windows.Forms.TextBox ItemID;
        public System.Windows.Forms.TextBox SupplierName;
        public System.Windows.Forms.TextBox SupplierID;
    }
}