namespace AppServer.UIQuestionSheet.UIQuestion
{
    partial class frmQuestionManager
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
            this._btnAdd = new System.Windows.Forms.Button();
            this._btnDelete = new System.Windows.Forms.Button();
            this._btnEdit = new System.Windows.Forms.Button();
            this.grQuestionCard = new System.Windows.Forms.GroupBox();
            this.questionCard = new AppServer.UIQuestionSheet.UIQuestion.QuestionCard();
            this._pnLoading = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._btnImport = new System.Windows.Forms.Button();
            this.navBar = new L3.Navigation();
            this.grQuestionCard.SuspendLayout();
            this._pnLoading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // _btnAdd
            // 
            this._btnAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this._btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnAdd.Location = new System.Drawing.Point(6, 7);
            this._btnAdd.Name = "_btnAdd";
            this._btnAdd.Size = new System.Drawing.Size(80, 25);
            this._btnAdd.TabIndex = 1;
            this._btnAdd.Text = "Thêm";
            this._btnAdd.UseVisualStyleBackColor = false;
            this._btnAdd.Visible = false;
            this._btnAdd.Click += new System.EventHandler(this._btnAdd_Click);
            // 
            // _btnDelete
            // 
            this._btnDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this._btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnDelete.Location = new System.Drawing.Point(164, 7);
            this._btnDelete.Name = "_btnDelete";
            this._btnDelete.Size = new System.Drawing.Size(80, 25);
            this._btnDelete.TabIndex = 3;
            this._btnDelete.Text = "Xóa";
            this._btnDelete.UseVisualStyleBackColor = false;
            this._btnDelete.Visible = false;
            this._btnDelete.Click += new System.EventHandler(this._btnDelete_Click);
            // 
            // _btnEdit
            // 
            this._btnEdit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this._btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnEdit.Location = new System.Drawing.Point(85, 7);
            this._btnEdit.Name = "_btnEdit";
            this._btnEdit.Size = new System.Drawing.Size(80, 25);
            this._btnEdit.TabIndex = 2;
            this._btnEdit.Text = "Sửa";
            this._btnEdit.UseVisualStyleBackColor = false;
            this._btnEdit.Visible = false;
            this._btnEdit.Click += new System.EventHandler(this._btnEdit_Click);
            // 
            // grQuestionCard
            // 
            this.grQuestionCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grQuestionCard.Controls.Add(this.questionCard);
            this.grQuestionCard.Controls.Add(this._pnLoading);
            this.grQuestionCard.Location = new System.Drawing.Point(8, 49);
            this.grQuestionCard.Name = "grQuestionCard";
            this.grQuestionCard.Size = new System.Drawing.Size(825, 586);
            this.grQuestionCard.TabIndex = 0;
            this.grQuestionCard.TabStop = false;
            this.grQuestionCard.Text = "Danh sách câu hỏi";
            // 
            // questionCard
            // 
            this.questionCard.BackColor = System.Drawing.Color.SkyBlue;
            this.questionCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.questionCard.Location = new System.Drawing.Point(3, 16);
            this.questionCard.Name = "questionCard";
            this.questionCard.Size = new System.Drawing.Size(819, 567);
            this.questionCard.TabIndex = 0;
            // 
            // _pnLoading
            // 
            this._pnLoading.BackColor = System.Drawing.Color.White;
            this._pnLoading.Controls.Add(this.pictureBox1);
            this._pnLoading.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnLoading.Location = new System.Drawing.Point(3, 16);
            this._pnLoading.Name = "_pnLoading";
            this._pnLoading.Size = new System.Drawing.Size(819, 567);
            this._pnLoading.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::AppServer.Properties.Resources._200;
            this.pictureBox1.Location = new System.Drawing.Point(285, 152);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // _btnImport
            // 
            this._btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnImport.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this._btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnImport.Location = new System.Drawing.Point(724, 7);
            this._btnImport.Name = "_btnImport";
            this._btnImport.Size = new System.Drawing.Size(109, 25);
            this._btnImport.TabIndex = 4;
            this._btnImport.Text = "Nhập từ tệp tin";
            this._btnImport.UseVisualStyleBackColor = false;
            this._btnImport.Visible = false;
            this._btnImport.Click += new System.EventHandler(this._btnImport_Click);
            // 
            // navBar
            // 
            this.navBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.navBar.Current = 0;
            this.navBar.Location = new System.Drawing.Point(627, 42);
            this.navBar.Maximum = 0;
            this.navBar.Minimum = 0;
            this.navBar.Name = "navBar";
            this.navBar.Size = new System.Drawing.Size(202, 21);
            this.navBar.TabIndex = 5;
            // 
            // frmQuestionManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 643);
            this.Controls.Add(this.navBar);
            this.Controls.Add(this._btnAdd);
            this.Controls.Add(this._btnDelete);
            this.Controls.Add(this._btnEdit);
            this.Controls.Add(this._btnImport);
            this.Controls.Add(this.grQuestionCard);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(856, 682);
            this.MinimumSize = new System.Drawing.Size(856, 682);
            this.Name = "frmQuestionManager";
            this.ShowIcon = false;
            this.Text = "Quản lý câu hỏi";
            this.Load += new System.EventHandler(this.frmQuestionManager_Load);
            this.grQuestionCard.ResumeLayout(false);
            this._pnLoading.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _btnAdd;
        private System.Windows.Forms.Button _btnDelete;
        private System.Windows.Forms.Button _btnEdit;
        private System.Windows.Forms.GroupBox grQuestionCard;
        private System.Windows.Forms.Button _btnImport;
        private L3.Navigation navBar;
        private QuestionCard questionCard;
        private System.Windows.Forms.Panel _pnLoading;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}