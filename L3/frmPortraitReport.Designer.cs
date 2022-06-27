namespace L3
{
    partial class frmPortraitReport<TModel, TCard>
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
            this.scrollableControl1 = new System.Windows.Forms.ScrollableControl();
            this._pnHost = new System.Windows.Forms.Panel();
            this._btnSave = new System.Windows.Forms.Button();
            this._nudPage = new System.Windows.Forms.NumericUpDown();
            this._lblPageiOfn = new System.Windows.Forms.Label();
            this._lblSaving = new System.Windows.Forms.Label();
            this._btnPrint = new System.Windows.Forms.Button();
            this.scrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nudPage)).BeginInit();
            this.SuspendLayout();
            // 
            // scrollableControl1
            // 
            this.scrollableControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scrollableControl1.AutoScroll = true;
            this.scrollableControl1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.scrollableControl1.Controls.Add(this._pnHost);
            this.scrollableControl1.Location = new System.Drawing.Point(2, 39);
            this.scrollableControl1.Name = "scrollableControl1";
            this.scrollableControl1.Size = new System.Drawing.Size(821, 462);
            this.scrollableControl1.TabIndex = 3;
            this.scrollableControl1.Text = "scrollableControl1";
            // 
            // _pnHost
            // 
            this._pnHost.AutoSize = true;
            this._pnHost.BackColor = System.Drawing.Color.White;
            this._pnHost.Location = new System.Drawing.Point(3, 3);
            this._pnHost.Name = "_pnHost";
            this._pnHost.Size = new System.Drawing.Size(794, 27);
            this._pnHost.TabIndex = 1;
            // 
            // _btnSave
            // 
            this._btnSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this._btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnSave.Location = new System.Drawing.Point(2, 6);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(47, 23);
            this._btnSave.TabIndex = 5;
            this._btnSave.Text = "Save";
            this._btnSave.UseVisualStyleBackColor = false;
            this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
            // 
            // _nudPage
            // 
            this._nudPage.Location = new System.Drawing.Point(126, 8);
            this._nudPage.Name = "_nudPage";
            this._nudPage.Size = new System.Drawing.Size(54, 20);
            this._nudPage.TabIndex = 7;
            this._nudPage.ValueChanged += new System.EventHandler(this._nudPage_ValueChanged);
            // 
            // _lblPageiOfn
            // 
            this._lblPageiOfn.AutoSize = true;
            this._lblPageiOfn.Location = new System.Drawing.Point(186, 11);
            this._lblPageiOfn.Name = "_lblPageiOfn";
            this._lblPageiOfn.Size = new System.Drawing.Size(58, 13);
            this._lblPageiOfn.TabIndex = 8;
            this._lblPageiOfn.Text = "Page i of n";
            // 
            // _lblSaving
            // 
            this._lblSaving.Location = new System.Drawing.Point(655, 10);
            this._lblSaving.Name = "_lblSaving";
            this._lblSaving.Size = new System.Drawing.Size(144, 13);
            this._lblSaving.TabIndex = 9;
            this._lblSaving.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _btnPrint
            // 
            this._btnPrint.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this._btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnPrint.Location = new System.Drawing.Point(55, 6);
            this._btnPrint.Name = "_btnPrint";
            this._btnPrint.Size = new System.Drawing.Size(65, 23);
            this._btnPrint.TabIndex = 10;
            this._btnPrint.Text = "Print";
            this._btnPrint.UseVisualStyleBackColor = false;
            this._btnPrint.Click += new System.EventHandler(this._btnPrint_Click);
            // 
            // frmPortraitReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 507);
            this.Controls.Add(this._btnPrint);
            this.Controls.Add(this._lblSaving);
            this.Controls.Add(this._lblPageiOfn);
            this.Controls.Add(this._nudPage);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this.scrollableControl1);
            this.MaximizeBox = false;
            this.Name = "frmPortraitReport";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.scrollableControl1.ResumeLayout(false);
            this.scrollableControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nudPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ScrollableControl scrollableControl1;
        private System.Windows.Forms.Panel _pnHost;
        private System.Windows.Forms.Button _btnSave;
        private System.Windows.Forms.NumericUpDown _nudPage;
        private System.Windows.Forms.Label _lblPageiOfn;
        private System.Windows.Forms.Label _lblSaving;
        private System.Windows.Forms.Button _btnPrint;
    }
}