using System;
using System.Collections.Generic;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacadeLayer
{
    public class FacadeFacebook
    {
        public static FacadeFacebook Instance
        {
            get
            {
                return Singleton<FacadeFacebook>.Instance;
            }
        }

        private FacadeFacebook()
        {
            LogicSettings = new LogicSettings().LoadFromFile() as LogicSettings;
        }

        public LoginResult LoginResult { get; set; }

        public User LoggedUser { get; set; }
        
        public LogicSettings LogicSettings { get; set; }

        public bool ShouldRestoreSettings()
        {
            return LogicSettings.RememberUser && !string.IsNullOrEmpty(LogicSettings.LastAccessToken);
        }

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
            
            LogicSettings.LastAccessToken = LoginResult.AccessToken;

            LoggedUser = LoginResult.LoggedInUser;
        }

        public bool IsUserLogin()
        {
            return LoggedUser != null;
        }

        public void Connect()
        {
            LoginResult = FacebookService.Connect(LogicSettings.LastAccessToken);
            LoggedUser = LoginResult.LoggedInUser;
        }

        public void Logout()
        {
            FacebookService.Logout(() => { });
            LogicSettings.RememberUser = false;
            LogicSettings.SaveToFile();
        }

        public bool IsLoggedUserHasAlbums()
        {
            return LoggedUser.Albums.Count > 0;
        }

        public FacebookObjectCollection<Album> GetLoggedUserAlbums()
        {
            return LoggedUser.Albums;
        }

        public IEnumerable<Post> GetLoggedUserPosts()
        {
            return LoggedUser.Posts;
        }

        public bool IsLoggedUserHasPosts()
        {
            return LoggedUser.Posts.Count > 0;
        }

        public bool isLoggedUserHasFriends()
        {
            return LoggedUser.Friends.Count > 0;
        }

        public FacebookObjectCollection<User> GetLoggedUserFriends()
        {
            return LoggedUser.Friends;
        }

        public bool IsLoggedUserHasCheckins()
        {
            return LoggedUser.Checkins.Count > 0;
        }

        public bool IsLoggedUserHasEvents()
        {
            return LoggedUser.Events.Count > 0;
        }

        public FacebookObjectCollection<Event> GetLoggedUserEvents()
        {
            return LoggedUser.Events;
        }
    }
}
