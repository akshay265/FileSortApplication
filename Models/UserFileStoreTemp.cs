using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FileSortApplication.Models
{
    internal static class UserFileStoreTemp
    {
        static UserFile temp;

        public static UserFile tempUserFile
        {
            get { return temp; }
            set { temp = value; }
        }
    }
}
