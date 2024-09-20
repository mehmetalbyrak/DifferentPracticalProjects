using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project11_TriggerOrderStock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number;
            Console.WriteLine("Stock Order System");
            Console.WriteLine();
            Console.WriteLine("1- Product Lists");
            Console.WriteLine("2- Order Lists");
            Console.WriteLine("3- Account State");
            Console.WriteLine("4- New Product Sales");
            Console.WriteLine("5- Product Stock Updating");
            Console.WriteLine();
            Console.WriteLine("----------------------------");
            Console.WriteLine();

            Console.WriteLine("Please enter the action you want :d ");
            Console.ReadLine();

            number = Console.ReadLine();

            if (number != null)
            {
                Console.WriteLine(number);
            }
        }
    }
}
