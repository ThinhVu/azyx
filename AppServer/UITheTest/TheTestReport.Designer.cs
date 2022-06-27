namespace AppServer.UITheTest
{
    partial class TheTestReport
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
            this._lvAnswer = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._lblReportDate = new System.Windows.Forms.Label();
            this._lblReportTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._lblTestAlias = new System.Windows.Forms.Label();
            this._lblTestName = new System.Windows.Forms.Label();
            this._lblSubjectName = new System.Windows.Forms.Label();
            this._lblTestDate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this._lblPageIndex = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._lblTestTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _lvAnswer
            // 
            this._lvAnswer.BackColor = System.Drawing.Color.White;
            this._lvAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._lvAnswer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader7,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this._lvAnswer.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lvAnswer.FullRowSelect = true;
            this._lvAnswer.GridLines = true;
            this._lvAnswer.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this._lvAnswer.Location = new System.Drawing.Point(81, 430);
            this._lvAnswer.MultiSelect = false;
            this._lvAnswer.Name = "_lvAnswer";
            this._lvAnswer.Scrollable = false;
            this._lvAnswer.Size = new System.Drawing.Size(618, 487);
            this._lvAnswer.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this._lvAnswer.TabIndex = 1;
            this._lvAnswer.TileSize = new System.Drawing.Size(1, 1);
            this._lvAnswer.UseCompatibleStateImageBehavior = false;
            this._lvAnswer.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            this.columnHeader1.Width = 41;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên học sinh";
            this.columnHeader2.Width = 122;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Điểm";
            this.columnHeader7.Width = 51;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Bỏ qua (*)";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Câu đúng (*)";
            this.columnHeader4.Width = 92;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Câu sai (*)";
            this.columnHeader5.Width = 79;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Thời gian làm bài (**)";
            this.columnHeader6.Width = 153;
            // 
            // _lblReportDate
            // 
            this._lblReportDate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblReportDate.Location = new System.Drawing.Point(628, 70);
            this._lblReportDate.Name = "_lblReportDate";
            this._lblReportDate.Size = new System.Drawing.Size(73, 13);
            this._lblReportDate.TabIndex = 2;
            this._lblReportDate.Text = "01/05/2018";
            this._lblReportDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _lblReportTime
            // 
            this._lblReportTime.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblReportTime.Location = new System.Drawing.Point(629, 83);
            this._lblReportTime.Name = "_lblReportTime";
            this._lblReportTime.Size = new System.Drawing.Size(73, 13);
            this._lblReportTime.TabIndex = 3;
            this._lblReportTime.Text = "9:30:12 AM";
            this._lblReportTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(262, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thông tin điểm thi";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.LightGray;
            this.label5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(78, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(619, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Thông tin bài thi";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(620, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Thông tin điểm thi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 946);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "(**) Giá trị tính theo phút";
            // 
            // _lblTestAlias
            // 
            this._lblTestAlias.AutoEllipsis = true;
            this._lblTestAlias.BackColor = System.Drawing.Color.Transparent;
            this._lblTestAlias.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblTestAlias.Location = new System.Drawing.Point(102, 256);
            this._lblTestAlias.Name = "_lblTestAlias";
            this._lblTestAlias.Size = new System.Drawing.Size(595, 13);
            this._lblTestAlias.TabIndex = 14;
            this._lblTestAlias.Text = "Mã bài thi: ....................................................................." +
    "...........................................................................";
            // 
            // _lblTestName
            // 
            this._lblTestName.AutoEllipsis = true;
            this._lblTestName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblTestName.Location = new System.Drawing.Point(102, 290);
            this._lblTestName.Name = "_lblTestName";
            this._lblTestName.Size = new System.Drawing.Size(597, 13);
            this._lblTestName.TabIndex = 15;
            this._lblTestName.Text = "Tên bài thi: ...................................................................." +
    "...............................................................";
            // 
            // _lblSubjectName
            // 
            this._lblSubjectName.AutoEllipsis = true;
            this._lblSubjectName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblSubjectName.Location = new System.Drawing.Point(102, 320);
            this._lblSubjectName.Name = "_lblSubjectName";
            this._lblSubjectName.Size = new System.Drawing.Size(597, 13);
            this._lblSubjectName.TabIndex = 16;
            this._lblSubjectName.Text = "Tên môn thi: ...................................................................." +
    ".............................................................";
            // 
            // _lblTestDate
            // 
            this._lblTestDate.AutoEllipsis = true;
            this._lblTestDate.BackColor = System.Drawing.Color.White;
            this._lblTestDate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblTestDate.Location = new System.Drawing.Point(424, 350);
            this._lblTestDate.Name = "_lblTestDate";
            this._lblTestDate.Size = new System.Drawing.Size(273, 13);
            this._lblTestDate.TabIndex = 17;
            this._lblTestDate.Text = "Ngày thi: ......................................................................." +
    "...............................................................";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(77, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 1);
            this.panel1.TabIndex = 19;
            // 
            // _lblPageIndex
            // 
            this._lblPageIndex.Location = new System.Drawing.Point(624, 986);
            this._lblPageIndex.Name = "_lblPageIndex";
            this._lblPageIndex.Size = new System.Drawing.Size(67, 13);
            this._lblPageIndex.TabIndex = 39;
            this._lblPageIndex.Text = "1";
            this._lblPageIndex.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 930);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "(*) Giá trị tính theo số lượng câu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(74, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "LUYỆN THI HỒNG ĐĂNG";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _lblTestTime
            // 
            this._lblTestTime.AutoEllipsis = true;
            this._lblTestTime.BackColor = System.Drawing.Color.White;
            this._lblTestTime.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblTestTime.Location = new System.Drawing.Point(102, 350);
            this._lblTestTime.Name = "_lblTestTime";
            this._lblTestTime.Size = new System.Drawing.Size(275, 13);
            this._lblTestTime.TabIndex = 42;
            this._lblTestTime.Text = "Thời gian thi: .................................................................." +
    "....................................................................";
            // 
            // TheTestReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this._lblTestTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._lblPageIndex);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this._lblReportTime);
            this.Controls.Add(this._lblReportDate);
            this.Controls.Add(this._lblTestAlias);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._lvAnswer);
            this.Controls.Add(this._lblTestName);
            this.Controls.Add(this._lblSubjectName);
            this.Controls.Add(this._lblTestDate);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TheTestReport";
            this.Size = new System.Drawing.Size(794, 1048);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView _lvAnswer;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label _lblReportDate;
        private System.Windows.Forms.Label _lblReportTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label _lblTestAlias;
        private System.Windows.Forms.Label _lblTestName;
        private System.Windows.Forms.Label _lblSubjectName;
        private System.Windows.Forms.Label _lblTestDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label _lblPageIndex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label _lblTestTime;
    }
}
