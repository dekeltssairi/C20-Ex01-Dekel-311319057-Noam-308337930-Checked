using System;

namespace FacadeLayer
{
    public class ConfirmedSickLocation
    {
        public string Location { get; set; }

        public DateTime DateOfSickConfirmation { get; set; }

        public void CreateConfirmedSickLocation(string i_Location, DateTime i_DateOfSickConfirmation)
        {
            Location = i_Location;
            DateOfSickConfirmation = i_DateOfSickConfirmation;
        }
    }
}
