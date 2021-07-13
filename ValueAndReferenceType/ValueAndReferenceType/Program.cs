using System;

namespace ValueAndReferenceType
{
    class Program
    {
        static void Main(string[] args)
        { 
            Person p = new Person { Name = "Olga", Age = 23 };
            СhangePerson(p);
            Console.WriteLine(p.Name);
        }

        static void СhangePerson(Person person)
        {
            Console.WriteLine("person.Name= " + person.Name + " person.Age = " + person.Age);
            person.Name = "Alisa";
            person.Age = 10;
         
            //person = new Person() { Name = "Petro", Age = 22 };

            Console.WriteLine("person.Name = " + person.Name + " person.Age = " + person.Age);
        }
    }
}
