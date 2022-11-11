using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace FileSortApplication
{
    public class UserFile :File
    {
        private int fileID;
        private String name;
        private String path;
        private String type;
        private int size;
        private String dateCreated;
        private String asscTags;

        public UserFile(int ID, String n, String p, String t, int s, String dC, String aT)
        {
            this.fileID = ID;
            this.name = n;
            this.path = p;
            this.type = t;
            this.size = s;
            this.dateCreated = dC;
            this.asscTags = aT;
        }

    }
}
