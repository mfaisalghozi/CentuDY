﻿using CentuDY.Handler;
using CentuDY.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentuDY.Controller
{
    public class TransactionController
    {
        internal static dynamic getTransactionHistory(int userID)
        {
           return TransactionHandler.getTransactionHistory(userID);
        }
    }
}