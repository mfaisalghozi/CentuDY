using CentuDY.Factory;
using CentuDY.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentuDY.Repository
{
    public class UserRepository
    {
        private static CentudyDatabaseEntities db = CentuDY.Singleton.SingletonDB.getInstance();

        public static void updateUser(int id, string username, string name, string gender, string phone, string address)
        {
            User u = getUserById(id);
            if (u != null)
            {
                u.Name = name;
                u.Username = username;
                u.Gender = gender;
                u.PhoneNumber = phone;
                u.Address = address;
                db.SaveChanges();
            }
        }

        public static User createUser(String username, String password, String name, String gender,String phone,String address)
        {
            return UserFactory.createUser(username, password,name,gender,phone,address);
        }

        public static void addUser(User u)
        {
            db.Users.Add(u);
            db.SaveChanges();
        }

        public static bool usernameUnique(string username)
        {
            User u = db.Users.Where(user => user.Username == username).FirstOrDefault();
            if (u == null)
            {
                return true;
            }
            return false;
        }

        public static User getUser(String username, String password)
        {
            User u = db.Users.Where(user => user.Username == username && user.Password == password).FirstOrDefault();
            return u;
        }
        
        public static User getUserById(int id)
        {
            User u = db.Users.Where(user => user.UserId == id).FirstOrDefault();
            return u;
        }

        public static void updateUserPassword(int id, string password)
        {
            User u = getUserById(id);
            if (u != null)
            {
                u.Password = password;
                db.SaveChanges();
            }
        }
    }

}