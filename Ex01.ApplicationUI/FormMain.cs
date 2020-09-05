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
        public UISetting UISettings { get; set; }

        public FormMain()
        {
            InitializeComponent();
            if (FacadeLayer.FacadeFacebook.Instance.LogicSettings.RememberUser && !string.IsNullOrEmpty(FacadeLayer.FacadeFacebook.Instance.LogicSettings.LastAccessToken))
            {
                UISettings = new UISetting().LoadFromFile() as UISetting;
                applySettings();
                FacadeLayer.FacadeFacebook.Instance.Connect();
                userBindingSource.DataSource = FacadeLayer.FacadeFacebook.Instance.LoggedUser;
                exposeLabels();
                handleButtonsVisibility();
            }

        }

        private void applySettings()
        {
            StartPosition = FormStartPosition.Manual;
            f_CheckBoxRememberMe.Checked = UISettings.RememberMeCheckBox;
            Location = UISettings.LastWindowLocation;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            FacadeLayer.FacadeFacebook.Instance.LogIn();
            userBindingSource.DataSource = FacadeLayer.FacadeFacebook.Instance.LoggedUser;
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

            f_ButtonLogin.Enabled = false;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
;
            if (f_CheckBoxRememberMe.Checked)
            {
                FacadeLayer.FacadeFacebook.Instance.LogicSettings.RememberUser= f_CheckBoxRememberMe.Checked;
                FacadeLayer.FacadeFacebook.Instance.LogicSettings.LastAccessToken = FacadeLayer.FacadeFacebook.Instance.LoginResult.AccessToken;
                FacadeLayer.FacadeFacebook.Instance.LogicSettings.SaveToFile();

                saveUiSettings();
            }
            else
            {
                FacadeLayer.FacadeFacebook.Instance.LogicSettings.LastAccessToken = null;
            }

            FacadeLayer.FacadeFacebook.Instance.LogicSettings.SaveToFile();
        }

        private void saveUiSettings()
        {
            UISettings = new UISetting
            {
                LastWindowSize = Size,
                LastWindowLocation = Location,
                RememberMeCheckBox = f_CheckBoxRememberMe.Checked
            };

            UISettings.SaveToFile();
        }

        private void clearForm()
        {
            this.Dispose(false);
            new FormMain().Show();
        }

        private void onFetchPostsThread()
        {
            foreach (Post post in FacadeLayer.FacadeFacebook.Instance.GetLoggedUserPosts())
            {
                f_ListBoxPosts.Invoke(new Action(() => f_ListBoxPosts.Items.Add(new PostProxy { Post = post })));
            }

            if (!FacadeLayer.FacadeFacebook.Instance.IsLoggedUserHasPosts())
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

            FacadeLayer.FacadeFacebook.Instance.Logout();
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

            if (!FacadeLayer.FacadeFacebook.Instance.isLoggedUserHasFriends())
            {
                MessageBox.Show("No Friends to retrieve :(");
            }
            else
            {
                new FormFriendList(FacadeLayer.FacadeFacebook.Instance.GetLoggedUserFriends(), f_LoadingCircleShowFriend).ShowDialog();
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

            if (!FacadeLayer.FacadeFacebook.Instance.IsLoggedUserHasCheckins())
            {
                MessageBox.Show("No Posts to retrieve :(");
            }
            else
            {
                new FormCheckinList(FacadeLayer.FacadeFacebook.Instance.GetCheckins(), f_LoadingCircleShowCheckins).ShowDialog();
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

            if (!FacadeLayer.FacadeFacebook.Instance.IsLoggedUserHasEvents())
            {
                MessageBox.Show("No Events to retrieve :(");
            }
            else
            {
                new FormEventsList(FacadeLayer.FacadeFacebook.Instance.GetLoggedUserEvents(), f_LoadingCircleShowEvents).ShowDialog();
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
            if (!FacadeLayer.FacadeFacebook.Instance.isLoggedUserHasFriends())
            {
                MessageBox.Show("You Don't have any friends :(");
            }
            else
            {
                DigginFriend digginFriend = FacadeLayer.FacadeFacebook.Instance.GetDigginFriend();

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
                new FormCovid19CheckedIn(FacadeLayer.FacadeFacebook.Instance.LoggedUser).ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("You dont have any chekins");
            }
        }

        private void onShowAlbumsThread()
        {
            /*            if (FacadeLayer.FacadeFacebook.Instance.LoggedUser.Albums.Count == 0)
                        {
                            MessageBox.Show("No Albums to retrieve :(");
                        }
                        else
                        {
                            new FormAlbums(r_FBConnector.LoggedUser.Albums, f_LoadingCircleShowMyAlbums).ShowDialog();
                        }*/

            if (!FacadeLayer.FacadeFacebook.Instance.IsLoggedUserHasAlbums())
            {
                MessageBox.Show("No Albums to retrieve :(");
            }
            else
            {
                new FormAlbums(FacadeLayer.FacadeFacebook.Instance.GetLoggedUserAlbums(), f_LoadingCircleShowMyAlbums).ShowDialog();
            }
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            //FacadeLayer.FacadeFacebook.Instance.Connect(FacadeLayer.FacadeFacebook.Instance.LastAccessToken);
            FacadeLayer.FacadeFacebook.Instance.Connect();
            userBindingSource.DataSource = FacadeLayer.FacadeFacebook.Instance.LoggedUser;
            handleButtonsVisibility();
            exposeLabels();

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            /*r_FBConnector.LoggedUser = r_FBConnector.LoginResult.LoggedInUser;
            userBindingSource.DataSource = r_FBConnector.LoggedUser;
            handleButtonsVisibility();
            exposeLabels();*/

            userBindingSource.DataSource = FacadeLayer.FacadeFacebook.Instance.LoggedUser;
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
