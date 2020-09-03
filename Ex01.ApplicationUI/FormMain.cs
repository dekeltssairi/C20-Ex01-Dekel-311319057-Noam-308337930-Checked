using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Windows.Forms;
using Ex01.ApplicationEngine;
using FacadeFacebook;
using FacadeLayer;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
namespace Ex01.ApplicationUI
{
    public partial class FormMain : Form
    {
        private readonly FacadeLayer.FacadeFacebook m_FacadeFacebook = new FacadeLayer.FacadeFacebook();

        public FormMain()
        {
            InitializeComponent();
        }

        private void applyAppSettings()
        {
            StartPosition = FormStartPosition.Manual;
            f_CheckBoxRememberMe.Checked = m_FacadeFacebook.LogicSettings.RememberUser;
            Location = m_FacadeFacebook.LogicSettings.LastWindowLocation;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            m_FacadeFacebook.LogIn();
            userBindingSource.DataSource = m_FacadeFacebook.LoggedUser;
            handleButtonsVisibility();
            exposeLabels();
        }

        protected override void OnShown(EventArgs e)
        {
            if (m_FacadeFacebook.LogicSettings.RememberUser && !string.IsNullOrEmpty(m_FacadeFacebook.LogicSettings.LastAccessToken))
            {
                applyAppSettings();
                m_FacadeFacebook.Connect();
                userBindingSource.DataSource = m_FacadeFacebook.LoggedUser;
                exposeLabels();
                handleButtonsVisibility();
            }
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

            f_ButtonLogin.Enabled = false;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            /*base.OnFormClosing(e);

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

            r_AppSettings.SaveToFile();*/

            base.OnFormClosing(e);

            //UISetting uiSetting = new UISetting() { LastWindowSize = Size , LastWindowLocation = Location};
            m_FacadeFacebook.LogicSettings.LastWindowLocation = Location;
            m_FacadeFacebook.LogicSettings.LastWindowSize = Size;
            m_FacadeFacebook.LogicSettings.RememberUser = f_CheckBoxRememberMe.Checked;
            if (m_FacadeFacebook.LogicSettings.RememberUser)
            {
                m_FacadeFacebook.LogicSettings.LastAccessToken = m_FacadeFacebook.LoginResult.AccessToken;
            }
            else
            {
                m_FacadeFacebook.LastAccessToken = null;
            }

            m_FacadeFacebook.LogicSettings.SaveToFile();
        }

        private void clearForm()
        {
            this.Dispose(false);
            new FormMain().Show();
        }

