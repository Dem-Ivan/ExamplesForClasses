using System;

namespace SemplForGenericType
{
	class Program
	{
		static void Main(string[] args)
		{
			var user = new User<int>();
			user.UserId = 12;
			user.Shift<string>("abc", "cba");

			var user2 = new User<bool>();
			user2.UserId = true;
			user2.Shift<int>(11, 22);

		}
	}
}
