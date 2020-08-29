using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace Ex01.ApplicationEngine
{
    public class FBConnector
    {
        public LoginResult LoginResult { get; set; }

        public User LoggedUser { get; set; }

        public string AccessToken { get; set; }

        private string k_AppId = "343280916704350";

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
    }
}
