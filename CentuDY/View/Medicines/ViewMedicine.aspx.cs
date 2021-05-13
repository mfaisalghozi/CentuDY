using CentuDY.Controller;
using CentuDY.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CentuDY.View.Medicines
{
    public partial class ViewMedicines : System.Web.UI.Page
    {
        Medicine currentMedicine;
        int roleId;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("../Login.aspx");
            }
            roleId = Int32.Parse(Session["role"].ToString());
            loadTable();
            if (roleId == 2)
            {
                foreach(GridViewRow r in MedicineTable.Rows)
                {
                    var lb1 = r.FindControl("UpdateLink") as LinkButton;
                    lb1.Visible = true;
                    var lb2 = r.FindControl("DeleteLink") as LinkButton;
                    lb2.Visible = true;
                    var lb3 = r.FindControl("CartLink") as LinkButton;
                    lb3.Visible = false;
                }
                insertButton.Visible = true;
            }

        }

        protected void loadTable()
        {
            MedicineTable.DataSource = MedicineController.getAllMedicine();
            MedicineTable.DataBind();
        }

        protected void addToCartMedicine(object sender, EventArgs e)
        {
            int medicineId = Int32.Parse((sender as LinkButton).CommandArgument);
            Response.Redirect("../Carts/AddToCart.aspx?id=" + medicineId);
        }

        protected void updateMedicine(object sender, EventArgs e)
        {
            int medicineId = Int32.Parse((sender as LinkButton).CommandArgument);
            Response.Redirect("./UpdateMedicine.aspx?id=" + medicineId);
        }

        protected void deleteMedicine(object sender, EventArgs e)
        {
            int medicineId = Int32.Parse((sender as LinkButton).CommandArgument);
            MedicineController.deleteMedicine(medicineId);
            loadTable();
        }

        protected void goToInsert(object sender, EventArgs e)
        {
            Response.Redirect("./InsertMedicine.aspx");
        }

        protected void search(object sender, EventArgs e)
        {
            String query = SearchBox.Text;

            MedicineTable.DataSource = MedicineController.getMedicineListByQuery(query);
            MedicineTable.DataBind();
        }

        protected void searchClear(object sender, EventArgs e)
        {
            loadTable();
        }
    }
}