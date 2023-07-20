using System;
namespace _20July
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Display();
            Employee employee2 = new Employee(12, "Sam");
            employee2.Display();
            Employee emp3 = new Employee();
            emp3.Register();
            emp3.Display();
            Console.ReadKey();
        }
    }
}
