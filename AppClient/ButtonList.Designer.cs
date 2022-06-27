namespace ClientApp
{
    partial class ButtonList
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ButtonList));
            this.scrollableControl1 = new System.Windows.Forms.ScrollableControl();
            this.flpButtonContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.scrollableControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // scrollableControl1
            // 
            this.scrollableControl1.AutoScroll = true;
            this.scrollableControl1.Controls.Add(this.flpButtonContainer);
            this.scrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.scrollableControl1.Name = "scrollableControl1";
            this.scrollableControl1.Size = new System.Drawing.Size(613, 159);
            this.scrollableControl1.TabIndex = 0;
            this.scrollableControl1.Text = "scrollableControl1";
            // 
            // flpButtonContainer
            // 
            this.flpButtonContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpButtonContainer.AutoSize = true;
            this.flpButtonContainer.Location = new System.Drawing.Point(4, 0);
            this.flpButtonContainer.Name = "flpButtonContainer";
            this.flpButtonContainer.Size = new System.Drawing.Size(606, 156);
            this.flpButtonContainer.TabIndex = 0;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "check-mark.png");
            // 
            // ButtonList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scrollableControl1);
            this.Name = "ButtonList";
            this.Size = new System.Drawing.Size(613, 159);
            this.scrollableControl1.ResumeLayout(false);
            this.scrollableControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ScrollableControl scrollableControl1;
        private System.Windows.Forms.FlowLayoutPanel flpButtonContainer;
        private System.Windows.Forms.ImageList imageList;
    }
}
