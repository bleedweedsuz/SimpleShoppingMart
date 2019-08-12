namespace KeyGenerator
{
    partial class Form1
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
            this.GBtn = new System.Windows.Forms.Button();
            this.keyBox = new System.Windows.Forms.RichTextBox();
            this.totalGeneration = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.totalGeneration)).BeginInit();
            this.SuspendLayout();
            // 
            // GBtn
            // 
            this.GBtn.Location = new System.Drawing.Point(13, 13);
            this.GBtn.Name = "GBtn";
            this.GBtn.Size = new System.Drawing.Size(75, 23);
            this.GBtn.TabIndex = 0;
            this.GBtn.Text = "Generate";
            this.GBtn.UseVisualStyleBackColor = true;
            this.GBtn.Click += new System.EventHandler(this.GBtn_Click);
            // 
            // keyBox
            // 
            this.keyBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keyBox.Location = new System.Drawing.Point(13, 43);
            this.keyBox.Name = "keyBox";
            this.keyBox.Size = new System.Drawing.Size(994, 536);
            this.keyBox.TabIndex = 1;
            this.keyBox.Text = "";
            // 
            // totalGeneration
            // 
            this.totalGeneration.Location = new System.Drawing.Point(94, 15);
            this.totalGeneration.Name = "totalGeneration";
            this.totalGeneration.Size = new System.Drawing.Size(120, 20);
            this.totalGeneration.TabIndex = 2;
            this.totalGeneration.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 591);
            this.Controls.Add(this.totalGeneration);
            this.Controls.Add(this.keyBox);
            this.Controls.Add(this.GBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Key Generator";
            ((System.ComponentModel.ISupportInitialize)(this.totalGeneration)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GBtn;
        private System.Windows.Forms.RichTextBox keyBox;
        private System.Windows.Forms.NumericUpDown totalGeneration;
    }
}

