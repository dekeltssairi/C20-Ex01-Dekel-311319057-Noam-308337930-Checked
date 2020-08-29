using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace Ex01.ApplicationUI
{
    public partial class FormMosiftDiggingFriend : Form
    {
        public FormMosiftDiggingFriend(User i_MostDiggingFriend, int maxNumOfPosts)
        {
            InitializeComponent();
            initializeComponent(i_MostDiggingFriend, maxNumOfPosts);
        }

        private void initializeComponent(User i_Friend, int i_NumOfPosts)
        {
            f_LabelNumOfPosts.Text = string.Format("Most Digging Friend is {0}. He post {1} posts last year", i_Friend.Name, i_NumOfPosts.ToString());
            f_LabelFriendName.Text = i_Friend.Name;
            f_PictureBoxProfilePicture.Load(i_Friend.PictureLargeURL);           
        }
    }
}
