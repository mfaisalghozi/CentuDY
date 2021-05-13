using CentuDY.Controller;
using CentuDY.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CentuDY.View.Carts
{
    public partial class AddToCart : System.Web.UI.Page
    {
        private static Medicine currentMedicine = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null || Session["role"].Equals("2"))
            {
                Response.Redirect("/View/HomePage.aspx");
            }
            if (Request.QueryString["id"] == null)
            {
                Response.Redirect("ViewCart.aspx");
            }
            if (!IsPostBack)
            {
                int id= Int32.Parse(Request.QueryString["id"]);
                attachProperties(id);
            }
        }

        private void attachProperties(int id)
        {
            if (!IsPostBack)
            {
                currentMedicine = MedicineController.getMedicineById(id);
                NameBox.Text = currentMedicine.Name;
                DescriptionBox.Text = currentMedicine.Description;
                PriceBox.Text = currentMedicine.Price.ToString();
                StockBox.Text = currentMedicine.Stock.ToString();
            }
        }

        protected void addToCart(object sender, EventArgs e)
        {
            int qty = Int32.Parse(QtyBox.Text);
            int medicineId = Int32.Parse(Request.QueryString["id"]);
            int userId = Int32.Parse(Session["user"].ToString());
            ErrorMessage.Text = CartController.doAddCart(qty, medicineId, userId);
            if (ErrorMessage.Text == "")
            {
                Response.Redirect("./ViewCart.aspx");
            }
        }
    }
}