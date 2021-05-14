using CentuDY.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentuDY.Factory
{
    public class TransactionFactory
    {
        public static HeaderTransaction CreateHeaderTransaction(int userId, DateTime transactionDate)
        {
            return new HeaderTransaction()
            {
                UserId = userId,
                TransactionDate = transactionDate
            };
        }

        public static DetailTransaction CreateDetailTransaction(int transactionid, int medicineId, int qty)
        {
            return new CentuDY.Model.DetailTransaction()
            {
                TransactionId = transactionid,
                MedicineId = medicineId,
                Quantity = qty
            };
        }
    }
}