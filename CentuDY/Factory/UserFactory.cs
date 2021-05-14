﻿using CentuDY.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentuDY.Factory
{
    public class UserFactory
    {
        public static User createUser(String username, String password, String name,String gender,String phone,String address)
        {
            return new CentuDY.Model.User()
            {
                RoleId = 1,
                Username = username,
                Password = password,
                Name = name,
                Gender = gender,
                PhoneNumber = phone,
                Address = address,
            };
        }
    }
}