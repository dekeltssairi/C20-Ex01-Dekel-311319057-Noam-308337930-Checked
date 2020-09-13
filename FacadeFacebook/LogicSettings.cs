using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace FacadeLayer
{
    public class LogicSettings : Settings
    {
        public bool RememberUser { get; set; }

        public string LastAccessToken { get; set; }

        public override void initialize()
        {
            RememberUser = false;
            LastAccessToken = null;
        }

        public LogicSettings() : base(@"\\LogicSettings.xml")
        {
        }
    }
}