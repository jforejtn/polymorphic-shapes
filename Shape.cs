using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphic_shapes
{
	// A base class for all of our shapes. 
	//
	public abstract class Shape
	{
		public abstract double Area();

		/// <summary>
		/// This is a polymorphic method. Different subtypes of `Shape` will have
		/// different implementations of this method.
		/// </summary>
		/// <returns></returns>
		public abstract string Description();
	}
}
