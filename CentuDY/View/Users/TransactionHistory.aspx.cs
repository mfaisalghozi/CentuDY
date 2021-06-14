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
        private List<String> transactionHistory;

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void GetTransactionHistory()
        {
            transactionHistory = TransactionController.getTransactionHistory(int.Parse(Session["user"].ToString()));
        }
    }
}