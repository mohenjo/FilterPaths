namespace FilterPaths
{
    partial class frmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRootPath = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnBrowseRootPath = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudPathLengthLimit = new System.Windows.Forms.NumericUpDown();
            this.nudFileSizeLimit = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.lstvMain = new System.Windows.Forms.ListView();
            this.clmCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmLength = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmFullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPathLengthLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFileSizeLimit)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemHelp});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStripMain.Size = new System.Drawing.Size(1345, 28);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // toolStripMenuItemHelp
            // 
            this.toolStripMenuItemHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItemHelp.Name = "toolStripMenuItemHelp";
            this.toolStripMenuItemHelp.Size = new System.Drawing.Size(63, 24);
            this.toolStripMenuItemHelp.Text = "&About";
            this.toolStripMenuItemHelp.Click += new System.EventHandler(this.toolStripMenuItemHelp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "검색 시작 경로:";
            // 
            // txtRootPath
            // 
            this.txtRootPath.Location = new System.Drawing.Point(152, 34);
            this.txtRootPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRootPath.Name = "txtRootPath";
            this.txtRootPath.ReadOnly = true;
            this.txtRootPath.Size = new System.Drawing.Size(314, 26);
            this.txtRootPath.TabIndex = 2;
            this.txtRootPath.TabStop = false;
            this.txtRootPath.TextChanged += new System.EventHandler(this.txtRootPath_TextChanged);
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 50;
            this.toolTip.AutoPopDelay = 10000;
            this.toolTip.InitialDelay = 50;
            this.toolTip.ReshowDelay = 10;
            // 
            // btnBrowseRootPath
            // 
            this.btnBrowseRootPath.Location = new System.Drawing.Point(475, 28);
            this.btnBrowseRootPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBrowseRootPath.Name = "btnBrowseRootPath";
            this.btnBrowseRootPath.Size = new System.Drawing.Size(108, 39);
            this.btnBrowseRootPath.TabIndex = 3;
            this.btnBrowseRootPath.Text = "찾아보기(&B)";
            this.btnBrowseRootPath.UseVisualStyleBackColor = true;
            this.btnBrowseRootPath.Click += new System.EventHandler(this.btnBrowseRootPath_Click);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "검색을 시작할 경로를 지정합니다.";
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "필터링 기준 경로명 길이:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "필터링 기준 파일 크기:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "글자    (윈도우 권장 259자 이하) ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(310, 125);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(284, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "MB     (양의 값인 경우만 크기 필터링)";
            // 
            // nudPathLengthLimit
            // 
            this.nudPathLengthLimit.Location = new System.Drawing.Point(211, 79);
            this.nudPathLengthLimit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudPathLengthLimit.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.nudPathLengthLimit.Minimum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.nudPathLengthLimit.Name = "nudPathLengthLimit";
            this.nudPathLengthLimit.Size = new System.Drawing.Size(91, 26);
            this.nudPathLengthLimit.TabIndex = 9;
            this.nudPathLengthLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudPathLengthLimit.ThousandsSeparator = true;
            this.nudPathLengthLimit.Value = new decimal(new int[] {
            259,
            0,
            0,
            0});
            // 
            // nudFileSizeLimit
            // 
            this.nudFileSizeLimit.Location = new System.Drawing.Point(211, 122);
            this.nudFileSizeLimit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudFileSizeLimit.Maximum = new decimal(new int[] {
            10240,
            0,
            0,
            0});
            this.nudFileSizeLimit.Name = "nudFileSizeLimit";
            this.nudFileSizeLimit.Size = new System.Drawing.Size(91, 26);
            this.nudFileSizeLimit.TabIndex = 10;
            this.nudFileSizeLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudFileSizeLimit.ThousandsSeparator = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudFileSizeLimit);
            this.groupBox1.Controls.Add(this.btnBrowseRootPath);
            this.groupBox1.Controls.Add(this.txtRootPath);
            this.groupBox1.Controls.Add(this.nudPathLengthLimit);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(15, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(606, 172);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " 필터링 설정 ";
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(15, 218);
            this.btnReload.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(300, 39);
            this.btnReload.TabIndex = 12;
            this.btnReload.Text = "필터링 결과 보기(&R)";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // lstvMain
            // 
            this.lstvMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmCategory,
            this.clmLength,
            this.clmSize,
            this.clmName,
            this.clmFullName});
            this.lstvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstvMain.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lstvMain.FullRowSelect = true;
            this.lstvMain.GridLines = true;
            this.lstvMain.HideSelection = false;
            this.lstvMain.Location = new System.Drawing.Point(12, 12);
            this.lstvMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstvMain.MultiSelect = false;
            this.lstvMain.Name = "lstvMain";
            this.lstvMain.Size = new System.Drawing.Size(1321, 380);
            this.lstvMain.TabIndex = 13;
            this.lstvMain.UseCompatibleStateImageBehavior = false;
            this.lstvMain.View = System.Windows.Forms.View.Details;
            this.lstvMain.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstvMain_MouseDoubleClick);
            // 
            // clmCategory
            // 
            this.clmCategory.Text = "분류";
            this.clmCategory.Width = 80;
            // 
            // clmLength
            // 
            this.clmLength.Text = "길이(글자)";
            this.clmLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clmLength.Width = 90;
            // 
            // clmSize
            // 
            this.clmSize.Text = "크기(KB)";
            this.clmSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clmSize.Width = 80;
            // 
            // clmName
            // 
            this.clmName.Text = "폴더명/파일명";
            this.clmName.Width = 150;
            // 
            // clmFullName
            // 
            this.clmFullName.Text = "절대경로";
            this.clmFullName.Width = 150;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnReload);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1345, 256);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lstvMain);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 284);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.panel2.Size = new System.Drawing.Size(1345, 404);
            this.panel2.TabIndex = 15;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1345, 688);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStripMain);
            this.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPathLengthLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFileSizeLimit)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHelp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRootPath;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnBrowseRootPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudPathLengthLimit;
        private System.Windows.Forms.NumericUpDown nudFileSizeLimit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.ListView lstvMain;
        private System.Windows.Forms.ColumnHeader clmCategory;
        private System.Windows.Forms.ColumnHeader clmLength;
        private System.Windows.Forms.ColumnHeader clmName;
        private System.Windows.Forms.ColumnHeader clmFullName;
        private System.Windows.Forms.ColumnHeader clmSize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

