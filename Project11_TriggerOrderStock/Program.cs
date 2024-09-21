using Project11_TriggerOrderStock.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project11_TriggerOrderStock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TriggerOrderStockDBEntities triggerOrderStockDBEntities = new TriggerOrderStockDBEntities();

            string number;
            Console.WriteLine("Stock Order System");
            Console.WriteLine();
            Console.WriteLine("1- Product Lists");
            Console.WriteLine("2- Order Lists");
            Console.WriteLine("3- Account State");
            Console.WriteLine("4- New Product Sales");
            Console.WriteLine("5- Process Counts (Trigger)");
            Console.WriteLine("6- Product Stock Updating");
            Console.WriteLine();
            Console.WriteLine("----------------------------");
            Console.WriteLine();

            Console.WriteLine("Please enter the action you want: ");
            number = Console.ReadLine(); // Giriş burada alınıyor

            if (number == "1")
            {
                var values = triggerOrderStockDBEntities.Products.ToList();

                foreach (var item in values)
                {
                    Console.WriteLine("Product Name: " + item.ProductName + " Product Price: " + item.ProductPrice + " Product Stock: " + item.ProductStock);
                }
            }

            if (number == "2")
            {
                Console.WriteLine("Order Lists");
                var values = triggerOrderStockDBEntities.Orders.ToList();

                foreach (var item in values)
                {
                    Console.WriteLine("Order Id: " + item.OrderId + " Customer: " + item.Customer + " Product Id: " + item.ProductId + " Quantity: " + item.Quantity + " Unit Price: " + item.UnitPrice + " Total Price: " + item.TotalPrice);
                }
            }

            if (number == "3")
            {
                Console.WriteLine("Account State");
                var values = triggerOrderStockDBEntities.CashRegisters.Select(x => x.Balance).FirstOrDefault();

                Console.WriteLine("Balance: " + values);
                
            }

            if (number == "4")
            {
                Console.WriteLine("New Product Sales");

                Console.WriteLine("Please enter the cutomer name: ");
                string customer = Console.ReadLine();

                Console.WriteLine("Please enter the product id: ");
                int productId = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the quantity: ");
                int quantity = Convert.ToInt32(Console.ReadLine());

                var productUnitPrice = triggerOrderStockDBEntities.Products.Where(x => x.ProductId == productId).Select(x => x.ProductPrice).FirstOrDefault();

                Console.WriteLine("Unit Price: " + productUnitPrice);

                decimal totalPrice = Convert.ToDecimal(quantity * productUnitPrice);

                Console.WriteLine("Total Price: " + totalPrice);

                Order order = new Order();
                order.Customer = customer;
                order.ProductId = productId;
                order.Quantity = quantity;
                order.UnitPrice = productUnitPrice;
                order.TotalPrice = totalPrice;

                triggerOrderStockDBEntities.Orders.Add(order);
                triggerOrderStockDBEntities.SaveChanges();

            }

            if (number == "5")
            {
                Console.WriteLine("Process Counts (Trigger)");

                var values = triggerOrderStockDBEntities.Processes
                    .Select(x=>x.Process1)
                    .FirstOrDefault();
                Console.WriteLine("Trigger Process Count: " + values);


            }
            Console.ReadLine();

            

        }

    }
}
