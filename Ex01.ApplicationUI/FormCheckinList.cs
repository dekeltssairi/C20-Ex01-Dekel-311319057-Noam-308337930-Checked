using System;
using System.CodeDom;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;


namespace Ex01.ApplicationUI
{
    public partial class FormCheckinList : Form
    {

        private readonly FacebookObjectCollection<CheckinProxy> m_Checkins;
        public FormCheckinList(FacebookObjectCollection<Checkin> i_Checkins)
        {
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

    }
}


