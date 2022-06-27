namespace AppServer
{
    partial class frmServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServer));
            this.listView1 = new System.Windows.Forms.ListView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this._btnManageClass = new System.Windows.Forms.Button();
            this._btnManageQuestionSheet = new System.Windows.Forms.Button();
            this._btnManageStudent = new System.Windows.Forms.Button();
            this._btnManageSubject = new System.Windows.Forms.Button();
            this.pnManageHost = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.testManageCard1 = new AppServer.UITheTest.TestManageCard();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this._pnMenu = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.trợGiúpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this._mnuItemReportBug = new System.Windows.Forms.ToolStripMenuItem();
            this._mnuItemOpenGuide = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this._mnuItemAuthorInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this._pnMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(0, 20);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(863, 208);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage5.Controls.Add(this.panel1);
            this.tabPage5.ImageIndex = 1;
            this.tabPage5.Location = new System.Drawing.Point(4, 37);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(966, 640);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "Quản lý thông tin";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this._btnManageClass);
            this.panel1.Controls.Add(this._btnManageQuestionSheet);
            this.panel1.Controls.Add(this._btnManageStudent);
            this.panel1.Controls.Add(this._btnManageSubject);
            this.panel1.Controls.Add(this.pnManageHost);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 634);
            this.panel1.TabIndex = 1;
            // 
            // _btnManageClass
            // 
            this._btnManageClass.BackColor = System.Drawing.SystemColors.Control;
            this._btnManageClass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this._btnManageClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnManageClass.Image = global::AppServer.Properties.Resources.books;
            this._btnManageClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnManageClass.Location = new System.Drawing.Point(3, 5);
            this._btnManageClass.Name = "_btnManageClass";
            this._btnManageClass.Size = new System.Drawing.Size(129, 35);
            this._btnManageClass.TabIndex = 6;
            this._btnManageClass.Text = "Lớp học";
            this._btnManageClass.UseVisualStyleBackColor = true;
            this._btnManageClass.Click += new System.EventHandler(this._btnManageClass_Click);
            // 
            // _btnManageQuestionSheet
            // 
            this._btnManageQuestionSheet.BackColor = System.Drawing.SystemColors.Control;
            this._btnManageQuestionSheet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnManageQuestionSheet.Image = global::AppServer.Properties.Resources.list24;
            this._btnManageQuestionSheet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnManageQuestionSheet.Location = new System.Drawing.Point(3, 128);
            this._btnManageQuestionSheet.Name = "_btnManageQuestionSheet";
            this._btnManageQuestionSheet.Size = new System.Drawing.Size(129, 35);
            this._btnManageQuestionSheet.TabIndex = 5;
            this._btnManageQuestionSheet.Text = "Đề thi";
            this._btnManageQuestionSheet.UseVisualStyleBackColor = true;
            this._btnManageQuestionSheet.Click += new System.EventHandler(this.btnManageQuestionSheet_Click);
            // 
            // _btnManageStudent
            // 
            this._btnManageStudent.BackColor = System.Drawing.SystemColors.Control;
            this._btnManageStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnManageStudent.Image = global::AppServer.Properties.Resources.student24;
            this._btnManageStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnManageStudent.Location = new System.Drawing.Point(3, 87);
            this._btnManageStudent.Name = "_btnManageStudent";
            this._btnManageStudent.Size = new System.Drawing.Size(129, 35);
            this._btnManageStudent.TabIndex = 3;
            this._btnManageStudent.Text = "Thí sinh";
            this._btnManageStudent.UseVisualStyleBackColor = true;
            this._btnManageStudent.Click += new System.EventHandler(this.btnManageStudent_Click);
            // 
            // _btnManageSubject
            // 
            this._btnManageSubject.BackColor = System.Drawing.SystemColors.Control;
            this._btnManageSubject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this._btnManageSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnManageSubject.Image = global::AppServer.Properties.Resources.books;
            this._btnManageSubject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnManageSubject.Location = new System.Drawing.Point(3, 46);
            this._btnManageSubject.Name = "_btnManageSubject";
            this._btnManageSubject.Size = new System.Drawing.Size(129, 35);
            this._btnManageSubject.TabIndex = 2;
            this._btnManageSubject.Text = "Môn học";
            this._btnManageSubject.UseVisualStyleBackColor = true;
            this._btnManageSubject.Click += new System.EventHandler(this.btnManageSubject_Click);
            // 
            // pnManageHost
            // 
            this.pnManageHost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnManageHost.Location = new System.Drawing.Point(138, 4);
            this.pnManageHost.Name = "pnManageHost";
            this.pnManageHost.Size = new System.Drawing.Size(817, 625);
            this.pnManageHost.TabIndex = 1;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "exam24x24.png");
            this.imageList1.Images.SetKeyName(1, "menu24.png");
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage6.Controls.Add(this.testManageCard1);
            this.tabPage6.ImageIndex = 0;
            this.tabPage6.Location = new System.Drawing.Point(4, 37);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(966, 640);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "Tổ chức thi";
            // 
            // testManageCard1
            // 
            this.testManageCard1.BackColor = System.Drawing.Color.SkyBlue;
            this.testManageCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testManageCard1.Location = new System.Drawing.Point(3, 3);
            this.testManageCard1.Name = "testManageCard1";
            this.testManageCard1.Size = new System.Drawing.Size(960, 634);
            this.testManageCard1.TabIndex = 0;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.ImageList = this.imageList1;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.Padding = new System.Drawing.Point(6, 10);
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(974, 681);
            this.tabControl2.TabIndex = 1;
            this.tabControl2.SelectedIndexChanged += new System.EventHandler(this.tabControl2_SelectedIndexChanged);
            // 
            // _pnMenu
            // 
            this._pnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._pnMenu.Controls.Add(this.menuStrip1);
            this._pnMenu.Location = new System.Drawing.Point(901, 0);
            this._pnMenu.Name = "_pnMenu";
            this._pnMenu.Size = new System.Drawing.Size(72, 25);
            this._pnMenu.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trợGiúpToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(72, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // trợGiúpToolStripMenuItem1
            // 
            this.trợGiúpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._mnuItemReportBug,
            this._mnuItemOpenGuide,
            this.toolStripSeparator1,
            this._mnuItemAuthorInfo});
            this.trợGiúpToolStripMenuItem1.Name = "trợGiúpToolStripMenuItem1";
            this.trợGiúpToolStripMenuItem1.Size = new System.Drawing.Size(63, 20);
            this.trợGiúpToolStripMenuItem1.Text = "Trợ giúp";
            // 
            // _mnuItemReportBug
            // 
            this._mnuItemReportBug.Name = "_mnuItemReportBug";
            this._mnuItemReportBug.Size = new System.Drawing.Size(173, 22);
            this._mnuItemReportBug.Text = "Báo cáo lỗi";
            this._mnuItemReportBug.Click += new System.EventHandler(this._mnuItemReportBug_Click);
            // 
            // _mnuItemOpenGuide
            // 
            this._mnuItemOpenGuide.Name = "_mnuItemOpenGuide";
            this._mnuItemOpenGuide.Size = new System.Drawing.Size(173, 22);
            this._mnuItemOpenGuide.Text = "Xem hướng dẫn";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(170, 6);
            // 
            // _mnuItemAuthorInfo
            // 
            this._mnuItemAuthorInfo.Name = "_mnuItemAuthorInfo";
            this._mnuItemAuthorInfo.Size = new System.Drawing.Size(173, 22);
            this._mnuItemAuthorInfo.Text = "Thông tin về AZYX";
            // 
            // frmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(974, 681);
            this.Controls.Add(this._pnMenu);
            this.Controls.Add(this.tabControl2);
            this.MinimumSize = new System.Drawing.Size(990, 720);
            this.Name = "frmServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AZYX - Máy chấm thi - Máy chủ";
            this.tabPage5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this._pnMenu.ResumeLayout(false);
            this._pnMenu.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnManageHost;
        private System.Windows.Forms.Button _btnManageQuestionSheet;
        private System.Windows.Forms.Button _btnManageStudent;
        private System.Windows.Forms.Button _btnManageSubject;        
        private UITheTest.TestManageCard testManageCard1;
        private System.Windows.Forms.Button _btnManageClass;
        private System.Windows.Forms.Panel _pnMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem _mnuItemReportBug;
        private System.Windows.Forms.ToolStripMenuItem _mnuItemOpenGuide;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem _mnuItemAuthorInfo;
    }
}

