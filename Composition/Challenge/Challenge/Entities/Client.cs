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

        public override string? ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append("Cliente: ");
            sb.Append(Name);
            sb.Append(" (");
            sb.Append(birthDate.ToString("dd/MM/yyyy"));
            sb.Append(") - ");
            sb.Append(email);            
            return sb.ToString();
      

        }
    }
}
