using FacebookWrapper.ObjectModel;

namespace Ex01.ApplicationUI
{
    internal class PostProxy
    {
        public Post Post { get; set; }

        public override string ToString()
        {
            string itemText;
            if (Post.Message != null)
            {
                itemText = Post.Message;
            }
            else if (Post.Caption != null)
            {
                itemText = Post.Caption;
            }
            else
            {
                itemText = string.Format("[{0}]", Post.Type);
            }

            return itemText;
        }
    }
}