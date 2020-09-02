using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace FacadeFacebook
{
    public class LogicSettings
    {
        public bool RememberUser { get; set; }

        public string LastAccessToken { get; set; }

/*      public Point LastWindowLocation { get; set; }

        public Size LastWindowSize { get; set; }
*/
        private const string k_SettingsFileSuffix = @"\\AppSettings.xml";

        public static LogicSettings LoadFromFile()
        {
            LogicSettings logicSettings = new LogicSettings();

            if (File.Exists(Directory.GetCurrentDirectory() + k_SettingsFileSuffix))
            {
                using (Stream xmlStream = new FileStream(Directory.GetCurrentDirectory() + k_SettingsFileSuffix, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(LogicSettings));
                    logicSettings = serializer.Deserialize(xmlStream) as LogicSettings;
                }
            }

            if (logicSettings.RememberUser == false)
            {
                logicSettings= new LogicSettings();
            }

            return logicSettings;
        }

        public LogicSettings()
        {
         //   LastWindowLocation = new Point(20, 20);
         //   LastWindowSize = new Size(1150, 640);
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
                XmlSerializer serializer = new XmlSerializer(typeof(LogicSettings));
                serializer.Serialize(xmlStream, this);
            }
        }
    }
}
