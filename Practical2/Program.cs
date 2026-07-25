using System;

namespace Practical2
{
    interface IPayroll
    {
        double CalculateSalary();
    }

    class Employee
    {
        public int EmpId;
        public string Name;

        public Employee(int id, string name)
        {
            EmpId = id;
            Name = name;
        }

        public void Display()
        {
            Console.WriteLine("Employee ID: " + EmpId);
            Console.WriteLine("Employee Name: " + Name);
        }
    }

    class FullTimeEmployee : Employee, IPayroll
    {
        private double MonthlySalary;

        public FullTimeEmployee(int id, string name, double salary)
            : base(id, name)
        {
            MonthlySalary = salary;
        }

        public double CalculateSalary()
        {
            return MonthlySalary;
        }
    }

    class PartTimeEmployee : Employee, IPayroll
    {
        private int HoursWorked;
        private double HourlyRate;

        public PartTimeEmployee(int id, string name, int hours, double rate)
            : base(id, name)
        {
            HoursWorked = hours;
            HourlyRate = rate;
        }

        public double CalculateSalary()
        {
            return HoursWorked * HourlyRate;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            IPayroll emp1 = new FullTimeEmployee(101, "Shiva", 50000);
            IPayroll emp2 = new PartTimeEmployee(102, "Kumar", 80, 300);

            Employee e1 = (Employee)emp1;
            Employee e2 = (Employee)emp2;

            Console.WriteLine("Full Time Employee");
            e1.Display();
            Console.WriteLine("Salary: " + emp1.CalculateSalary());

            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Part Time Employee");
            e2.Display();
            Console.WriteLine("Salary: " + emp2.CalculateSalary());

            Console.ReadKey();
        }
    }
}