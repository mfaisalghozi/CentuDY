using CentuDY.Factory;
using CentuDY.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentuDY.Repository
{
    public class CartRepository
    {
        private static CentudyDatabaseEntities db = CentuDY.Singleton.SingletonDB.getInstance();
        public static List<Cart> getAllCartMedicines(int userId)
        {
            List<Cart> cp = db.Carts.Where(x => x.UserId == userId).ToList();
            return cp;
        }
        public static void updateCartMedicineQty(int medicineId, int userId, int qty)
        {
            Cart p = getCartMedicineByUserId(medicineId, userId);
            p.Quantity = qty;
            db.SaveChanges();
        }
        public static Cart createCartMedicine(int userId, int medicineId, int qty)
        {
            return CartFactory.CreateCart(userId, medicineId, qty);
        }

        public static void addCartMedicine(Cart cart)
        {
            db.Carts.Add(cart);
            db.SaveChanges();
        }

        public static Cart getCartMedicineByUserId(int medicineId, int userid)
        {
            return db.Carts.Where(cart => (cart.MedicineId == medicineId && cart.UserId == userid)).FirstOrDefault();
        }

        public static List<Cart> getAllCartByUserId(int userId)
        {
            return db.Carts.Where(cart => (cart.UserId == userId)).ToList();
        }

        //public static Cart getCartMedicineById(int id)
        //{
        //    return db.Carts.Where(cart => cart.MedicineId == id).FirstOrDefault();
        //}

        public static void deleteCartMedicineByUser(List<Cart> cp)
        {
            for (int i = 0; i < cp.Count(); i++)
            {
                db.Carts.Remove(cp[i]);
            }
            db.SaveChanges();
        }

        public static Cart getCartMedicineByUser(int userid)
        {
            return db.Carts.Where(cart => (cart.UserId == userid)).FirstOrDefault();
        }


        public static void deleteCartMedicine(int id, int userid)
        {
            Cart c = getCartMedicineByUserId(id, userid);
            db.Carts.Remove(c);
            db.SaveChanges();
        }
    }
}