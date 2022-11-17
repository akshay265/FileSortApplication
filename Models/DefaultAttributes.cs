using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSortApplication.Models
{
    
    public class DefaultAttributes
    {
        public static String defaultDir = @"C:\Users";

        public static String DefaultDir
        {
            get { return defaultDir; }
            set { defaultDir = value; }
        }
    }
}
