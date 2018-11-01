namespace WW_Coding_Challenge_FootballExercise
{
    partial class mainForm
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
            this.lblFilePath = new System.Windows.Forms.Label();
            this.tbTAL = new System.Windows.Forms.TabControl();
            this.tpInputError = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgErrorResult = new System.Windows.Forms.DataGridView();
            this.grpFileSource = new System.Windows.Forms.GroupBox();
            this.cmFileName = new System.Windows.Forms.ComboBox();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.grpReadResult = new System.Windows.Forms.GroupBox();
            this.dgReadResult = new System.Windows.Forms.DataGridView();
            this.grpSmallestDiff = new System.Windows.Forms.GroupBox();
            this.lblAssumption = new System.Windows.Forms.Label();
            this.lblDiff = new System.Windows.Forms.Label();
            this.lblDiffResult = new System.Windows.Forms.Label();
            this.lblTeam = new System.Windows.Forms.Label();
            this.lblF = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblAResult = new System.Windows.Forms.Label();
            this.lblTeamResult = new System.Windows.Forms.Label();
            this.lblFResult = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbTAL.SuspendLayout();
            this.tpInputError.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgErrorResult)).BeginInit();
            this.grpFileSource.SuspendLayout();
            this.grpReadResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReadResult)).BeginInit();
            this.grpSmallestDiff.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(12, 30);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(54, 13);
            this.lblFilePath.TabIndex = 0;
            this.lblFilePath.Text = "File Name";
            // 
            // tbTAL
            // 
            this.tbTAL.Controls.Add(this.tpInputError);
            this.tbTAL.Location = new System.Drawing.Point(12, 34);
            this.tbTAL.Name = "tbTAL";
            this.tbTAL.SelectedIndex = 0;
            this.tbTAL.Size = new System.Drawing.Size(866, 549);
            this.tbTAL.TabIndex = 3;
            // 
            // tpInputError
            // 
            this.tpInputError.Controls.Add(this.groupBox1);
            this.tpInputError.Controls.Add(this.grpFileSource);
            this.tpInputError.Controls.Add(this.grpReadResult);
            this.tpInputError.Location = new System.Drawing.Point(4, 22);
            this.tpInputError.Name = "tpInputError";
            this.tpInputError.Padding = new System.Windows.Forms.Padding(3);
            this.tpInputError.Size = new System.Drawing.Size(858, 523);
            this.tpInputError.TabIndex = 0;
            this.tpInputError.Text = "File Input & Error";
            this.tpInputError.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgErrorResult);
            this.groupBox1.Location = new System.Drawing.Point(20, 311);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(822, 206);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Error Result Summary";
            // 
            // dgErrorResult
            // 
            this.dgErrorResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgErrorResult.Location = new System.Drawing.Point(9, 33);
            this.dgErrorResult.Name = "dgErrorResult";
            this.dgErrorResult.Size = new System.Drawing.Size(793, 167);
            this.dgErrorResult.TabIndex = 8;
            // 
            // grpFileSource
            // 
            this.grpFileSource.Controls.Add(this.cmFileName);
            this.grpFileSource.Controls.Add(this.btnLoadFile);
            this.grpFileSource.Controls.Add(this.lblFilePath);
            this.grpFileSource.Location = new System.Drawing.Point(11, 21);
            this.grpFileSource.Name = "grpFileSource";
            this.grpFileSource.Size = new System.Drawing.Size(831, 59);
            this.grpFileSource.TabIndex = 4;
            this.grpFileSource.TabStop = false;
            this.grpFileSource.Text = "File Source";
            // 
            // cmFileName
            // 
            this.cmFileName.FormattingEnabled = true;
            this.cmFileName.Items.AddRange(new object[] {
            "football.csv",
            "football.dat"});
            this.cmFileName.Location = new System.Drawing.Point(90, 30);
            this.cmFileName.Name = "cmFileName";
            this.cmFileName.Size = new System.Drawing.Size(109, 21);
            this.cmFileName.TabIndex = 8;
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(219, 30);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(97, 23);
            this.btnLoadFile.TabIndex = 4;
            this.btnLoadFile.Text = "L&oad File";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.LoadFile);
            // 
            // grpReadResult
            // 
            this.grpReadResult.Controls.Add(this.dgReadResult);
            this.grpReadResult.Location = new System.Drawing.Point(11, 86);
            this.grpReadResult.Name = "grpReadResult";
            this.grpReadResult.Size = new System.Drawing.Size(831, 206);
            this.grpReadResult.TabIndex = 5;
            this.grpReadResult.TabStop = false;
            this.grpReadResult.Text = "Read Result";
            // 
            // dgReadResult
            // 
            this.dgReadResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReadResult.Location = new System.Drawing.Point(18, 30);
            this.dgReadResult.Name = "dgReadResult";
            this.dgReadResult.Size = new System.Drawing.Size(793, 156);
            this.dgReadResult.TabIndex = 6;
            // 
            // grpSmallestDiff
            // 
            this.grpSmallestDiff.Controls.Add(this.lblAssumption);
            this.grpSmallestDiff.Controls.Add(this.lblDiff);
            this.grpSmallestDiff.Controls.Add(this.lblDiffResult);
            this.grpSmallestDiff.Controls.Add(this.lblTeam);
            this.grpSmallestDiff.Controls.Add(this.lblF);
            this.grpSmallestDiff.Controls.Add(this.lblA);
            this.grpSmallestDiff.Controls.Add(this.lblAResult);
            this.grpSmallestDiff.Controls.Add(this.lblTeamResult);
            this.grpSmallestDiff.Controls.Add(this.lblFResult);
            this.grpSmallestDiff.Location = new System.Drawing.Point(884, 56);
            this.grpSmallestDiff.Name = "grpSmallestDiff";
            this.grpSmallestDiff.Size = new System.Drawing.Size(780, 292);
            this.grpSmallestDiff.TabIndex = 9;
            this.grpSmallestDiff.TabStop = false;
            this.grpSmallestDiff.Text = "Smallest Difference FA Result";
            // 
            // lblAssumption
            // 
            this.lblAssumption.AutoSize = true;
            this.lblAssumption.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssumption.Location = new System.Drawing.Point(19, 26);
            this.lblAssumption.Name = "lblAssumption";
            this.lblAssumption.Size = new System.Drawing.Size(0, 22);
            this.lblAssumption.TabIndex = 1;
            // 
            // lblDiff
            // 
            this.lblDiff.AutoSize = true;
            this.lblDiff.Location = new System.Drawing.Point(20, 246);
            this.lblDiff.Name = "lblDiff";
            this.lblDiff.Size = new System.Drawing.Size(61, 13);
            this.lblDiff.TabIndex = 7;
            this.lblDiff.Text = "Differences";
            // 
            // lblDiffResult
            // 
            this.lblDiffResult.AutoSize = true;
            this.lblDiffResult.Location = new System.Drawing.Point(140, 252);
            this.lblDiffResult.Name = "lblDiffResult";
            this.lblDiffResult.Size = new System.Drawing.Size(0, 13);
            this.lblDiffResult.TabIndex = 8;
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.Location = new System.Drawing.Point(20, 168);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(34, 13);
            this.lblTeam.TabIndex = 0;
            this.lblTeam.Text = "Team";
            // 
            // lblF
            // 
            this.lblF.AutoSize = true;
            this.lblF.Location = new System.Drawing.Point(20, 194);
            this.lblF.Name = "lblF";
            this.lblF.Size = new System.Drawing.Size(13, 13);
            this.lblF.TabIndex = 1;
            this.lblF.Text = "F";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(20, 224);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(14, 13);
            this.lblA.TabIndex = 2;
            this.lblA.Text = "A";
            // 
            // lblAResult
            // 
            this.lblAResult.AutoSize = true;
            this.lblAResult.Location = new System.Drawing.Point(140, 222);
            this.lblAResult.Name = "lblAResult";
            this.lblAResult.Size = new System.Drawing.Size(0, 13);
            this.lblAResult.TabIndex = 5;
            // 
            // lblTeamResult
            // 
            this.lblTeamResult.AutoSize = true;
            this.lblTeamResult.Location = new System.Drawing.Point(140, 166);
            this.lblTeamResult.Name = "lblTeamResult";
            this.lblTeamResult.Size = new System.Drawing.Size(0, 13);
            this.lblTeamResult.TabIndex = 3;
            // 
            // lblFResult
            // 
            this.lblFResult.AutoSize = true;
            this.lblFResult.Location = new System.Drawing.Point(140, 192);
            this.lblFResult.Name = "lblFResult";
            this.lblFResult.Size = new System.Drawing.Size(0, 13);
            this.lblFResult.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1730, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authorToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // authorToolStripMenuItem
            // 
            this.authorToolStripMenuItem.Name = "authorToolStripMenuItem";
            this.authorToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.authorToolStripMenuItem.Text = "Author";
            this.authorToolStripMenuItem.Click += new System.EventHandler(this.authorToolStripMenuItem_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1730, 595);
            this.Controls.Add(this.grpSmallestDiff);
            this.Controls.Add(this.tbTAL);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "Coding Challenge - TAL (William Wang)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tbTAL.ResumeLayout(false);
            this.tpInputError.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgErrorResult)).EndInit();
            this.grpFileSource.ResumeLayout(false);
            this.grpFileSource.PerformLayout();
            this.grpReadResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgReadResult)).EndInit();
            this.grpSmallestDiff.ResumeLayout(false);
            this.grpSmallestDiff.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.TabControl tbTAL;
        private System.Windows.Forms.TabPage tpInputError;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.DataGridView dgReadResult;
        private System.Windows.Forms.GroupBox grpFileSource;
        private System.Windows.Forms.GroupBox grpReadResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgErrorResult;
        private System.Windows.Forms.Label lblAResult;
        private System.Windows.Forms.Label lblFResult;
        private System.Windows.Forms.Label lblTeamResult;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblF;
        private System.Windows.Forms.Label lblTeam;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmFileName;
        private System.Windows.Forms.Label lblAssumption;
        private System.Windows.Forms.Label lblDiffResult;
        private System.Windows.Forms.Label lblDiff;
        private System.Windows.Forms.GroupBox grpSmallestDiff;
    }
}

