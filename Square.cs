using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphic_shapes
{
	public class Square(double edge) : Shape
	{
		public double Edge = edge;

		public override double Area()
		{
			return Edge * Edge;
		}

		public static Square Construct(string[] parameters)
		{
			if (parameters.Length == 1)
			{
				double edge = double.Parse(parameters[0]);
				if (edge > 0)
				{
					return new Square(edge);
				}
				else
				{
					throw new ArgumentException("You can't create a Square whose edge is not positive number!");
				}
			}
			throw new FormatException("Can't create Square, because you've supplied invorrect number of parameters!");
		}

		public override string Description()
		{
			return $"Square with EDGE = {Edge}";
		}
	}
}
