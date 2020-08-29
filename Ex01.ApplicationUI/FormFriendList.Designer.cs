using System;

namespace Ex01.ApplicationUI
{
    partial class FormFriendList
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
            this.f_ListBoxFriends = new System.Windows.Forms.ListBox();
            this.f_PictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.f_ListBoxPosts = new System.Windows.Forms.ListBox();
            this.f_LabelWait = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.f_PictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // f_ListBoxFriends
            // 
            this.f_ListBoxFriends.FormattingEnabled = true;
            this.f_ListBoxFriends.ItemHeight = 16;
            this.f_ListBoxFriends.Location = new System.Drawing.Point(45, 32);
            this.f_ListBoxFriends.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.f_ListBoxFriends.Name = "f_ListBoxFriends";
            this.f_ListBoxFriends.Size = new System.Drawing.Size(192, 148);
            this.f_ListBoxFriends.TabIndex = 0;
            this.f_ListBoxFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
            // 
            // f_PictureBoxProfile
            // 
            this.f_PictureBoxProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.f_PictureBoxProfile.Location = new System.Drawing.Point(565, 33);
            this.f_PictureBoxProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.f_PictureBoxProfile.Name = "f_PictureBoxProfile";
            this.f_PictureBoxProfile.Size = new System.Drawing.Size(191, 148);
            this.f_PictureBoxProfile.TabIndex = 1;
            this.f_PictureBoxProfile.TabStop = false;
            // 
            // f_ListBoxPosts
            // 
            this.f_ListBoxPosts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.f_ListBoxPosts.FormattingEnabled = true;
            this.f_ListBoxPosts.HorizontalScrollbar = true;
            this.f_ListBoxPosts.ImeMode = System.Windows.Forms.ImeMode.On;
            this.f_ListBoxPosts.ItemHeight = 16;
            this.f_ListBoxPosts.Location = new System.Drawing.Point(45, 207);
            this.f_ListBoxPosts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.f_ListBoxPosts.MaximumSize = new System.Drawing.Size(1332, 148);
            this.f_ListBoxPosts.Name = "f_ListBoxPosts";
            this.f_ListBoxPosts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.f_ListBoxPosts.Size = new System.Drawing.Size(709, 148);
            this.f_ListBoxPosts.TabIndex = 2;
            this.f_ListBoxPosts.UseWaitCursor = true;
            // 
            // f_LabelWait
            // 
            this.f_LabelWait.AutoSize = true;
            this.f_LabelWait.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.f_LabelWait.Location = new System.Drawing.Point(282, 33);
            this.f_LabelWait.Name = "f_LabelWait";
            this.f_LabelWait.Size = new System.Drawing.Size(188, 32);
            this.f_LabelWait.TabIndex = 3;
            this.f_LabelWait.Text = "Loading.......";
            this.f_LabelWait.Visible = false;
            // 
            // FormFriendList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.f_LabelWait);
            this.Controls.Add(this.f_ListBoxPosts);
            this.Controls.Add(this.f_PictureBoxProfile);
            this.Controls.Add(this.f_ListBoxFriends);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormFriendList";
            this.Text = "Friends List";
            ((System.ComponentModel.ISupportInitialize)(this.f_PictureBoxProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox f_ListBoxFriends;
        private System.Windows.Forms.PictureBox f_PictureBoxProfile;
        private System.Windows.Forms.ListBox f_ListBoxPosts;
        private System.Windows.Forms.Label f_LabelWait;
    }
}