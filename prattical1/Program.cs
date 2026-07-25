using System;

namespace prattical1
{
    internal class Student
    {
        private int studentId;
        private string studentName;
        private string course;
        private double fees;

        public Student(int studentId, string studentName, string course, double fees)
        {
            this.studentId = studentId;
            this.studentName = studentName;
            this.course = course;
            this.fees = fees;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("\n========== Student Admission Details ============");
            Console.WriteLine("Student ID   : " + studentId);
            Console.WriteLine("Student Name : " + studentName);
            Console.WriteLine("Course       : " + course);
            Console.WriteLine("Fees         : " + fees);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Student ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Course: ");
            string course = Console.ReadLine();

            Console.Write("Enter Fees: ");
            double fees = double.Parse(Console.ReadLine());

            Student s1 = new Student(id, name, course, fees);

            s1.DisplayDetails();

            Console.WriteLine("\nPress Enter to Exit...");
            Console.ReadLine();
        }
    }
}