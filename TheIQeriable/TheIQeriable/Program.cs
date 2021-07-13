using System;
using System.Collections.Generic;
using System.Linq;

namespace TheIQeriable
{
	class Program
	{
		static void Main(string[] args)
		{
			string [] teams = { "Бавария", "Боруссия", "Реал Мадрид", "Манчестер Сити", "ПСЖ", "Барселона" };
			
			IEnumerable<string> selectTeams = teams.Where(x => x.StartsWith("Б"));

			IQueryable<string> qeri = teams.Where(x => x.StartsWith("Б"));
		}
	}
}
