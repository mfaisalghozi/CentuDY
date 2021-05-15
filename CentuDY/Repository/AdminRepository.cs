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

            var query = from x in db.Users where x.RoleId == 1 select x;
            return query.ToList();
        }

        public static void deleteUserByIndex(int userIndex)
        {

            User userToDelete = db.Users.Find(userIndex);

            db.Users.Remove(userToDelete);
            db.SaveChanges();
        }

       
    }
}