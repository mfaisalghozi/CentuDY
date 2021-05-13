﻿using CentuDY.Factory;
using CentuDY.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentuDY.Repository
{
    public class TransactionRepository
    {
        private static CentudyDatabaseEntities db = CentuDY.Singleton.SingletonDB.getInstance();
        public static HeaderTransaction CreateHeaderTransaction(int userId, DateTime transactionDate)
        {
            return TransactionFactory.CreateHeaderTransaction(userId, transactionDate);
        }

        public static DetailTransaction CreateDetailTransaction(int transactionid, int medicineId, int qty)
        {
            return TransactionFactory.CreateDetailTransaction(transactionid, medicineId, qty);
        }

        public static HeaderTransaction AddTransactionHeader(HeaderTransaction transactionHeader)
        {
            db.HeaderTransactions.Add(transactionHeader);
            db.SaveChanges();
            return transactionHeader;
        }

        public static DetailTransaction AddTransactionDetail(DetailTransaction transactionDetail)
        {
            db.DetailTransactions.Add(transactionDetail);
            db.SaveChanges();

            return transactionDetail;
        }
    }
}