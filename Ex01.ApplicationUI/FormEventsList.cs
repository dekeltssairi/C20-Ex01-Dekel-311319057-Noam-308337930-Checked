using FacebookWrapper.ObjectModel;
using MRG.Controls.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex01.ApplicationUI
{
    public partial class FormEventsList : Form
    {
        private FacebookObjectCollection<Event> m_Events;
        private LoadingCircle m_LoadingCircleShowEvents;

        public FormEventsList(FacebookWrapper.ObjectModel.FacebookObjectCollection<FacebookWrapper.ObjectModel.Event> i_Events, MRG.Controls.UI.LoadingCircle i_LoadingCircleShowEvents)
        {
            m_Events = i_Events;
            m_LoadingCircleShowEvents = i_LoadingCircleShowEvents;
            InitializeComponent();
            eventBindingSource.DataSource = m_Events;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            m_LoadingCircleShowEvents.Invoke(new Action(() =>
            {
                m_LoadingCircleShowEvents.Visible = false;
                m_LoadingCircleShowEvents.Enabled = false;
            }));
        }
    }
}
