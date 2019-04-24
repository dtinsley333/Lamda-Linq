using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<Customer> customerOrders = new List<Customer>();
            Customer customer1 = new Customer
              { Name = "Bob",
                OrderCount = 500
              };

            customerOrders.Add(customer1);

            Customer customer2 = new Customer
            {
                Name = "Billy",
                OrderCount = 50
            };
            customerOrders.Add(customer2);

            Customer customer3 = new Customer
            {
                Name = "Brandon",
                OrderCount = 400
            };
            customerOrders.Add(customer3);

            Customer customer4 = new Customer
            {
                Name = "Bruce",
                OrderCount = 50
            };
            customerOrders.Add(customer4);

            Customer customer5 = new Customer
            {
                Name = "Benson",
                OrderCount = 530
            };
            customerOrders.Add(customer5);


            List<Customer> highVolumeCustomers = customerOrders
                .Where(x => x.OrderCount > 100)
                .OrderByDescending(x => x.OrderCount)
                .ThenByDescending(x=>x.Name)
                .ToList();

            var cust = highVolumeCustomers;

            Console.Read();
        }
        public class Customer
        {
            public int OrderCount{ get; set; }
            public string Name { get; set; }

        };
    }
}
