using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using MRG.Controls.UI;

namespace Ex01.ApplicationUI
{
    public partial class FormMosiftDiggingFriend : Form
    {
        private User m_MostDiggingFriend;
        private LoadingCircle m_LoadingCircleShowMostDiggingFriend;

        public FormMosiftDiggingFriend(User i_MostDiggingFriend, int maxNumOfPosts, MRG.Controls.UI.LoadingCircle i_LoadingCircleShowMostDiggingFriend)
        {
            m_MostDiggingFriend = i_MostDiggingFriend;
            m_LoadingCircleShowMostDiggingFriend = i_LoadingCircleShowMostDiggingFriend;
            InitializeComponent();
            initializeComponent(i_MostDiggingFriend, maxNumOfPosts);
        }

        private void initializeComponent(User i_Friend, int i_NumOfPosts)
        {
            userBindingSource.DataSource = i_Friend;
            f_LabelNumOfPosts.Text = string.Format("Most Digging Friend is {0}. He post {1} posts last year", i_Friend.Name, i_NumOfPosts.ToString());
            //f_LabelFriendName.Text = i_Friend.Name;
            //f_PictureBoxProfilePicture.Load(i_Friend.PictureLargeURL);           
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            m_LoadingCircleShowMostDiggingFriend.Invoke(new Action(() =>
            {
                m_LoadingCircleShowMostDiggingFriend.Visible = false;
                m_LoadingCircleShowMostDiggingFriend.Enabled = false;
            }));

        }
    }
}
