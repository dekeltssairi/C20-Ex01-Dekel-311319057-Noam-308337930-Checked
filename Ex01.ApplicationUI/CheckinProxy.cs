using FacebookWrapper.ObjectModel;

namespace Ex01.ApplicationUI
{
    internal class CheckinProxy
    {
        public Checkin Checkin { get; set; }

        public override string ToString()
        {
            return Checkin.Place.Name;
        }
    }
}