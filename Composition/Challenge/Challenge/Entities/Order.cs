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
            double total = 0;
            int i = 0;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("----------------");
            sb.AppendLine("ORDER SUMMARY:");
            sb.Append("  Order Moment: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy hh:mm:ss"));
            sb.Append("  Status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("  ");
            sb.AppendLine(Client.ToString());
       
            sb.AppendLine("ORDER ITENS:");

            foreach (OrderItem item in orderItens) {
                i++;
                sb.Append($"  #{i} ");
                sb.AppendLine(item.ToString());
                total += item.SubTotal();
            }
            sb.AppendLine("----------------");
            sb.Append("  Total Price: R$");
            sb.Append(total.ToString("F2") );

            return sb.ToString();
        }
    }
}
