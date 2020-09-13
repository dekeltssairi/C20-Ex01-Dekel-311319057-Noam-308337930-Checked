using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml.Serialization;

namespace FacadeLayer
{
    public abstract class Settings
    {
        protected readonly string r_SettingsFileSuffix;

        public virtual void initialize()
        {
        }

        public Settings LoadFromFile()
        {
            Settings settings;

            if (File.Exists(Directory.GetCurrentDirectory() + r_SettingsFileSuffix))
            {
                using (Stream xmlStream = new FileStream(Directory.GetCurrentDirectory() + r_SettingsFileSuffix, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(this.GetType());       // reflection: can change at run time due to inheritnace
                    settings = serializer.Deserialize(xmlStream) as Settings;
                }
            }
            else
            {
                settings = Activator.CreateInstance(this.GetType()) as Settings;        // reflection: can change at run time due to inheritnace
                settings.initialize();
            }

            return settings;
        }

        public Settings(string i_SettingsFileSuffix)
        {
            r_SettingsFileSuffix = i_SettingsFileSuffix;
        }

        public void SaveToFile()
        {
            if (File.Exists(Directory.GetCurrentDirectory() + r_SettingsFileSuffix))
            {
                File.Delete(Directory.GetCurrentDirectory() + r_SettingsFileSuffix);
            }

            using (Stream xmlStream = new FileStream(Directory.GetCurrentDirectory() + r_SettingsFileSuffix, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(xmlStream, this);
            }
        }
    }
}
