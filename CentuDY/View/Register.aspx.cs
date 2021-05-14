using CentuDY.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CentuDY.View
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void registration(object sender, EventArgs e)
        {
            string username = UsernameBox.Text;
            string password = PasswordBox.Text;
            string confirmPassword = ConfirmPasswordBox.Text;
            string name = NameBox.Text;
            string gender = GenderButtons.Text;
            string phone = PhoneBox.Text;
            string address = AddressBox.Text;

            string error = UserController.register(username, password, confirmPassword, name, gender, phone, address);

            if (error == "")
            {
                Response.Redirect("./Login.aspx");
            }
            else
            {
                ErrorMessage.Text = error;
            }

        }
    }
}