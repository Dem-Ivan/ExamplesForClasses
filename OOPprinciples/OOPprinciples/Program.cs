using System;

namespace OOPprinciples
{
	class Program
	{
		static void Main(string[] args)
		{
			Person person = new Person();
			person.Name = "Alex";
			person.Phone = "77933509";

			person.DisplayData();

			Employee employee = new Employee();
			employee.Name = "Olga";
			employee.Phone = "77712345";
			employee.Salari = 500;
			employee.DisplayData();

			Client client = new Client();
			client.Name = "Tom";
			client.Phone = "77613434";
			client.Count = 1000;
			client.DisplayData();

			Person[] people = new Person[] { person, employee, client };

			foreach (var item in people)
			{
				item.DisplayData();
			}
		}
	}
}
