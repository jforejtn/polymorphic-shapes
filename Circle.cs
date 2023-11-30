using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphic_shapes
{
	public class Circle(double r) : Shape
	{
		public double R = r;

		public override double Area()
		{
			return Math.PI * R * R;
		}
		
		public static Circle Construct(string[] parameters)
		{
			if (parameters.Length == 1)
			{
				double radius = double.Parse(parameters[0]);
				if (radius > 0)
				{
					return new Circle(radius);
				}
				else
				{
					throw new ArgumentException("You can't create a Circle whose radius is not positive number!");
				}
			}
			throw new FormatException("Can't create Circle, because you've supplied invorrect number of parameters!");
		}
	
		public override string Description()
		{
			return $"Circle with RADIUS = {R}";
		}
	}
}
