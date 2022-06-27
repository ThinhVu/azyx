namespace AppServer.UIClass
{
    partial class ClassCard
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
            this._txtClassName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._txtAdditionInfo = new System.Windows.Forms.TextBox();
            this._txtClassAlias = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên lớp:";
            // 
            // _txtClassName
            // 
            this._txtClassName.Location = new System.Drawing.Point(17, 77);
            this._txtClassName.Name = "_txtClassName";
            this._txtClassName.Size = new System.Drawing.Size(254, 20);
            this._txtClassName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mô tả:";
            // 
            // _txtAdditionInfo
            // 
            this._txtAdditionInfo.Location = new System.Drawing.Point(17, 122);
            this._txtAdditionInfo.Multiline = true;
            this._txtAdditionInfo.Name = "_txtAdditionInfo";
            this._txtAdditionInfo.Size = new System.Drawing.Size(254, 84);
            this._txtAdditionInfo.TabIndex = 3;
            // 
            // _txtClassAlias
            // 
            this._txtClassAlias.Location = new System.Drawing.Point(17, 31);
            this._txtClassAlias.Name = "_txtClassAlias";
            this._txtClassAlias.Size = new System.Drawing.Size(254, 20);
            this._txtClassAlias.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã lớp:";
            // 
            // ClassCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this._txtClassAlias);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._txtAdditionInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._txtClassName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ClassCard";
            this.Size = new System.Drawing.Size(287, 226);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtClassName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _txtAdditionInfo;
        private System.Windows.Forms.TextBox _txtClassAlias;
        private System.Windows.Forms.Label label3;
    }
}
