using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge.Entities {
    internal class Client {
        public string Name { get; set; }
        public string email { get; set; }
        public DateTime birthDate { get; set; }

        public Client() {
        }
        public Client(string name, string email, DateTime birthDate) {
            Name = name;
            this.email = email;
            this.birthDate = birthDate;
        }
    }
}
