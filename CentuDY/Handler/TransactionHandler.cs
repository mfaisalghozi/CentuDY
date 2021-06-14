using CentuDY.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentuDY.Handler
{
    public class TransactionHandler
    {
        internal static List<string> getTransactionHistory(int userID)
        {
            return TransactionRepository.getTransactionHistory(userID);
        }
    }
}