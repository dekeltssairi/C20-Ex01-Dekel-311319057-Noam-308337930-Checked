using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace Ex01.ApplicationUI
{
    public partial class FormFriendList : Form
    {
        private readonly FacebookObjectCollection<User> r_Friends;
        public FormFriendList(FacebookObjectCollection<User> i_friends)
        {
            r_Friends = i_friends;
            InitializeComponent();
            initializeComponent();
            
        }

        private void initializeComponent()
        {
            f_LabelWait.Visible = true;
            f_ListBoxFriends.Items.Clear();
            fillFriends(r_Friends);
            f_LabelWait.Visible = false;


            //System.Threading.Thread.Sleep(100);
            //throw new NotImplementedException();
        }

        private void fillFriends(FacebookObjectCollection<User> i_Friends)
        {
            foreach (User friend in i_Friends)
            {
                f_ListBoxFriends.Items.Add(friend);
                friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
            }
        }

        private void displaySelectedFriend(User i_Selecteduser)
        {               
                if (i_Selecteduser.PictureNormalURL != null)
                {
                    f_PictureBoxProfile.LoadAsync(i_Selecteduser.PictureNormalURL);
                }
                else
                {
                    f_PictureBoxProfile.Image = f_PictureBoxProfile.ErrorImage;
                }

                displaySelectedFriendPosts(i_Selecteduser.Posts);   
        }

        private void displaySelectedFriendPosts(FacebookObjectCollection<Post> i_friendsPosts)
        {
           f_ListBoxPosts.Items.Clear();
           int counter = 0;
           foreach (Post post in i_friendsPosts)
           {
                if(counter < 10)
                {
                    f_ListBoxPosts.Items.Add(post);
                    counter++;
                }
                else
                {
                    break;
                }
           }
        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            f_LabelWait.Visible = true;
            if (f_ListBoxFriends.SelectedItems.Count == 1)
            {
                displaySelectedFriend(f_ListBoxFriends.SelectedItem as User);
            }
            f_LabelWait.Visible = false;
        }
    }
}
