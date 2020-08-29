namespace Ex01.ApplicationUI
{
    partial class FormAlbums
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
            this.albumPictureBox1 = new System.Windows.Forms.PictureBox();
            this.f_LinkLableNext = new System.Windows.Forms.LinkLabel();
            this.f_LinkLabelPrevious = new System.Windows.Forms.LinkLabel();
            this.f_LabelAlbumName = new System.Windows.Forms.Label();
            this.f_LabelCreatedDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.albumPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // albumPictureBox1
            // 
            this.albumPictureBox1.Location = new System.Drawing.Point(137, 93);
            this.albumPictureBox1.Name = "albumPictureBox1";
            this.albumPictureBox1.Size = new System.Drawing.Size(141, 158);
            this.albumPictureBox1.TabIndex = 1;
            this.albumPictureBox1.TabStop = false;
            // 
            // f_LinkLableNext
            // 
            this.f_LinkLableNext.AutoSize = true;
            this.f_LinkLableNext.Location = new System.Drawing.Point(331, 168);
            this.f_LinkLableNext.Name = "f_LinkLableNext";
            this.f_LinkLableNext.Size = new System.Drawing.Size(34, 17);
            this.f_LinkLableNext.TabIndex = 2;
            this.f_LinkLableNext.TabStop = true;
            this.f_LinkLableNext.Text = "next";
            this.f_LinkLableNext.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.nextLinkLable_LinkClicked);
            // 
            // f_LinkLabelPrevious
            // 
            this.f_LinkLabelPrevious.AutoSize = true;
            this.f_LinkLabelPrevious.Location = new System.Drawing.Point(21, 168);
            this.f_LinkLabelPrevious.Name = "f_LinkLabelPrevious";
            this.f_LinkLabelPrevious.Size = new System.Drawing.Size(62, 17);
            this.f_LinkLabelPrevious.TabIndex = 3;
            this.f_LinkLabelPrevious.TabStop = true;
            this.f_LinkLabelPrevious.Text = "previous";
            this.f_LinkLabelPrevious.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.previousLinkLabel_LinkClicked);
            // 
            // f_LabelAlbumName
            // 
            this.f_LabelAlbumName.AutoSize = true;
            this.f_LabelAlbumName.Location = new System.Drawing.Point(138, 40);
            this.f_LabelAlbumName.Name = "f_LabelAlbumName";
            this.f_LabelAlbumName.Size = new System.Drawing.Size(88, 17);
            this.f_LabelAlbumName.TabIndex = 4;
            this.f_LabelAlbumName.Text = "Album Name";
            // 
            // f_LabelCreatedDate
            // 
            this.f_LabelCreatedDate.AutoSize = true;
            this.f_LabelCreatedDate.Location = new System.Drawing.Point(134, 73);
            this.f_LabelCreatedDate.Name = "f_LabelCreatedDate";
            this.f_LabelCreatedDate.Size = new System.Drawing.Size(92, 17);
            this.f_LabelCreatedDate.TabIndex = 5;
            this.f_LabelCreatedDate.Text = "Created Date";
            // 
            // FormAlbums
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 327);
            this.Controls.Add(this.f_LabelCreatedDate);
            this.Controls.Add(this.f_LabelAlbumName);
            this.Controls.Add(this.f_LinkLabelPrevious);
            this.Controls.Add(this.f_LinkLableNext);
            this.Controls.Add(this.albumPictureBox1);
            this.Name = "FormAlbums";
            this.Text = "Albums";
            ((System.ComponentModel.ISupportInitialize)(this.albumPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox albumPictureBox1;
        private System.Windows.Forms.LinkLabel f_LinkLableNext;
        private System.Windows.Forms.LinkLabel f_LinkLabelPrevious;
        private System.Windows.Forms.Label f_LabelAlbumName;
        private System.Windows.Forms.Label f_LabelCreatedDate;
    }
}