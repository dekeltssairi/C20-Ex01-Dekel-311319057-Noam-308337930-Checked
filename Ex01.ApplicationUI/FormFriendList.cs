using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace Ex01.ApplicationUI
{
    public partial class FormFriendList : Form
    {
        private readonly FacebookObjectCollection<User> r_Friends;

        private readonly MRG.Controls.UI.LoadingCircle m_LoadingCircleShowFriend;

        public FormFriendList(FacebookObjectCollection<User> i_friends, MRG.Controls.UI.LoadingCircle i_LoadingCircleShowFriend)
        {
            r_Friends = i_friends;
            m_LoadingCircleShowFriend = i_LoadingCircleShowFriend;
            InitializeComponent();
            initializeComponent();
        }

        private void initializeComponent()
        {
            userBindingSource.DataSource = r_Friends;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            m_LoadingCircleShowFriend.Invoke(new Action(() =>
            {
                m_LoadingCircleShowFriend.Visible = false;
                m_LoadingCircleShowFriend.Enabled = false;
            }));
        }
    }
}
