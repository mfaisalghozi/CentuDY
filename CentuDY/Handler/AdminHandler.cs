using CentuDY.Model;
using CentuDY.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentuDY.Handler
{
    public class AdminHandler
    {

        public static List<User> getAllUsers()
        {
            return AdminRepository.getAllUsers();
        }

        public static void deleteUsersByIndex(int index)
        {
            AdminRepository.deleteUserByIndex(index);
        }

    }
}