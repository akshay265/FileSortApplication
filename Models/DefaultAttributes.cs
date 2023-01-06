using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSortApplication.Models
{
    
    public class DefaultAttributes
    {
        public static String originalDefaultDir = @"C:\Users";
        private static String defaultDir = @"C:\Users";
        private static bool isUserAware = false;
        private static Icon iconObj = new Icon(@"C:\Users\Akshay\Source\Repos\akshay265\FileSortApplication\Models\big_man.ico");

        public static String DefaultDir
        {
            get { return defaultDir; }
            set { defaultDir = value; }
        }

        public static bool UserAware
        {
            get { return isUserAware; }
            set { isUserAware = value; }
        }

        public static Icon DefaultIconObj
        {
            get { return iconObj; }
        }

      //https://stackoverflow.com/questions/4479421/get-windows-theme
        public String GetTheme()
        {
                String RegistryKey = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes";
                String theme;
                theme = (String)Registry.GetValue(RegistryKey, "CurrentTheme", String.Empty);
                theme = theme.Split('\\').Last().Split('.').First().ToString();
                return theme;
        }
    }
}
