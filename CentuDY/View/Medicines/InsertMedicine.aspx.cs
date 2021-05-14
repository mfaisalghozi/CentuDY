using CentuDY.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CentuDY.View.Medicines
{
    public partial class InsertMedicine : System.Web.UI.Page
    {
        int roleId;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("../Login.aspx");
            }
            roleId = Int32.Parse(Session["role"].ToString());
            if (roleId != 2)
            {
                Response.Redirect("../HomePage.aspx");
            }
        }

        protected void insertProduct(object sender, EventArgs e)
        {
            string name = NameBox.Text;
            string description = DescriptionBox.Text;
            int price = 0;
            int stock = 0;
            try
            {
                price = Int32.Parse(PriceBox.Text);
            }
            catch(Exception e1)
            {
            }
            try
            {
                stock = Int32.Parse(StockBox.Text);
            }
            catch (Exception e2)
            {

            }

            string error = MedicineController.insertMedicine(name, description, price, stock);

            if (error == "")
            {
                Response.Redirect("./ViewMedicine.aspx");
            }
            else
            {
                ErrorMessage.Text = error;
            }
        }
    }
}