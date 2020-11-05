using Microsoft.EntityFrameworkCore;
using ProductsApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsApi.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {   
            modelBuilder.Entity<Product>().HasData(
                new Product
                {   Id = 1,
                    Name = "Water",
                    Price = 0.5,
                    ValidFrom = DateTime.Today,
                    ValidTo = DateTime.Today.AddDays(10)

                },
                 new Product
                 {   Id = 2,
                     Name = "Blouse",
                     Price = 50,
                     ValidFrom = DateTime.Today,
                     ValidTo = DateTime.Today.AddDays(10)

                 },
                  new Product
                  {
                      Id = 3,
                      Name = "Jeans",
                      Price = 120,
                      ValidFrom = DateTime.Today,
                      ValidTo = DateTime.Today.AddDays(10)

                  },
                   new Product
                   {
                       Id = 4,
                       Name = "Hat",
                       Price = 20,
                       ValidFrom = DateTime.Today,
                       ValidTo = DateTime.Today.AddDays(10)

                   },
                    new Product
                    {
                        Id = 5,
                        Name = "Laptop",
                        Price = 2310,
                        ValidFrom = DateTime.Today,
                        ValidTo = DateTime.Today.AddDays(10)

                    },
                     new Product
                     {
                         Id = 6,
                         Name = "Mug",
                         Price = 12,
                         ValidFrom = DateTime.Today,
                         ValidTo = DateTime.Today.AddDays(10)

                     },
                      new Product
                      {
                          Id = 7,
                          Name = "Fork",
                          Price = 1.5,
                          ValidFrom = DateTime.Today,
                          ValidTo = DateTime.Today.AddDays(10)

                      },
                       new Product
                       {   Id = 8,
                           Name = "Spoon",
                           Price = 2.5,
                           ValidFrom = DateTime.Today,
                           ValidTo = DateTime.Today.AddDays(10)

                       }
            ); 
           
        }
    }
}
