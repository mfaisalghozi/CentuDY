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
    public partial class Login : System.Web.UI.Page
    {
        string password;
        protected void Page_Load(object sender, EventArgs e)
        {

            HttpCookie rememberCookie = Request.Cookies["remember_user"];
            if (Session["user"] != null)
            {
                Response.Redirect("HomePage.aspx");
            }
            else if (rememberCookie != null)
            {
                String[] rememberUser = rememberCookie.Value.ToString().Split('%');
                String username = rememberUser[0];
                String password = rememberUser[1];
                User login = UserController.login(username, password);
                Session["user"] = login.UserId;
                Session["role"] = login.RoleId;
                Response.Redirect("HomePage.aspx");
                //UsernameBox.Text = username;
                //PasswordBox.Attributes["value"] = password;
            }

        }

        protected void login(object sender, EventArgs e)
        {
            
            String username = UsernameBox.Text;
            String password = PasswordBox.Text;

            string error = UserController.loginInputValidity(username, password);

            if (error != null)
            {
                ErrorMessage.Text = error;
            }

            User login = UserController.login(username, password);

            if (login != null)
            {
                Session["user"] = login.UserId;
                Session["role"] = login.RoleId;
                if (RememberMe.Checked)
                {
                    HttpCookie cookie = new HttpCookie("remember_user", username+"%"+password);
                    cookie.Expires = DateTime.Now.AddHours(2);
                    Response.Cookies.Add(cookie);
                }
                Response.Redirect("HomePage.aspx");
            }
            else
            {
                ErrorMessage.Text = "Wrong username or password";
            }
        }

    }
}