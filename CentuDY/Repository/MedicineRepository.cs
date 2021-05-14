using CentuDY.Factory;
using CentuDY.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentuDY.Repository
{
    public class MedicineRepository
    {
        private static CentudyDatabaseEntities db = CentuDY.Singleton.SingletonDB.getInstance();
        public static void updateMedicine(int id,string name, string desc, int price, int stock)
        {
            Medicine temp = getMedicineById(id);
            if (temp != null)
            {
                temp.Name = name;
                temp.Description = desc;
                temp.Price = price;
                temp.Stock = stock;
                db.SaveChanges();
            }

        }
        public static Medicine getMedicineById(int id)
        {
            Medicine m = db.Medicines.Where(medicine => medicine.MedicineId == id).FirstOrDefault();
            return m;
        }

        public static List<Medicine> getMedicineListByQuery(string query)
        {
            //List<Medicine> lm = getAllMedicines();
            //List<Medicine> result = new List<Medicine>();
            //foreach (Medicine m in lm)
            //{
            //    String name = m.Name;
            //    if (name.Contains(query))
            //    {

            //    }
            //}
            return db.Medicines.Where(medicine => medicine.Name.Contains(query)).ToList();
        }

        public static List<Medicine> getAllMedicines()
        {
            return db.Medicines.ToList();
        }
        public static Medicine createMedicine(string name, string desc, int price, int stock)
        {
            return MedicineFactory.createMedicine(name,desc, price, stock);
        }
        public static void addMedicine(Medicine p)
        {
            db.Medicines.Add(p);
            db.SaveChanges();
        }

        public static void deleteMedicine(int id)
        {
            Medicine m = getMedicineById(id);
            if (m != null)
            {
                db.Medicines.Remove(m);
                db.SaveChanges();
            }

        }

        public static  List<Medicine> getRandomMedicine()
        {
            List<Medicine> all_ = getAllMedicines();
            List<Medicine> result = new List<Medicine>();
            Random r = new Random((int)DateTime.Now.Ticks);
            int count = 0;
            if(all_.Count() < 6)
            {
                count = all_.Count();
            }
            else
            {
                count = 5;
            }
            //Generate 5 random numbers using it
            List<int> numbers = new List<int>();
            bool f = true;
            //Generate 5 numbers
            while (numbers.Count < count)
            {
                //Generate a random number
                var current = r.Next(0, all_.Count());
                //Check if it exists - if not add it
                if (f)
                {
                    numbers.Add(current);
                    result.Add(all_[current]);
                    f = false;
                }
                if (numbers.Any(x => x != current))
                {
                    numbers.Add(current);
                    result.Add(all_[current]);
                }
            }
            return result;
        }
    }
}