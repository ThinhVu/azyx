namespace AppServer.UIQuestionSheet
{
    partial class QuestionSheetManageCard
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
            this._btnDelete = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._lvQSheet = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._btnAdd = new System.Windows.Forms.Button();
            this._btnEdit = new System.Windows.Forms.Button();
            this._btnQuestionManage = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // _btnDelete
            // 
            this._btnDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this._btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnDelete.Location = new System.Drawing.Point(160, 2);
            this._btnDelete.Name = "_btnDelete";
            this._btnDelete.Size = new System.Drawing.Size(80, 25);
            this._btnDelete.TabIndex = 34;
            this._btnDelete.Text = "Xóa";
            this._btnDelete.UseVisualStyleBackColor = false;
            this._btnDelete.Visible = false;
            this._btnDelete.Click += new System.EventHandler(this._btnDelete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this._lvQSheet);
            this.groupBox2.Location = new System.Drawing.Point(0, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1018, 170);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách bộ đề";
            // 
            // _lvQSheet
            // 
            this._lvQSheet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader10,
            this.columnHeader11});
            this._lvQSheet.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lvQSheet.FullRowSelect = true;
            this._lvQSheet.GridLines = true;
            this._lvQSheet.Location = new System.Drawing.Point(3, 16);
            this._lvQSheet.MultiSelect = false;
            this._lvQSheet.Name = "_lvQSheet";
            this._lvQSheet.Size = new System.Drawing.Size(1012, 151);
            this._lvQSheet.TabIndex = 0;
            this._lvQSheet.UseCompatibleStateImageBehavior = false;
            this._lvQSheet.View = System.Windows.Forms.View.Details;
            this._lvQSheet.SelectedIndexChanged += new System.EventHandler(this._lvQSheet_SelectedIndexChanged);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Mã bộ đề";
            this.columnHeader7.Width = 81;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Môn học";
            this.columnHeader8.Width = 139;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Thời lượng bài làm";
            this.columnHeader10.Width = 177;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Thông tin thêm...";
            this.columnHeader11.Width = 397;
            // 
            // _btnAdd
            // 
            this._btnAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this._btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnAdd.Location = new System.Drawing.Point(2, 2);
            this._btnAdd.Name = "_btnAdd";
            this._btnAdd.Size = new System.Drawing.Size(80, 25);
            this._btnAdd.TabIndex = 26;
            this._btnAdd.Text = "Thêm";
            this._btnAdd.UseVisualStyleBackColor = false;
            this._btnAdd.Click += new System.EventHandler(this._btnAdd_Click);
            // 
            // _btnEdit
            // 
            this._btnEdit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this._btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnEdit.Location = new System.Drawing.Point(81, 2);
            this._btnEdit.Name = "_btnEdit";
            this._btnEdit.Size = new System.Drawing.Size(80, 25);
            this._btnEdit.TabIndex = 35;
            this._btnEdit.Text = "Sửa";
            this._btnEdit.UseVisualStyleBackColor = false;
            this._btnEdit.Visible = false;
            this._btnEdit.Click += new System.EventHandler(this._btnEdit_Click);
            // 
            // _btnQuestionManage
            // 
            this._btnQuestionManage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnQuestionManage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this._btnQuestionManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnQuestionManage.Location = new System.Drawing.Point(868, 3);
            this._btnQuestionManage.Name = "_btnQuestionManage";
            this._btnQuestionManage.Size = new System.Drawing.Size(147, 25);
            this._btnQuestionManage.TabIndex = 36;
            this._btnQuestionManage.Text = "Quản lý câu hỏi";
            this._btnQuestionManage.UseVisualStyleBackColor = false;
            this._btnQuestionManage.Visible = false;
            this._btnQuestionManage.Click += new System.EventHandler(this._btnQuestionManage_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            // 
            // QuestionSheetManageCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._btnQuestionManage);
            this.Controls.Add(this._btnEdit);
            this.Controls.Add(this._btnDelete);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this._btnAdd);
            this.Name = "QuestionSheetManageCard";
            this.Size = new System.Drawing.Size(1020, 205);
            this.Load += new System.EventHandler(this.QuestionSheetManageCard_Load);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _btnDelete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView _lvQSheet;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Button _btnAdd;
        private System.Windows.Forms.Button _btnEdit;
        private System.Windows.Forms.Button _btnQuestionManage;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}
