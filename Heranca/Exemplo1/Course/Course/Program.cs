using Course.Entities;
using System;
using System.Collections.Generic;


namespace Course {
    class Program {
        static void Main(string[] args) {


            Account acc1 = new Account(1001, "Alex", 500.00);
            Account acc2 = new BusinessAccaount(1003, "Bob", 500.00, 200.00);
            Account acc3 = new SavingsAccount(1004, "Anna", 500.00, 0.01);


            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);
            acc3.Withdraw(10.0);


            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
            Console.WriteLine(acc3.Balance);
        }
    }
}