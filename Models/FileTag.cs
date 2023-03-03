using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSortApplication.Models
{
    public class FileTag
    {
        private String tagID;
        private String tagStr;

        public FileTag(String ID, String str)
        {
            this.tagID = ID;
            this.tagStr = str;
        }

        public FileTag( String str)
        {
            this.tagStr = str;
        }

        public override String ToString()
        {
            return tagStr;
        }
    }
}
