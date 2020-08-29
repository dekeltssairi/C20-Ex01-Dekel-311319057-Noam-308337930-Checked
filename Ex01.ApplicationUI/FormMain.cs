using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Ex01.ApplicationEngine;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace Ex01.ApplicationUI
{
    public partial class FormMain : Form
    {
        private readonly FBConnector r_FBConnector = new FBConnector();
        private readonly ApplicationSettings r_AppSettings = ApplicationSettings.LoadFromFile();

        public FormMain()
        {
            InitializeComponent();
        }

        private void applyAppSettings()
        {
            StartPosition = FormStartPosition.Manual;
            f_CheckBoxRememberMe.Checked = r_AppSettings.RememberUser;
            Location = r_AppSettings.LastWindowLocation;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            f_LabelPleaseWait.Visible = true;
            r_FBConnector.LogIn();
            r_AppSettings.LastAccessToken = r_FBConnector.AccessToken;
            
            fetchUserInfo();
            f_LabelPleaseWait.Visible = false;
        }

        protected override void OnShown(EventArgs e)
        {
            if (r_AppSettings.RememberUser && !string.IsNullOrEmpty(r_AppSettings.LastAccessToken))
            {
                r_FBConnector.Connect(r_AppSettings.LastAccessToken);
                fetchUserInfo();
            }
        }

        private void fetchUserInfo()
        {
            r_FBConnector.LoggedUser = r_FBConnector.LoginResult.LoggedInUser;
            userBindingSource.DataSource = r_FBConnector.LoggedUser;
            //f_PictureBoxProfile.Load(r_FBConnector.LoggedUser.PictureNormalURL);
            handleButtonsVisibility();
            exposeLabels();
        }

        private void exposeLabels()
        {
            foreach (Label label in f_PanelProfile.Controls.OfType<Label>())
            {
                label.Visible = !label.Visible;
            }
        }

        private void handleButtonsVisibility()
        {
            foreach (Button button in splitContainer1.Panel2.Controls.OfType<Button>())
            {
                button.Enabled = !button.Enabled;
            }

            /*f_ButtonPost.Enabled = !f_ButtonPost.Enabled;
            f_ButtonLogin.Enabled = !f_ButtonLogin.Enabled;
            f_ButtonLogout.Enabled = !f_ButtonLogout.Enabled;
            f_ButtonCovid19.Enabled = !f_ButtonCovid19.Enabled;
            f_ButtonMyAlbums.Enabled = !f_ButtonMyAlbums.Enabled;
            f_ButtonShowLikes.Enabled = !f_ButtonShowLikes.Enabled;
            f_ButtonShowChekins.Enabled = !f_ButtonShowChekins.Enabled;
            f_ButtonShowMyPosts.Enabled = !f_ButtonShowMyPosts.Enabled;
            f_ButtonShowFriends.Enabled = !f_ButtonShowFriends.Enabled;
            f_ButtonShowMyEvents.Enabled = !f_ButtonShowMyEvents.Enabled;
            f_ButtonShowMostDiggingFriend.Enabled = !f_ButtonShowMostDiggingFriend.Enabled;*/
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            r_AppSettings.LastWindowLocation = Location;
            r_AppSettings.LastWindowSize = Size;
            r_AppSettings.RememberUser = f_CheckBoxRememberMe.Checked;
            if (r_AppSettings.RememberUser == true)
            {
                r_AppSettings.LastAccessToken = r_FBConnector.LoginResult.AccessToken;
            }
            else
            {
                r_AppSettings.LastAccessToken = null;
            }

            r_AppSettings.SaveToFile();
        }

        private void clearForm()
        {
           this.Dispose(false);
           new FormMain().Show();
        }

        private void fetchPosts()
        {
            foreach (Post post in r_FBConnector.LoggedUser.Posts)
            {
                if (post.Message != null)
                {
                    f_ListBoxPosts.Items.Add(post.Message);
                }
                else if (post.Caption != null)
                {
                    f_ListBoxPosts.Items.Add(post.Caption);
                }
                else
                {
                    f_ListBoxPosts.Items.Add(string.Format("[{0}]", post.Type));
                }
            }

            if (r_FBConnector.LoggedUser.Posts.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve :(");
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            if (r_FBConnector.LoggedUser != null)
            {
                FacebookService.Logout(() => { });
                f_CheckBoxRememberMe.Checked = false;
                r_AppSettings.RememberUser = false;
                r_AppSettings.SaveToFile();
                clearForm();
            }
            else
            {
                MessageBox.Show("You must loggin first!");
            }
        }

        private void f_ShowFriendsButton_Click(object sender, EventArgs e)
        {
            f_LabelPleaseWait.Visible = true;
            if (r_FBConnector.LoggedUser == null)
            {
                MessageBox.Show("You must loggin first!");
            }
            else if (r_FBConnector.LoggedUser.Friends.Count == 0)
            {
                MessageBox.Show("No Friends to retrieve :(");
            }
            else
            {
                new FormFriendList(r_FBConnector.LoggedUser.Friends).ShowDialog();
            }

            f_LabelPleaseWait.Visible = false;
        }

        private void f_CheckinsButton_Click(object sender, EventArgs e)
        {
            f_LabelPleaseWait.Visible = true;
            if (r_FBConnector.LoggedUser == null)
            {
                MessageBox.Show("You must loggin first!");
            }
            else if (r_FBConnector.LoggedUser.Checkins.Count == 0)
            {
                MessageBox.Show("No Checkins to retrieve :(");
            }
            else
            {
                new FormCheckinList(r_FBConnector.LoggedUser.Checkins).ShowDialog();
            }

            f_LabelPleaseWait.Visible = false;
        }

        private void fetchEvents()
        {
            f_ListBoxEvents.DisplayMember = "Name";
            foreach (Event fbEvent in r_FBConnector.LoggedUser.Events)
            {
                f_ListBoxEvents.Items.Add(fbEvent);
            }
        }

        private void buttonMostDiggingFriend_Click(object sender, EventArgs e)
        {
            f_LabelPleaseWait.Visible = true;
            if (r_FBConnector.LoggedUser != null)
            {
                DateTime lastYear = DateTime.Today.AddYears(-1);
                User mostDiggingFriend = null;
                int postCounter, maxNumOfPosts = 0;
                
                foreach (User friend in r_FBConnector.LoggedUser.Friends)
                {
                    postCounter = 0;
                    foreach (Post post in friend.Posts)
                    {
                        if (post.CreatedTime > lastYear)
                        {
                            postCounter++;
                        }
                    }

                    if (postCounter > maxNumOfPosts)
                    {
                        maxNumOfPosts = postCounter;
                        mostDiggingFriend = friend;
                    }
                }

                new FormMosiftDiggingFriend(mostDiggingFriend, maxNumOfPosts).ShowDialog();
            }
            else
            {
                MessageBox.Show("You must loggin first!");
            }

            f_LabelPleaseWait.Visible = false;
        }

        private void f_Postbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Out of Permission!");
        }

        private void Covid19_button_Click(object sender, EventArgs e)
        {
            f_LabelPleaseWait.Visible = true;

            if (r_FBConnector.LoggedUser == null)
            {
                MessageBox.Show("You must loggin first!");
            }
            else
            {
                try
                {
                    new FormCovid19CheckedIn(r_FBConnector).ShowDialog();
                }
                catch (Exception)
                {
                    MessageBox.Show("You dont have any chekins");
                }
            }

            f_LabelPleaseWait.Visible = false;
        }

        private void buttonShowMyPost_Click(object sender, EventArgs e)
        {
            f_LabelPleaseWait.Visible = true;

            if (r_FBConnector.LoggedUser != null)
            {
                f_ListBoxPosts.Items.Clear();
                fetchPosts();
            }
            else
            {
                MessageBox.Show("You must loggin first!");
            }

            f_LabelPleaseWait.Visible = false;
        }

        private void buttonShowMyEvents_Click(object sender, EventArgs e)
        {
            f_LabelPleaseWait.Visible = true;

            if (r_FBConnector.LoggedUser == null)
            {
                MessageBox.Show("You must loggin first!");
            }
            else if (r_FBConnector.LoggedUser.Events.Count == 0)
            {
                MessageBox.Show("No Events to retrieve :(");
            }
            else
            {
                fetchEvents();
            }

            f_LabelPleaseWait.Visible = false;
        }

        private void buttonShowMyLikes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Out of Permission!");
        }

        private void buttonMyAlbums_Click(object sender, EventArgs e)
        {
            f_LabelPleaseWait.Visible = true;
            if (r_FBConnector.LoggedUser == null)
            {
                MessageBox.Show("You must loggin first!");
            }
            else if (r_FBConnector.LoggedUser.Albums.Count == 0)
            {
                MessageBox.Show("No albums to retrieve :(");
            }
            else
            {
                f_LabelPleaseWait.Visible = false;
                new FormAlbums(r_FBConnector.LoggedUser.Albums).ShowDialog();  
            }
        }
    }
}