using Ex01.ApplicationUI;
using System.Drawing;
using System.IO;
using System.Xml.Serialization;

namespace Ex01.ApplicationUI
{
    public class UISetting
    {
        public Size LastWindowSize { get; set; }
        public Point LastWindowLocation { get; set; }
        public bool RememberMeCheckBox { get; set; }

        private const string k_SettingsFileSuffix = @"\\UISettings.xml";

        private void initialize()
        {
            LastWindowLocation = new Point(20, 20);
            LastWindowSize = new Size(1150, 640);
        }

        public static UISetting LoadFromFile()
        {
            UISetting uiSetting = new UISetting();

            if (File.Exists(Directory.GetCurrentDirectory() + k_SettingsFileSuffix))
            {
                using (Stream xmlStream = new FileStream(Directory.GetCurrentDirectory() + k_SettingsFileSuffix, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(UISetting));
                    uiSetting = serializer.Deserialize(xmlStream) as UISetting;
                }
            }
            else
            {
                uiSetting.initialize();
            }


            return uiSetting;
        }
        public UISetting() { }

        public void SaveToFile()
        {
            if (File.Exists(Directory.GetCurrentDirectory() + k_SettingsFileSuffix))
            {
                File.Delete(Directory.GetCurrentDirectory() + k_SettingsFileSuffix);
            }

            using (Stream xmlStream = new FileStream(Directory.GetCurrentDirectory() + k_SettingsFileSuffix, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(UISetting));
                serializer.Serialize(xmlStream, this);
            }
        }

    }
}



