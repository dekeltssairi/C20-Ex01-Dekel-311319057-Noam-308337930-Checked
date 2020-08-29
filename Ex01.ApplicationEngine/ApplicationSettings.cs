using System.Xml.Serialization;
using System.Drawing;
using System.IO;

namespace Ex01.ApplicationEngine
{
    public class ApplicationSettings
    {
        public bool RememberUser { get; set; }

        public string LastAccessToken { get; set; }

        public Point LastWindowLocation { get; set; }

        public Size LastWindowSize { get; set; }

        private const string k_SettingsFileSuffix = @"\\AppSettings.xml";

        public static ApplicationSettings LoadFromFile()
        {
            ApplicationSettings appSettings = new ApplicationSettings();

            if (File.Exists(Directory.GetCurrentDirectory() + k_SettingsFileSuffix))
            {
                using (Stream xmlStream = new FileStream(Directory.GetCurrentDirectory() + k_SettingsFileSuffix, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(ApplicationSettings));
                    appSettings = serializer.Deserialize(xmlStream) as ApplicationSettings;
                }
            }

            if (appSettings.RememberUser == false)
            {
                appSettings = new ApplicationSettings();
            }

            return appSettings;
        }

        public ApplicationSettings()
        {
            LastWindowLocation = new Point(20, 20);
            LastWindowSize = new Size(1150, 640);
            RememberUser = false;
            LastAccessToken = null;
        }

        public void SaveToFile()
        {
            if (File.Exists(Directory.GetCurrentDirectory() + k_SettingsFileSuffix))
            {
                File.Delete(Directory.GetCurrentDirectory() + k_SettingsFileSuffix);
            }

            using (Stream xmlStream = new FileStream(Directory.GetCurrentDirectory() + k_SettingsFileSuffix, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ApplicationSettings));
                serializer.Serialize(xmlStream, this);
            }
        }
    }
}
