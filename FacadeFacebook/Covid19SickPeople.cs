using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace FacadeLayer
{
    public class Covid19SickPeople
    {
        private const string k_SickPeopleFileSuffix = @"\\Covid19SickPeople.xml";

        public List<ConfirmedSickLocation> ConfirmedSickLocations { get; set; }

        public static Covid19SickPeople LoadFromFile()
        {
            Covid19SickPeople covid19SickPeople = new Covid19SickPeople();

            if (File.Exists(Directory.GetCurrentDirectory() + k_SickPeopleFileSuffix))
            {
                using (Stream xmlStream = new FileStream(Directory.GetCurrentDirectory() + k_SickPeopleFileSuffix, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Covid19SickPeople));
                    covid19SickPeople = serializer.Deserialize(xmlStream) as Covid19SickPeople;
                }
            }
            else
            {
                covid19SickPeople.loadDefault();
            }

            return covid19SickPeople;
        }

        public Covid19SickPeople()
        {
            ConfirmedSickLocations = new List<ConfirmedSickLocation>();            
        }

        private void loadDefault()
        {
            ConfirmedSickLocation defaultLocation = new ConfirmedSickLocation();
            defaultLocation.Location = "האקדמית תא יפו";
            defaultLocation.DateOfSickConfirmation = new DateTime(2020, 04, 03, 10, 30, 0);

            ConfirmedSickLocations.Add(defaultLocation);
        }

        public void SaveToFile()
        {
            if (File.Exists(Directory.GetCurrentDirectory() + k_SickPeopleFileSuffix))
            {
                File.Delete(Directory.GetCurrentDirectory() + k_SickPeopleFileSuffix);
            }

            using (Stream xmlStream = new FileStream(Directory.GetCurrentDirectory() + k_SickPeopleFileSuffix, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Covid19SickPeople));
                serializer.Serialize(xmlStream, this);
            }
        }

        public void AddConfirmedLocationTotheList(ConfirmedSickLocation i_confirmedSickLocation)
        {
            if(!CheckIfLocationIsInTheList(i_confirmedSickLocation) == true)
            {
                ConfirmedSickLocations.Add(i_confirmedSickLocation);
            }
        }

        public bool CheckIfLocationIsInTheList(ConfirmedSickLocation i_Location)
        {
            foreach(ConfirmedSickLocation confirmedSickLocation in ConfirmedSickLocations)
            {
                if (confirmedSickLocation.Location == i_Location.Location)
                {
                    if (IsWithInTheRecoveryTime(confirmedSickLocation.DateOfSickConfirmation))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private bool IsWithInTheRecoveryTime(DateTime i_TimeToCompare)
        {
            const double HowMuchHoursToWait = Utilities.Constants.MaxHoursToWaitForRecovery;
            double IsInfectionTimeIsOver = (DateTime.Now - i_TimeToCompare).TotalHours;

            return IsInfectionTimeIsOver > HowMuchHoursToWait;
        }
    }
}
