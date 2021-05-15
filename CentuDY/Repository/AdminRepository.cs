using CentuDY.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentuDY.Repository
{
    public class AdminRepository
    {

        private static CentudyDatabaseEntities db = CentuDY.Singleton.SingletonDB.getInstance();

        public static List<User> getAllUsers()
        {
            return db.Users.ToList();
        }
    }
}