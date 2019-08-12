namespace MartSolution
{
    partial class AboutBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.descriptionBox = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SpeedTxt = new System.Windows.Forms.Label();
            this.ppBtn = new System.Windows.Forms.PictureBox();
            this.HeaderImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tScrollerTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ppBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeaderImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 348);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.descriptionBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 123);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(613, 225);
            this.panel3.TabIndex = 0;
            // 
            // descriptionBox
            // 
            this.descriptionBox.AutoSize = true;
            this.descriptionBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.descriptionBox.Location = new System.Drawing.Point(6, 2);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(496, 559);
            this.descriptionBox.TabIndex = 6;
            this.descriptionBox.Text = resources.GetString("descriptionBox.Text");
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SpeedTxt);
            this.panel2.Controls.Add(this.ppBtn);
            this.panel2.Controls.Add(this.HeaderImage);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(613, 123);
            this.panel2.TabIndex = 2;
            // 
            // SpeedTxt
            // 
            this.SpeedTxt.AutoSize = true;
            this.SpeedTxt.BackColor = System.Drawing.Color.Transparent;
            this.SpeedTxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SpeedTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpeedTxt.ForeColor = System.Drawing.Color.White;
            this.SpeedTxt.Location = new System.Drawing.Point(33, 105);
            this.SpeedTxt.Name = "SpeedTxt";
            this.SpeedTxt.Size = new System.Drawing.Size(66, 16);
            this.SpeedTxt.TabIndex = 7;
            this.SpeedTxt.Text = "speed x 1";
            this.SpeedTxt.Click += new System.EventHandler(this.SpeedTxt_Click);
            // 
            // ppBtn
            // 
            this.ppBtn.BackColor = System.Drawing.Color.Transparent;
            this.ppBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ppBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ppBtn.Image = global::MartSolution.Properties.Resources.play_1;
            this.ppBtn.Location = new System.Drawing.Point(3, 95);
            this.ppBtn.Name = "ppBtn";
            this.ppBtn.Size = new System.Drawing.Size(30, 27);
            this.ppBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ppBtn.TabIndex = 2;
            this.ppBtn.TabStop = false;
            this.ppBtn.Click += new System.EventHandler(this.ppBtn_Click);
            // 
            // HeaderImage
            // 
            this.HeaderImage.Image = global::MartSolution.Properties.Resources.uRBtadp;
            this.HeaderImage.Location = new System.Drawing.Point(-1, -2);
            this.HeaderImage.Name = "HeaderImage";
            this.HeaderImage.Size = new System.Drawing.Size(619, 353);
            this.HeaderImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HeaderImage.TabIndex = 0;
            this.HeaderImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.label1.Location = new System.Drawing.Point(3, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sales Management System V 1.0";
            // 
            // tScrollerTimer
            // 
            this.tScrollerTimer.Interval = 35;
            this.tScrollerTimer.Tick += new System.EventHandler(this.tScrollerTimer_Tick);
            // 
            // AboutBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(613, 348);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AboutBox_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ppBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeaderImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox HeaderImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label descriptionBox;
        private System.Windows.Forms.Timer tScrollerTimer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox ppBtn;
        private System.Windows.Forms.Label SpeedTxt;
    }
}