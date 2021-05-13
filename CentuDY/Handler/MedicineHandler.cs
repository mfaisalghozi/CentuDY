using CentuDY.Model;
using CentuDY.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentuDY.Handler
{
    public class MedicineHandler
    {
        public static Medicine getMedicineById(int id)
        {
            return MedicineRepository.getMedicineById(id);
        }
        public static List<Medicine> getAllMedicine()
        {
            return MedicineRepository.getAllMedicines();
        }
        public static void addMedicine(string name, string desc, int price, int stock)
        {
            Medicine m = MedicineRepository.createMedicine(name,desc, price, stock);
            MedicineRepository.addMedicine(m);
        }

        public static void updateMedicine(int id,string name, string desc, int price, int stock)
        {
            MedicineRepository.updateMedicine(id,name, desc, price, stock);
        }
        public static void deleteMedicine(int id)
        {
            MedicineRepository.deleteMedicine(id);
        }

        public static List<Medicine> getMedicineListByQuery(string query)
        {
            return MedicineRepository.getMedicineListByQuery(query);
        }

        public static List<Medicine> getRandomMedicine()
        {
            return MedicineRepository.getRandomMedicine();
        }
    }
}