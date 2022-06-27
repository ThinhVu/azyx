namespace AppServer.UITheTest
{
    partial class TestManageCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {                                               
            this.columnHeader0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this._lvaTheTest = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._btnStart = new System.Windows.Forms.Button();
            this._btnViewTestResult = new System.Windows.Forms.Button();
            this._btnRefresh = new System.Windows.Forms.Button();
            this._btnStop = new System.Windows.Forms.Button();
            this._chkHideTheTestDone = new System.Windows.Forms.CheckBox();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
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
            this.columnHeader2.Width = 121;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mã đề thi";
            this.columnHeader3.Width = 89;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Bắt đầu";
            this.columnHeader4.Width = 108;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Trạng thái";
            this.columnHeader5.Width = 138;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Mô tả";
            this.columnHeader6.Width = 119;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this._lvaTheTest);
            this.groupBox3.Location = new System.Drawing.Point(0, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(934, 199);
            this.groupBox3.TabIndex = 80;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách bài thi";
            // 
            // _lvaTheTest
            // 
            this._lvaTheTest.BackColor = System.Drawing.SystemColors.Window;
            this._lvaTheTest.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader0,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this._lvaTheTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lvaTheTest.FullRowSelect = true;
            this._lvaTheTest.GridLines = true;
            this._lvaTheTest.Location = new System.Drawing.Point(3, 16);
            this._lvaTheTest.Name = "_lvaTheTest";
            this._lvaTheTest.Size = new System.Drawing.Size(928, 180);
            this._lvaTheTest.TabIndex = 0;
            this._lvaTheTest.UseCompatibleStateImageBehavior = false;
            this._lvaTheTest.View = System.Windows.Forms.View.Details;
            this._lvaTheTest.SelectedIndexChanged += new System.EventHandler(this._lvTheTest_SelectedIndexChanged);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "STT";
            this.columnHeader7.Width = 45;
            // 
            // _btnStart
            // 
            this._btnStart.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this._btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnStart.Location = new System.Drawing.Point(0, 0);
            this._btnStart.Name = "_btnStart";
            this._btnStart.Size = new System.Drawing.Size(73, 23);
            this._btnStart.TabIndex = 82;
            this._btnStart.Text = "Bắt đầu";
            this._btnStart.UseVisualStyleBackColor = false;
            this._btnStart.Click += new System.EventHandler(this._btnStart_Click);
            // 
            // _btnViewTestResult
            // 
            this._btnViewTestResult.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this._btnViewTestResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnViewTestResult.Location = new System.Drawing.Point(72, 0);
            this._btnViewTestResult.Name = "_btnViewTestResult";
            this._btnViewTestResult.Size = new System.Drawing.Size(100, 23);
            this._btnViewTestResult.TabIndex = 85;
            this._btnViewTestResult.Text = "Xem kết quả";
            this._btnViewTestResult.UseVisualStyleBackColor = false;
            this._btnViewTestResult.Visible = false;
            this._btnViewTestResult.Click += new System.EventHandler(this._btnViewTestResult_Click);
            // 
            // _btnRefresh
            // 
            this._btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnRefresh.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this._btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnRefresh.Location = new System.Drawing.Point(807, 0);
            this._btnRefresh.Name = "_btnRefresh";
            this._btnRefresh.Size = new System.Drawing.Size(129, 23);
            this._btnRefresh.TabIndex = 86;
            this._btnRefresh.Text = "Cập nhật danh sách";
            this._btnRefresh.UseVisualStyleBackColor = false;
            this._btnRefresh.Click += new System.EventHandler(this._btnRefresh_Click);
            // 
            // _btnStop
            // 
            this._btnStop.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this._btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnStop.Location = new System.Drawing.Point(72, 0);
            this._btnStop.Name = "_btnStop";
            this._btnStop.Size = new System.Drawing.Size(100, 23);
            this._btnStop.TabIndex = 89;
            this._btnStop.Text = "Kết thúc";
            this._btnStop.UseVisualStyleBackColor = false;
            this._btnStop.Visible = false;
            this._btnStop.Click += new System.EventHandler(this._btnStop_Click);
            // 
            // _chkHideTheTestDone
            // 
            this._chkHideTheTestDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._chkHideTheTestDone.AutoSize = true;
            this._chkHideTheTestDone.Location = new System.Drawing.Point(808, 27);
            this._chkHideTheTestDone.Name = "_chkHideTheTestDone";
            this._chkHideTheTestDone.Size = new System.Drawing.Size(112, 17);
            this._chkHideTheTestDone.TabIndex = 90;
            this._chkHideTheTestDone.Text = "Ẩn bài đã thi xong";
            this._chkHideTheTestDone.UseVisualStyleBackColor = true;
            this._chkHideTheTestDone.CheckedChanged += new System.EventHandler(this._chkHideTheTestDone_CheckedChanged);
            // 
            // TestManageCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this._chkHideTheTestDone);
            this.Controls.Add(this._btnStop);
            this.Controls.Add(this._btnRefresh);
            this.Controls.Add(this._btnViewTestResult);
            this.Controls.Add(this._btnStart);
            this.Controls.Add(this.groupBox3);
            this.Name = "TestManageCard";
            this.Size = new System.Drawing.Size(936, 234);
            this.Load += new System.EventHandler(this.TestManageCard_Load);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        System.Windows.Forms.ListView _lvaTheTest;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ColumnHeader columnHeader0;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button _btnStart;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button _btnViewTestResult;
        private System.Windows.Forms.Button _btnRefresh;
        private System.Windows.Forms.Button _btnStop;
        private System.Windows.Forms.CheckBox _chkHideTheTestDone;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}
