using CentuDY.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentuDY.Factory
{
    public class MedicineFactory
    {
        public static Medicine createMedicine(String name, String description, int stock, int price)
        {
            return new CentuDY.Model.Medicine()
            {
                Name = name,
                Description = description,
                Stock = stock,
                Price = price,
            };
        }
    }
}