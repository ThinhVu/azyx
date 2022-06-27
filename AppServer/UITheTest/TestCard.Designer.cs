namespace AppServer.UITheTest
{
    partial class TestCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestCard));
            this.label1 = new System.Windows.Forms.Label();
            this._cbQuesionSheet = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this._txtAdditionlInfo = new System.Windows.Forms.TextBox();
            this._btnQuestionSheetPreview = new System.Windows.Forms.Button();
            this._cbSubject = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this._lblId = new System.Windows.Forms.Label();
            this._dtpCreatedDate = new System.Windows.Forms.DateTimePicker();
            this._lblStatus = new System.Windows.Forms.Label();
            this._txtAlias = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đề:";
            // 
            // _cbQuesionSheet
            // 
            this._cbQuesionSheet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbQuesionSheet.FormattingEnabled = true;
            this._cbQuesionSheet.Location = new System.Drawing.Point(73, 199);
            this._cbQuesionSheet.Name = "_cbQuesionSheet";
            this._cbQuesionSheet.Size = new System.Drawing.Size(178, 21);
            this._cbQuesionSheet.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mô tả:";
            // 
            // _txtAdditionlInfo
            // 
            this._txtAdditionlInfo.Location = new System.Drawing.Point(15, 243);
            this._txtAdditionlInfo.Multiline = true;
            this._txtAdditionlInfo.Name = "_txtAdditionlInfo";
            this._txtAdditionlInfo.Size = new System.Drawing.Size(327, 88);
            this._txtAdditionlInfo.TabIndex = 5;
            // 
            // _btnQuestionSheetPreview
            // 
            this._btnQuestionSheetPreview.Enabled = false;
            this._btnQuestionSheetPreview.Location = new System.Drawing.Point(257, 198);
            this._btnQuestionSheetPreview.Name = "_btnQuestionSheetPreview";
            this._btnQuestionSheetPreview.Size = new System.Drawing.Size(85, 23);
            this._btnQuestionSheetPreview.TabIndex = 6;
            this._btnQuestionSheetPreview.Text = "Xem nội dung";
            this._btnQuestionSheetPreview.UseVisualStyleBackColor = true;
            this._btnQuestionSheetPreview.Click += new System.EventHandler(this._btnQuestionSheetPreview_Click);
            // 
            // _cbSubject
            // 
            this._cbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbSubject.FormattingEnabled = true;
            this._cbSubject.Location = new System.Drawing.Point(73, 172);
            this._cbSubject.Name = "_cbSubject";
            this._cbSubject.Size = new System.Drawing.Size(269, 21);
            this._cbSubject.TabIndex = 2;
            this._cbSubject.SelectedIndexChanged += new System.EventHandler(this._cbSubject_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Môn học:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(345, 72);
            this.label4.TabIndex = 9;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tên bài thi:";
            // 
            // _txtName
            // 
            this._txtName.Location = new System.Drawing.Point(73, 120);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(269, 20);
            this._txtName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ngày tạo:";
            // 
            // _lblId
            // 
            this._lblId.AutoSize = true;
            this._lblId.Location = new System.Drawing.Point(13, 340);
            this._lblId.Name = "_lblId";
            this._lblId.Size = new System.Drawing.Size(13, 13);
            this._lblId.TabIndex = 14;
            this._lblId.Text = "0";
            this._lblId.Visible = false;
            // 
            // _dtpCreatedDate
            // 
            this._dtpCreatedDate.Enabled = false;
            this._dtpCreatedDate.Location = new System.Drawing.Point(73, 146);
            this._dtpCreatedDate.Name = "_dtpCreatedDate";
            this._dtpCreatedDate.Size = new System.Drawing.Size(269, 20);
            this._dtpCreatedDate.TabIndex = 15;
            // 
            // _lblStatus
            // 
            this._lblStatus.AutoSize = true;
            this._lblStatus.Location = new System.Drawing.Point(38, 340);
            this._lblStatus.Name = "_lblStatus";
            this._lblStatus.Size = new System.Drawing.Size(13, 13);
            this._lblStatus.TabIndex = 16;
            this._lblStatus.Text = "0";
            this._lblStatus.Visible = false;
            // 
            // _txtAlias
            // 
            this._txtAlias.Location = new System.Drawing.Point(73, 94);
            this._txtAlias.Name = "_txtAlias";
            this._txtAlias.Size = new System.Drawing.Size(269, 20);
            this._txtAlias.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Mã bài thi:";
            // 
            // TestCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this._txtAlias);
            this.Controls.Add(this.label7);
            this.Controls.Add(this._lblStatus);
            this.Controls.Add(this._dtpCreatedDate);
            this.Controls.Add(this._lblId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._cbSubject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._btnQuestionSheetPreview);
            this.Controls.Add(this._txtAdditionlInfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._cbQuesionSheet);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TestCard";
            this.Size = new System.Drawing.Size(358, 363);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _cbQuesionSheet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _txtAdditionlInfo;
        private System.Windows.Forms.Button _btnQuestionSheetPreview;
        private System.Windows.Forms.ComboBox _cbSubject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label _lblId;
        private System.Windows.Forms.DateTimePicker _dtpCreatedDate;
        private System.Windows.Forms.Label _lblStatus;
        private System.Windows.Forms.TextBox _txtAlias;
        private System.Windows.Forms.Label label7;
    }
}
