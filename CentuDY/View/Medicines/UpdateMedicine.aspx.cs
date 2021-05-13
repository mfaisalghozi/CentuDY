using CentuDY.Controller;
using CentuDY.Model;
using CentuDY.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CentuDY.View.Medicines
{
    public partial class UpdateMedicine : System.Web.UI.Page
    {
        Medicine m;
        int roleId;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] == null)
            {
                Response.Redirect("./ViewMedicine.aspx");
                return;
            }
            if (!IsPostBack)
            {
                int medicineId = Int32.Parse(Request.QueryString["id"]);
                attachProperties(medicineId);
            }
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

        private void attachProperties(int medicineId)
        {
            m = MedicineRepository.getMedicineById(medicineId);
            NameBox.Text = m.Name;
            DescriptionBox.Text = m.Description;
            PriceBox.Text = m.Price.ToString();
            StockBox.Text = m.Stock.ToString();

        }

        protected void updateMedicine(object sender, EventArgs e)
        {
            int medicineId = Int32.Parse(Request.QueryString["id"]);
            string name = NameBox.Text;
            string description = DescriptionBox.Text;
            int price = 0;
            int stock = 0;
            try
            {
                price = Int32.Parse(PriceBox.Text);
            }
            catch (Exception e1)
            {
            }
            try
            {
                stock = Int32.Parse(StockBox.Text);
            }
            catch (Exception e2)
            {

            }

            string error = MedicineController.updateMedicine(medicineId, name, description, price, stock);

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