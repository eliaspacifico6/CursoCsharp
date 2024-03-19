using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace Challenge {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine( "Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date: ");
            string birthDate = Console.ReadLine();

            Console.WriteLine("Enter Order Data:");

            int item = 1;

            Console.WriteLine($"Enter #{item} data: ");
            Console.Write("Product Name: ");
            string prdouctName = Console.ReadLine();
            do {
               
                Console.Write("Product price: ");
                double prouctPrice = double.Parse(Console.ReadLine());
                Console.Write("Product quantity: ");
                double prouctQuantity = double.Parse(Console.ReadLine());

                item++;
                Console.WriteLine($"Enter #{item} data or <<Enter>> to sigin. ");
                Console.WriteLine("Product name: ");
                    prdouctName = Console.ReadLine();

                

            } while (string.IsNullOrWhiteSpace(prdouctName));


        }
    }
}
