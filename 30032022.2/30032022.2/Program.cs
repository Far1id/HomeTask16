using System;
using ClassLibrary;

namespace _30032022._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.Name = "Ferid";
            student1.Surname = "Cahangirli";
            student1.GroupNo = "BP202";
            Console.WriteLine(student1.Introduce());

            Employee employee1 = new Employee();
            employee1.Name = "Ferid";
            employee1.Surname = "Cahangirli";
            employee1.Position = "Senior Developer";
            Console.WriteLine(employee1.Introduce());

        }
    }
} 
