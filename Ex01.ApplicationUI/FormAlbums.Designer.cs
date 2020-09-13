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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label imageAlbumLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label createdTimeLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlbums));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.f_AlbumList = new System.Windows.Forms.ListBox();
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.createdTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.descriptionLabel1 = new System.Windows.Forms.Label();
            this.imageAlbumPictureBox = new System.Windows.Forms.PictureBox();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.albumBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.albumBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            descriptionLabel = new System.Windows.Forms.Label();
            imageAlbumLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            createdTimeLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageAlbumPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingNavigator)).BeginInit();
            this.albumBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(20, 102);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(83, 17);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Description:";
            // 
            // imageAlbumLabel
            // 
            imageAlbumLabel.AutoSize = true;
            imageAlbumLabel.Location = new System.Drawing.Point(20, 128);
            imageAlbumLabel.Name = "imageAlbumLabel";
            imageAlbumLabel.Size = new System.Drawing.Size(93, 17);
            imageAlbumLabel.TabIndex = 4;
            imageAlbumLabel.Text = "Image Album:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(20, 181);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(49, 17);
            nameLabel.TabIndex = 6;
            nameLabel.Text = "Name:";
            // 
            // createdTimeLabel1
            // 
            createdTimeLabel1.AutoSize = true;
            createdTimeLabel1.Location = new System.Drawing.Point(16, 73);
            createdTimeLabel1.Name = "createdTimeLabel1";
            createdTimeLabel1.Size = new System.Drawing.Size(97, 17);
            createdTimeLabel1.TabIndex = 7;
            createdTimeLabel1.Text = "Created Time:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.f_AlbumList);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(createdTimeLabel1);
            this.splitContainer1.Panel2.Controls.Add(this.createdTimeDateTimePicker);
            this.splitContainer1.Panel2.Controls.Add(descriptionLabel);
            this.splitContainer1.Panel2.Controls.Add(this.descriptionLabel1);
            this.splitContainer1.Panel2.Controls.Add(imageAlbumLabel);
            this.splitContainer1.Panel2.Controls.Add(this.imageAlbumPictureBox);
            this.splitContainer1.Panel2.Controls.Add(nameLabel);
            this.splitContainer1.Panel2.Controls.Add(this.nameLabel1);
            this.splitContainer1.Size = new System.Drawing.Size(668, 493);
            this.splitContainer1.SplitterDistance = 265;
            this.splitContainer1.TabIndex = 0;
            // 
            // f_AlbumList
            // 
            this.f_AlbumList.DataSource = this.albumBindingSource;
            this.f_AlbumList.DisplayMember = "Name";
            this.f_AlbumList.FormattingEnabled = true;
            this.f_AlbumList.ItemHeight = 16;
            this.f_AlbumList.Location = new System.Drawing.Point(0, 35);
            this.f_AlbumList.Name = "f_AlbumList";
            this.f_AlbumList.Size = new System.Drawing.Size(262, 452);
            this.f_AlbumList.TabIndex = 0;
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Album);
            // 
            // createdTimeDateTimePicker
            // 
            this.createdTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.albumBindingSource, "CreatedTime", true));
            this.createdTimeDateTimePicker.Location = new System.Drawing.Point(119, 68);
            this.createdTimeDateTimePicker.Name = "createdTimeDateTimePicker";
            this.createdTimeDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.createdTimeDateTimePicker.TabIndex = 8;
            // 
            // descriptionLabel1
            // 
            this.descriptionLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "Description", true));
            this.descriptionLabel1.Location = new System.Drawing.Point(123, 102);
            this.descriptionLabel1.Name = "descriptionLabel1";
            this.descriptionLabel1.Size = new System.Drawing.Size(100, 23);
            this.descriptionLabel1.TabIndex = 3;
            this.descriptionLabel1.Text = "label1";
            // 
            // imageAlbumPictureBox
            // 
            this.imageAlbumPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.albumBindingSource, "ImageAlbum", true));
            this.imageAlbumPictureBox.Location = new System.Drawing.Point(123, 128);
            this.imageAlbumPictureBox.Name = "imageAlbumPictureBox";
            this.imageAlbumPictureBox.Size = new System.Drawing.Size(100, 50);
            this.imageAlbumPictureBox.TabIndex = 5;
            this.imageAlbumPictureBox.TabStop = false;
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "Name", true));
            this.nameLabel1.Location = new System.Drawing.Point(123, 181);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(100, 23);
            this.nameLabel1.TabIndex = 7;
            this.nameLabel1.Text = "label1";
            // 
            // albumBindingNavigator
            // 
            this.albumBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.albumBindingNavigator.BindingSource = this.albumBindingSource;
            this.albumBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.albumBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.albumBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.albumBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.albumBindingNavigatorSaveItem});
            this.albumBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.albumBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.albumBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.albumBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.albumBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.albumBindingNavigator.Name = "albumBindingNavigator";
            this.albumBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.albumBindingNavigator.Size = new System.Drawing.Size(668, 31);
            this.albumBindingNavigator.TabIndex = 1;
            this.albumBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // albumBindingNavigatorSaveItem
            // 
            this.albumBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.albumBindingNavigatorSaveItem.Enabled = false;
            this.albumBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("albumBindingNavigatorSaveItem.Image")));
            this.albumBindingNavigatorSaveItem.Name = "albumBindingNavigatorSaveItem";
            this.albumBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.albumBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // FormAlbums
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 493);
            this.Controls.Add(this.albumBindingNavigator);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormAlbums";
            this.Text = "Albums";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageAlbumPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingNavigator)).EndInit();
            this.albumBindingNavigator.ResumeLayout(false);
            this.albumBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox f_AlbumList;
        private System.Windows.Forms.BindingSource albumBindingSource;
        private System.Windows.Forms.Label descriptionLabel1;
        private System.Windows.Forms.PictureBox imageAlbumPictureBox;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.BindingNavigator albumBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton albumBindingNavigatorSaveItem;
        private System.Windows.Forms.DateTimePicker createdTimeDateTimePicker;
    }
}