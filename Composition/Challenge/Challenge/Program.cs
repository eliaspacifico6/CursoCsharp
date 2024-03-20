using Challenge.Entities;
using Challenge.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Transactions;
using System.Xml;


namespace Challenge {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Enter cliente data:");
            Console.Write("Name:  Elias Pacifico");
            Console.WriteLine("");
            string name = "Elias Pacifico"; // Console.ReadLine();
            Console.Write("Email:  eliaspacifico6@gmial.com");
            Console.WriteLine("");
            string email = "eliaspacifico6@gmial.com"; // Console.ReadLine();
            Console.Write("Birth date: 30/07/1995");
            Console.WriteLine("");
            DateTime birthDate = DateTime.Parse("30/07/1995"); //(Console.ReadLine());

            Client client = new Client(name, email, birthDate);
            //Console.WriteLine(client.ToString);
            Order order = new Order(client);
            // Console.WriteLine(order);
            
            Console.WriteLine("Enter Order Data:");
            int item = 1;
            string str;
            Console.WriteLine($"Enter #{item} data: ");
            Console.Write("Product Name: ");
            string productName = Console.ReadLine();
            do {

                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine());
                Console.Write("Product quantity: ");
                int productQuatity = int.Parse(Console.ReadLine());
                Product product = new Product(productName, productPrice);

                //Console.WriteLine(product.ToString());
                OrderItem orderitem = new OrderItem(product, productQuatity);
                //Console.WriteLine(orderitem.ToString());
                order.AddItem(orderitem);



                item++;
                productName = null;
                Console.WriteLine($"Enter #{item} data or <<Enter>> to sigin. ");
                Console.Write("Product Name: ");
                productName = Console.ReadLine();                          
            
            } while (!string.IsNullOrWhiteSpace(productName));



          
            Console.WriteLine(order.ToString());


        }
    }
}
