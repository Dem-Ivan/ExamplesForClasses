using System;

namespace SemplForReflection
{
    public class Employee
    {
        public string Name { get; set; }
        public string Phone { get; set; }

        public Employee(string Name, string Phone)
        {
            this.Name = Name;
            this.Phone = Phone;
        }

        public void PrintEmployeeData()
        {
            Console.WriteLine($"Name - {Name}, Phone - {Phone}");
        }
    }
}
