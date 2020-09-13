using Ex01.ApplicationUI;
using FacadeLayer;
using System.Drawing;
using System.IO;
using System.Xml.Serialization;

namespace Ex01.ApplicationUI
{
    public class UISetting : Settings
    {
        public Size LastWindowSize { get; set; }
        public Point LastWindowLocation { get; set; }
        public bool RememberMeCheckBox { get; set; }

        public override void initialize()
        {
            LastWindowLocation = new Point(20, 20);
            LastWindowSize = new Size(1150, 640);
        }
        public UISetting():base(@"\\UISettings.xml") { }

    }
}



