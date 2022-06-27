namespace ClientApp.UIQuestion
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
            this.lblId = new System.Windows.Forms.Label();
            this.scrollableControl1 = new System.Windows.Forms.ScrollableControl();
            this._pnHost = new System.Windows.Forms.Panel();
            this._rtbContent = new L3.ExRichText();
            this._lblB = new System.Windows.Forms.Label();
            this._lblA = new System.Windows.Forms.Label();
            this._lblD = new System.Windows.Forms.Label();
            this._rtbB = new L3.ExRichText();
            this._rtbA = new L3.ExRichText();
            this._rtbC = new L3.ExRichText();
            this._lblC = new System.Windows.Forms.Label();
            this._rtbD = new L3.ExRichText();
            this.scrollableControl1.SuspendLayout();
            this._pnHost.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(869, 8);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(13, 13);
            this.lblId.TabIndex = 17;
            this.lblId.Text = "0";
            this.lblId.Visible = false;
            // 
            // scrollableControl1
            // 
            this.scrollableControl1.AutoScroll = true;
            this.scrollableControl1.BackColor = System.Drawing.Color.White;
            this.scrollableControl1.Controls.Add(this._pnHost);
            this.scrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.scrollableControl1.Name = "scrollableControl1";
            this.scrollableControl1.Size = new System.Drawing.Size(810, 562);
            this.scrollableControl1.TabIndex = 18;
            this.scrollableControl1.Text = "scrollableControl1";
            this.scrollableControl1.SizeChanged += new System.EventHandler(this.scrollableControl1_SizeChanged);
            // 
            // _pnHost
            // 
            this._pnHost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._pnHost.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._pnHost.BackColor = System.Drawing.Color.White;
            this._pnHost.Controls.Add(this._rtbContent);
            this._pnHost.Controls.Add(this._lblB);
            this._pnHost.Controls.Add(this._lblA);
            this._pnHost.Controls.Add(this._lblD);
            this._pnHost.Controls.Add(this._rtbB);
            this._pnHost.Controls.Add(this._rtbA);
            this._pnHost.Controls.Add(this._rtbC);
            this._pnHost.Controls.Add(this._lblC);
            this._pnHost.Controls.Add(this._rtbD);
            this._pnHost.Location = new System.Drawing.Point(3, 3);
            this._pnHost.Name = "_pnHost";
            this._pnHost.Size = new System.Drawing.Size(804, 556);
            this._pnHost.TabIndex = 1;
            // 
            // _rtbContent
            // 
            this._rtbContent.AcceptsTab = true;
            this._rtbContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._rtbContent.AutoWordSelection = true;
            this._rtbContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._rtbContent.DetectUrls = false;
            this._rtbContent.Location = new System.Drawing.Point(20, 52);
            this._rtbContent.Name = "_rtbContent";
            this._rtbContent.Size = new System.Drawing.Size(772, 16);
            this._rtbContent.TabIndex = 70;
            this._rtbContent.Text = "";
            this._rtbContent.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler(this.rtb_ContentsResized);
            // 
            // _lblB
            // 
            this._lblB.AutoSize = true;
            this._lblB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblB.Location = new System.Drawing.Point(17, 115);
            this._lblB.Name = "_lblB";
            this._lblB.Size = new System.Drawing.Size(19, 13);
            this._lblB.TabIndex = 62;
            this._lblB.Text = "B)";
            // 
            // _lblA
            // 
            this._lblA.AutoSize = true;
            this._lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblA.Location = new System.Drawing.Point(17, 92);
            this._lblA.Name = "_lblA";
            this._lblA.Size = new System.Drawing.Size(19, 13);
            this._lblA.TabIndex = 66;
            this._lblA.Text = "A)";
            // 
            // _lblD
            // 
            this._lblD.AutoSize = true;
            this._lblD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblD.Location = new System.Drawing.Point(16, 167);
            this._lblD.Name = "_lblD";
            this._lblD.Size = new System.Drawing.Size(20, 13);
            this._lblD.TabIndex = 64;
            this._lblD.Text = "D)";
            // 
            // _rtbB
            // 
            this._rtbB.BackColor = System.Drawing.Color.White;
            this._rtbB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._rtbB.Location = new System.Drawing.Point(40, 113);
            this._rtbB.Name = "_rtbB";
            this._rtbB.Size = new System.Drawing.Size(750, 19);
            this._rtbB.TabIndex = 67;
            this._rtbB.Text = "";
            this._rtbB.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler(this.rtb_ContentsResized);
            // 
            // _rtbA
            // 
            this._rtbA.BackColor = System.Drawing.Color.White;
            this._rtbA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._rtbA.Location = new System.Drawing.Point(40, 88);
            this._rtbA.Name = "_rtbA";
            this._rtbA.Size = new System.Drawing.Size(750, 19);
            this._rtbA.TabIndex = 68;
            this._rtbA.Text = "";
            this._rtbA.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler(this.rtb_ContentsResized);
            // 
            // _rtbC
            // 
            this._rtbC.BackColor = System.Drawing.Color.White;
            this._rtbC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._rtbC.Location = new System.Drawing.Point(40, 138);
            this._rtbC.Name = "_rtbC";
            this._rtbC.Size = new System.Drawing.Size(750, 19);
            this._rtbC.TabIndex = 69;
            this._rtbC.Text = "";
            this._rtbC.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler(this.rtb_ContentsResized);
            // 
            // _lblC
            // 
            this._lblC.AutoSize = true;
            this._lblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblC.Location = new System.Drawing.Point(17, 141);
            this._lblC.Name = "_lblC";
            this._lblC.Size = new System.Drawing.Size(19, 13);
            this._lblC.TabIndex = 63;
            this._lblC.Text = "C)";
            // 
            // _rtbD
            // 
            this._rtbD.BackColor = System.Drawing.Color.White;
            this._rtbD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._rtbD.Location = new System.Drawing.Point(40, 163);
            this._rtbD.Name = "_rtbD";
            this._rtbD.Size = new System.Drawing.Size(750, 19);
            this._rtbD.TabIndex = 65;
            this._rtbD.Text = "";
            this._rtbD.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler(this.rtb_ContentsResized);
            // 
            // QuestionCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.scrollableControl1);
            this.Controls.Add(this.lblId);
            this.Name = "QuestionCard";
            this.Size = new System.Drawing.Size(810, 562);
            this.Load += new System.EventHandler(this.QuestionCard_Load);
            this.scrollableControl1.ResumeLayout(false);
            this._pnHost.ResumeLayout(false);
            this._pnHost.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ScrollableControl scrollableControl1;
        private System.Windows.Forms.Panel _pnHost;
        private L3.ExRichText _rtbContent;
        private System.Windows.Forms.Label _lblB;
        private System.Windows.Forms.Label _lblA;
        private System.Windows.Forms.Label _lblD;
        private L3.ExRichText _rtbB;
        private L3.ExRichText _rtbA;
        private L3.ExRichText _rtbC;
        private System.Windows.Forms.Label _lblC;
        private L3.ExRichText _rtbD;
    }
}
