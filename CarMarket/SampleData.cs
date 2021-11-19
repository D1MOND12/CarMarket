using CarMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarMarket
{
    public static class SampleData
    {
        public static void Initialize(ApplicationContext context)
        {
            if (!context.Cars.Any())
            {
                context.Cars.AddRange(
                    new Cars
                    {
                        Name = "BMW M4 CS",
                        Marks = "BMW",
                        Price = 6300020
                    },
                    new Cars
                    {
                        Name = "Mercedes-Benz AMG GT 63 S 4MATIC+",
                        Marks = "Mercedes-Benz",
                        Price = 15920200
                    },
                    new Cars
                    {
                        Name = "Toyota Crown 2021",
                        Marks = "Toyota",
                        Price = 3670230
                    }
                );
                context.SaveChanges();
            }
        }
    }
}