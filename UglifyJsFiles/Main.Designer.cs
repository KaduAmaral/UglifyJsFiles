namespace UglifyJsFiles
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtDirPath = new System.Windows.Forms.TextBox();
            this.btnPickFolder = new System.Windows.Forms.Button();
            this.lstDirFiles = new System.Windows.Forms.ListBox();
            this.btnAllRight = new System.Windows.Forms.Button();
            this.btnOneRight = new System.Windows.Forms.Button();
            this.btnOneLeft = new System.Windows.Forms.Button();
            this.btnAllLeft = new System.Windows.Forms.Button();
            this.lstSelectedFiles = new System.Windows.Forms.ListBox();
            this.btnGoTop = new System.Windows.Forms.Button();
            this.btnGoDown = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPathUnified = new System.Windows.Forms.TextBox();
            this.btnUnifiedFolder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMinifiedFolder = new System.Windows.Forms.Button();
            this.txtPathMinified = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinify = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUgSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtDirPath
            // 
            resources.ApplyResources(this.txtDirPath, "txtDirPath");
            this.txtDirPath.Name = "txtDirPath";
            // 
            // btnPickFolder
            // 
            resources.ApplyResources(this.btnPickFolder, "btnPickFolder");
            this.btnPickFolder.Name = "btnPickFolder";
            this.btnPickFolder.UseVisualStyleBackColor = true;
            this.btnPickFolder.Click += new System.EventHandler(this.btnPickFolder_Click);
            // 
            // lstDirFiles
            // 
            this.lstDirFiles.FormattingEnabled = true;
            resources.ApplyResources(this.lstDirFiles, "lstDirFiles");
            this.lstDirFiles.Name = "lstDirFiles";
            this.lstDirFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            // 
            // btnAllRight
            // 
            resources.ApplyResources(this.btnAllRight, "btnAllRight");
            this.btnAllRight.Name = "btnAllRight";
            this.btnAllRight.UseVisualStyleBackColor = true;
            this.btnAllRight.Click += new System.EventHandler(this.btnAllRight_Click);
            // 
            // btnOneRight
            // 
            resources.ApplyResources(this.btnOneRight, "btnOneRight");
            this.btnOneRight.Name = "btnOneRight";
            this.btnOneRight.UseVisualStyleBackColor = true;
            this.btnOneRight.Click += new System.EventHandler(this.btnOneRight_Click);
            // 
            // btnOneLeft
            // 
            resources.ApplyResources(this.btnOneLeft, "btnOneLeft");
            this.btnOneLeft.Name = "btnOneLeft";
            this.btnOneLeft.UseVisualStyleBackColor = true;
            this.btnOneLeft.Click += new System.EventHandler(this.btnOneLeft_Click);
            // 
            // btnAllLeft
            // 
            resources.ApplyResources(this.btnAllLeft, "btnAllLeft");
            this.btnAllLeft.Name = "btnAllLeft";
            this.btnAllLeft.UseVisualStyleBackColor = true;
            this.btnAllLeft.Click += new System.EventHandler(this.btnAllLeft_Click);
            // 
            // lstSelectedFiles
            // 
            this.lstSelectedFiles.FormattingEnabled = true;
            resources.ApplyResources(this.lstSelectedFiles, "lstSelectedFiles");
            this.lstSelectedFiles.Name = "lstSelectedFiles";
            this.lstSelectedFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            // 
            // btnGoTop
            // 
            resources.ApplyResources(this.btnGoTop, "btnGoTop");
            this.btnGoTop.Name = "btnGoTop";
            this.btnGoTop.UseVisualStyleBackColor = true;
            this.btnGoTop.Click += new System.EventHandler(this.btnGoTop_Click);
            // 
            // btnGoDown
            // 
            resources.ApplyResources(this.btnGoDown, "btnGoDown");
            this.btnGoDown.Name = "btnGoDown";
            this.btnGoDown.UseVisualStyleBackColor = true;
            this.btnGoDown.Click += new System.EventHandler(this.btnGoDown_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtPathUnified
            // 
            resources.ApplyResources(this.txtPathUnified, "txtPathUnified");
            this.txtPathUnified.Name = "txtPathUnified";
            // 
            // btnUnifiedFolder
            // 
            resources.ApplyResources(this.btnUnifiedFolder, "btnUnifiedFolder");
            this.btnUnifiedFolder.Name = "btnUnifiedFolder";
            this.btnUnifiedFolder.UseVisualStyleBackColor = true;
            this.btnUnifiedFolder.Click += new System.EventHandler(this.btnUnifiedFolder_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // btnMinifiedFolder
            // 
            resources.ApplyResources(this.btnMinifiedFolder, "btnMinifiedFolder");
            this.btnMinifiedFolder.Name = "btnMinifiedFolder";
            this.btnMinifiedFolder.UseVisualStyleBackColor = true;
            this.btnMinifiedFolder.Click += new System.EventHandler(this.btnMinifiedFolder_Click);
            // 
            // txtPathMinified
            // 
            resources.ApplyResources(this.txtPathMinified, "txtPathMinified");
            this.txtPathMinified.Name = "txtPathMinified";
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinify
            // 
            resources.ApplyResources(this.btnMinify, "btnMinify");
            this.btnMinify.Name = "btnMinify";
            this.btnMinify.UseVisualStyleBackColor = true;
            this.btnMinify.Click += new System.EventHandler(this.btnMinify_Click);
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnUgSettings
            // 
            resources.ApplyResources(this.btnUgSettings, "btnUgSettings");
            this.btnUgSettings.Name = "btnUgSettings";
            this.btnUgSettings.UseVisualStyleBackColor = true;
            this.btnUgSettings.Click += new System.EventHandler(this.btnUgSettings_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btnUgSettings);
            this.Controls.Add(this.btnMinify);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtPathMinified);
            this.Controls.Add(this.btnMinifiedFolder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnUnifiedFolder);
            this.Controls.Add(this.txtPathUnified);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGoDown);
            this.Controls.Add(this.btnGoTop);
            this.Controls.Add(this.lstSelectedFiles);
            this.Controls.Add(this.btnAllLeft);
            this.Controls.Add(this.btnOneLeft);
            this.Controls.Add(this.btnOneRight);
            this.Controls.Add(this.btnAllRight);
            this.Controls.Add(this.lstDirFiles);
            this.Controls.Add(this.btnPickFolder);
            this.Controls.Add(this.txtDirPath);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDirPath;
        private System.Windows.Forms.Button btnPickFolder;
        private System.Windows.Forms.ListBox lstDirFiles;
        private System.Windows.Forms.Button btnAllRight;
        private System.Windows.Forms.Button btnOneRight;
        private System.Windows.Forms.Button btnOneLeft;
        private System.Windows.Forms.Button btnAllLeft;
        private System.Windows.Forms.ListBox lstSelectedFiles;
        private System.Windows.Forms.Button btnGoTop;
        private System.Windows.Forms.Button btnGoDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPathUnified;
        private System.Windows.Forms.Button btnUnifiedFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMinifiedFolder;
        private System.Windows.Forms.TextBox txtPathMinified;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinify;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUgSettings;
    }
}

