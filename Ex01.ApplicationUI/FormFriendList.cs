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
            userBindingSource.DataSource = r_Friends;
        }
    }
}
