namespace DbUpdator
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
            this.txtConString = new System.Windows.Forms.TextBox();
            this.btnTestCon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMainFolderPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrowsFolders = new System.Windows.Forms.Button();
            this.chkSprintFolders = new System.Windows.Forms.CheckedListBox();
            this.btnLoadSprints = new System.Windows.Forms.Button();
            this.chkSqlFiles = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblConStatus = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDbVersion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtConString
            // 
            this.txtConString.Location = new System.Drawing.Point(12, 25);
            this.txtConString.Name = "txtConString";
            this.txtConString.Size = new System.Drawing.Size(939, 20);
            this.txtConString.TabIndex = 0;
            this.txtConString.Text = "Server=.;UID=sa;PWD=sa123;Database=SalvagePlus;min pool size=6; max pool size=100" +
    ";";
            // 
            // btnTestCon
            // 
            this.btnTestCon.Location = new System.Drawing.Point(966, 25);
            this.btnTestCon.Name = "btnTestCon";
            this.btnTestCon.Size = new System.Drawing.Size(75, 23);
            this.btnTestCon.TabIndex = 1;
            this.btnTestCon.Text = "Test Con";
            this.btnTestCon.UseVisualStyleBackColor = true;
            this.btnTestCon.Click += new System.EventHandler(this.btnTestCon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Connection String";
            // 
            // txtMainFolderPath
            // 
            this.txtMainFolderPath.Location = new System.Drawing.Point(15, 67);
            this.txtMainFolderPath.Name = "txtMainFolderPath";
            this.txtMainFolderPath.Size = new System.Drawing.Size(763, 20);
            this.txtMainFolderPath.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Main Folder Path";
            // 
            // btnBrowsFolders
            // 
            this.btnBrowsFolders.Location = new System.Drawing.Point(784, 65);
            this.btnBrowsFolders.Name = "btnBrowsFolders";
            this.btnBrowsFolders.Size = new System.Drawing.Size(75, 23);
            this.btnBrowsFolders.TabIndex = 5;
            this.btnBrowsFolders.Text = "Brows";
            this.btnBrowsFolders.UseVisualStyleBackColor = true;
            this.btnBrowsFolders.Click += new System.EventHandler(this.btnBrowsFolders_Click);
            // 
            // chkSprintFolders
            // 
            this.chkSprintFolders.CheckOnClick = true;
            this.chkSprintFolders.FormattingEnabled = true;
            this.chkSprintFolders.HorizontalScrollbar = true;
            this.chkSprintFolders.Location = new System.Drawing.Point(12, 93);
            this.chkSprintFolders.Name = "chkSprintFolders";
            this.chkSprintFolders.Size = new System.Drawing.Size(301, 409);
            this.chkSprintFolders.TabIndex = 6;
            this.chkSprintFolders.SelectedValueChanged += new System.EventHandler(this.chkSprintFolders_SelectedValueChanged);
            // 
            // btnLoadSprints
            // 
            this.btnLoadSprints.Location = new System.Drawing.Point(865, 64);
            this.btnLoadSprints.Name = "btnLoadSprints";
            this.btnLoadSprints.Size = new System.Drawing.Size(86, 23);
            this.btnLoadSprints.TabIndex = 7;
            this.btnLoadSprints.Text = "Show Sprints";
            this.btnLoadSprints.UseVisualStyleBackColor = true;
            this.btnLoadSprints.Click += new System.EventHandler(this.btnLoadSprints_Click);
            // 
            // chkSqlFiles
            // 
            this.chkSqlFiles.CheckOnClick = true;
            this.chkSqlFiles.FormattingEnabled = true;
            this.chkSqlFiles.HorizontalScrollbar = true;
            this.chkSqlFiles.Location = new System.Drawing.Point(319, 95);
            this.chkSqlFiles.Name = "chkSqlFiles";
            this.chkSqlFiles.Size = new System.Drawing.Size(312, 409);
            this.chkSqlFiles.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Connection Status";
            // 
            // lblConStatus
            // 
            this.lblConStatus.AutoSize = true;
            this.lblConStatus.Location = new System.Drawing.Point(235, 9);
            this.lblConStatus.Name = "lblConStatus";
            this.lblConStatus.Size = new System.Drawing.Size(0, 13);
            this.lblConStatus.TabIndex = 10;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(966, 64);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 11;
            this.btnRun.Text = "Run Scripts";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lstResults
            // 
            this.lstResults.FormattingEnabled = true;
            this.lstResults.HorizontalScrollbar = true;
            this.lstResults.Location = new System.Drawing.Point(647, 95);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(394, 407);
            this.lstResults.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(402, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Db Version";
            // 
            // lblDbVersion
            // 
            this.lblDbVersion.AutoSize = true;
            this.lblDbVersion.Location = new System.Drawing.Point(467, 9);
            this.lblDbVersion.Name = "lblDbVersion";
            this.lblDbVersion.Size = new System.Drawing.Size(0, 13);
            this.lblDbVersion.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 509);
            this.Controls.Add(this.lblDbVersion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.lblConStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkSqlFiles);
            this.Controls.Add(this.btnLoadSprints);
            this.Controls.Add(this.chkSprintFolders);
            this.Controls.Add(this.btnBrowsFolders);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMainFolderPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTestCon);
            this.Controls.Add(this.txtConString);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConString;
        private System.Windows.Forms.Button btnTestCon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMainFolderPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBrowsFolders;
        private System.Windows.Forms.CheckedListBox chkSprintFolders;
        private System.Windows.Forms.Button btnLoadSprints;
        private System.Windows.Forms.CheckedListBox chkSqlFiles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblConStatus;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDbVersion;
    }
}

