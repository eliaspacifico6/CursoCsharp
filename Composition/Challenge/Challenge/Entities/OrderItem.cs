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
        public Double Price { get;  }

        public OrderItem() {
        }



        public OrderItem( Product product, int quantity, double? price = null) {
            Product = product;
            Quantity = quantity;
            SetPrice(price);
        }

        public void SetPrice(double? price = null) {
            Price = price ?? Price = Product.Price;
        }

        public Double SubTotal() {
            return Quantity * Price;
        } 

      
    }
}
