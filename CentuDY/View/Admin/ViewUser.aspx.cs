using CentuDY.Controller;
using CentuDY.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CentuDY.View.Admin
{
    public partial class ViewUser : System.Web.UI.Page
    {

        private List<User> users;

        protected void Page_Load(object sender, EventArgs e)
        {
            users = AdminController.getAllUsers();
            ViewUserTable.DataSource = users;
            ViewUserTable.DataBind();

        }

        protected void ViewUserTable_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int userIndex = int.Parse(e.CommandArgument.ToString());
            AdminController.deleteUserByIndex(userIndex);

            Response.Redirect("./ViewUser.aspx");
        }
    }
}