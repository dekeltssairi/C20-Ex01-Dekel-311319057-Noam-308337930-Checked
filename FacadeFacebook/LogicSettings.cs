using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace FacadeFacebook
{
    public class LogicSettings                                  // should split to logic setting and ui setting.
    {
        public bool RememberUser { get; set; }
        public string LastAccessToken { get; set; }


        private const string k_SettingsFileSuffix = @"\\LogicSettings.xml";

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
            else
            {
                logicSettings.initialize();
            }

            return logicSettings;
        }

        private void initialize()
        {
            RememberUser = false;
            LastAccessToken = null;
        }

        public LogicSettings(){}

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
