using Course.Entities;
using System;
using System.Collections.Generic;


namespace Course {
    class Program {
        static void Main(string[] args) {

            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccaount bacc = BusinessAccaount(1002, "Maria", 0.00, 500.00);

            Account acc1 = bacc;
            Account acc2 = new BusinessAccaount(1003, "Bob", 0.00, 200.00)


        }
    }
}