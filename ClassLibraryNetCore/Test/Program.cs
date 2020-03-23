using ClassLibraryNetCore.Directory;
using ClassLibraryNetCore.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer()
            {
                Name = "Andrei",
                City = "Cluj",
                Orders = new List<Order>()
                {
                    new Order()
                    {
                        TotalValue = 12345
                    }
                }

            };

            ModelContext modelContext = new ModelContext();
            modelContext.Customers.Add(customer);
            modelContext.SaveChanges();
            foreach (var index in modelContext.Customers.Include(c => c.Orders))
            {
                Console.WriteLine(index.Name + " " + index.Orders.Count());
            }

        }
    }
}