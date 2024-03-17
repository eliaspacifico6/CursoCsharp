using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Exercise.Entities.Enuns;

namespace Exercise.Entities {
    internal class Worker {

        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Departament Departament { get; set; }
        public List<HourContract> contracts { get; set; } = new List<HourContract>();


        public Worker() {
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Departament departament) {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament ?? throw new ArgumentNullException(nameof(departament));
        }

        public void AddContract(HourContract contract) {
            contracts.Add(contract);
        }
        public void RemoveContract(HourContract contract) {
            contracts.Remove(contract);
        }

        public double Income(int year, int month) {
            double sum = BaseSalary;
            foreach (HourContract contract in contracts) {
                if (contract.Date.Year == year && contract.Date.Month == month) {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }

    }
}
