using System;
using System.CodeDom;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using MRG.Controls.UI;

namespace Ex01.ApplicationUI
{
    public partial class FormCheckinList : Form
    {
        private readonly LoadingCircle m_LoadingCircleShowCheckins;

        private readonly FacebookObjectCollection<CheckinProxy> m_Checkins;

        public FormCheckinList(FacebookObjectCollection<Checkin> i_Checkins, MRG.Controls.UI.LoadingCircle i_LoadingCircleShowCheckins)
        {
            m_LoadingCircleShowCheckins = i_LoadingCircleShowCheckins;
            m_Checkins = new FacebookObjectCollection<CheckinProxy>();
            foreach (Checkin checkin in i_Checkins)
            {
                m_Checkins.Add(new CheckinProxy { Checkin = checkin });
            }

            InitializeComponent();
            initializeComponent();
        }

        private void initializeComponent()
        {
            checkinProxyBindingSource.DataSource = m_Checkins;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            m_LoadingCircleShowCheckins.Invoke(new Action(() =>
            {
                m_LoadingCircleShowCheckins.Visible = false;
                m_LoadingCircleShowCheckins.Enabled = false;
            }));
        }
    }
}