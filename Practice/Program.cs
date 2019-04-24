using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {

           List<Customer> highVolumeCustomers = GetHighVolumeCustomers();

            //load the list with customer class instances
            List<Customer> customers = highVolumeCustomers
                .Where(x => x.OrderCount > 100)
                .OrderByDescending(x => x.OrderCount)
                .ThenByDescending(x => x.Name)
                .ToList();

            //display the query results. 
            Console.WriteLine(" Customers with more than 100 Orders");
            foreach (Customer customer in customers)
            {
                Console.WriteLine("Name: " + customer.Name + " Order Count: " + customer.OrderCount);
            };

            List<Customer> GetHighVolumeCustomers()
            {
                //create a object to store customer names and order count
                List<Customer> customerOrders = new List<Customer>();

                //Create and populate orders
                Customer customer1 = new Customer
                {
                    Name = "Bob",
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

                return customerOrders;
            }

           

            Console.Read();
        }
        public class Customer
        {
            public int OrderCount { get; set; }
            public string Name { get; set; }

        }
   



   
    }
}
