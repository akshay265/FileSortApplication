using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace FileSortApplication
{
    public class UserFile
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

        public int FileID
        {
            get { return fileID; }
            //set { fileID = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public String Path
        {
            get { return path; }
            set { path = value; }
        }

        public String Type
        {
            get { return type; }
            set { type = value; }
        }

        public int Size
        {
            get { return size; }
           // set { size = value; }
        }

        public String DateCreated
        {
            get { return dateCreated; }
            set { dateCreated = value; }
        }

        public String AssociatedTags
        {
            get { return asscTags; }
            set { asscTags = value; }
        }


    }
}
