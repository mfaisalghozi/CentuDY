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
    public partial class UpdateProfile : System.Web.UI.Page
    {
        User user;
        int userId;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("../Login.aspx");
            }
            if (Request.QueryString["id"] == null)
            {
                Response.Redirect("./ProfilePage.aspx");
                return;
            }
            if (!IsPostBack)
            {
                userId = Int32.Parse(Request.QueryString["id"]);
                getUserProfile(userId);
            }
        }

        private void getUserProfile(int id)
        {
            user = UserRepository.getUserById(id);
            NameBox.Text = user.Name;
            UsernameBox.Text = user.Username;
            PhoneBox.Text = user.PhoneNumber.ToString();
            AddressBox.Text = user.Address;

            string userGender = user.Gender;
            if(userGender.Equals("Male"))
            {
                male.Selected = true;
                female.Selected = false;
            } 
            else
            {
                female.Selected = true;
                male.Selected = false;
            }
        }

        protected void UpdateProfileBtn_Click(object sender, EventArgs e)
        {
            int userId = Int32.Parse(Request.QueryString["id"]);
            string name = NameBox.Text;
            string username = UsernameBox.Text;
            string gender = GenderButtons.Text;
            string phone = PhoneBox.Text;
            string address = AddressBox.Text;
           
            string message = UserController.updateProfile(userId,username, name, gender, phone, address);
            SuccessMessage.Text = message;
        }

        protected void BackToHomeBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("../HomePage.aspx");
        }
    }
}