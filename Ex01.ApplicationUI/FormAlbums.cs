using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace Ex01.ApplicationUI
{
    public partial class FormAlbums : Form
    {
        private readonly FacebookObjectCollection<Album> r_Albums;
        private int m_AlbumIndex;

        public FormAlbums(FacebookObjectCollection<Album> i_Albums)
        {
            r_Albums = i_Albums;
            m_AlbumIndex = 0;
            InitializeComponent();                      //desginer code
            initializeComponent();                      //our code
        }

        private void initializeComponent()
        {
            albumPictureBox1.Load(r_Albums[m_AlbumIndex].PictureAlbumURL);
            f_LabelAlbumName.Text = r_Albums[m_AlbumIndex].Name;
            f_LabelCreatedDate.Text = string.Format("created date: {0} ", r_Albums[m_AlbumIndex].CreatedTime.ToString());  
        }
        private void previousLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (m_AlbumIndex > 0)
            {
                m_AlbumIndex--;
            }

            initializeComponent();
        }

        private void nextLinkLable_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (m_AlbumIndex < r_Albums.Count - 1)
            {
                m_AlbumIndex++;
            }

            initializeComponent();
        }
    }
}
