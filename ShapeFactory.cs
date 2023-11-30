using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphic_shapes
{
	public static class ShapeFactory
	{
		public static Shape? ConstructFromString(string shapeString)
		{
			string[] tokens = shapeString.Split(' ');
			if (tokens.Length > 0)
			{
				try
				{
					if (tokens[0] == "square")
					{
						return Square.Construct(tokens.Skip(1).ToArray());
					}
					if (tokens[0] == "circle")
					{
						return Circle.Construct(tokens.Skip(1).ToArray());
					}
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}
			}
			return null;
		}
	}
}
