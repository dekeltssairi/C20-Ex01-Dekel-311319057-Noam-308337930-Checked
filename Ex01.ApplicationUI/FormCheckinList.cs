using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace Ex01.ApplicationUI
{
    public partial class FormCheckinList : Form
    {
        public FormCheckinList(FacebookObjectCollection<Checkin> i_Checkins)
        {
            InitializeComponent();
            f_ListBoxCheckins.Items.Clear();

            foreach (Checkin checkin in i_Checkins)
            {
                f_ListBoxCheckins.Items.Add(checkin.Place.Name);
            }
        }
    }
}
