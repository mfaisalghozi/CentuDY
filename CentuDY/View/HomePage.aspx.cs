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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                String id = Session["user"].ToString();
                User user = UserController.getUserbyId(Int32.Parse(id));
                WelcomeMessageLabel.Text = "Welcome "+user.Name+"!";
            }
        }
    }
}