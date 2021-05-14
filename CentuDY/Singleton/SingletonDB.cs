using CentuDY.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentuDY.Singleton
{
    public class SingletonDB
    {
        private static CentudyDatabaseEntities db = null;

        private SingletonDB()
        {
        }

        public static CentudyDatabaseEntities getInstance()
        {
            return (db == null) ? new CentudyDatabaseEntities() : db;
        }
    }
}