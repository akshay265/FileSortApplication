using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace FileSortApplication.Models
{
    public static class DbaseConnection
    {
        static string localDbase = CurrentPath.GetDbasePath() + "\\UserItemsDB.accdb";
        static string DSN = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + localDbase;

        static OleDbConnection myConn = new OleDbConnection(DSN);
        static OleDbDataAdapter myAdapter;


        public static void EstablishConn(string SQL)
        {
            myAdapter = new OleDbDataAdapter(SQL, myConn);
            myConn.Open();
        }
        public static DataTable GetFileListData()
        {

            string SQL = "SELECT * FROM File_List";
            /*
                        //Create Objects of ADOConnection and ADOCommand    
                        OleDbConnection myConn = new OleDbConnection(DSN);
                        OleDbDataAdapter myCmd = new OleDbDataAdapter(SQL, myConn);
                        myConn.Open();*/
            EstablishConn(SQL);

            DataSet ds = new DataSet();
            myAdapter.Fill(ds, "File_List");

            DataTable dt = ds.Tables[0];

            myConn.Close();

            return dt;
        }

        public static DataTable GetTagListData()
        {
            string SQL = "SELECT * FROM Tags_List";

            /* //Create Objects of ADOConnection and ADOCommand    
             OleDbConnection myConn = new OleDbConnection(DSN);
             OleDbDataAdapter myCmd = new OleDbDataAdapter(SQL, myConn);
             myConn.Open();*/

            EstablishConn(SQL);

            DataSet ds = new DataSet();
            myAdapter.Fill(ds, "Tags_List");

            DataTable dt = ds.Tables[0];

            myConn.Close();

            return dt;
        }

        public static void AddTag(FileTag newTag)
        {
            //string sql = "INSERT INTO Fault (str) VALUES (?)";
            //EstablishConn(sql);
            using (myConn = new OleDbConnection(DSN))
            using (OleDbCommand cmd = new OleDbCommand())
            {
                cmd.Connection = myConn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Tags_List (str) VALUES (?)";

                cmd.Parameters.Add(new OleDbParameter("@str", OleDbType.VarChar)).Value = newTag.ToString();

                myConn.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        public static void ConnectToDatabase()
        {
            OleDbConnection dbaseConnection = new OleDbConnection();
            OleDbDataAdapter dbaseAdapter;
            DataTable localFileTable = new DataTable();


            string dbaseloc = CurrentPath.GetDbasePath() + "\\UserItems.accdb";
            dbaseConnection.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source = " + dbaseloc + ";";

            dbaseConnection.Open();

            dbaseAdapter = new OleDbDataAdapter("SELECT * FROM File_List;", dbaseConnection);
            dbaseAdapter.Fill(localFileTable);

            // rowPos = (localFileTable.Rows.Count != 0) ? localFileTable.Rows.Count : 0;
        }
    }
}

/*
OdbcConnection conn = new OdbcConnection();
conn.ConnectionString = "Driver = {Microsoft Access Driver (*.accdb)}; Dbq = " + dbaseloc ;
conn.Open();

string CONNECTION_STRING = "Driver={Microsoft Access Driver (*.mdb, *.accdb)};Dbq = " + dbaseloc;
OdbcConnection myConnection = new OdbcConnection(CONNECTION_STRING);
myConnection.Open();
*/
