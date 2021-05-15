using CentuDY.Handler;
using CentuDY.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentuDY.Controller
{
    public class AdminController
    {   
        public static List<User> getAllUsers()
        {
            return AdminHandler.getAllUsers();
        }

        internal static void deleteUserByIndex(int userIndex)
        {
            AdminHandler.deleteUsersByIndex(userIndex);
        }


    }
}