using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
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

            dbaseConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Dbase\\UserItems.accdb";
            
            dbaseConnection.Open();

            dbaseAdapter = new OleDbDataAdapter("Select * From Files_List", dbaseConnection);
            dbaseAdapter.Fill(localFileTable);

            rowPos = (localFileTable.Rows.Count != 0) ? localFileTable.Rows.Count : 0;
        }
    }
}
