﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge.Entities {
    internal class Product {

        public string Name { get; set; }
        public double Price { get; set; }

        public Product() {
        }
        public Product( string name, double price) {
            Name = name;
            Price = price;
        }
        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name);
            sb.Append(" R$:");
            sb.Append(Price);
            return sb.ToString();
        }
    }
}
