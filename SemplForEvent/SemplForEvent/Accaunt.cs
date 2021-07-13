using System;
using System.Collections.Generic;
using System.Text;

namespace SemplForEvent
{
	public class Accaunt
	{
		public delegate void AccauntHandler(string message);
		public event AccauntHandler Notify;

		public int _sum { get; private set; }

		public Accaunt(int sum)
		{
			_sum = sum;
		}

		public void PutSum(int sum)
		{
			_sum = _sum + sum;

			if (Notify != null)
				Notify($"Счет пополнен на {sum} руб.");
		}

		public void TakeSum(int sum)
		{
			if (_sum >= sum)
			{
				_sum = _sum - sum;
				Notify?.Invoke($"Со счета снято {sum} руб.");
			}
		}

	}
}
