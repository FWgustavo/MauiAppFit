using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiAppFit.Models;
using SQLite;

namespace MauiAppFit.Helpers
{
    public class SQLiteDataBaseHelper
    {
        readonly SQLiteDataBaseHelper _db;

        public SQLiteDataBaseHelper(string dbPath)
        {
            _db = new SQLiteDataBaseHelper(dbPath);
            _db CreateTableAsync<Atividade>().Wait();
        }
    }
}
