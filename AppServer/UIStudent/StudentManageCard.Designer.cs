namespace AppServer.UIStudent
{
    partial class StudentManageCard
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
            this._btnExamReport = new System.Windows.Forms.Button();
            this._btnDelete = new System.Windows.Forms.Button();
            this._btnEdit = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this._lv = new System.Windows.Forms.ListView();
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._btnAdd = new System.Windows.Forms.Button();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // _btnExamReport
            // 
            this._btnExamReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnExamReport.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this._btnExamReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnExamReport.Location = new System.Drawing.Point(732, 3);
            this._btnExamReport.Name = "_btnExamReport";
            this._btnExamReport.Size = new System.Drawing.Size(150, 25);
            this._btnExamReport.TabIndex = 55;
            this._btnExamReport.Text = "Xem điểm các lần thi";
            this._btnExamReport.UseVisualStyleBackColor = true;
            this._btnExamReport.Visible = false;
            this._btnExamReport.Click += new System.EventHandler(this._btnExamReport_Click);
            // 
            // _btnDelete
            // 
            this._btnDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this._btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnDelete.Location = new System.Drawing.Point(160, 2);
            this._btnDelete.Name = "_btnDelete";
            this._btnDelete.Size = new System.Drawing.Size(80, 25);
            this._btnDelete.TabIndex = 54;
            this._btnDelete.Text = "Xóa";
            this._btnDelete.UseVisualStyleBackColor = true;
            this._btnDelete.Visible = false;
            this._btnDelete.Click += new System.EventHandler(this._btnDelete_Click);
            // 
            // _btnEdit
            // 
            this._btnEdit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this._btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnEdit.Location = new System.Drawing.Point(81, 2);
            this._btnEdit.Name = "_btnEdit";
            this._btnEdit.Size = new System.Drawing.Size(80, 25);
            this._btnEdit.TabIndex = 53;
            this._btnEdit.Text = "Sửa";
            this._btnEdit.UseVisualStyleBackColor = true;
            this._btnEdit.Visible = false;
            this._btnEdit.Click += new System.EventHandler(this._btnEdit_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this._lv);
            this.groupBox3.Location = new System.Drawing.Point(0, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(885, 150);
            this.groupBox3.TabIndex = 52;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách học sinh";
            // 
            // _lv
            // 
            this._lv.BackColor = System.Drawing.SystemColors.Window;
            this._lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader17,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this._lv.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lv.FullRowSelect = true;
            this._lv.GridLines = true;
            this._lv.Location = new System.Drawing.Point(3, 16);
            this._lv.MultiSelect = false;
            this._lv.Name = "_lv";
            this._lv.Size = new System.Drawing.Size(879, 131);
            this._lv.TabIndex = 0;
            this._lv.UseCompatibleStateImageBehavior = false;
            this._lv.View = System.Windows.Forms.View.Details;
            this._lv.SelectedIndexChanged += new System.EventHandler(this._lv_SelectedIndexChanged);
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Mã";
            this.columnHeader13.Width = 42;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Tên học sinh";
            this.columnHeader14.Width = 123;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Địa chỉ email";
            this.columnHeader15.Width = 110;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Số điện thoại";
            this.columnHeader17.Width = 87;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Lớp";
            this.columnHeader1.Width = 95;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Thông tin thêm";
            this.columnHeader2.Width = 175;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên đăng nhập";
            this.columnHeader3.Width = 114;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mật khẩu";
            this.columnHeader4.Width = 113;
            // 
            // _btnAdd
            // 
            this._btnAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this._btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnAdd.Location = new System.Drawing.Point(2, 2);
            this._btnAdd.Name = "_btnAdd";
            this._btnAdd.Size = new System.Drawing.Size(80, 25);
            this._btnAdd.TabIndex = 46;
            this._btnAdd.Text = "Thêm";
            this._btnAdd.UseVisualStyleBackColor = true;
            this._btnAdd.Click += new System.EventHandler(this._btnAdd_Click);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "STT";
            // 
            // StudentManageCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._btnExamReport);
            this.Controls.Add(this._btnDelete);
            this.Controls.Add(this._btnEdit);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this._btnAdd);
            this.Name = "StudentManageCard";
            this.Size = new System.Drawing.Size(887, 185);
            this.Load += new System.EventHandler(this.StudentManageCard_Load);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _btnExamReport;
        private System.Windows.Forms.Button _btnDelete;
        private System.Windows.Forms.Button _btnEdit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView _lv;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.Button _btnAdd;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}
