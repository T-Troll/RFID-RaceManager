using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.IO;

namespace RaceManager.Data
{
    public class database
    {
        public SQLiteConnection get_SQLiteConnection()
        {
            if (!File.Exists("races.db"))//sqlite"))
                SQLiteConnection.CreateFile("races.db");// sqlite");

            SQLiteConnection myConnection = new SQLiteConnection("data source=races.db");// sqlite");
            myConnection.Open();
            return myConnection;
        }

        public int getLastInsertedId(SQLiteCommand cmd)
        {
            //database objDatabase = new database();
            //SQLiteCommand cmd;
            string lastRowIdQuery;
            lastRowIdQuery = @"select last_insert_rowid()";
            //cmd = new SQLiteCommand(objDatabase.get_SQLiteConnection());
            cmd.CommandText = lastRowIdQuery;
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

    }
}
