using System;
using System.Windows.Forms;
using FacadeLayer;
using FacebookWrapper.ObjectModel;

namespace Ex01.ApplicationUI
{
    public partial class FormCovid19CheckedIn : Form
    {
        private readonly User m_LoggedUser;
        private readonly Covid19SickPeople r_ConfirmedSickPeople = Covid19SickPeople.LoadFromFile();

        public FormCovid19CheckedIn(User i_LoggedUser)
        {
            m_LoggedUser = i_LoggedUser;
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void AddConfirmedSickLocation_button_Click(object sender, EventArgs e)
        {
            ResultStatus_label.Text = " ";
            try
            {
                ConfirmedSickLocation LocationInput = getSelectedLocationAndDateTime();
                r_ConfirmedSickPeople.AddConfirmedLocationTotheList(LocationInput);
            }
            catch (Exception AddConfirmedSickLocation)
            {
                MessageBox.Show(AddConfirmedSickLocation.Message);
            }

            clearLocationDateTimeSelectingFields();
        }

        private void CheckUserLocation_button_Click(object sender, EventArgs e)
        {
            ResultStatus_label.Text = " ";
            try
            {
                ConfirmedSickLocation LocationInput = getSelectedLocationAndDateTime();
                if (r_ConfirmedSickPeople.CheckIfLocationIsInTheList(LocationInput))
                {
                    ResultStatus_label.Text = Utilities.Constants.NegaiveMessage;
                }
                else
                {
                    ResultStatus_label.Text = Utilities.Constants.NegaiveMessage;
                }
            }
            catch (Exception CheckUserLocationError)
            {
                MessageBox.Show(CheckUserLocationError.Message);
            }

            clearLocationDateTimeSelectingFields();
        }

        private void clearLocationDateTimeSelectingFields()
        {
            Hour_textBox.Clear();
            Minute_textBox.Clear();
            Second_TextBox.Clear();
            LocationTimeToCheck_dateTimePicker.Value = DateTime.Now;
            LocationDescription_textBox.Clear();
        }

        private ConfirmedSickLocation getSelectedLocationAndDateTime()
        {
            ConfirmedSickLocation confirmedSickLocation = new ConfirmedSickLocation();
            DateTime SelectedDateTime;

            try
            {
                SelectedDateTime = createSeletedDateTime(Hour_textBox.Text, Minute_textBox.Text, Second_TextBox.Text);
                if (LocationDescription_textBox.Text == string.Empty)
                {
                    throw new Exception("Location Description is empty");
                }
            }
            catch (Exception createSelectedDateTimeError)
            {
                clearLocationDateTimeSelectingFields();
                throw createSelectedDateTimeError;
            }

            confirmedSickLocation.Location = LocationDescription_textBox.Text;
            confirmedSickLocation.DateOfSickConfirmation = SelectedDateTime;

            return confirmedSickLocation;
        }

        private DateTime createSeletedDateTime(string i_Hour, string i_Minute, string i_Second)
        {
            int HourAsInt, MinuteAsInt, SecondsAsInt;
            int Day, Month, Year;

            try
            {
                bool isHourValid = Utilities.inputValidation(i_Hour, out HourAsInt, 2, 24, "Hour");
                bool isMinuteVaild = Utilities.inputValidation(i_Minute, out MinuteAsInt, 2, 60, "Minute");
                bool isSecondsVaild = Utilities.inputValidation(i_Second, out SecondsAsInt, 2, 60, "Second");
            }
            catch (Exception TimeError)
            {
                throw TimeError;
            }

            if(LocationTimeToCheck_dateTimePicker.Value != null)
            {
                if (LocationTimeToCheck_dateTimePicker.Value > DateTime.Now)
                {
                    throw new Exception("Selected Date canot be in the future");
                }

                Day = LocationTimeToCheck_dateTimePicker.Value.Day;
                Month = LocationTimeToCheck_dateTimePicker.Value.Month;
                Year = LocationTimeToCheck_dateTimePicker.Value.Year;
            }
            else
            {
                throw new Exception("Date is not selected");
            }

            return new DateTime(Year, Month, Day, HourAsInt, MinuteAsInt, SecondsAsInt);
        }

        private void MyCheckins_button_Click(object sender, EventArgs e)
        {
            ResultStatus_label.Text = string.Empty;
            addToLocationsList();
        }

        private void LoadSickList_button_Click(object sender, EventArgs e)
        {
            ResultStatus_label.Text = " ";
            ConfirmedSickLocations_listBox.Items.Clear();
            foreach (ConfirmedSickLocation confirmedSickLocation in r_ConfirmedSickPeople.ConfirmedSickLocations)
            {
                ConfirmedSickLocations_listBox.Items.Add(string.Format("{0},{1}", confirmedSickLocation.Location, confirmedSickLocation.DateOfSickConfirmation));
            }
        }

        private void CheckMyCheckins_button_Click(object sender, EventArgs e)
        {
            FacebookObjectCollection<Checkin> checkins = m_LoggedUser.Checkins;
            ConfirmedSickLocation LocationInput = new ConfirmedSickLocation();
            bool result = false;
            foreach (Checkin checkin in checkins)
            {
                LocationInput.DateOfSickConfirmation = checkin.CreatedTime ?? new DateTime(1900, 01, 01, 0, 0, 0);
                LocationInput.Location = checkin.Place.Name;
                if(r_ConfirmedSickPeople.CheckIfLocationIsInTheList(LocationInput))
                {
                    result = true;
                } 
            }

            if(result == true)
            {
                ResultStatus_label.Text = Utilities.Constants.PositiveMessage;
            }
            else
            {
                ResultStatus_label.Text = Utilities.Constants.NegaiveMessage;
            }
        }

        private void addToLocationsList()
        {
            ResultStatus_label.Text = " ";
            Locations_listBox.Items.Clear();
            FacebookObjectCollection<Checkin> checkins = m_LoggedUser.Checkins;
            foreach (Checkin checkin in checkins)
            {
                Locations_listBox.Items.Add(checkin);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            r_ConfirmedSickPeople.SaveToFile();
        }

        private void Locations_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResultStatus_label.Text = " ";
            if (Locations_listBox.SelectedItems.Count == 1)
            {
                displaySelectedLocation(Locations_listBox.SelectedItem as Checkin);
            }
        }

        private void displaySelectedLocation(Checkin i_Checkin)
        {
            if (i_Checkin != null)
            {
                LocationDescription_textBox.Text = i_Checkin.Place.Name ?? " ";
                LocationTimeToCheck_dateTimePicker.Value = i_Checkin.CreatedTime ?? LocationTimeToCheck_dateTimePicker.Value;
                Hour_textBox.Text = i_Checkin.CreatedTime.Value.Hour.ToString();
                Minute_textBox.Text = i_Checkin.CreatedTime.Value.Minute.ToString();
                Second_TextBox.Text = i_Checkin.CreatedTime.Value.Second.ToString();
            }
        }

        private void Friends_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResultStatus_label.Text = " ";
            if (Friends_listBox.SelectedItems.Count == 1)
            {
                displaySelectedFriendCheckIns(Locations_listBox.SelectedItem as User);
            }
        }

        private void displaySelectedFriendCheckIns(User i_SelectedUser)
        {
            Friends_listBox.Items.Clear();
            try
            {
                foreach (Checkin checkin in i_SelectedUser.Checkins)
                {
                    Friends_listBox.Items.Add(checkin);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Service is not Available");
            }
        }

        private void loadFriend_button_Click(object sender, EventArgs e)
        {
            ResultStatus_label.Text = " ";
            foreach (User friend in m_LoggedUser.Friends)
            {
                Friends_listBox.Items.Add(friend);
                friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
            }
        }
    }
}
