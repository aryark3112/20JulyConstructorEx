using System;
namespace _20July
{
    public class Employee
    {
        int id;
        string name;
        public Employee()
        { 
        
            Console.WriteLine("Parameterized Constructor Call");
            id = -1;
            name = "not given";
        }
        public Employee(int id,string name)
        {
            Console.WriteLine("Parameterized Constructor");
            this.id = id;
            this.name = name;
        }
        public void Register()
        {
            Console.WriteLine("Enter Id");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
        }
        public void Display()
        {
            Console.WriteLine("ID: \t"+id);
            Console.WriteLine("Name:\t"+name);
        }
    }

}
