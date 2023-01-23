using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FileSortApplication.Models
{
    public static class DbaseConnection
    {
        static string localDbase = CurrentPath.GetDbasePath() + "\\UserItem.mdb";
        static string DSN = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + localDbase;

        public static DataTable GetFileListData()
        {
            //DSN = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + localDbase;
            
            string SQL = "SELECT * FROM Files_List";

            //Create Objects of ADOConnection and ADOCommand    
            OleDbConnection myConn = new OleDbConnection(DSN);
            OleDbDataAdapter myCmd = new OleDbDataAdapter(SQL, myConn);
            myConn.Open();

            DataSet ds = new DataSet();
            myCmd.Fill(ds, "Files_List");

            DataTable dt = ds.Tables[0];

            myConn.Close();

            return dt;
        }

        public static void ConnectToDatabase()
        {
            OleDbConnection dbaseConnection = new OleDbConnection();
            OleDbDataAdapter dbaseAdapter;
            DataTable localFileTable = new DataTable();
            int rowPos = 0, rowNum = 0;

            string dbaseloc = CurrentPath.GetDbasePath() + "\\UserItems2.accdb";
            dbaseConnection.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source = " + dbaseloc + ";";

            dbaseConnection.Open();

            dbaseAdapter = new OleDbDataAdapter("SELECT * FROM File_List;", dbaseConnection);
            dbaseAdapter.Fill(localFileTable);

            rowPos = (localFileTable.Rows.Count != 0) ? localFileTable.Rows.Count : 0;
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
