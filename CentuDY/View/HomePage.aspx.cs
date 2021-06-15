using CentuDY.Controller;
using CentuDY.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CentuDY.View
{
    public partial class HomePage : System.Web.UI.Page
    {
        User user;
        int roleId;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session["user"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            else
            {
                String id = Session["user"].ToString();
                user = UserController.getUserbyId(Int32.Parse(id));
                try
                {
                    roleId = Int32.Parse(Session["role"].ToString());
                }
                catch (Exception ex)
                {
                    Response.Redirect("../Login.aspx");
                }
                if (roleId == 2)
                {
                    InsertMedicineButton.Visible = true;
                    ViewUserButton.Visible = true;
                    ViewCartButton.Visible = false;
                    MedicineRandomTable.Visible = false;
                    
                }
                WelcomeMessageLabel.Text = "Welcome "+user.Name+"!";
                loadTable();
                userid.Text = "User id is " + id;


            }
        }

        protected void loadTable()
        {
            MedicineRandomTable.DataSource = MedicineController.getRandomMedicine();
            MedicineRandomTable.DataBind();
        }
        public void goToInsertMedicine(object sender, EventArgs e)
        {
            Response.Redirect("Medicines/InsertMedicine.aspx");
        }

        protected void GoToViewMedicines(object sender, EventArgs e)
        {
            Response.Redirect("Medicines/ViewMedicine.aspx");
        }

        protected void logout(object sender, EventArgs e)
        {
            Session["user"] = null;
            Session["roleId"] = null;
            if (Request.Cookies["remember_user"] != null)
            {
                Response.Cookies["remember_user"].Expires = DateTime.Now.AddDays(-1);
            }
            Response.Redirect("Login.aspx");
        }

        protected void goToViewCart(object sender, EventArgs e)
        {
            Response.Redirect("Carts/ViewCart.aspx");
        }

        protected void addToCartMedicine(object sender, EventArgs e)
        {
            int medicineId = Int32.Parse((sender as LinkButton).CommandArgument);
            Response.Redirect("Carts/AddToCart.aspx?id=" + medicineId);
        }

        protected void goToViewUser(object sender, EventArgs e)
        {
            Response.Redirect("Admin/ViewUser.aspx");

        }

        protected void ViewProfileBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Users/ProfilePage.aspx");
        }

        protected void ViewTransactionHistory_Click(object sender, EventArgs e)
        {
            Response.Redirect("Users/TransactionHistory.aspx");
        }
    }
}