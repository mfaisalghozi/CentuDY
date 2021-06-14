using CentuDY.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentuDY.Controller
{
    public class TransactionController
    {
        internal static List<string> getTransactionHistory(int userID)
        {
            return TransactionHandler.getTransactionHistory(userID);
        }
    }
}