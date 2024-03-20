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

        public Order() {
        }

        public Order( Client client) {
            Moment = DateTime.Now;
            Status  = OrderStatus.PendingPayment;
            Client = client;
        }

        public void AddItem(OrderItem item) {
            orderItens.Add(item);
           
        }
        public void RemoveItem(OrderItem orderItem) {
            orderItens.Remove(orderItem);
        }

        public double Total() {
            double total = 0;
            foreach (OrderItem item in orderItens) {
                total += item.SubTotal();
            }
            return total;
        }

        public override string? ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY:");
            sb.Append("Order Moment: ");
            sb.Append(Moment.ToString("dd/MM/yyyy hh:mm:ss"));
            sb.AppendLine("Status: ");
            sb.Append(Status.ToString());
            sb.AppendLine(Client.ToString());
            sb.AppendLine("ORDER ITENS:");

            return sb.ToString();
        }
    }
}
