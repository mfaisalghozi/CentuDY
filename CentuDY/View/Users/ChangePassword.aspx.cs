using CentuDY.Controller;
using CentuDY.Model;
using CentuDY.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CentuDY.View.Users
{
    public partial class ChangePassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] == null)
            {
                Response.Redirect("../Login.aspx");
            }
            if (Session["user"] == null)
            {
                Response.Redirect("../Login.aspx");
            }
        }

        protected void BackToHomeBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("../HomePage.aspx");
        }

        protected void changePasswordBtn_Click(object sender, EventArgs e)
        {
            int userId = Int32.Parse(Request.QueryString["id"]);
            User user = UserRepository.getUserById(userId);
            string currPass = user.Password;

            string oldPass = OldPasswordBox.Text;
            string newPass = NewPasswordBox.Text;
            string confirmNewPass = ConfirmNewPasswordBox.Text;

            if (oldPass.Equals("") || newPass.Equals("") || confirmNewPass.Equals(""))
            {
                ErrorMessage.Text = "Password Cannot Be Empty !";
            } else if (!oldPass.Equals(currPass))
            {
                ErrorMessage.Text = "Wrong Old Password !";
            } else if (!newPass.Equals(confirmNewPass))
            {
                ErrorMessage.Text = "Confirm Password Does not match with the new password !";
            } else
            {
                //Update Password
                UserController.updatePassword(userId, newPass);
                ErrorMessage.Text = "";
                SuccessMessage.Text = "Successfully Change Passsword";
            }
        }
    }
}