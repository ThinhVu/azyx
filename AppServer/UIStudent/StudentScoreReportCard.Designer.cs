namespace AppServer.UIStudent
{
    partial class StudentScoreReportCard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this._lblReportTime = new System.Windows.Forms.Label();
            this._lblReportDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._lblStudentId = new System.Windows.Forms.Label();
            this._lblStudentName = new System.Windows.Forms.Label();
            this._lblClassName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._lvTestAnswer = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label7 = new System.Windows.Forms.Label();
            this._lblSubject = new System.Windows.Forms.Label();
            this._picLoading = new System.Windows.Forms.PictureBox();
            this._lblPageIndex = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._picLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(84, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 1);
            this.panel1.TabIndex = 24;
            // 
            // _lblReportTime
            // 
            this._lblReportTime.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblReportTime.Location = new System.Drawing.Point(639, 81);
            this._lblReportTime.Name = "_lblReportTime";
            this._lblReportTime.Size = new System.Drawing.Size(74, 13);
            this._lblReportTime.TabIndex = 21;
            this._lblReportTime.Text = "9:30:12 AM";
            this._lblReportTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _lblReportDate
            // 
            this._lblReportDate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblReportDate.Location = new System.Drawing.Point(639, 68);
            this._lblReportDate.Name = "_lblReportDate";
            this._lblReportDate.Size = new System.Drawing.Size(74, 13);
            this._lblReportDate.TabIndex = 20;
            this._lblReportDate.Text = "01/05/2018";
            this._lblReportDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(259, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 32);
            this.label3.TabIndex = 22;
            this.label3.Text = "Thông tin điểm thi";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.LightGray;
            this.label5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(86, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(632, 18);
            this.label5.TabIndex = 26;
            this.label5.Text = "Thông tin học sinh";
            // 
            // _lblStudentId
            // 
            this._lblStudentId.AutoEllipsis = true;
            this._lblStudentId.BackColor = System.Drawing.Color.Transparent;
            this._lblStudentId.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblStudentId.Location = new System.Drawing.Point(110, 242);
            this._lblStudentId.Name = "_lblStudentId";
            this._lblStudentId.Size = new System.Drawing.Size(599, 13);
            this._lblStudentId.TabIndex = 27;
            this._lblStudentId.Text = "Mã học sinh: ...................................................................." +
    "............................................................................";
            // 
            // _lblStudentName
            // 
            this._lblStudentName.AutoEllipsis = true;
            this._lblStudentName.BackColor = System.Drawing.Color.Transparent;
            this._lblStudentName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblStudentName.Location = new System.Drawing.Point(110, 265);
            this._lblStudentName.Name = "_lblStudentName";
            this._lblStudentName.Size = new System.Drawing.Size(599, 13);
            this._lblStudentName.TabIndex = 28;
            this._lblStudentName.Text = "Tên học sinh: ..................................................................." +
    ".............................................................................";
            // 
            // _lblClassName
            // 
            this._lblClassName.AutoEllipsis = true;
            this._lblClassName.BackColor = System.Drawing.Color.Transparent;
            this._lblClassName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblClassName.Location = new System.Drawing.Point(110, 291);
            this._lblClassName.Name = "_lblClassName";
            this._lblClassName.Size = new System.Drawing.Size(599, 13);
            this._lblClassName.TabIndex = 29;
            this._lblClassName.Text = "Tên lớp: ........................................................................" +
    "........................................................................";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(634, 18);
            this.label4.TabIndex = 30;
            this.label4.Text = "Thông tin điểm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Môn học:";
            // 
            // _lvTestAnswer
            // 
            this._lvTestAnswer.BackColor = System.Drawing.Color.White;
            this._lvTestAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._lvTestAnswer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this._lvTestAnswer.FullRowSelect = true;
            this._lvTestAnswer.GridLines = true;
            this._lvTestAnswer.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this._lvTestAnswer.Location = new System.Drawing.Point(89, 392);
            this._lvTestAnswer.Margin = new System.Windows.Forms.Padding(0);
            this._lvTestAnswer.MultiSelect = false;
            this._lvTestAnswer.Name = "_lvTestAnswer";
            this._lvTestAnswer.Scrollable = false;
            this._lvTestAnswer.Size = new System.Drawing.Size(629, 538);
            this._lvTestAnswer.TabIndex = 33;
            this._lvTestAnswer.UseCompatibleStateImageBehavior = false;
            this._lvTestAnswer.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            this.columnHeader1.Width = 35;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã bài thi";
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên bài thi";
            this.columnHeader3.Width = 134;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ngày thi";
            this.columnHeader4.Width = 135;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Điểm";
            this.columnHeader5.Width = 59;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Bỏ qua";
            this.columnHeader6.Width = 54;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Đúng";
            this.columnHeader7.Width = 42;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Sai";
            this.columnHeader8.Width = 40;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "(*)";
            this.columnHeader9.Width = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 939);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "(*) Thời gian làm bài (phút)";
            // 
            // _lblSubject
            // 
            this._lblSubject.AutoSize = true;
            this._lblSubject.Location = new System.Drawing.Point(154, 364);
            this._lblSubject.Name = "_lblSubject";
            this._lblSubject.Size = new System.Drawing.Size(70, 13);
            this._lblSubject.TabIndex = 37;
            this._lblSubject.Text = "_mon hoc_";
            // 
            // _picLoading
            // 
            this._picLoading.Image = global::AppServer.Properties.Resources.GD;
            this._picLoading.Location = new System.Drawing.Point(142, 473);
            this._picLoading.Name = "_picLoading";
            this._picLoading.Size = new System.Drawing.Size(498, 401);
            this._picLoading.TabIndex = 36;
            this._picLoading.TabStop = false;
            this._picLoading.Visible = false;
            // 
            // _lblPageIndex
            // 
            this._lblPageIndex.Location = new System.Drawing.Point(665, 971);
            this._lblPageIndex.Name = "_lblPageIndex";
            this._lblPageIndex.Size = new System.Drawing.Size(67, 13);
            this._lblPageIndex.TabIndex = 38;
            this._lblPageIndex.Text = "1";
            this._lblPageIndex.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "LUYỆN THI HỒNG ĐĂNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // StudentScoreReportCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this._lblPageIndex);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._lblClassName);
            this.Controls.Add(this._lblStudentName);
            this.Controls.Add(this._lblStudentId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._lblReportTime);
            this.Controls.Add(this._lblReportDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._picLoading);
            this.Controls.Add(this._lvTestAnswer);
            this.Controls.Add(this._lblSubject);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "StudentScoreReportCard";
            this.Size = new System.Drawing.Size(794, 1048);
            ((System.ComponentModel.ISupportInitialize)(this._picLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label _lblReportTime;
        private System.Windows.Forms.Label _lblReportDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label _lblStudentId;
        private System.Windows.Forms.Label _lblStudentName;
        private System.Windows.Forms.Label _lblClassName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView _lvTestAnswer;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox _picLoading;
        private System.Windows.Forms.Label _lblSubject;
        private System.Windows.Forms.Label _lblPageIndex;
        private System.Windows.Forms.Label label1;
    }
}
