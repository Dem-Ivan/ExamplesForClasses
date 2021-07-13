using System;
using System.Collections.Generic;
using System.Text;

namespace TheIComparable
{
	public class Rectangl : IComparable
	{
		public string Name { get; set; }
		public int Height { get; set; }
		public int Width { get; set; }

		public int CompareTo(object obj)
		{
			Rectangl r = obj as Rectangl;
			if (r != null)
			{
				return this.GetSquare().CompareTo(r.GetSquare());
			}
			else
				throw new Exception("Сравнение не возможно");
		}

		public int GetSquare()
		{
			return (Height * Width);
		}
	}
}
