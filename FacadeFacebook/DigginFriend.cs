using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadeFacebook
{
    public class DigginFriend
    {
        public User Friend { get; set; }
        public int NumOfPosts{ get; set; }

        public DigginFriend(User i_Friend, int i_NumOfPosts)
        {
            Friend = i_Friend;
            NumOfPosts = i_NumOfPosts;
        }
    }
}
