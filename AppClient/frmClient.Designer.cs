namespace ClientApp
{
    partial class frmClient
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
            this.pnHost = new System.Windows.Forms.Panel();
            this.btnLoadTest = new System.Windows.Forms.Button();
            this.btnJoin = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this._lvTheTest = new System.Windows.Forms.ListView();
            this.columnHeader0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnHost.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnHost
            // 
            this.pnHost.BackColor = System.Drawing.Color.Transparent;
            this.pnHost.Controls.Add(this.btnLoadTest);
            this.pnHost.Controls.Add(this.btnJoin);
            this.pnHost.Controls.Add(this.groupBox3);
            this.pnHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnHost.Location = new System.Drawing.Point(0, 0);
            this.pnHost.Name = "pnHost";
            this.pnHost.Size = new System.Drawing.Size(947, 505);
            this.pnHost.TabIndex = 0;
            this.pnHost.Visible = false;
            // 
            // btnLoadTest
            // 
            this.btnLoadTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadTest.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLoadTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadTest.Location = new System.Drawing.Point(821, 6);
            this.btnLoadTest.Name = "btnLoadTest";
            this.btnLoadTest.Size = new System.Drawing.Size(121, 23);
            this.btnLoadTest.TabIndex = 86;
            this.btnLoadTest.Text = "Cập nhật danh sách";
            this.btnLoadTest.UseVisualStyleBackColor = false;
            this.btnLoadTest.Click += new System.EventHandler(this._btnUpdateExam_Click);
            // 
            // btnJoin
            // 
            this.btnJoin.BackColor = System.Drawing.Color.Moccasin;
            this.btnJoin.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnJoin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnJoin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnJoin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJoin.Location = new System.Drawing.Point(4, 6);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(84, 23);
            this.btnJoin.TabIndex = 85;
            this.btnJoin.Text = "Tham gia thi";
            this.btnJoin.UseVisualStyleBackColor = false;
            this.btnJoin.Visible = false;
            this.btnJoin.Click += new System.EventHandler(this._btnJoin_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this._lvTheTest);
            this.groupBox3.Location = new System.Drawing.Point(1, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(944, 463);
            this.groupBox3.TabIndex = 84;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách thi";
            // 
            // _lvTheTest
            // 
            this._lvTheTest.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader0,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this._lvTheTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lvTheTest.FullRowSelect = true;
            this._lvTheTest.GridLines = true;
            this._lvTheTest.Location = new System.Drawing.Point(3, 16);
            this._lvTheTest.Name = "_lvTheTest";
            this._lvTheTest.Size = new System.Drawing.Size(938, 444);
            this._lvTheTest.TabIndex = 1;
            this._lvTheTest.UseCompatibleStateImageBehavior = false;
            this._lvTheTest.View = System.Windows.Forms.View.Details;
            this._lvTheTest.SelectedIndexChanged += new System.EventHandler(this._lvTheTest_SelectedIndexChanged);
            // 
            // columnHeader0
            // 
            this.columnHeader0.Text = "Mã bài thi";
            this.columnHeader0.Width = 73;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên bài thi";
            this.columnHeader1.Width = 118;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Môn thi";
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mã đề thi";
            this.columnHeader3.Width = 107;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Bắt đầu";
            this.columnHeader4.Width = 108;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Trạng thái";
            this.columnHeader5.Width = 112;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Mô tả";
            this.columnHeader6.Width = 195;
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 505);
            this.Controls.Add(this.pnHost);
            this.Name = "frmClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AZYX Client - Phần mềm thi trắc nghiệm ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmClient_FormClosing);
            this.Load += new System.EventHandler(this.frmClient_Load);
            this.pnHost.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnHost;
        private System.Windows.Forms.Button btnLoadTest;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView _lvTheTest;
        private System.Windows.Forms.ColumnHeader columnHeader0;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader5;

    }
}