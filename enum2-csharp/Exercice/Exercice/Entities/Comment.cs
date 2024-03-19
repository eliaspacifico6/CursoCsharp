using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice.Entities {
    internal class Comment {

        public String text { get; set; }


        public Comment(string text) {
            this.text = text;
        }
    }
}
