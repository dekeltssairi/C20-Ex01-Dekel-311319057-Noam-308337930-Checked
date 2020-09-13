using FacebookWrapper.ObjectModel;

namespace FacadeLayer
{
    public class DigginFriend
    {
        public User Friend { get; set; }

        public int NumOfPosts { get; set; }

        public DigginFriend(User i_Friend, int i_NumOfPosts)
        {
            Friend = i_Friend;
            NumOfPosts = i_NumOfPosts;
        }
    }
}