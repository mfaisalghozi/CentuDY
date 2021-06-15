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

            var grandTotal = 0;


            for (int i = 0; i < TransactionHistoryTable.Rows.Count; i++)
            {
                grandTotal = grandTotal + Int32.Parse(TransactionHistoryTable.Rows[i].Cells[3].Text);
            }

            GrandTotal.Text = "Grand Total : " + grandTotal.ToString();
        }

        protected void HomeBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("../HomePage.aspx");
        }
    }
}