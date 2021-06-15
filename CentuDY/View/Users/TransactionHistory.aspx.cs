using CentuDY.Controller;
using CentuDY.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CentuDY.View.Users
{
    public partial class TransactionHistory : System.Web.UI.Page
    {
        private static CentudyDatabaseEntities db = CentuDY.Singleton.SingletonDB.getInstance();
        dynamic transactionHistory;
        protected void Page_Load(object sender, EventArgs e)
        {
            GetTransactionHistory();
        }

        protected void GetTransactionHistory()
        {
    
            transactionHistory = TransactionController.getTransactionHistory(int.Parse(Session["user"].ToString()));

            TransactionHistoryTable.DataSource = transactionHistory;
            TransactionHistoryTable.DataBind();

            //var query = from header in db.HeaderTransactions.ToList()
            //            join detail in db.DetailTransactions.ToList() on header.TransactionId equals detail.TransactionId
            //            join medicine in db.Medicines.ToList() on detail.MedicineId equals medicine.MedicineId
            //            select new { Name = medicine.Name, Quantity = detail.Quantity, TransactionDate = header.TransactionDate, SubTotal = medicine.Price*detail.Quantity };

            //TransactionHistoryTable.DataSource = query.ToList();
            //TransactionHistoryTable.DataBind();
        }
    }
}