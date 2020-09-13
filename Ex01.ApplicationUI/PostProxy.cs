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
                //f_ListBoxPosts.Items.Add(post.Message);
            }
            else if (Post.Caption != null)
            {
                itemText = Post.Caption;
                //f_ListBoxPosts.Items.Add(post.Caption);
            }
            else
            {
                itemText = string.Format("[{0}]", Post.Type);
                //f_ListBoxPosts.Items.Add(string.Format("[{0}]", post.Type));
            }

            return itemText;
        }

        
    }
}