namespace AppServer.UIQuestionSheet.UIQuestion
{
    partial class QuestionCard
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.scrollableControl1 = new System.Windows.Forms.ScrollableControl();
            this._pnHost = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this._rtbContent = new L3.ExRichText();
            this._lblB = new System.Windows.Forms.Label();
            this._pnShuffleAnswer = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this._chkShuffle = new System.Windows.Forms.CheckBox();
            this._lblA = new System.Windows.Forms.Label();
            this._pnAnswer = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this._abcd1 = new L3.ABCD();
            this._lblD = new System.Windows.Forms.Label();
            this._rtbB = new L3.ExRichText();
            this._rtbA = new L3.ExRichText();
            this._rtbC = new L3.ExRichText();
            this._lblC = new System.Windows.Forms.Label();
            this._rtbD = new L3.ExRichText();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this._brtbGuide = new L3.ExRichText();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.scrollableControl1.SuspendLayout();
            this._pnHost.SuspendLayout();
            this._pnShuffleAnswer.SuspendLayout();
            this._pnAnswer.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(6, 10);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(810, 562);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 19;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabPage1.Controls.Add(this.scrollableControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 36);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(802, 522);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nội dung câu hỏi";
            // 
            // scrollableControl1
            // 
            this.scrollableControl1.AutoScroll = true;
            this.scrollableControl1.BackColor = System.Drawing.Color.White;
            this.scrollableControl1.Controls.Add(this._pnHost);
            this.scrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollableControl1.Location = new System.Drawing.Point(3, 3);
            this.scrollableControl1.Name = "scrollableControl1";
            this.scrollableControl1.Size = new System.Drawing.Size(796, 516);
            this.scrollableControl1.TabIndex = 0;
            this.scrollableControl1.Text = "scrollableControl1";
            // 
            // _pnHost
            // 
            this._pnHost.BackColor = System.Drawing.Color.White;
            this._pnHost.Controls.Add(this.label1);
            this._pnHost.Controls.Add(this._rtbContent);
            this._pnHost.Controls.Add(this._lblB);
            this._pnHost.Controls.Add(this._pnShuffleAnswer);
            this._pnHost.Controls.Add(this._lblA);
            this._pnHost.Controls.Add(this._pnAnswer);
            this._pnHost.Controls.Add(this._lblD);
            this._pnHost.Controls.Add(this._rtbB);
            this._pnHost.Controls.Add(this._rtbA);
            this._pnHost.Controls.Add(this._rtbC);
            this._pnHost.Controls.Add(this._lblC);
            this._pnHost.Controls.Add(this._rtbD);
            this._pnHost.Location = new System.Drawing.Point(3, 3);
            this._pnHost.Name = "_pnHost";
            this._pnHost.Size = new System.Drawing.Size(769, 510);
            this._pnHost.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 71;
            this.label1.Text = "Câu hỏi:";
            // 
            // _rtbContent
            // 
            this._rtbContent.AcceptsTab = true;
            this._rtbContent.AutoWordSelection = true;
            this._rtbContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._rtbContent.DetectUrls = false;
            this._rtbContent.Location = new System.Drawing.Point(20, 23);
            this._rtbContent.Name = "_rtbContent";
            this._rtbContent.Size = new System.Drawing.Size(728, 16);
            this._rtbContent.TabIndex = 70;
            this._rtbContent.Text = "";
            this._rtbContent.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler(this.rtb_ContentsResized);
            this._rtbContent.SizeChanged += new System.EventHandler(this.rtb_SizeChanged);
            // 
            // _lblB
            // 
            this._lblB.AutoSize = true;
            this._lblB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblB.Location = new System.Drawing.Point(17, 83);
            this._lblB.Name = "_lblB";
            this._lblB.Size = new System.Drawing.Size(21, 16);
            this._lblB.TabIndex = 62;
            this._lblB.Text = "B)";
            // 
            // _pnShuffleAnswer
            // 
            this._pnShuffleAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._pnShuffleAnswer.Controls.Add(this.label6);
            this._pnShuffleAnswer.Controls.Add(this._chkShuffle);
            this._pnShuffleAnswer.Location = new System.Drawing.Point(465, 464);
            this._pnShuffleAnswer.Name = "_pnShuffleAnswer";
            this._pnShuffleAnswer.Size = new System.Drawing.Size(276, 36);
            this._pnShuffleAnswer.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Trộn đáp án:";
            // 
            // _chkShuffle
            // 
            this._chkShuffle.Location = new System.Drawing.Point(94, 12);
            this._chkShuffle.Name = "_chkShuffle";
            this._chkShuffle.Size = new System.Drawing.Size(15, 14);
            this._chkShuffle.TabIndex = 49;
            this._chkShuffle.UseVisualStyleBackColor = false;
            // 
            // _lblA
            // 
            this._lblA.AutoSize = true;
            this._lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblA.Location = new System.Drawing.Point(17, 60);
            this._lblA.Name = "_lblA";
            this._lblA.Size = new System.Drawing.Size(21, 16);
            this._lblA.TabIndex = 66;
            this._lblA.Text = "A)";
            // 
            // _pnAnswer
            // 
            this._pnAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._pnAnswer.Controls.Add(this.label5);
            this._pnAnswer.Controls.Add(this._abcd1);
            this._pnAnswer.Location = new System.Drawing.Point(465, 424);
            this._pnAnswer.Name = "_pnAnswer";
            this._pnAnswer.Size = new System.Drawing.Size(276, 34);
            this._pnAnswer.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Đáp án:";
            // 
            // _abcd1
            // 
            this._abcd1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._abcd1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._abcd1.Location = new System.Drawing.Point(94, 4);
            this._abcd1.Name = "_abcd1";
            this._abcd1.Size = new System.Drawing.Size(164, 27);
            this._abcd1.TabIndex = 48;
            // 
            // _lblD
            // 
            this._lblD.AutoSize = true;
            this._lblD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblD.Location = new System.Drawing.Point(16, 135);
            this._lblD.Name = "_lblD";
            this._lblD.Size = new System.Drawing.Size(22, 16);
            this._lblD.TabIndex = 64;
            this._lblD.Text = "D)";
            // 
            // _rtbB
            // 
            this._rtbB.BackColor = System.Drawing.Color.White;
            this._rtbB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._rtbB.Location = new System.Drawing.Point(40, 81);
            this._rtbB.Name = "_rtbB";
            this._rtbB.Size = new System.Drawing.Size(719, 19);
            this._rtbB.TabIndex = 67;
            this._rtbB.Text = "";
            this._rtbB.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler(this.rtb_ContentsResized);
            this._rtbB.SizeChanged += new System.EventHandler(this.rtb_SizeChanged);
            // 
            // _rtbA
            // 
            this._rtbA.BackColor = System.Drawing.Color.White;
            this._rtbA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._rtbA.Location = new System.Drawing.Point(40, 56);
            this._rtbA.Name = "_rtbA";
            this._rtbA.Size = new System.Drawing.Size(719, 19);
            this._rtbA.TabIndex = 68;
            this._rtbA.Text = "";
            this._rtbA.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler(this.rtb_ContentsResized);
            this._rtbA.SizeChanged += new System.EventHandler(this.rtb_SizeChanged);
            // 
            // _rtbC
            // 
            this._rtbC.BackColor = System.Drawing.Color.White;
            this._rtbC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._rtbC.Location = new System.Drawing.Point(40, 106);
            this._rtbC.Name = "_rtbC";
            this._rtbC.Size = new System.Drawing.Size(719, 19);
            this._rtbC.TabIndex = 69;
            this._rtbC.Text = "";
            this._rtbC.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler(this.rtb_ContentsResized);
            this._rtbC.SizeChanged += new System.EventHandler(this.rtb_SizeChanged);
            // 
            // _lblC
            // 
            this._lblC.AutoSize = true;
            this._lblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblC.Location = new System.Drawing.Point(17, 109);
            this._lblC.Name = "_lblC";
            this._lblC.Size = new System.Drawing.Size(21, 16);
            this._lblC.TabIndex = 63;
            this._lblC.Text = "C)";
            // 
            // _rtbD
            // 
            this._rtbD.BackColor = System.Drawing.Color.White;
            this._rtbD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._rtbD.Location = new System.Drawing.Point(40, 131);
            this._rtbD.Name = "_rtbD";
            this._rtbD.Size = new System.Drawing.Size(719, 19);
            this._rtbD.TabIndex = 65;
            this._rtbD.Text = "";
            this._rtbD.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler(this.rtb_ContentsResized);
            this._rtbD.SizeChanged += new System.EventHandler(this.rtb_SizeChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this._brtbGuide);
            this.tabPage2.Location = new System.Drawing.Point(4, 36);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(802, 522);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lời giải";
            // 
            // _brtbGuide
            // 
            this._brtbGuide.Dock = System.Windows.Forms.DockStyle.Fill;
            this._brtbGuide.Location = new System.Drawing.Point(3, 3);
            this._brtbGuide.Name = "_brtbGuide";
            this._brtbGuide.Size = new System.Drawing.Size(796, 516);
            this._brtbGuide.TabIndex = 0;
            this._brtbGuide.Text = "";
            // 
            // QuestionCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tabControl1);
            this.Name = "QuestionCard";
            this.Size = new System.Drawing.Size(810, 562);
            this.Load += new System.EventHandler(this.QuestionCard_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.scrollableControl1.ResumeLayout(false);
            this._pnHost.ResumeLayout(false);
            this._pnHost.PerformLayout();
            this._pnShuffleAnswer.ResumeLayout(false);
            this._pnShuffleAnswer.PerformLayout();
            this._pnAnswer.ResumeLayout(false);
            this._pnAnswer.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private L3.ExRichText _brtbGuide;
        private System.Windows.Forms.ScrollableControl scrollableControl1;
        private System.Windows.Forms.Panel _pnHost;
        private System.Windows.Forms.Label label1;
        private L3.ExRichText _rtbContent;
        private System.Windows.Forms.Label _lblB;
        private System.Windows.Forms.Panel _pnShuffleAnswer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox _chkShuffle;
        private System.Windows.Forms.Label _lblA;
        private System.Windows.Forms.Panel _pnAnswer;
        private System.Windows.Forms.Label label5;
        private L3.ABCD _abcd1;
        private System.Windows.Forms.Label _lblD;
        private L3.ExRichText _rtbB;
        private L3.ExRichText _rtbA;
        private L3.ExRichText _rtbC;
        private System.Windows.Forms.Label _lblC;
        private L3.ExRichText _rtbD;
    }
}
