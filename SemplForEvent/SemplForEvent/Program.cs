using System;

namespace SemplForEvent
{
	class Program
	{
		static void Main(string[] args)
		{
			Accaunt accaunt1 = new Accaunt(100);
			accaunt1.Notify += ReadMessageSender;
			accaunt1.Notify += MessageSender;

			accaunt1.PutSum(50);
			
			accaunt1.TakeSum(70);

			accaunt1.Notify -= ReadMessageSender;
			accaunt1.PutSum(70);
			accaunt1.TakeSum(70);
		}

		private static void MessageSender(string message)
		{
			Console.WriteLine(message);
		}

		private static void ReadMessageSender(string message)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine(message);
			Console.ResetColor();
		}
	}
}
