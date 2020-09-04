using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml.Serialization;

namespace FacadeFacebook
{
    public class Settings
    {

        private readonly string r_SettingsFileSuffix;

        private void initialize()
        {
        }

        public Settings LoadFromFile()
        {
            Settings uiSetting = Activator.CreateInstance(this.GetType(), r_SettingsFileSuffix) as Settings;

            if (File.Exists(Directory.GetCurrentDirectory() + r_SettingsFileSuffix))
            {
                using (Stream xmlStream = new FileStream(Directory.GetCurrentDirectory() + r_SettingsFileSuffix, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(this.GetType());
                    uiSetting = serializer.Deserialize(xmlStream) as Settings;
                }
            }
            else
            {
                uiSetting.initialize();
            }


            return uiSetting;
        }

        public Settings(string i_SettingsFileSuffix)
        {
            r_SettingsFileSuffix = i_SettingsFileSuffix;
        }
    }
}
