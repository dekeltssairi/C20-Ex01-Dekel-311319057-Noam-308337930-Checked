namespace Ex01.ApplicationUI
{
    partial class FormMosiftDiggingFriend
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
            this.f_LabelFriendName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.f_PictureBoxProfilePicture = new System.Windows.Forms.PictureBox();
            this.f_LabelNumOfPosts = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f_PictureBoxProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // f_LabelFriendName
            // 
            this.f_LabelFriendName.AutoSize = true;
            this.f_LabelFriendName.Location = new System.Drawing.Point(317, 98);
            this.f_LabelFriendName.Name = "f_LabelFriendName";
            this.f_LabelFriendName.Size = new System.Drawing.Size(116, 17);
            this.f_LabelFriendName.TabIndex = 2;
            this.f_LabelFriendName.Text = "friendNameLabel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "This guy is Crazy digging";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Ex01.ApplicationUI.Properties.Resources.icons8_spade_100;
            this.pictureBox4.Location = new System.Drawing.Point(71, 242);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(98, 123);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Ex01.ApplicationUI.Properties.Resources.icon_חופר_ציור_csp27622896;
            this.pictureBox3.Location = new System.Drawing.Point(565, 229);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(179, 151);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // f_PictureBoxProfilePicture
            // 
            this.f_PictureBoxProfilePicture.Location = new System.Drawing.Point(237, 194);
            this.f_PictureBoxProfilePicture.Name = "f_PictureBoxProfilePicture";
            this.f_PictureBoxProfilePicture.Size = new System.Drawing.Size(271, 186);
            this.f_PictureBoxProfilePicture.TabIndex = 0;
            this.f_PictureBoxProfilePicture.TabStop = false;
            // 
            // f_LabelNumOfPosts
            // 
            this.f_LabelNumOfPosts.AutoSize = true;
            this.f_LabelNumOfPosts.Location = new System.Drawing.Point(473, 407);
            this.f_LabelNumOfPosts.Name = "f_LabelNumOfPosts";
            this.f_LabelNumOfPosts.Size = new System.Drawing.Size(92, 17);
            this.f_LabelNumOfPosts.TabIndex = 6;
            this.f_LabelNumOfPosts.Text = "Num of Posts";
            // 
            // FormMosiftDiggingFriend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 457);
            this.Controls.Add(this.f_LabelNumOfPosts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.f_LabelFriendName);
            this.Controls.Add(this.f_PictureBoxProfilePicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormMosiftDiggingFriend";
            this.Text = "Most Digging Friend";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f_PictureBoxProfilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox f_PictureBoxProfilePicture;
        private System.Windows.Forms.Label f_LabelFriendName;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label f_LabelNumOfPosts;
    }
}