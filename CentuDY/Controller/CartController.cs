using CentuDY.Handler;
using CentuDY.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentuDY.Controller
{
    public class CartController
    {
        public static String doAddCart(int qty, int medicineId, int userId)
        {
            Cart cp = CartHandler.getCartMedicine(medicineId, userId);
            int medicineStock = MedicineHandler.getMedicineById(medicineId).Stock;

            if (qty < 1)
            {
                return "Qty must be more than 0";
            }

            if (cp == null)
            {
                if (qty > medicineStock)
                {
                    return "Qty can't be more than available stock";
                }
                CartHandler.createCartMedicine(userId, medicineId, qty);
                return "";
            }
            else
            {

                int currCartStock = cp.Quantity;
                int requetedStock = currCartStock + qty;


                if (requetedStock > medicineStock)
                {
                    return "Qty must be less than or equals to medicine stocks";
                }
                CartHandler.updateCartMedicineQty(medicineId, userId, requetedStock);
                return "";
            }
        }

        public static List<Cart> getAllCartByUserId(int userId)
        {
            return CartHandler.getAllCartByUserId(userId);
        }

        public static void doDeleteCart(int id, int userID)
        {
            CartHandler.deleteCartMedicine(id, userID);
        }

        //public static String doUpdateCart(int qty, int medicineId, int userId)
        //{
        //    int medicineStock = MedicineHandler.getMedicineById(medicineId).Stock;

        //    if (qty == 0)
        //    {
        //        CartHandler.deleteCartMedicine(medicineId, userId);
        //        return "";
        //    }
        //    else if (qty < 1)
        //    {
        //        return "Quantity must be more than 0";
        //    }
        //    else if (qty > medicineStock)
        //    {
        //        return "Quantity can't be more than available stock";
        //    }
        //    CartHandler.updateCartMedicineQty(medicineId, userId, qty);
        //    return "";
        //}

        public static String checkout(int userID)
        {
            Cart cp = CartHandler.getCartMedicineByUser(userID);
            if (cp == null)
            {
                return "Cart can't be empty";
            }
            CartHandler.checkout(userID);
            return "Checkout Success";
        }





        //public static Cart getCartMedicineByUserId(int medicineid, int userId)
        //{
        //    return CartHandler.getCartMedicine(medicineid, userId);
        //}
    }
}