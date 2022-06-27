namespace AppServer.UIStudent
{
    partial class frmStudentScoreReportOptions
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
            this._btnViewReport = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            this._cbSubject = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _btnViewReport
            // 
            this._btnViewReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnViewReport.BackColor = System.Drawing.SystemColors.Control;
            this._btnViewReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnViewReport.Location = new System.Drawing.Point(158, 59);
            this._btnViewReport.Name = "_btnViewReport";
            this._btnViewReport.Size = new System.Drawing.Size(75, 23);
            this._btnViewReport.TabIndex = 1;
            this._btnViewReport.Text = "Xem report";
            this._btnViewReport.UseVisualStyleBackColor = false;
            this._btnViewReport.Click += new System.EventHandler(this._btnViewReport_Click);
            // 
            // _btnCancel
            // 
            this._btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnCancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this._btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnCancel.Location = new System.Drawing.Point(239, 59);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(75, 23);
            this._btnCancel.TabIndex = 2;
            this._btnCancel.Text = "Đóng";
            this._btnCancel.UseVisualStyleBackColor = false;
            this._btnCancel.Click += new System.EventHandler(this._btnCancel_Click);
            // 
            // _cbSubject
            // 
            this._cbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbSubject.FormattingEnabled = true;
            this._cbSubject.Location = new System.Drawing.Point(86, 23);
            this._cbSubject.Name = "_cbSubject";
            this._cbSubject.Size = new System.Drawing.Size(228, 21);
            this._cbSubject.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Môn học:";
            // 
            // frmStudentScoreReportOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 94);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this._cbSubject);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnViewReport);
            this.Name = "frmStudentScoreReportOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tùy chọn báo cáo";
            this.Load += new System.EventHandler(this.StudentScoreReportOptions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnViewReport;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.ComboBox _cbSubject;
        private System.Windows.Forms.Label label1;
    }
}