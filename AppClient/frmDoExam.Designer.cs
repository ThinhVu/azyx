namespace ClientApp
{
    partial class frmDoExam
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
            this.components = new System.ComponentModel.Container();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnOpenCalc = new System.Windows.Forms.Button();
            this.timerCountdown = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this._picHourGlass = new System.Windows.Forms.PictureBox();
            this._lblRemainingTime = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._lblNotDone = new System.Windows.Forms.Label();
            this._lblFalse = new System.Windows.Forms.Label();
            this._lblTrue = new System.Windows.Forms.Label();
            this._lblScore = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this._lblCorrectAnswer = new System.Windows.Forms.Label();
            this._grbQuestion = new System.Windows.Forms.GroupBox();
            this._abcd = new L3.ABCD();
            this._pnLoading = new System.Windows.Forms.Panel();
            this._picLoading = new System.Windows.Forms.PictureBox();
            this.questionCard1 = new ClientApp.UIQuestion.QuestionCard();
            this.exRichText1 = new L3.ExRichText();
            this._btnTemporySave = new System.Windows.Forms.Button();
            this.btnList = new ClientApp.ButtonList();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._picHourGlass)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this._grbQuestion.SuspendLayout();
            this._pnLoading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._picLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Location = new System.Drawing.Point(1111, 508);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(98, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Nộp bài";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this._btnSubmit_Click);
            // 
            // btnOpenCalc
            // 
            this.btnOpenCalc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenCalc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOpenCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenCalc.Location = new System.Drawing.Point(915, 508);
            this.btnOpenCalc.Name = "btnOpenCalc";
            this.btnOpenCalc.Size = new System.Drawing.Size(92, 23);
            this.btnOpenCalc.TabIndex = 5;
            this.btnOpenCalc.Text = "Mở máy tính";
            this.btnOpenCalc.UseVisualStyleBackColor = false;
            this.btnOpenCalc.Click += new System.EventHandler(this._btnOpenCalc_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this._picHourGlass);
            this.panel1.Controls.Add(this._lblRemainingTime);
            this.panel1.Location = new System.Drawing.Point(833, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 69);
            this.panel1.TabIndex = 9;
            // 
            // _picHourGlass
            // 
            this._picHourGlass.Image = global::ClientApp.Properties.Resources.hourglass_full32;
            this._picHourGlass.Location = new System.Drawing.Point(4, 16);
            this._picHourGlass.Name = "_picHourGlass";
            this._picHourGlass.Size = new System.Drawing.Size(31, 35);
            this._picHourGlass.TabIndex = 19;
            this._picHourGlass.TabStop = false;
            // 
            // _lblRemainingTime
            // 
            this._lblRemainingTime.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblRemainingTime.Location = new System.Drawing.Point(29, 16);
            this._lblRemainingTime.Name = "_lblRemainingTime";
            this._lblRemainingTime.Size = new System.Drawing.Size(156, 37);
            this._lblRemainingTime.TabIndex = 18;
            this._lblRemainingTime.Text = "00:00:00";
            this._lblRemainingTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.toolTip.SetToolTip(this._lblRemainingTime, "Thời gian còn lại");
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this._lblNotDone);
            this.panel2.Controls.Add(this._lblFalse);
            this.panel2.Controls.Add(this._lblTrue);
            this.panel2.Controls.Add(this._lblScore);
            this.panel2.Location = new System.Drawing.Point(1035, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(174, 69);
            this.panel2.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ClientApp.Properties.Resources.scoreboard;
            this.pictureBox1.Location = new System.Drawing.Point(7, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 35);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // _lblNotDone
            // 
            this._lblNotDone.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblNotDone.Image = global::ClientApp.Properties.Resources.dots_clear;
            this._lblNotDone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._lblNotDone.Location = new System.Drawing.Point(137, 47);
            this._lblNotDone.Name = "_lblNotDone";
            this._lblNotDone.Size = new System.Drawing.Size(33, 14);
            this._lblNotDone.TabIndex = 24;
            this._lblNotDone.Text = "00";
            this._lblNotDone.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.toolTip.SetToolTip(this._lblNotDone, "Số câu chưa làm");
            // 
            // _lblFalse
            // 
            this._lblFalse.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblFalse.Image = global::ClientApp.Properties.Resources.dot_false;
            this._lblFalse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._lblFalse.Location = new System.Drawing.Point(137, 30);
            this._lblFalse.Name = "_lblFalse";
            this._lblFalse.Size = new System.Drawing.Size(33, 14);
            this._lblFalse.TabIndex = 23;
            this._lblFalse.Text = "00";
            this._lblFalse.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.toolTip.SetToolTip(this._lblFalse, "Số câu làm sai");
            // 
            // _lblTrue
            // 
            this._lblTrue.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblTrue.Image = global::ClientApp.Properties.Resources.dot_true;
            this._lblTrue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._lblTrue.Location = new System.Drawing.Point(137, 11);
            this._lblTrue.Name = "_lblTrue";
            this._lblTrue.Size = new System.Drawing.Size(33, 14);
            this._lblTrue.TabIndex = 22;
            this._lblTrue.Text = "00";
            this._lblTrue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.toolTip.SetToolTip(this._lblTrue, "Số câu làm đúng");
            // 
            // _lblScore
            // 
            this._lblScore.AutoSize = true;
            this._lblScore.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblScore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._lblScore.Location = new System.Drawing.Point(32, 11);
            this._lblScore.Name = "_lblScore";
            this._lblScore.Size = new System.Drawing.Size(105, 45);
            this._lblScore.TabIndex = 20;
            this._lblScore.Text = "0.00";
            this._lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip.SetToolTip(this._lblScore, "Điểm số");
            // 
            // _lblCorrectAnswer
            // 
            this._lblCorrectAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._lblCorrectAnswer.AutoSize = true;
            this._lblCorrectAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblCorrectAnswer.Location = new System.Drawing.Point(526, 29);
            this._lblCorrectAnswer.Name = "_lblCorrectAnswer";
            this._lblCorrectAnswer.Size = new System.Drawing.Size(40, 39);
            this._lblCorrectAnswer.TabIndex = 15;
            this._lblCorrectAnswer.Text = "A";
            this.toolTip.SetToolTip(this._lblCorrectAnswer, "Đáp án chính xác");
            this._lblCorrectAnswer.Visible = false;
            // 
            // _grbQuestion
            // 
            this._grbQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._grbQuestion.BackColor = System.Drawing.Color.Transparent;
            this._grbQuestion.Controls.Add(this._abcd);
            this._grbQuestion.Controls.Add(this._pnLoading);
            this._grbQuestion.Controls.Add(this.questionCard1);
            this._grbQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._grbQuestion.Location = new System.Drawing.Point(12, 12);
            this._grbQuestion.Name = "_grbQuestion";
            this._grbQuestion.Size = new System.Drawing.Size(808, 519);
            this._grbQuestion.TabIndex = 12;
            this._grbQuestion.TabStop = false;
            this._grbQuestion.Text = "Câu hỏi";
            // 
            // _abcd
            // 
            this._abcd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._abcd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._abcd.Location = new System.Drawing.Point(554, 15);
            this._abcd.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this._abcd.Name = "_abcd";
            this._abcd.Size = new System.Drawing.Size(251, 41);
            this._abcd.TabIndex = 14;
            // 
            // _pnLoading
            // 
            this._pnLoading.BackColor = System.Drawing.Color.White;
            this._pnLoading.Controls.Add(this._picLoading);
            this._pnLoading.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnLoading.Location = new System.Drawing.Point(3, 16);
            this._pnLoading.Name = "_pnLoading";
            this._pnLoading.Size = new System.Drawing.Size(802, 500);
            this._pnLoading.TabIndex = 16;
            // 
            // _picLoading
            // 
            this._picLoading.BackColor = System.Drawing.SystemColors.Window;
            this._picLoading.Image = global::ClientApp.Properties.Resources._200;
            this._picLoading.Location = new System.Drawing.Point(302, 170);
            this._picLoading.Name = "_picLoading";
            this._picLoading.Size = new System.Drawing.Size(196, 181);
            this._picLoading.TabIndex = 17;
            this._picLoading.TabStop = false;
            // 
            // questionCard1
            // 
            this.questionCard1.AutoSize = true;
            this.questionCard1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.questionCard1.BackColor = System.Drawing.Color.SkyBlue;
            this.questionCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.questionCard1.Location = new System.Drawing.Point(3, 16);
            this.questionCard1.Name = "questionCard1";
            this.questionCard1.Size = new System.Drawing.Size(802, 500);
            this.questionCard1.TabIndex = 16;
            // 
            // exRichText1
            // 
            this.exRichText1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exRichText1.Location = new System.Drawing.Point(833, 260);
            this.exRichText1.Name = "exRichText1";
            this.exRichText1.Size = new System.Drawing.Size(376, 242);
            this.exRichText1.TabIndex = 13;
            this.exRichText1.Text = "--- Nhap --";
            // 
            // _btnTemporySave
            // 
            this._btnTemporySave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnTemporySave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this._btnTemporySave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnTemporySave.Location = new System.Drawing.Point(1013, 508);
            this._btnTemporySave.Name = "_btnTemporySave";
            this._btnTemporySave.Size = new System.Drawing.Size(92, 23);
            this._btnTemporySave.TabIndex = 14;
            this._btnTemporySave.Text = "Lưu tạm thời";
            this._btnTemporySave.UseVisualStyleBackColor = false;
            this._btnTemporySave.Click += new System.EventHandler(this._btnTemporySave_Click);
            // 
            // btnList
            // 
            this.btnList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnList.BackColor = System.Drawing.SystemColors.Window;
            this.btnList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnList.Location = new System.Drawing.Point(833, 87);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(376, 167);
            this.btnList.TabIndex = 7;
            // 
            // frmDoExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1218, 543);
            this.Controls.Add(this._lblCorrectAnswer);
            this.Controls.Add(this._btnTemporySave);
            this.Controls.Add(this.exRichText1);
            this.Controls.Add(this._grbQuestion);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOpenCalc);
            this.Controls.Add(this.btnSubmit);
            this.Name = "frmDoExam";
            this.Text = "Làm bài thi [Đỗ Trung Nghĩa] - Môn Toán - Mã đề 1804091324";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDoExam_FormClosing);
            this.Load += new System.EventHandler(this.frmDoExam_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._picHourGlass)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this._grbQuestion.ResumeLayout(false);
            this._grbQuestion.PerformLayout();
            this._pnLoading.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._picLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnOpenCalc;
        private System.Windows.Forms.Timer timerCountdown;
        private ButtonList btnList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label _lblRemainingTime;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label _lblScore;
        private System.Windows.Forms.Label _lblTrue;
        private System.Windows.Forms.Label _lblNotDone;
        private System.Windows.Forms.Label _lblFalse;
        private System.Windows.Forms.PictureBox _picHourGlass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.GroupBox _grbQuestion;
        private System.Windows.Forms.Panel _pnLoading;
        private System.Windows.Forms.PictureBox _picLoading;
        private L3.ABCD _abcd;
        private System.Windows.Forms.Label _lblCorrectAnswer;
        private ClientApp.UIQuestion.QuestionCard questionCard1;
        private L3.ExRichText exRichText1;
        private System.Windows.Forms.Button _btnTemporySave;
    }
}