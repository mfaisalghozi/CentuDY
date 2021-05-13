using CentuDY.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentuDY.Factory
{
    public class CartFactory
    {
        public static Cart CreateCart(int userId, int medicineId, int qty)
        {
            return new CentuDY.Model.Cart()
            {
                UserId = userId,
                MedicineId = medicineId,
                Quantity = qty
            };
        }
    }
}