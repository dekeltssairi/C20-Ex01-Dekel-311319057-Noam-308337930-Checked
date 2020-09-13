using System;
using System.Windows.Forms;
using FacadeLayer;
using MRG.Controls.UI;

namespace Ex01.ApplicationUI
{
    public partial class FormMosiftDiggingFriend : Form
    {
        private DigginFriend m_MostDiggingFriend;
        private LoadingCircle m_LoadingCircleShowMostDiggingFriend;

        public FormMosiftDiggingFriend(DigginFriend i_MostDiggingFriend, MRG.Controls.UI.LoadingCircle i_LoadingCircleShowMostDiggingFriend)
        {
            m_MostDiggingFriend = i_MostDiggingFriend;
            m_LoadingCircleShowMostDiggingFriend = i_LoadingCircleShowMostDiggingFriend;
            InitializeComponent();
            initializeComponent(i_MostDiggingFriend);
        }

        private void initializeComponent(DigginFriend i_Friend)         
        {
            userBindingSource.DataSource = i_Friend.Friend;
            f_LabelNumOfPosts.Text = string.Format("Most Digging Friend is {0}. He post {1} posts last year", i_Friend.Friend.Name, i_Friend.NumOfPosts.ToString());
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