using System;
using System.Collections.Generic;
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
    }
}
