using Challenge.Entities;
using Challenge.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;


namespace Challenge {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date: ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthDate);
          //  Console.WriteLine(client);
            Order order = new Order(client);
          // Console.WriteLine(order);
          Console.WriteLine("Enter Order Data:");

            int item = 1;

            Console.WriteLine($"Enter #{item} data: ");
            Console.Write("Product Name: ");
            string prdouctName = Console.ReadLine();
            Console.Write("Product price: ");
            double prdouctPrice = double.Parse(Console.ReadLine());
            Console.Write("Product quantity: ");           
            int prdouctQuantity = int.Parse(Console.ReadLine());
            
            Product product = new Product(prdouctName, prdouctPrice);
            //Console.WriteLine(product);
            OrderItem orderitem = new OrderItem(product, prdouctQuantity);
            Console.WriteLine(orderitem);
            order.AddItem(orderitem);

            //    item++;
            //    Console.WriteLine($"Enter #{item} data or <<Enter>> to sigin. ");
            //    Console.Write("Product name: ");
            //    prdouctName = Console.ReadLine();



            //} while (!string.IsNullOrWhiteSpace(prdouctName));


        }
    }
}
