using CentuDY.Handler;
using CentuDY.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentuDY.Controller
{
    public class UserController
    {
        public static User getUserbyId(int id)
        {
            return UserHandler.getUserById(id);
        }
        public static String loginInputValidity(string username,string password)
        {
            if (username.Equals(""))
            {
                return "Username cannot be empty!";
            }
            else if (password.Equals(""))
            {
                return "Password cannot be empty!";
            }

            return "";
        }

        public static string updateProfile(int id,string username,string name,string gender,string phone,string address)
        {
            UserHandler.updateProfile(id, username, name, gender, phone, address);
            return "Profile Update Success";
        }

        public static void updatePassword(int id, string password)
        {
            UserHandler.updatePassword(id, password);
        }

        public static User login(string username, string password)
        {
            return UserHandler.login(username, password);
        }
        public static string register(string username, string password, string confirmPassword, string name, string gender,string phone,string address)
        {
            if (username.Length == 0)
            {
                return "Username can't be empty";
            }
            else if (username.Length < 3)
            {
                return "Username length can't be less then 3 characters";
            }
            else if (!UserHandler.usernameUnique(username))
            {
                return "Username is already exists";
            }
            else if (password.Length == 0)
            {
                return "Password can't be empty";
            }
            else if (confirmPassword.Length == 0)
            {
                return "Confirm Password can't be empty";
            }
            else if (password.Length < 8)
            {
                return "Password length can't be less then 8 characters";
            }
            else if (!password.Equals(confirmPassword))
            {
                return "Password and confirm password must be same!";
            }
            else if (name.Length == 0)
            {
                return "Name can't be empty";
            }
            else if (!(gender.Equals("Male") || gender.Equals("Female")))
            {
                return "Gender must be chosen";
            }
            else if(phone.Length==0)
            {
                return "Phone number can't be empty";
            }
            else if (address.Length == 0)
            {
                return "Address can't be empty";
            }
            else if (!address.Contains("Street"))
            {
                return "Address must contain \"Street\" ";
            }

            UserHandler.register(username, password, name, gender, phone, address);
            return "";
        }
    }
}