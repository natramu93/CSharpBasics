using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Internal

namespace Basic10
{
	class Rectangle
	{
		//member variables
		internal double length;
		internal double width;

		double GetArea()
		{
			return length * width;
		}

		public void Display()
		{
			Console.WriteLine("Length: {0}", length);
			Console.WriteLine("Width: {0}", width);
			Console.WriteLine("Area: {0}", GetArea());
		}
	}//end class Rectangle

	class ExecuteRectangle
	{
		static void Main(string[] args)
		{
			Rectangle r = new Rectangle();
			r.length = 4.5;
			r.width = 3.5;
			r.Display();
			Console.ReadLine();
		}
	}
}
