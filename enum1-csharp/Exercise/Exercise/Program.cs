using System;
using Exercise.Entities;
using Exercise.Entities.Enuns;

namespace Exercise {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter departament's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string  name = Console.ReadLine();
            Console.Write("Level (Junion/MedLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine());

            Departament dept = new Departament(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.WriteLine("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                Console.WriteLine($"Enter #{i} contrct data:");

                Console.Write("Date (DD/MM/YYYY): ");
                DateTime dateContract = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Velue per hour: ");
                double veluePerHour = double.Parse(Console.ReadLine());

                Console.Write("Duration (hours)");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(dateContract, veluePerHour, hours);

                worker.AddContract(contract);

            }

            Console.Write("Enter Month and year to calculate income (MM/YYY): ");
            string[] monthAndYear = Console.ReadLine().Split("/");
            int month = int.Parse(monthAndYear[0]);
            int year = int.Parse(monthAndYear[1]);

            Console.WriteLine($"Name: {worker.Name}");
            Console.WriteLine($"Departament: {worker.Departament.Name}");
            Console.WriteLine($"Income for {month}/{year}: {worker.Income(year,month)}");


        }
    }
}