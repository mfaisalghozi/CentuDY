using CentuDY.Model;
using CentuDY.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentuDY.Handler
{
    public class CartHandler
    {


        public static void updateCartMedicineQty(int id, int userid, int qty)
        {
            CartRepository.updateCartMedicineQty(id, userid, qty);
        }
        public static Cart getCartMedicine(int medicineid, int userId)
        {
            return CartRepository.getCartMedicineByUserId(medicineid, userId);
        }

        public static void deleteCartMedicine(int id, int userid)
        {
            CartRepository.deleteCartMedicine(id, userid);
        }

        public static void createCartMedicine(int userId, int medicineId, int qty)
        {
            Cart cartmedicine = CartRepository.createCartMedicine(userId, medicineId, qty);
            CartRepository.addCartMedicine(cartmedicine);
        }

        public static List<Cart> getAllCartByUserId(int userId)
        {
            return CartRepository.getAllCartByUserId(userId);
        }

        public static Cart getCartMedicineByUser(int userId)
        {
            return CartRepository.getCartMedicineByUser(userId);
        }

        public static void checkout(int userId)
        {
            List<Cart> cm = CartRepository.getAllCartMedicines(userId);
            DateTime now = DateTime.Now;

            HeaderTransaction transactionHeader = TransactionRepository.CreateHeaderTransaction(userId, now);
            int headerId = TransactionRepository.AddTransactionHeader(transactionHeader).TransactionId;
            for (int i = 0; i < cm.Count(); i++)
            {

                DetailTransaction transactionDetail = TransactionRepository.CreateDetailTransaction(headerId, cm[i].MedicineId, cm[i].Quantity);
                TransactionRepository.AddTransactionDetail(transactionDetail);
            }
            CartRepository.deleteCartMedicineByUser(cm);
        }

        //public static void updateMedicine(int medicineid, int userid, int qty)
        //{
        //    CartRepository.updateCartMedicineQty(medicineid, userid, qty);
        //}
    }
}