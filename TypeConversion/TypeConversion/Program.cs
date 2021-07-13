using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 10;
            double b = c;
            b = 10.01;
            Console.WriteLine("c = " + c + " b = " + b);
            int f = (int)b;
            Console.WriteLine("b = " + b + " f =" + f);

			var myFrenl1 = new Frend() { Name = "Tom", Age = 20 };

			Console.WriteLine("myFrend = ");
			myFrenl1.Display();

			Person person3 = myFrenl1;
			Console.WriteLine("person3.Name = " + person3.Name);

			Colleg myColleg1 = new Colleg() { Name = "Jonn", Age = 24 };
			myColleg1.Display();
			Console.WriteLine("Colleg = " + myColleg1.ComonWorc);

			Frend MyFrend2 = (Frend)person3;
			Console.WriteLine("Frend = " + MyFrend2.Name + " _  " + MyFrend2.Age);


			Console.WriteLine("___№5___ DownCasting");

			object obj = new Frend() { Age = 33, Name = "Anton", ComonIntereses = "PlayStantion" };
			Frend frend = (Frend)obj;

			Person person4 = new Colleg() { Age = 22, Name = "Olga", ComonWorc = "IDC" };
			Colleg colleg = (Colleg)person4;


			Person person5 = new Person() { Age = 53, Name = "Andru" };

			Console.WriteLine("___№6___ Варианты");

			//------------
			//Frend myFrend2 = (Frend)person5; Выкинет ошибку
			//-----------

			Frend myFrend2 = person5 as Frend; // выдась null
											   //----------
			try
			{
				Frend myFrend3 = (Frend)person5;
				myFrend3.Display();
			}
			catch (InvalidCastException e)
			{
				Console.WriteLine(e.Message);
			}
			//------

			if (person5 is Frend)
			{
				Frend myFrend4 = (Frend)person5;

			}
			else
			{
				Console.WriteLine("Перобразование не удалось *(");
			}
		}
    }
}
