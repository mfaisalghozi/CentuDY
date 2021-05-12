using CentuDY.Model;
using CentuDY.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentuDY.Handler
{
    public class UserHandler
    {
        public static User getUserById(int id)
        {
            return UserRepository.getUserById(id);
        }
        public static void register(String username, String password,String name, String gender,String phone,String address)
        {
            User u = UserRepository.createUser(username, password, name,gender,phone,address);
            UserRepository.addUser(u);
        }

        public static User login(String username, String password)
        {
            User u = UserRepository.getUser(username, password);
            return u;
        }

        public static bool usernameUnique(string username)
        {
            return UserRepository.usernameUnique(username);
        }
    }
}