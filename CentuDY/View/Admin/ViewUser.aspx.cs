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
            int index = Convert.ToInt32(e.CommandArgument);
            GridView grid = sender as GridView;
            GridViewRow row = grid.Rows[index];

            AdminController.deleteUserByIndex(int.Parse(row.Cells[1].Text));

            Response.Redirect("./ViewUser.aspx");
        }
    }
}