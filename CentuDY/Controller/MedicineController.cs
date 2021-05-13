using CentuDY.Handler;
using CentuDY.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentuDY.Controller
{
    public class MedicineController
    {
        public static Medicine getMedicineById(int id)
        {
            return MedicineHandler.getMedicineById(id);
        }
        public static List<Medicine> getAllMedicine()
        {
            return MedicineHandler.getAllMedicine();
        }
        
        public static string validateInput(string name, string desc, int price, int stock)
        {
            if (name.Length <= 0)
            {
                return "Name must be filled!";
            }
            else if (desc.Length <= 0)
            {
                return "Description cannot be empty!";
            }
            else if (desc.Length < 10)
            {
                return "Description must be longer than 10 characters";
            }
            else if (price <= 0)
            {
                return "Price must be more than 0";
            }
            else if (stock <= 0)
            {
                return "Stock must at least 1!";
            }
            else
            {
                return "";
            }
        }

        public static string insertMedicine(string name, string desc, int price, int stock)
        {
            string message = validateInput(name, desc, price, stock);
            if (message != "")
            {
                return message;
            }
            else
            {
                MedicineHandler.addMedicine(name, desc, price, stock);
                return "";
            }

        }

        public static string updateMedicine(int id,string name, string desc, int price, int stock)
        {
            string message = validateInput(name, desc, price, stock);
            if (!message.Equals(""))
            {
                return message;
            }
            else
            {
                MedicineHandler.updateMedicine(id,name, desc, price, stock);
            }
            return "";

        }

        public static void deleteMedicine(int id)
        {
            MedicineHandler.deleteMedicine(id);

        }

        public static List<Medicine> getMedicineListByQuery(string query)
        {
            if (query.Equals(""))
            {
                return getAllMedicine();
            }
            return MedicineHandler.getMedicineListByQuery(query);
        }

        public static List<Medicine> getRandomMedicine()
        {
            return MedicineHandler.getRandomMedicine();
        }
    }
}