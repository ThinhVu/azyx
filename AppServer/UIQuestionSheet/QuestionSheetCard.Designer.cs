namespace AppServer.UIQuestionSheet
{
    partial class QuestionSheetCard
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
            this.label1 = new System.Windows.Forms.Label();
            this._cbSubject = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this._rtbAdditionlInfo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._nudTestTime = new System.Windows.Forms.NumericUpDown();
            this._btnQuestionManage = new System.Windows.Forms.Label();
            this._txtAlias = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._nudTestTime)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Môn học:";
            // 
            // _cbSubject
            // 
            this._cbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbSubject.FormattingEnabled = true;
            this._cbSubject.Location = new System.Drawing.Point(13, 109);
            this._cbSubject.Name = "_cbSubject";
            this._cbSubject.Size = new System.Drawing.Size(276, 21);
            this._cbSubject.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mô tả:";
            // 
            // _rtbAdditionlInfo
            // 
            this._rtbAdditionlInfo.Location = new System.Drawing.Point(13, 179);
            this._rtbAdditionlInfo.Multiline = true;
            this._rtbAdditionlInfo.Name = "_rtbAdditionlInfo";
            this._rtbAdditionlInfo.Size = new System.Drawing.Size(276, 85);
            this._rtbAdditionlInfo.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Thời lượng bài làm (phút):";
            // 
            // _nudTestTime
            // 
            this._nudTestTime.Location = new System.Drawing.Point(215, 138);
            this._nudTestTime.Name = "_nudTestTime";
            this._nudTestTime.Size = new System.Drawing.Size(74, 20);
            this._nudTestTime.TabIndex = 3;
            // 
            // _btnQuestionManage
            // 
            this._btnQuestionManage.Location = new System.Drawing.Point(13, 14);
            this._btnQuestionManage.Name = "_btnQuestionManage";
            this._btnQuestionManage.Size = new System.Drawing.Size(276, 29);
            this._btnQuestionManage.TabIndex = 12;
            this._btnQuestionManage.Text = "Chọn lựa thông tin môn học, nhập thời lượng làm bài, số lượng câu hỏi và thông ti" +
    "n bổ sung.";
            // 
            // _txtAlias
            // 
            this._txtAlias.Location = new System.Drawing.Point(13, 69);
            this._txtAlias.Name = "_txtAlias";
            this._txtAlias.Size = new System.Drawing.Size(276, 20);
            this._txtAlias.TabIndex = 1;
            this._txtAlias.Tag = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mã đề:";
            // 
            // QuestionSheetCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this._txtAlias);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._btnQuestionManage);
            this.Controls.Add(this._nudTestTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._rtbAdditionlInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._cbSubject);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "QuestionSheetCard";
            this.Size = new System.Drawing.Size(308, 286);
            ((System.ComponentModel.ISupportInitialize)(this._nudTestTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _cbSubject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _rtbAdditionlInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown _nudTestTime;
        private System.Windows.Forms.Label _btnQuestionManage;
        private System.Windows.Forms.TextBox _txtAlias;
        private System.Windows.Forms.Label label3;
    }
}
