namespace AppServer.UIQuestionSheet.UIQuestion
{
    partial class frmQuestionImport
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnConfig = new System.Windows.Forms.Panel();
            this.btnOpen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnProcessing = new System.Windows.Forms.Panel();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.lblQuestionNumber = new System.Windows.Forms.Label();
            this.lblProcessedLine = new System.Windows.Forms.Label();
            this.lblTotalLine = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.chkAutoClose = new System.Windows.Forms.CheckBox();
            this.pnConfig.SuspendLayout();
            this.pnProcessing.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Location = new System.Drawing.Point(206, 147);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(76, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "Bắt đầu";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(281, 147);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(76, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Đóng";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnConfig
            // 
            this.pnConfig.BackColor = System.Drawing.Color.White;
            this.pnConfig.Controls.Add(this.btnOpen);
            this.pnConfig.Controls.Add(this.label3);
            this.pnConfig.Controls.Add(this.txtFilePath);
            this.pnConfig.Controls.Add(this.label2);
            this.pnConfig.Location = new System.Drawing.Point(1, 0);
            this.pnConfig.Name = "pnConfig";
            this.pnConfig.Size = new System.Drawing.Size(368, 141);
            this.pnConfig.TabIndex = 7;
            // 
            // btnOpen
            // 
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Location = new System.Drawing.Point(280, 96);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(76, 24);
            this.btnOpen.TabIndex = 11;
            this.btnOpen.Text = "Mở";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(15, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(350, 35);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tệp tin chứa câu hỏi cần tuân thủ theo định dạng mà chương trình đề ra.";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(18, 71);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(338, 20);
            this.txtFilePath.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tệp tin:";
            // 
            // pnProcessing
            // 
            this.pnProcessing.BackColor = System.Drawing.Color.White;
            this.pnProcessing.Controls.Add(this.lblPercentage);
            this.pnProcessing.Controls.Add(this.lblQuestionNumber);
            this.pnProcessing.Controls.Add(this.lblProcessedLine);
            this.pnProcessing.Controls.Add(this.lblTotalLine);
            this.pnProcessing.Controls.Add(this.progressBar1);
            this.pnProcessing.Controls.Add(this.label7);
            this.pnProcessing.Controls.Add(this.label6);
            this.pnProcessing.Controls.Add(this.label5);
            this.pnProcessing.Controls.Add(this.lblStatus);
            this.pnProcessing.Location = new System.Drawing.Point(0, 0);
            this.pnProcessing.Name = "pnProcessing";
            this.pnProcessing.Size = new System.Drawing.Size(369, 141);
            this.pnProcessing.TabIndex = 8;
            // 
            // lblPercentage
            // 
            this.lblPercentage.Location = new System.Drawing.Point(309, 15);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(46, 13);
            this.lblPercentage.TabIndex = 12;
            this.lblPercentage.Text = "0%";
            this.lblPercentage.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblQuestionNumber
            // 
            this.lblQuestionNumber.AutoSize = true;
            this.lblQuestionNumber.Location = new System.Drawing.Point(130, 107);
            this.lblQuestionNumber.Name = "lblQuestionNumber";
            this.lblQuestionNumber.Size = new System.Drawing.Size(13, 13);
            this.lblQuestionNumber.TabIndex = 10;
            this.lblQuestionNumber.Text = "0";
            // 
            // lblProcessedLine
            // 
            this.lblProcessedLine.AutoSize = true;
            this.lblProcessedLine.Location = new System.Drawing.Point(130, 86);
            this.lblProcessedLine.Name = "lblProcessedLine";
            this.lblProcessedLine.Size = new System.Drawing.Size(13, 13);
            this.lblProcessedLine.TabIndex = 9;
            this.lblProcessedLine.Text = "0";
            // 
            // lblTotalLine
            // 
            this.lblTotalLine.AutoSize = true;
            this.lblTotalLine.Location = new System.Drawing.Point(130, 66);
            this.lblTotalLine.Name = "lblTotalLine";
            this.lblTotalLine.Size = new System.Drawing.Size(13, 13);
            this.lblTotalLine.TabIndex = 8;
            this.lblTotalLine.Text = "0";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(25, 31);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(330, 17);
            this.progressBar1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Số lượng câu hỏi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Số dòng đã xử lý:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tổng số dòng:";
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(22, 15);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(333, 13);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "...";
            // 
            // chkAutoClose
            // 
            this.chkAutoClose.AutoSize = true;
            this.chkAutoClose.Location = new System.Drawing.Point(12, 151);
            this.chkAutoClose.Name = "chkAutoClose";
            this.chkAutoClose.Size = new System.Drawing.Size(169, 17);
            this.chkAutoClose.TabIndex = 9;
            this.chkAutoClose.Text = "Tự động đóng khi hoàn thành";
            this.chkAutoClose.UseVisualStyleBackColor = true;
            // 
            // frmQuestionImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 179);
            this.ControlBox = false;
            this.Controls.Add(this.chkAutoClose);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.pnConfig);
            this.Controls.Add(this.pnProcessing);
            this.MaximumSize = new System.Drawing.Size(385, 218);
            this.MinimumSize = new System.Drawing.Size(385, 218);
            this.Name = "frmQuestionImport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nhập câu hỏi tự động";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQuestionImport_FormClosing);
            this.Load += new System.EventHandler(this.frmQuestionImport_Load);
            this.pnConfig.ResumeLayout(false);
            this.pnConfig.PerformLayout();
            this.pnProcessing.ResumeLayout(false);
            this.pnProcessing.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnConfig;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Panel pnProcessing;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblQuestionNumber;
        private System.Windows.Forms.Label lblProcessedLine;
        private System.Windows.Forms.Label lblTotalLine;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.CheckBox chkAutoClose;
    }
}