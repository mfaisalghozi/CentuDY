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
    public partial class ProfilePage : System.Web.UI.Page
    {
        User u;
        protected void Page_Load(object sender, EventArgs e)
        {   
            if (Request.QueryString["id"] == null)
            {
                Response.Redirect("./HomePage.aspx");
                return;
            }
            else
            {
                int userId = Int32.Parse(Request.QueryString["id"]);
                getUserInfo(userId);
            }

        }

        private void getUserInfo(int id)
        {
            u = UserRepository.getUserById(id);
            UsernameLabel.Text = "Username : " + u.Username;
            PasswordLabel.Text = "Password : " + u.Password;
            NameLabel.Text = "Name : " + u.Name;
            GenderLabel.Text = "Gender : " + u.Gender;
            PhoneNumbLabel.Text = "Phone Number : " + u.PhoneNumber.ToString();
            AddressLabel.Text = "Address : " + u.Address;
        }

        protected void updatePageBtn_Click(object sender, EventArgs e)
        {

        }

        protected void changePassBtn_Click(object sender, EventArgs e)
        {

        }
    }
}