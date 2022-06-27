namespace AppServer.UIQuestionSheet.UIQuestion
{
    partial class frmQuestionPreview
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
            this.questionCard = new QuestionCard();
            this.navigation = new L3.Navigation();
            this.SuspendLayout();
            // 
            // questionCard
            // 
            this.questionCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.questionCard.BackColor = System.Drawing.Color.Transparent;
            this.questionCard.Location = new System.Drawing.Point(12, 12);
            this.questionCard.Name = "questionCard";
            this.questionCard.Size = new System.Drawing.Size(800, 562);
            this.questionCard.TabIndex = 2;
            // 
            // navigation
            // 
            this.navigation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.navigation.Current = 0;
            this.navigation.Location = new System.Drawing.Point(609, 12);
            this.navigation.Maximum = 100;
            this.navigation.Minimum = 0;
            this.navigation.Name = "navigation";
            this.navigation.Size = new System.Drawing.Size(203, 23);
            this.navigation.TabIndex = 3;
            // 
            // QuestionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 581);
            this.Controls.Add(this.navigation);
            this.Controls.Add(this.questionCard);
            this.MaximumSize = new System.Drawing.Size(840, 620);
            this.MinimumSize = new System.Drawing.Size(840, 620);
            this.Name = "QuestionList";
            this.Text = "Danh sách câu hỏi";
            this.Load += new System.EventHandler(this.QuestionList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private QuestionCard questionCard;
        private L3.Navigation navigation;
    }
}