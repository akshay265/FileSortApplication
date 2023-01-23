using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Drawing;

namespace FileSortApplication.Models
{
    public class UserFile
    {
        private int fileID;
        private String name;
        private String path;
        private String type;
        private long size;
        private String dateCreated;
        private String asscTags;
        private FileInfo fileObj;

        public UserFile(int ID, String n, String p, String t, long s, String dC, String aT)
        {
            this.fileID = ID;
            this.name = n;
            this.path = p;
            this.type = t;
            this.size = s;
            this.dateCreated = dC;
            this.asscTags = aT;
            this.fileObj = new FileInfo(p);
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

        public long Size
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

        public String MoveToDbase()
        {
            String filename = name;
            String sourcepath = path;
            String targetpath = DefaultAttributes.DefaultDir;

            DbaseConnection.ConnectToDatabase();

            String sourcefile = System.IO.Path.Combine(sourcepath, filename);
            String destfile = System.IO.Path.Combine(targetpath, filename);

            if (!Directory.Exists(targetpath))
            {
                Directory.CreateDirectory(targetpath);
            }

            File.Copy(sourcefile, destfile, true);
            if (Directory.Exists(sourcepath))
            {
                String[] files = Directory.GetFiles(sourcepath);

                // Copy the files and overwrite destination files if they already exist.
                foreach (String s in files)
                {
                    // Use static Path methods to extract only the file name from the path.
                    filename = System.IO.Path.GetFileName(s);
                    destfile = System.IO.Path.Combine(targetpath, filename);
                    File.Copy(s, destfile, true);
                }
            }
            else
            {
                return "File doesn't exist";
            }

            return "File moved";
        
        }

        public Boolean Delete(Bitmap bmap)
        {
            bmap.Dispose();
            bmap = null;

            try
            {
                fileObj.Delete();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

            try
            {
                DbaseConnection.ConnectToDatabase();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;   
            }

            return false;
        }
    }
}
