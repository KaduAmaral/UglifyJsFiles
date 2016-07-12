namespace UglifyJsFiles
{
    partial class UglifySettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UglifySettings));
            this.btnClose = new System.Windows.Forms.Button();
            this.chkSupportIE8 = new System.Windows.Forms.CheckBox();
            this.chkScrewIE8 = new System.Windows.Forms.CheckBox();
            this.chkMangle = new System.Windows.Forms.CheckBox();
            this.chkCompress = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(113, 60);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Fechar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // chkSupportIE8
            // 
            this.chkSupportIE8.AutoSize = true;
            this.chkSupportIE8.Checked = true;
            this.chkSupportIE8.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSupportIE8.Location = new System.Drawing.Point(13, 13);
            this.chkSupportIE8.Name = "chkSupportIE8";
            this.chkSupportIE8.Size = new System.Drawing.Size(82, 17);
            this.chkSupportIE8.TabIndex = 2;
            this.chkSupportIE8.Text = "Support IE8";
            this.chkSupportIE8.UseVisualStyleBackColor = true;
            this.chkSupportIE8.CheckedChanged += new System.EventHandler(this.chkSupportIE8_CheckedChanged);
            // 
            // chkScrewIE8
            // 
            this.chkScrewIE8.AutoSize = true;
            this.chkScrewIE8.Location = new System.Drawing.Point(116, 13);
            this.chkScrewIE8.Name = "chkScrewIE8";
            this.chkScrewIE8.Size = new System.Drawing.Size(75, 17);
            this.chkScrewIE8.TabIndex = 3;
            this.chkScrewIE8.Text = "Screw IE8";
            this.chkScrewIE8.UseVisualStyleBackColor = true;
            this.chkScrewIE8.CheckedChanged += new System.EventHandler(this.chkScrewIE8_CheckedChanged);
            // 
            // chkMangle
            // 
            this.chkMangle.AutoSize = true;
            this.chkMangle.Checked = true;
            this.chkMangle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMangle.Location = new System.Drawing.Point(13, 37);
            this.chkMangle.Name = "chkMangle";
            this.chkMangle.Size = new System.Drawing.Size(61, 17);
            this.chkMangle.TabIndex = 4;
            this.chkMangle.Text = "Mangle";
            this.chkMangle.UseVisualStyleBackColor = true;
            // 
            // chkCompress
            // 
            this.chkCompress.AutoSize = true;
            this.chkCompress.Checked = true;
            this.chkCompress.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCompress.Location = new System.Drawing.Point(116, 37);
            this.chkCompress.Name = "chkCompress";
            this.chkCompress.Size = new System.Drawing.Size(72, 17);
            this.chkCompress.TabIndex = 5;
            this.chkCompress.Text = "Compress";
            this.chkCompress.UseVisualStyleBackColor = true;
            // 
            // UglifySettings
            // 
            this.AcceptButton = this.btnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(202, 95);
            this.ControlBox = false;
            this.Controls.Add(this.chkCompress);
            this.Controls.Add(this.chkMangle);
            this.Controls.Add(this.chkScrewIE8);
            this.Controls.Add(this.chkSupportIE8);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(218, 134);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(218, 134);
            this.Name = "UglifySettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uglify Settings";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.CheckBox chkSupportIE8;
        public System.Windows.Forms.CheckBox chkScrewIE8;
        public System.Windows.Forms.CheckBox chkMangle;
        public System.Windows.Forms.CheckBox chkCompress;
    }
}