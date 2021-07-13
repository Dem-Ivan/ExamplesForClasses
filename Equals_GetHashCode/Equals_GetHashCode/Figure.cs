using System;
using System.Collections.Generic;
using System.Text;

namespace Equals_GetHashCode
{
	public class Figure
	{
		public int Langth { get; }
		public int Width { get; }

		public Figure(int langth, int width)
		{
			Langth = langth;
			width = Width;
		}

		public override bool Equals(object obj)
		{
			if (obj == null)
			{
				return false;
			}

			if (!(obj is Figure))
			{
				return false;
			}

			var figure = (Figure)obj;
			return figure.Langth == Langth && figure.Width == Width;
		}

		public override int GetHashCode()
		{
			return (Langth.GetHashCode() + Width.GetHashCode());
		}
	}
}
