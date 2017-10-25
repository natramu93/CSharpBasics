using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic27
{
	class DivNumbers
	{
		int result;

		DivNumbers()
		{
			result = 0;
		}

		public void division(int num1, int num2)
		{
			try
			{
				result = num1 / num2;
			}
			catch (DivideByZeroException e)
			{
				Console.WriteLine("Exception caught: {0}", e);
			}
			finally
			{
				Console.WriteLine("Result: {0}", result);
			}
		}

		static void Main(string[] args)
		{

			//try
			//{
			// statements causing exception
			//}
			//catch (ExceptionName e1)
			//{
			// error handling code
			//}
			//catch (ExceptionName e2)
			//{
			// error handling code
			//}
			//catch (ExceptionName eN)
			//{
			// error handling code
			//}
			//finally
			//{
			// statements to be executed
			//}


			//System.IO.IOException				Handles I/O errors.
			//System.IndexOutOfRangeException		Handles errors generated when a method refers to an array index out of range.
			//System.ArrayTypeMismatchException	Handles errors generated when type is mismatched with the array type.
			//System.NullReferenceException		Handles errors generated from referencing a null object.
			//System.DivideByZeroException		Handles errors generated from dividing a dividend with zero.
			//System.InvalidCastException			Handles errors generated during typecasting.
			//System.OutOfMemoryException			Handles errors generated from insufficient free memory.
			//System.StackOverflowException		Handles errors generated from stack overflow.

			DivNumbers d = new DivNumbers();
			d.division(25, 0);
			Console.ReadKey();

		}

	}

}
