namespace MartSolution.Tools
{
    partial class DatabaseManipulation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseManipulation));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.CBTab = new System.Windows.Forms.TabPage();
            this.CBPanel = new System.Windows.Forms.Panel();
            this.Fname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CreateBackup = new System.Windows.Forms.Button();
            this.RDTab = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ResetDatabase = new System.Windows.Forms.Button();
            this.CreateBackupFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1.SuspendLayout();
            this.CBTab.SuspendLayout();
            this.CBPanel.SuspendLayout();
            this.RDTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.CBTab);
            this.tabControl1.Controls.Add(this.RDTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(527, 162);
            this.tabControl1.TabIndex = 12;
            // 
            // CBTab
            // 
            this.CBTab.Controls.Add(this.CBPanel);
            this.CBTab.Location = new System.Drawing.Point(4, 24);
            this.CBTab.Name = "CBTab";
            this.CBTab.Padding = new System.Windows.Forms.Padding(3);
            this.CBTab.Size = new System.Drawing.Size(519, 134);
            this.CBTab.TabIndex = 0;
            this.CBTab.Text = "Create Backup";
            this.CBTab.UseVisualStyleBackColor = true;
            // 
            // CBPanel
            // 
            this.CBPanel.Controls.Add(this.Fname);
            this.CBPanel.Controls.Add(this.label3);
            this.CBPanel.Controls.Add(this.CreateBackup);
            this.CBPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CBPanel.Location = new System.Drawing.Point(3, 3);
            this.CBPanel.Name = "CBPanel";
            this.CBPanel.Size = new System.Drawing.Size(513, 128);
            this.CBPanel.TabIndex = 12;
            // 
            // Fname
            // 
            this.Fname.AutoSize = true;
            this.Fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fname.Location = new System.Drawing.Point(151, 78);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(0, 13);
            this.Fname.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(505, 75);
            this.label3.TabIndex = 0;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // CreateBackup
            // 
            this.CreateBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateBackup.Image = global::MartSolution.Properties.Resources.backup_2;
            this.CreateBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreateBackup.Location = new System.Drawing.Point(4, 90);
            this.CreateBackup.Name = "CreateBackup";
            this.CreateBackup.Size = new System.Drawing.Size(140, 34);
            this.CreateBackup.TabIndex = 11;
            this.CreateBackup.Text = "Create Backup";
            this.CreateBackup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CreateBackup.UseVisualStyleBackColor = true;
            this.CreateBackup.Click += new System.EventHandler(this.CreateBackup_Click);
            // 
            // RDTab
            // 
            this.RDTab.Controls.Add(this.panel1);
            this.RDTab.Location = new System.Drawing.Point(4, 24);
            this.RDTab.Name = "RDTab";
            this.RDTab.Padding = new System.Windows.Forms.Padding(3);
            this.RDTab.Size = new System.Drawing.Size(519, 134);
            this.RDTab.TabIndex = 1;
            this.RDTab.Text = "Reset Database";
            this.RDTab.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ResetDatabase);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 128);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(504, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // ResetDatabase
            // 
            this.ResetDatabase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetDatabase.Image = global::MartSolution.Properties.Resources.Reset;
            this.ResetDatabase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ResetDatabase.Location = new System.Drawing.Point(4, 90);
            this.ResetDatabase.Name = "ResetDatabase";
            this.ResetDatabase.Size = new System.Drawing.Size(147, 34);
            this.ResetDatabase.TabIndex = 11;
            this.ResetDatabase.Text = "Reset Database";
            this.ResetDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ResetDatabase.UseVisualStyleBackColor = true;
            this.ResetDatabase.Click += new System.EventHandler(this.ResetDatabase_Click);
            // 
            // DatabaseManipulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(535, 170);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DatabaseManipulation";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Manipulation Tool";
            this.Load += new System.EventHandler(this.DatabaseManipulation_Load);
            this.tabControl1.ResumeLayout(false);
            this.CBTab.ResumeLayout(false);
            this.CBPanel.ResumeLayout(false);
            this.CBPanel.PerformLayout();
            this.RDTab.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateBackup;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage CBTab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog CreateBackupFolderBrowserDialog;
        private System.Windows.Forms.Panel CBPanel;
        private System.Windows.Forms.TabPage RDTab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ResetDatabase;
        private System.Windows.Forms.Label Fname;
    }
}