        private void onFetchPostsThread()
        {

            /*foreach (Post post in m_FacadeFacebook.LoggedUser.Posts)
            {
                new PostProxy() { Post = post };
                f_ListBoxPosts.Invoke(new Action(() => f_ListBoxPosts.Items.Add(new PostProxy { Post = post })));
            }

            if (r_FBConnector.LoggedUser.Posts.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve :(");
            }*/
            foreach (Post post in m_FacadeFacebook.GetLoggedUserPosts())
            {
                f_ListBoxPosts.Invoke(new Action(() => f_ListBoxPosts.Items.Add(new PostProxy { Post = post })));
            }

            if (!m_FacadeFacebook.IsLoggedUserHasPosts())
            {
                MessageBox.Show("No Posts to retrieve :(");
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            /*                FacebookService.Logout(() => { });
                            f_CheckBoxRememberMe.Checked = false;
                            r_AppSettings.RememberUser = false;
                            r_AppSettings.SaveToFile();
                            clearForm();*/

            m_FacadeFacebook.Logout();
            clearForm();

        }

        private void f_ShowFriendsButton_Click(object sender, EventArgs e)
        {
            f_LoadingCircleShowFriend.Visible = true;
            f_LoadingCircleShowFriend.Active = true;
            new Thread(onShowFriendsThread).Start();
        }

        private void onShowFriendsThread()
        {
            /*if (r_FBConnector.LoggedUser.Friends.Count == 0)
            {
                MessageBox.Show("No Friends to retrieve :(");
            }
            else
            {
                new FormFriendList(r_FBConnector.LoggedUser.Friends, f_LoadingCircleShowFriend).ShowDialog();
            }*/

            if (!m_FacadeFacebook.isLoggedUserHasFriends())
            {
                MessageBox.Show("No Friends to retrieve :(");
            }
            else
            {
                new FormFriendList(m_FacadeFacebook.GetLoggedUserFriends(), f_LoadingCircleShowFriend).ShowDialog();
            }
        }

        private void f_CheckinsButton_Click(object sender, EventArgs e)
        {
            f_LoadingCircleShowCheckins.Visible = true;
            f_LoadingCircleShowCheckins.Active = true;
            new Thread(onShowCheckinsThread).Start();
        }

        private void onShowCheckinsThread()
        {
            /*if (r_FBConnector.LoggedUser.Checkins.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve :(");
            }
            else
            {
                new FormCheckinList(r_FBConnector.LoggedUser.Checkins, f_LoadingCircleShowCheckins).ShowDialog();
            }*/

            if (!m_FacadeFacebook.IsLoggedUserHasCheckins())
            {
                MessageBox.Show("No Posts to retrieve :(");
            }
            else
            {
                new FormCheckinList(m_FacadeFacebook.GetCheckins(), f_LoadingCircleShowCheckins).ShowDialog();
            }
        }
        private void onFetchEventsThread()
        {
            /*if (r_FBConnector.LoggedUser.Events.Count == 0)
            {
                MessageBox.Show("No Events to retrieve :(");
            }
            else
            {
                new FormEventsList(r_FBConnector.LoggedUser.Events, f_LoadingCircleShowEvents).ShowDialog();
            }*/

            if (!m_FacadeFacebook.IsLoggedUserHasEvents())
            {
                MessageBox.Show("No Events to retrieve :(");
            }
            else
            {
                new FormEventsList(m_FacadeFacebook.GetLoggedUserEvents(), f_LoadingCircleShowEvents).ShowDialog();
            }


            //eventBindingSource.DataSource = r_FBConnector.LoggedUser.Events;
            /*f_ListBoxEvents.DisplayMember = "Name";
            foreach (Event fbEvent in r_FBConnector.LoggedUser.Events)
            {
                f_ListBoxEvents.Items.Add(fbEvent);
            }*/
        }

        private void onMostDiggingFriendThread()
        {
            /*        if (r_FBConnector.LoggedUser.Friends.Count == 0)
                    {
                        MessageBox.Show("You Don't have any friends :(");
                    }
                    else
                    {
                        f_LoadingCircleShowMostDiggingFriend.Visible = true;
                        f_LoadingCircleShowMostDiggingFriend.Active = true;
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

                        new FormMosiftDiggingFriend(mostDiggingFriend, maxNumOfPosts, f_LoadingCircleShowMostDiggingFriend).ShowDialog();
                    }
        */
            if (!m_FacadeFacebook.isLoggedUserHasFriends())
            {
                MessageBox.Show("You Don't have any friends :(");
            }
            else
            {
                DigginFriend digginFriend = m_FacadeFacebook.GetDigginFriend();

                new FormMosiftDiggingFriend(digginFriend, f_LoadingCircleShowMostDiggingFriend).ShowDialog();
            }

        }

        private void buttonMostDiggingFriend_Click(object sender, EventArgs e)
        {
            f_LoadingCircleShowMostDiggingFriend.Visible = true;
            f_LoadingCircleShowMostDiggingFriend.Active = true;
            new Thread(onMostDiggingFriendThread).Start();

        }


        private void f_Postbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Out of Permission!");
        }

        private void Covid19_button_Click(object sender, EventArgs e)
        {
            try
            {
                new FormCovid19CheckedIn(m_FacadeFacebook.LoggedUser).ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("You dont have any chekins");
            }
        }

        private void onShowAlbumsThread()
        {
            /*            if (m_FacadeFacebook.LoggedUser.Albums.Count == 0)
                        {
                            MessageBox.Show("No Albums to retrieve :(");
                        }
                        else
                        {
                            new FormAlbums(r_FBConnector.LoggedUser.Albums, f_LoadingCircleShowMyAlbums).ShowDialog();
                        }*/

            if (!m_FacadeFacebook.IsLoggedUserHasAlbums())
            {
                MessageBox.Show("No Albums to retrieve :(");
            }
            else
            {
                new FormAlbums(m_FacadeFacebook.GetLoggedUserAlbums(), f_LoadingCircleShowMyAlbums).ShowDialog();
            }
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            //m_FacadeFacebook.Connect(m_FacadeFacebook.LastAccessToken);
            m_FacadeFacebook.Connect();
            userBindingSource.DataSource = m_FacadeFacebook.LoggedUser;
            handleButtonsVisibility();
            exposeLabels();

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            /*r_FBConnector.LoggedUser = r_FBConnector.LoginResult.LoggedInUser;
            userBindingSource.DataSource = r_FBConnector.LoggedUser;
            handleButtonsVisibility();
            exposeLabels();*/

            userBindingSource.DataSource = m_FacadeFacebook.LoggedUser;
            handleButtonsVisibility();
            exposeLabels();
        }

        private void f_ButtonShowLikes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Out of Permission!");
        }

        private void f_ButtonMyAlbums_Click(object sender, EventArgs e)
        {
            f_LoadingCircleShowMyAlbums.Visible = true;
            f_LoadingCircleShowMyAlbums.Active = true;
            new Thread(onShowAlbumsThread).Start();
        }

        private void f_ButtonShowMyEvents_Click(object sender, EventArgs e)
        {
            f_LoadingCircleShowEvents.Visible = true;
            f_LoadingCircleShowEvents.Active = true;
            new Thread(onFetchEventsThread).Start();
        }

        private void f_ButtonShowMyPosts_Click(object sender, EventArgs e)
        {
            f_ListBoxPosts.Items.Clear();
            new Thread(onFetchPostsThread).Start();
        }
    }
}
