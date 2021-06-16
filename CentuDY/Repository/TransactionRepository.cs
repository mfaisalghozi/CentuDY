using CentuDY.Factory;
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

        internal static dynamic getTransactionHistory(int userID)
        {

            var query = from header in db.HeaderTransactions.ToList()
                        join detail in db.DetailTransactions.ToList() on header.TransactionId equals detail.TransactionId
                        join medicine in db.Medicines.ToList() on detail.MedicineId equals medicine.MedicineId
                        where header.UserId == userID
                        select new { Name = medicine.Name, Quantity = detail.Quantity, TransactionDate = header.TransactionDate, SubTotal = medicine.Price * detail.Quantity };

            dynamic transaction = query;

            return transaction;
              
        }

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