using scrollFrame.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

namespace scrollFrame.DataAccess
{
    public class PersonaDAO : IDisposable
    {
        protected SQLiteConnection sqlconnection;
        public PersonaDAO()
        {
            sqlconnection = new SQLiteConnection(DatabasePath);
            sqlconnection.CreateTable<PersonaModel>();
        }

        protected string DatabasePath
        {
            get
            {
                //#if __IOS__
                //                var dbName = Constants.dbName;
                //                string dbPath = Path.Combine(
                //                Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                //                    dbName);
                //                return dbPath;
                //#endif
                //#if __ANDROID__
                var dbName = "miDB.db3";
                string folder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                var dbPath = Path.Combine(folder, dbName);
                return dbPath;
                //#endif
            }
        }
        public void Dispose()
        {
            if (sqlconnection != null)
            {
                try
                {
                    sqlconnection.Close();
                }
                catch
                {
                }
            }
        }

        public void create(PersonaModel personaModel) 
        {
            sqlconnection.Insert(personaModel);
        }

        public List<PersonaModel> list()
        {
            return (from t in sqlconnection.Table<PersonaModel>() select t).ToList();
        }
    } 
}
