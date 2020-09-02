using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadeFacebook
{
    public class FacadeFacebook
    {
        public LoginResult LoginResult { get; set; }
        public User LoggedUser { get; set; }
        public string AccessToken { get; set; }

        private readonly LogicSettings r_LogicSettings = LogicSettings.LoadFromFile();

        private string k_AppId = "343280916704350";






        public FacebookObjectCollection<User> GetFriends()
        {
            return LoggedUser.Friends;
        }

        public FacebookObjectCollection<Checkin> GetCheckins()
        {
            return LoggedUser.Checkins;
        }

        public FacebookObjectCollection<Album> GetAlbums()
        {
            return LoggedUser.Albums;
        }

        public FacebookObjectCollection<Event> GetEvents()
        {
            return LoggedUser.Events;
        }

        public FacebookObjectCollection<Post> GetPosts()
        {
            return LoggedUser.Posts;
        }

        public DigginFriend GetDigginFriend()
        {
            DateTime lastYear = DateTime.Today.AddYears(-1);
            User mostDiggingFriend = null;
            int postCounter, maxNumOfPosts = 0;

            foreach (User friend in LoggedUser.Friends)
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

            return new DigginFriend(mostDiggingFriend, maxNumOfPosts);
        }





        public void LogIn()
        {
            LoginResult = FacebookService.Login(
                k_AppId,
                "public_profile",
                "user_likes",
                "user_posts",
                "user_photos",
                "user_videos");
            AccessToken = LoginResult.AccessToken;
        }

        public void Connect(string i_LastAccessToken)
        {
            LoginResult = FacebookService.Connect(i_LastAccessToken);
        }

        public void Logout()
        {
            FacebookService.Logout(() => { });
            //f_CheckBoxRememberMe.Checked = false;
            r_LogicSettings.RememberUser = false;
            r_LogicSettings.SaveToFile();
            //clearForm();
        }
    }
}
