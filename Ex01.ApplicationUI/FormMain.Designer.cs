namespace Ex01.ApplicationUI
{
    partial class FormMain
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
            System.Windows.Forms.Label aboutLabel;
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label nameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.f_PanelProfile = new System.Windows.Forms.Panel();
            this.aboutLabel1 = new System.Windows.Forms.Label();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.birthdayLabel1 = new System.Windows.Forms.Label();
            this.emailLabel1 = new System.Windows.Forms.Label();
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.f_ButtonLogin = new System.Windows.Forms.Button();
            this.f_CheckBoxRememberMe = new System.Windows.Forms.CheckBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.f_ButtonShowMyEvents = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.f_ButtonMyAlbums = new System.Windows.Forms.Button();
            this.f_ButtonShowLikes = new System.Windows.Forms.Button();
            this.f_ButtonShowMyPosts = new System.Windows.Forms.Button();
            this.f_ListBoxEvents = new System.Windows.Forms.ListBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.f_ButtonLogout = new System.Windows.Forms.Button();
            this.f_ListBoxPosts = new System.Windows.Forms.ListBox();
            this.f_lastPostStaus = new System.Windows.Forms.TextBox();
            this.f_ButtonShowMostDiggingFriend = new System.Windows.Forms.Button();
            this.f_ButtonCovid19 = new System.Windows.Forms.Button();
            this.f_ButtonShowChekins = new System.Windows.Forms.Button();
            this.f_ButtonShowFriends = new System.Windows.Forms.Button();
            this.f_ButtonPost = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.userBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.userBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.f_LoadingCircleShowFriend = new MRG.Controls.UI.LoadingCircle();
            this.f_LoadingCircleShowCheckins = new MRG.Controls.UI.LoadingCircle();
            this.f_LoadingCircleShowMyLikes = new MRG.Controls.UI.LoadingCircle();
            this.f_LoadingCircleShowMyAlbums = new MRG.Controls.UI.LoadingCircle();
            aboutLabel = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.f_PanelProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingNavigator)).BeginInit();
            this.userBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // aboutLabel
            // 
            aboutLabel.AutoSize = true;
            aboutLabel.Location = new System.Drawing.Point(9, 143);
            aboutLabel.Name = "aboutLabel";
            aboutLabel.Size = new System.Drawing.Size(49, 17);
            aboutLabel.TabIndex = 0;
            aboutLabel.Text = "About:";
            aboutLabel.Visible = false;
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new System.Drawing.Point(9, 166);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(64, 17);
            birthdayLabel.TabIndex = 2;
            birthdayLabel.Text = "Birthday:";
            birthdayLabel.Visible = false;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(9, 189);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(46, 17);
            emailLabel.TabIndex = 4;
            emailLabel.Text = "Email:";
            emailLabel.Visible = false;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(9, 88);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(49, 17);
            nameLabel.TabIndex = 8;
            nameLabel.Text = "Name:";
            nameLabel.Visible = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.splitContainer1.Panel1.Controls.Add(this.f_PanelProfile);
            this.splitContainer1.Panel1.Controls.Add(this.f_ButtonLogin);
            this.splitContainer1.Panel1.Controls.Add(this.f_CheckBoxRememberMe);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.splitContainer1.Panel2.Controls.Add(this.f_LoadingCircleShowMyAlbums);
            this.splitContainer1.Panel2.Controls.Add(this.f_LoadingCircleShowMyLikes);
            this.splitContainer1.Panel2.Controls.Add(this.f_LoadingCircleShowCheckins);
            this.splitContainer1.Panel2.Controls.Add(this.f_LoadingCircleShowFriend);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox4);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.f_ButtonShowMyEvents);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox2);
            this.splitContainer1.Panel2.Controls.Add(this.f_ButtonMyAlbums);
            this.splitContainer1.Panel2.Controls.Add(this.f_ButtonShowLikes);
            this.splitContainer1.Panel2.Controls.Add(this.f_ButtonShowMyPosts);
            this.splitContainer1.Panel2.Controls.Add(this.f_ListBoxEvents);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox3);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel2.Controls.Add(this.f_ButtonLogout);
            this.splitContainer1.Panel2.Controls.Add(this.f_ListBoxPosts);
            this.splitContainer1.Panel2.Controls.Add(this.f_lastPostStaus);
            this.splitContainer1.Panel2.Controls.Add(this.f_ButtonShowMostDiggingFriend);
            this.splitContainer1.Panel2.Controls.Add(this.f_ButtonCovid19);
            this.splitContainer1.Panel2.Controls.Add(this.f_ButtonShowChekins);
            this.splitContainer1.Panel2.Controls.Add(this.f_ButtonShowFriends);
            this.splitContainer1.Panel2.Controls.Add(this.f_ButtonPost);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Size = new System.Drawing.Size(1392, 730);
            this.splitContainer1.SplitterDistance = 281;
            this.splitContainer1.TabIndex = 0;
            // 
            // f_PanelProfile
            // 
            this.f_PanelProfile.BackColor = System.Drawing.Color.CadetBlue;
            this.f_PanelProfile.Controls.Add(aboutLabel);
            this.f_PanelProfile.Controls.Add(this.aboutLabel1);
            this.f_PanelProfile.Controls.Add(birthdayLabel);
            this.f_PanelProfile.Controls.Add(this.birthdayLabel1);
            this.f_PanelProfile.Controls.Add(emailLabel);
            this.f_PanelProfile.Controls.Add(this.emailLabel1);
            this.f_PanelProfile.Controls.Add(this.imageNormalPictureBox);
            this.f_PanelProfile.Controls.Add(nameLabel);
            this.f_PanelProfile.Controls.Add(this.nameLabel1);
            this.f_PanelProfile.Location = new System.Drawing.Point(3, 144);
            this.f_PanelProfile.Name = "f_PanelProfile";
            this.f_PanelProfile.Size = new System.Drawing.Size(275, 583);
            this.f_PanelProfile.TabIndex = 0;
            // 
            // aboutLabel1
            // 
            this.aboutLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "About", true));
            this.aboutLabel1.Location = new System.Drawing.Point(114, 143);
            this.aboutLabel1.Name = "aboutLabel1";
            this.aboutLabel1.Size = new System.Drawing.Size(182, 23);
            this.aboutLabel1.TabIndex = 1;
            this.aboutLabel1.Text = "label3";
            this.aboutLabel1.Visible = false;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // birthdayLabel1
            // 
            this.birthdayLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Birthday", true));
            this.birthdayLabel1.Location = new System.Drawing.Point(114, 166);
            this.birthdayLabel1.Name = "birthdayLabel1";
            this.birthdayLabel1.Size = new System.Drawing.Size(182, 23);
            this.birthdayLabel1.TabIndex = 3;
            this.birthdayLabel1.Text = "label3";
            this.birthdayLabel1.Visible = false;
            // 
            // emailLabel1
            // 
            this.emailLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Email", true));
            this.emailLabel1.Location = new System.Drawing.Point(114, 189);
            this.emailLabel1.Name = "emailLabel1";
            this.emailLabel1.Size = new System.Drawing.Size(182, 23);
            this.emailLabel1.TabIndex = 5;
            this.emailLabel1.Text = "label3";
            this.emailLabel1.Visible = false;
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(3, 3);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(100, 71);
            this.imageNormalPictureBox.TabIndex = 7;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Name", true));
            this.nameLabel1.Location = new System.Drawing.Point(114, 88);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(182, 23);
            this.nameLabel1.TabIndex = 9;
            this.nameLabel1.Text = "label3";
            this.nameLabel1.Visible = false;
            // 
            // f_ButtonLogin
            // 
            this.f_ButtonLogin.Location = new System.Drawing.Point(6, 44);
            this.f_ButtonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.f_ButtonLogin.Name = "f_ButtonLogin";
            this.f_ButtonLogin.Size = new System.Drawing.Size(100, 35);
            this.f_ButtonLogin.TabIndex = 86;
            this.f_ButtonLogin.Text = "Login";
            this.f_ButtonLogin.UseVisualStyleBackColor = true;
            this.f_ButtonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // f_CheckBoxRememberMe
            // 
            this.f_CheckBoxRememberMe.AutoSize = true;
            this.f_CheckBoxRememberMe.Location = new System.Drawing.Point(6, 96);
            this.f_CheckBoxRememberMe.Margin = new System.Windows.Forms.Padding(1);
            this.f_CheckBoxRememberMe.Name = "f_CheckBoxRememberMe";
            this.f_CheckBoxRememberMe.Size = new System.Drawing.Size(122, 21);
            this.f_CheckBoxRememberMe.TabIndex = 85;
            this.f_CheckBoxRememberMe.Text = "Remember me";
            this.f_CheckBoxRememberMe.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Ex01.ApplicationUI.Properties.Resources.Artboard_1_copy_5_2x_220x120;
            this.pictureBox4.Location = new System.Drawing.Point(773, 547);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(261, 117);
            this.pictureBox4.TabIndex = 100;
            this.pictureBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(554, 485);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(447, 46);
            this.label2.TabIndex = 99;
            this.label2.Text = "You must try those new features";
            // 
            // f_ButtonShowMyEvents
            // 
            this.f_ButtonShowMyEvents.Enabled = false;
            this.f_ButtonShowMyEvents.ForeColor = System.Drawing.SystemColors.ControlText;
            this.f_ButtonShowMyEvents.Location = new System.Drawing.Point(277, 448);
            this.f_ButtonShowMyEvents.Name = "f_ButtonShowMyEvents";
            this.f_ButtonShowMyEvents.Size = new System.Drawing.Size(253, 23);
            this.f_ButtonShowMyEvents.TabIndex = 92;
            this.f_ButtonShowMyEvents.Text = "Show My Events!";
            this.f_ButtonShowMyEvents.UseVisualStyleBackColor = true;
            this.f_ButtonShowMyEvents.Click += new System.EventHandler(this.buttonShowMyEvents_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Ex01.ApplicationUI.Properties.Resources.people;
            this.pictureBox2.Location = new System.Drawing.Point(-39, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 33);
            this.pictureBox2.TabIndex = 93;
            this.pictureBox2.TabStop = false;
            // 
            // f_ButtonMyAlbums
            // 
            this.f_ButtonMyAlbums.Enabled = false;
            this.f_ButtonMyAlbums.ForeColor = System.Drawing.SystemColors.ControlText;
            this.f_ButtonMyAlbums.Location = new System.Drawing.Point(835, 438);
            this.f_ButtonMyAlbums.Name = "f_ButtonMyAlbums";
            this.f_ButtonMyAlbums.Size = new System.Drawing.Size(196, 23);
            this.f_ButtonMyAlbums.TabIndex = 94;
            this.f_ButtonMyAlbums.Text = "My Albums";
            this.f_ButtonMyAlbums.UseVisualStyleBackColor = true;
            this.f_ButtonMyAlbums.Click += new System.EventHandler(this.buttonMyAlbums_Click);
            // 
            // f_ButtonShowLikes
            // 
            this.f_ButtonShowLikes.Enabled = false;
            this.f_ButtonShowLikes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.f_ButtonShowLikes.Location = new System.Drawing.Point(835, 377);
            this.f_ButtonShowLikes.Name = "f_ButtonShowLikes";
            this.f_ButtonShowLikes.Size = new System.Drawing.Size(196, 23);
            this.f_ButtonShowLikes.TabIndex = 98;
            this.f_ButtonShowLikes.Text = "Show my likes";
            this.f_ButtonShowLikes.UseVisualStyleBackColor = true;
            this.f_ButtonShowLikes.Click += new System.EventHandler(this.buttonShowMyLikes_Click);
            // 
            // f_ButtonShowMyPosts
            // 
            this.f_ButtonShowMyPosts.Enabled = false;
            this.f_ButtonShowMyPosts.ForeColor = System.Drawing.SystemColors.ControlText;
            this.f_ButtonShowMyPosts.Location = new System.Drawing.Point(21, 448);
            this.f_ButtonShowMyPosts.Name = "f_ButtonShowMyPosts";
            this.f_ButtonShowMyPosts.Size = new System.Drawing.Size(253, 23);
            this.f_ButtonShowMyPosts.TabIndex = 91;
            this.f_ButtonShowMyPosts.Text = "Show My Posts!";
            this.f_ButtonShowMyPosts.UseVisualStyleBackColor = true;
            this.f_ButtonShowMyPosts.Click += new System.EventHandler(this.buttonShowMyPost_Click);
            // 
            // f_ListBoxEvents
            // 
            this.f_ListBoxEvents.FormattingEnabled = true;
            this.f_ListBoxEvents.ItemHeight = 16;
            this.f_ListBoxEvents.Location = new System.Drawing.Point(280, 494);
            this.f_ListBoxEvents.Name = "f_ListBoxEvents";
            this.f_ListBoxEvents.Size = new System.Drawing.Size(250, 116);
            this.f_ListBoxEvents.TabIndex = 89;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Ex01.ApplicationUI.Properties.Resources.logout;
            this.pictureBox3.Location = new System.Drawing.Point(1039, 61);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 35);
            this.pictureBox3.TabIndex = 96;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ex01.ApplicationUI.Properties.Resources.facebook_logo1;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(879, 198);
            this.pictureBox1.TabIndex = 95;
            this.pictureBox1.TabStop = false;
            // 
            // f_ButtonLogout
            // 
            this.f_ButtonLogout.Enabled = false;
            this.f_ButtonLogout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.f_ButtonLogout.Location = new System.Drawing.Point(899, 61);
            this.f_ButtonLogout.Name = "f_ButtonLogout";
            this.f_ButtonLogout.Size = new System.Drawing.Size(102, 35);
            this.f_ButtonLogout.TabIndex = 90;
            this.f_ButtonLogout.Text = "Logout";
            this.f_ButtonLogout.UseVisualStyleBackColor = true;
            this.f_ButtonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // f_ListBoxPosts
            // 
            this.f_ListBoxPosts.FormattingEnabled = true;
            this.f_ListBoxPosts.HorizontalScrollbar = true;
            this.f_ListBoxPosts.ItemHeight = 16;
            this.f_ListBoxPosts.Location = new System.Drawing.Point(19, 494);
            this.f_ListBoxPosts.Name = "f_ListBoxPosts";
            this.f_ListBoxPosts.Size = new System.Drawing.Size(255, 116);
            this.f_ListBoxPosts.TabIndex = 88;
            // 
            // f_lastPostStaus
            // 
            this.f_lastPostStaus.Location = new System.Drawing.Point(21, 237);
            this.f_lastPostStaus.Multiline = true;
            this.f_lastPostStaus.Name = "f_lastPostStaus";
            this.f_lastPostStaus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.f_lastPostStaus.Size = new System.Drawing.Size(509, 160);
            this.f_lastPostStaus.TabIndex = 93;
            // 
            // f_ButtonShowMostDiggingFriend
            // 
            this.f_ButtonShowMostDiggingFriend.Enabled = false;
            this.f_ButtonShowMostDiggingFriend.ForeColor = System.Drawing.SystemColors.ControlText;
            this.f_ButtonShowMostDiggingFriend.Location = new System.Drawing.Point(562, 547);
            this.f_ButtonShowMostDiggingFriend.Name = "f_ButtonShowMostDiggingFriend";
            this.f_ButtonShowMostDiggingFriend.Size = new System.Drawing.Size(196, 36);
            this.f_ButtonShowMostDiggingFriend.TabIndex = 91;
            this.f_ButtonShowMostDiggingFriend.Text = "Show Most digging friend";
            this.f_ButtonShowMostDiggingFriend.UseVisualStyleBackColor = true;
            this.f_ButtonShowMostDiggingFriend.Click += new System.EventHandler(this.buttonMostDiggingFriend_Click);
            // 
            // f_ButtonCovid19
            // 
            this.f_ButtonCovid19.Enabled = false;
            this.f_ButtonCovid19.ForeColor = System.Drawing.SystemColors.ControlText;
            this.f_ButtonCovid19.Location = new System.Drawing.Point(562, 630);
            this.f_ButtonCovid19.Name = "f_ButtonCovid19";
            this.f_ButtonCovid19.Size = new System.Drawing.Size(196, 34);
            this.f_ButtonCovid19.TabIndex = 89;
            this.f_ButtonCovid19.Text = "Covid-19 Location checks";
            this.f_ButtonCovid19.UseVisualStyleBackColor = true;
            this.f_ButtonCovid19.Click += new System.EventHandler(this.Covid19_button_Click);
            // 
            // f_ButtonShowChekins
            // 
            this.f_ButtonShowChekins.CausesValidation = false;
            this.f_ButtonShowChekins.Enabled = false;
            this.f_ButtonShowChekins.ForeColor = System.Drawing.SystemColors.ControlText;
            this.f_ButtonShowChekins.Location = new System.Drawing.Point(835, 310);
            this.f_ButtonShowChekins.Name = "f_ButtonShowChekins";
            this.f_ButtonShowChekins.Size = new System.Drawing.Size(196, 23);
            this.f_ButtonShowChekins.TabIndex = 88;
            this.f_ButtonShowChekins.Text = "Show checkins";
            this.f_ButtonShowChekins.UseVisualStyleBackColor = true;
            this.f_ButtonShowChekins.Click += new System.EventHandler(this.f_CheckinsButton_Click);
            // 
            // f_ButtonShowFriends
            // 
            this.f_ButtonShowFriends.Enabled = false;
            this.f_ButtonShowFriends.ForeColor = System.Drawing.SystemColors.ControlText;
            this.f_ButtonShowFriends.Location = new System.Drawing.Point(835, 240);
            this.f_ButtonShowFriends.Name = "f_ButtonShowFriends";
            this.f_ButtonShowFriends.Size = new System.Drawing.Size(196, 23);
            this.f_ButtonShowFriends.TabIndex = 87;
            this.f_ButtonShowFriends.Text = "Show Friends";
            this.f_ButtonShowFriends.UseVisualStyleBackColor = true;
            this.f_ButtonShowFriends.Click += new System.EventHandler(this.f_ShowFriendsButton_Click);
            // 
            // f_ButtonPost
            // 
            this.f_ButtonPost.Enabled = false;
            this.f_ButtonPost.ForeColor = System.Drawing.SystemColors.ControlText;
            this.f_ButtonPost.Location = new System.Drawing.Point(455, 412);
            this.f_ButtonPost.Name = "f_ButtonPost";
            this.f_ButtonPost.Size = new System.Drawing.Size(75, 23);
            this.f_ButtonPost.TabIndex = 86;
            this.f_ButtonPost.Text = "Post";
            this.f_ButtonPost.UseVisualStyleBackColor = true;
            this.f_ButtonPost.Click += new System.EventHandler(this.f_Postbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 85;
            this.label1.Text = "Post Status:";
            // 
            // userBindingNavigator
            // 
            this.userBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.userBindingNavigator.BindingSource = this.userBindingSource;
            this.userBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.userBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.userBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.userBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.userBindingNavigatorSaveItem});
            this.userBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.userBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.userBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.userBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.userBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.userBindingNavigator.Name = "userBindingNavigator";
            this.userBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.userBindingNavigator.Size = new System.Drawing.Size(1392, 31);
            this.userBindingNavigator.TabIndex = 1;
            this.userBindingNavigator.Text = "bindingNavigator1";
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
            // userBindingNavigatorSaveItem
            // 
            this.userBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.userBindingNavigatorSaveItem.Enabled = false;
            this.userBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("userBindingNavigatorSaveItem.Image")));
            this.userBindingNavigatorSaveItem.Name = "userBindingNavigatorSaveItem";
            this.userBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.userBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // f_LoadingCircleShowFriend
            // 
            this.f_LoadingCircleShowFriend.Active = false;
            this.f_LoadingCircleShowFriend.Color = System.Drawing.Color.DarkGray;
            this.f_LoadingCircleShowFriend.InnerCircleRadius = 8;
            this.f_LoadingCircleShowFriend.Location = new System.Drawing.Point(754, 240);
            this.f_LoadingCircleShowFriend.Name = "f_LoadingCircleShowFriend";
            this.f_LoadingCircleShowFriend.NumberSpoke = 10;
            this.f_LoadingCircleShowFriend.OuterCircleRadius = 10;
            this.f_LoadingCircleShowFriend.RotationSpeed = 100;
            this.f_LoadingCircleShowFriend.Size = new System.Drawing.Size(75, 23);
            this.f_LoadingCircleShowFriend.SpokeThickness = 4;
            this.f_LoadingCircleShowFriend.StylePreset = MRG.Controls.UI.LoadingCircle.StylePresets.MacOSX;
            this.f_LoadingCircleShowFriend.TabIndex = 101;
            this.f_LoadingCircleShowFriend.Text = "loadingCircle1";
            this.f_LoadingCircleShowFriend.Visible = false;
            // 
            // f_LoadingCircleShowCheckins
            // 
            this.f_LoadingCircleShowCheckins.Active = false;
            this.f_LoadingCircleShowCheckins.Color = System.Drawing.Color.DarkGray;
            this.f_LoadingCircleShowCheckins.InnerCircleRadius = 8;
            this.f_LoadingCircleShowCheckins.Location = new System.Drawing.Point(754, 310);
            this.f_LoadingCircleShowCheckins.Name = "f_LoadingCircleShowCheckins";
            this.f_LoadingCircleShowCheckins.NumberSpoke = 10;
            this.f_LoadingCircleShowCheckins.OuterCircleRadius = 10;
            this.f_LoadingCircleShowCheckins.RotationSpeed = 100;
            this.f_LoadingCircleShowCheckins.Size = new System.Drawing.Size(75, 23);
            this.f_LoadingCircleShowCheckins.SpokeThickness = 4;
            this.f_LoadingCircleShowCheckins.StylePreset = MRG.Controls.UI.LoadingCircle.StylePresets.MacOSX;
            this.f_LoadingCircleShowCheckins.TabIndex = 102;
            this.f_LoadingCircleShowCheckins.Text = "loadingCircle1";
            this.f_LoadingCircleShowCheckins.Visible = false;
            // 
            // f_LoadingCircleShowMyLikes
            // 
            this.f_LoadingCircleShowMyLikes.Active = false;
            this.f_LoadingCircleShowMyLikes.Color = System.Drawing.Color.DarkGray;
            this.f_LoadingCircleShowMyLikes.InnerCircleRadius = 8;
            this.f_LoadingCircleShowMyLikes.Location = new System.Drawing.Point(754, 377);
            this.f_LoadingCircleShowMyLikes.Name = "f_LoadingCircleShowMyLikes";
            this.f_LoadingCircleShowMyLikes.NumberSpoke = 10;
            this.f_LoadingCircleShowMyLikes.OuterCircleRadius = 10;
            this.f_LoadingCircleShowMyLikes.RotationSpeed = 100;
            this.f_LoadingCircleShowMyLikes.Size = new System.Drawing.Size(75, 23);
            this.f_LoadingCircleShowMyLikes.SpokeThickness = 4;
            this.f_LoadingCircleShowMyLikes.StylePreset = MRG.Controls.UI.LoadingCircle.StylePresets.MacOSX;
            this.f_LoadingCircleShowMyLikes.TabIndex = 103;
            this.f_LoadingCircleShowMyLikes.Text = "loadingCircle2";
            this.f_LoadingCircleShowMyLikes.Visible = false;
            // 
            // f_LoadingCircleShowMyAlbums
            // 
            this.f_LoadingCircleShowMyAlbums.Active = false;
            this.f_LoadingCircleShowMyAlbums.Color = System.Drawing.Color.DarkGray;
            this.f_LoadingCircleShowMyAlbums.InnerCircleRadius = 8;
            this.f_LoadingCircleShowMyAlbums.Location = new System.Drawing.Point(754, 437);
            this.f_LoadingCircleShowMyAlbums.Name = "f_LoadingCircleShowMyAlbums";
            this.f_LoadingCircleShowMyAlbums.NumberSpoke = 10;
            this.f_LoadingCircleShowMyAlbums.OuterCircleRadius = 10;
            this.f_LoadingCircleShowMyAlbums.RotationSpeed = 100;
            this.f_LoadingCircleShowMyAlbums.Size = new System.Drawing.Size(75, 23);
            this.f_LoadingCircleShowMyAlbums.SpokeThickness = 4;
            this.f_LoadingCircleShowMyAlbums.StylePreset = MRG.Controls.UI.LoadingCircle.StylePresets.MacOSX;
            this.f_LoadingCircleShowMyAlbums.TabIndex = 104;
            this.f_LoadingCircleShowMyAlbums.Text = "loadingCircle3";
            this.f_LoadingCircleShowMyAlbums.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 730);
            this.Controls.Add(this.userBindingNavigator);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wellcom to our Facebook App";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.f_PanelProfile.ResumeLayout(false);
            this.f_PanelProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingNavigator)).EndInit();
            this.userBindingNavigator.ResumeLayout(false);
            this.userBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button f_ButtonShowMyEvents;
        private System.Windows.Forms.Button f_ButtonShowMyPosts;
        private System.Windows.Forms.ListBox f_ListBoxEvents;
        private System.Windows.Forms.ListBox f_ListBoxPosts;
        private System.Windows.Forms.Button f_ButtonLogin;
        private System.Windows.Forms.CheckBox f_CheckBoxRememberMe;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox f_lastPostStaus;
        private System.Windows.Forms.Button f_ButtonShowMostDiggingFriend;
        private System.Windows.Forms.Button f_ButtonLogout;
        private System.Windows.Forms.Button f_ButtonCovid19;
        private System.Windows.Forms.Button f_ButtonShowChekins;
        private System.Windows.Forms.Button f_ButtonShowFriends;
        private System.Windows.Forms.Button f_ButtonPost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button f_ButtonShowLikes;
        private System.Windows.Forms.Button f_ButtonMyAlbums;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel f_PanelProfile;
        private System.Windows.Forms.Label aboutLabel1;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Label birthdayLabel1;
        private System.Windows.Forms.Label emailLabel1;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.BindingNavigator userBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton userBindingNavigatorSaveItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MRG.Controls.UI.LoadingCircle f_LoadingCircleShowFriend;
        private MRG.Controls.UI.LoadingCircle f_LoadingCircleShowMyAlbums;
        private MRG.Controls.UI.LoadingCircle f_LoadingCircleShowMyLikes;
        private MRG.Controls.UI.LoadingCircle f_LoadingCircleShowCheckins;
    }
}