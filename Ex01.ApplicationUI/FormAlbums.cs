using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using MRG.Controls.UI;

namespace Ex01.ApplicationUI
{
    public partial class FormAlbums : Form
    {
        private readonly FacebookObjectCollection<Album> r_Albums;
        private readonly LoadingCircle m_LoadingCircleShowMyAlbums;

        public FormAlbums(FacebookObjectCollection<Album> i_Albums, MRG.Controls.UI.LoadingCircle i_LoadingCircleShowMyAlbums)
        {
            r_Albums = i_Albums;
            m_LoadingCircleShowMyAlbums = i_LoadingCircleShowMyAlbums;
            InitializeComponent();                      
            albumBindingSource.DataSource = r_Albums;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            m_LoadingCircleShowMyAlbums.Invoke(new Action(() =>
            {
                m_LoadingCircleShowMyAlbums.Visible = false;
                m_LoadingCircleShowMyAlbums.Enabled = false;
            }));
        }
    }
}