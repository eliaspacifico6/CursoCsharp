using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge.Entities.Enums;

namespace Challenge.Entities {
    internal class Order {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public Client Client { get; set; }
        public List<OrderItem> orderItens { get; set; } = new List<OrderItem>();

       

        public Order() { }


        public AddItem(OrderItem orderItem) {
            orderItens.Add(orderItem);
        }
        public RemoveItem(OrderItem orderItem) {
            orderItens.Remove(orderItem);
        }

        public double Total() {
            double total = 0;
            foreach (OrderItem item in orderItens) {
                total += item.SubTotal;
            }
            return total;
        }

    }
}
