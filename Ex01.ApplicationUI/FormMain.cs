using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using FacadeLayer;
using FacebookWrapper.ObjectModel;
using MRG.Controls.UI;

namespace Ex01.ApplicationUI
{
    public partial class FormMain : Form
    {
        public UISetting UISettings { get; set; }

        public FormMain()
        {
            InitializeComponent();
            if (FacadeFacebook.Instance.ShouldRestoreSettings())
            {
                restoreSettings();
                FacadeFacebook.Instance.Connect();
                userBindingSource.DataSource = FacadeFacebook.Instance.LoggedUser;
                handleControlsVisibility();
            }
        }

        private void handleControlsVisibility()
        {
            handleLabels();
            handleButtons();
            f_CheckBoxRememberMe.Visible = !f_CheckBoxRememberMe.Visible;
        }

        private void handleLabels()
        {
            foreach (Label label in f_PanelProfile.Controls.OfType<Label>())
            {
                label.Visible = !label.Visible;
            }
        }

        private void handleButtons()
        {
            foreach (Button button in splitContainer1.Panel2.Controls.OfType<Button>())
            {
                button.Enabled = !button.Enabled;
            }

            f_ButtonLogin.Enabled = false;
        }

        private void restoreSettings()
        {
            UISettings = new UISetting().LoadFromFile() as UISetting;
            applySettings();
        }

        private void applySettings()
        {
            StartPosition = FormStartPosition.Manual;
            f_CheckBoxRememberMe.Checked = UISettings.RememberMeCheckBox;
            Location = UISettings.LastWindowLocation;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            FacadeFacebook.Instance.LogIn();
            userBindingSource.DataSource = FacadeFacebook.Instance.LoggedUser;
            handleControlsVisibility();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacadeFacebook.Instance.Logout();
            clearForm();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (f_CheckBoxRememberMe.Checked == true && FacadeFacebook.Instance.IsUserLogin() == true)
            {
                FacadeFacebook.Instance.LogicSettings.RememberUser = f_CheckBoxRememberMe.Checked;
                FacadeFacebook.Instance.LogicSettings.LastAccessToken = FacadeFacebook.Instance.LoginResult.AccessToken;
                FacadeFacebook.Instance.LogicSettings.SaveToFile();
                saveUiSettings();
            }
            else
            {
                FacadeFacebook.Instance.LogicSettings.LastAccessToken = null;
            }

            FacadeFacebook.Instance.LogicSettings.SaveToFile();
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
            foreach (Post post in FacadeFacebook.Instance.GetLoggedUserPosts())
            {
                f_ListBoxPosts.Invoke(new Action(() => f_ListBoxPosts.Items.Add(new PostProxy { Post = post })));
            }

            if (!FacadeFacebook.Instance.IsLoggedUserHasPosts())
            {
                MessageBox.Show("No Posts to retrieve :(");
            }
        }

        private void onShowFriendsThread()
        {
            if (!FacadeFacebook.Instance.isLoggedUserHasFriends())
            {
                MessageBox.Show("No Friends to retrieve :(");
            }
            else
            {
                new FormFriendList(FacadeFacebook.Instance.GetLoggedUserFriends(), f_LoadingCircleShowFriend).ShowDialog();
            }
        }

        private void onShowCheckinsThread()
        {
            if (!FacadeFacebook.Instance.IsLoggedUserHasCheckins())
            {
                MessageBox.Show("No Posts to retrieve :(");
            }
            else
            {
                new FormCheckinList(FacadeFacebook.Instance.GetCheckins(), f_LoadingCircleShowCheckins).ShowDialog();
            }
        }

        private void onFetchEventsThread()
        {
            if (!FacadeFacebook.Instance.IsLoggedUserHasEvents() == true)
            {
                MessageBox.Show("No Events to retrieve :(");
            }
            else
            {
                new FormEventsList(FacadeFacebook.Instance.GetLoggedUserEvents(), f_LoadingCircleShowEvents).ShowDialog();
            }
        }

        private void onMostDiggingFriendThread()
        {
            if (!FacadeFacebook.Instance.isLoggedUserHasFriends() == true)
            {
                MessageBox.Show("You Don't have any friends :(");
            }
            else
            {
                DigginFriend digginFriend = FacadeFacebook.Instance.GetDigginFriend();

                new FormMosiftDiggingFriend(digginFriend, f_LoadingCircleShowMostDiggingFriend).ShowDialog();
            }
        }

        private void Covid19_button_Click(object sender, EventArgs e)
        {
            try
            {
                new FormCovid19CheckedIn(FacadeFacebook.Instance.LoggedUser).ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("You dont have any chekins");
            }
        }

        private void onShowAlbumsThread()
        {
            if (!FacadeFacebook.Instance.IsLoggedUserHasAlbums())
            {
                MessageBox.Show("No Albums to retrieve :(");
            }
            else
            {
                new FormAlbums(FacadeFacebook.Instance.GetLoggedUserAlbums(), f_LoadingCircleShowMyAlbums).ShowDialog();
            }
        }

        private void activeLoadingCircle(LoadingCircle i_LoadingCircle)
        {
            i_LoadingCircle.Visible = true;
            i_LoadingCircle.Active = true;
        }

        private void f_ButtonShowLikes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Out of Permission!");
        }

        private void f_Postbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Out of Permission!");
        }

        private void f_ButtonShowMyPosts_Click(object sender, EventArgs e)
        {
            f_ListBoxPosts.Items.Clear();
            new Thread(onFetchPostsThread).Start();
        }

        private void f_ButtonShowMyEvents_Click(object sender, EventArgs e)
        {
            activeLoadingCircle(f_LoadingCircleShowEvents);
            new Thread(onFetchEventsThread).Start();
        }

        private void f_ButtonMyAlbums_Click(object sender, EventArgs e)
        {
            activeLoadingCircle(f_LoadingCircleShowMyAlbums);
            new Thread(onShowAlbumsThread).Start();
        }

        private void buttonMostDiggingFriend_Click(object sender, EventArgs e)
        {
            activeLoadingCircle(f_LoadingCircleShowMostDiggingFriend);
            new Thread(onMostDiggingFriendThread).Start();
        }

        private void f_CheckinsButton_Click(object sender, EventArgs e)
        {
            activeLoadingCircle(f_LoadingCircleShowCheckins);
            new Thread(onShowCheckinsThread).Start();
        }

        private void f_ShowFriendsButton_Click(object sender, EventArgs e)
        {
            activeLoadingCircle(f_LoadingCircleShowFriend);
            new Thread(onShowFriendsThread).Start();
        }
    }
}
