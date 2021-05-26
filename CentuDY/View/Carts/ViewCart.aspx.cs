using CentuDY.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CentuDY.View.Carts
{
    public partial class ViewCart : System.Web.UI.Page
    {
        int id ;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null || Session["role"].Equals("2"))
            {
                Response.Redirect("/View/HomePage.aspx");
            }
            if (!IsPostBack)
            {
                countGrandTotal();
            }
        }
        protected void countGrandTotal()
        {
            int sum = 0;
            for (int i = 0; i < CartTable.Rows.Count; i++)
            {
                int subTotal = 0;
                subTotal = Int32.Parse(CartTable.Rows[i].Cells[4].Text);
                sum = sum + subTotal;
            }
            totalLabelValue.Text = sum.ToString();
        }

        protected void deleteCart(object sender, EventArgs e)
        {
            int id = Int32.Parse((sender as LinkButton).CommandArgument);
            int userID = Int32.Parse(Session["user"].ToString());
            CartController.doDeleteCart(id, userID);
            CartTable.DataBind();
            countGrandTotal(); 
        }

        protected void checkout(object sender, EventArgs e)
        {
            int userID = Int32.Parse(Session["user"].ToString());
            string checkoutStatus = CartController.checkout(userID);
            
            if (checkoutStatus.Equals("success"))
            {
                Response.Redirect("CheckoutSuccess.aspx");
            }
            else if (checkoutStatus.Equals("empty"))
            {
                ErrorMessageLabel.Text = "Cart can't be empty";
            }
            CartTable.DataBind();
        }

        protected void ContinueShopBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Medicines/ViewMedicine.aspx");
        }
    }
}