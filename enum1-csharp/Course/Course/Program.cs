using System;
using Course.Entities;
using Course.Entities.Enums;


namespace Course {
    class Program {
        static void Main(string[] args) {

            Order order = new Order() {
                Id = 1,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment

            };

            Console.WriteLine(order);

            Console.WriteLine("=================");

            string txt = OrderStatus.PendingPayment.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");


            Console.WriteLine( os);
            Console.WriteLine(txt);

        }
    }
}