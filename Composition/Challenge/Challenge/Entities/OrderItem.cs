using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge.Entities {
    internal class OrderItem {

        public Product Product { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public OrderItem() {
        }

        public OrderItem(Product product, int quantity) {
            Product = product;
            Quantity = quantity;
            SetPrice();


        }

        public void SetPrice(double? price = null) {
            
            Price = price ?? Product.Price;
        }


        public double SubTotal() {
            return Quantity * Price;
        }

        public override string? ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append(Product.Name);
            sb.Append(", R$");
            sb.Append(Price);
            sb.Append(", Quantity: ");
            sb.Append(Quantity);
            sb.Append(", SubTotal: R$");
            sb.Append(SubTotal().ToString("F2"));      

            return sb.ToString();
        }
    }
}
