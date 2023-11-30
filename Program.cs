namespace polymorphic_shapes
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<Shape> shapes = new List<Shape>();

			var help = @"
+=====================================================================+
| Welcome to shape creator! Start off by creating a couple of shapes. |
| To do this, use one of following commands:                          |
|                                                                     |
|   square EDGE                                                       |
|   circle RADIUS                                                     |
|                                                                     |
| When you're finished, type 'done'.                                  |
+=====================================================================+
";

			Console.WriteLine(help);
			bool stillAddingShapes = true;
			while (stillAddingShapes)
			{
				var input = Console.ReadLine()!;
				if (input == "done")
				{
					stillAddingShapes = false;
				}
				else
				{
					var shape = ShapeFactory.ConstructFromString(input);
					if (shape != null)
					{
						Console.WriteLine($"Good! You've added: {shape.Description()}\n");
						shapes.Add(shape);
					}
				}
			}

			foreach (var shape in shapes)
			{
				string area = shape.Area().ToString("F2");
				Console.WriteLine($"{shape.Description()}. It's area is {area}");
			}
		}
	}
}
