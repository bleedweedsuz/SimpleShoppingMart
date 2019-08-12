namespace MartSolution
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AppDescription = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Password = new System.Windows.Forms.TextBox();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.LicenseRegisterPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Pkey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.RegisterProductKey = new System.Windows.Forms.Button();
            this.PTimerLicense = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.LoginPanel.SuspendLayout();
            this.LicenseRegisterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(173, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 156);
            this.panel1.TabIndex = 2;
            // 
            // UserName
            // 
            this.UserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(3, 5);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(346, 15);
            this.UserName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(176, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // Login
            // 
            this.Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.Color.Brown;
            this.Login.Image = global::MartSolution.Properties.Resources.Login;
            this.Login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Login.Location = new System.Drawing.Point(180, 114);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(121, 45);
            this.Login.TabIndex = 6;
            this.Login.Text = "Login [4]";
            this.Login.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MartSolution.Properties.Resources.MartSolution_Big;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AppDescription
            // 
            this.AppDescription.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppDescription.ForeColor = System.Drawing.Color.DimGray;
            this.AppDescription.Location = new System.Drawing.Point(16, 178);
            this.AppDescription.Name = "AppDescription";
            this.AppDescription.Size = new System.Drawing.Size(531, 23);
            this.AppDescription.TabIndex = 7;
            this.AppDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.UserName);
            this.panel2.Location = new System.Drawing.Point(180, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(354, 28);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.Password);
            this.panel3.Location = new System.Drawing.Point(180, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(354, 28);
            this.panel3.TabIndex = 1;
            // 
            // Password
            // 
            this.Password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(3, 5);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(346, 15);
            this.Password.TabIndex = 1;
            this.Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Password_KeyDown);
            // 
            // LoginPanel
            // 
            this.LoginPanel.Controls.Add(this.pictureBox1);
            this.LoginPanel.Controls.Add(this.panel3);
            this.LoginPanel.Controls.Add(this.label1);
            this.LoginPanel.Controls.Add(this.panel2);
            this.LoginPanel.Controls.Add(this.panel1);
            this.LoginPanel.Controls.Add(this.label2);
            this.LoginPanel.Controls.Add(this.Login);
            this.LoginPanel.Location = new System.Drawing.Point(689, 12);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(541, 163);
            this.LoginPanel.TabIndex = 8;
            // 
            // LicenseRegisterPanel
            // 
            this.LicenseRegisterPanel.Controls.Add(this.label3);
            this.LicenseRegisterPanel.Controls.Add(this.Pkey);
            this.LicenseRegisterPanel.Controls.Add(this.label4);
            this.LicenseRegisterPanel.Controls.Add(this.pictureBox3);
            this.LicenseRegisterPanel.Controls.Add(this.label5);
            this.LicenseRegisterPanel.Controls.Add(this.panel11);
            this.LicenseRegisterPanel.Controls.Add(this.RegisterProductKey);
            this.LicenseRegisterPanel.Location = new System.Drawing.Point(12, 12);
            this.LicenseRegisterPanel.Name = "LicenseRegisterPanel";
            this.LicenseRegisterPanel.Size = new System.Drawing.Size(541, 163);
            this.LicenseRegisterPanel.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(289, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "For product key please contact to software vendor.\r\nAfter product key match appli" +
    "cation will restart.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Pkey
            // 
            this.Pkey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pkey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pkey.Location = new System.Drawing.Point(180, 28);
            this.Pkey.MaxLength = 100;
            this.Pkey.Name = "Pkey";
            this.Pkey.Size = new System.Drawing.Size(354, 26);
            this.Pkey.TabIndex = 0;
            this.Pkey.TextChanged += new System.EventHandler(this.Pkey_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "[ eg. xxxx-xxxx-xxxx-xxxx ]";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MartSolution.Properties.Resources.MartSolution_Big;
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(165, 156);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(176, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Product Key ";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Black;
            this.panel11.Location = new System.Drawing.Point(173, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1, 156);
            this.panel11.TabIndex = 2;
            // 
            // RegisterProductKey
            // 
            this.RegisterProductKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterProductKey.Enabled = false;
            this.RegisterProductKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterProductKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterProductKey.ForeColor = System.Drawing.Color.Brown;
            this.RegisterProductKey.Image = global::MartSolution.Properties.Resources.Login;
            this.RegisterProductKey.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RegisterProductKey.Location = new System.Drawing.Point(180, 61);
            this.RegisterProductKey.Name = "RegisterProductKey";
            this.RegisterProductKey.Size = new System.Drawing.Size(156, 45);
            this.RegisterProductKey.TabIndex = 1;
            this.RegisterProductKey.Text = "Register [ 4 ]";
            this.RegisterProductKey.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RegisterProductKey.UseVisualStyleBackColor = true;
            this.RegisterProductKey.Click += new System.EventHandler(this.RegisterProductKey_Click);
            // 
            // PTimerLicense
            // 
            this.PTimerLicense.Interval = 1000;
            this.PTimerLicense.Tick += new System.EventHandler(this.PTimerLicense_Tick);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(571, 213);
            this.Controls.Add(this.LicenseRegisterPanel);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.AppDescription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(587, 252);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mart Solution Login Form";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.LicenseRegisterPanel.ResumeLayout(false);
            this.LicenseRegisterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Label AppDescription;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Panel LicenseRegisterPanel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button RegisterProductKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Pkey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer PTimerLicense;
    }
}