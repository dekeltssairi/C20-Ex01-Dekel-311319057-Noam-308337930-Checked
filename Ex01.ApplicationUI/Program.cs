using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Ex01.ApplicationUI;
using FacebookWrapper;

// $G$ RUL-004 (-20) Wrong zip name format / folder name format
// $G$ RUL-999 (-10) Wrong mail subject


// $G$ THE-001 (-31) your grade on diagrams document - 69. please see comments inside the document. (40% of your grade).

namespace Ex01.ApplicationUI
{

    // $G$ CSS-999 (-5) Access modifiers are missing
    static class Program
    {
        [STAThread]
        static void Main()
        {
            FacebookService.s_UseForamttedToStrings = true;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
