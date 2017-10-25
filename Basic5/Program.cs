using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic5
{
	class Program
	{
		static void Main(string[] args)
		{
			//if (boolean_expression)
			//{
			//	/* statement(s) will execute if the boolean expression is true */
			//}
			/* local variable definition */
			int a = 10;

			/* check the boolean condition using if statement */
			if (a < 20)
			{
				/* if condition is true then print the following */
				Console.WriteLine("a is less than 20");
			}
			Console.WriteLine("value of a is : {0}", a);
			Console.ReadLine();

			//if (boolean_expression)
			//{
			//	/* statement(s) will execute if the boolean expression is true */
			//}
			//else
			//{
			//	/* statement(s) will execute if the boolean expression is false */
			//}

			/* local variable definition */
			a = 100;

			/* check the boolean condition */
			if (a < 20)
			{
				/* if condition is true then print the following */
				Console.WriteLine("a is less than 20");
			}
			else
			{
				/* if condition is false then print the following */
				Console.WriteLine("a is not less than 20");
			}
			Console.WriteLine("value of a is : {0}", a);
			Console.ReadLine();

			//if (boolean_expression 1) {
			//	/* Executes when the boolean expression 1 is true */
			//} else if (boolean_expression 2) {
			//	/* Executes when the boolean expression 2 is true */
			//} else if (boolean_expression 3) {
			//	/* Executes when the boolean expression 3 is true */
			//} else {
			//	/* executes when the none of the above condition is true */
			//}

			if (a == 10)
			{
				/* if condition is true then print the following */
				Console.WriteLine("Value of a is 10");
			}
			else if (a == 20)
			{
				/* if else if condition is true */
				Console.WriteLine("Value of a is 20");
			}
			else if (a == 30)
			{
				/* if else if condition is true  */
				Console.WriteLine("Value of a is 30");
			}
			else
			{
				/* if none of the conditions is true */
				Console.WriteLine("None of the values is matching");
			}
			Console.WriteLine("Exact value of a is: {0}", a);
			Console.ReadLine();

			//if (boolean_expression 1) {
			//	/* Executes when the boolean expression 1 is true */
			//	if (boolean_expression 2) {
			//		/* Executes when the boolean expression 2 is true */
			//	}
			//}

			a = 100;
			int b = 200;

			/* check the boolean condition */
			if (a == 100)
			{

				/* if condition is true then check the following */
				if (b == 200)
				{
					/* if condition is true then print the following */
					Console.WriteLine("Value of a is 100 and b is 200");
				}
			}
			Console.WriteLine("Exact value of a is : {0}", a);
			Console.WriteLine("Exact value of b is : {0}", b);
			Console.ReadLine();

			//switch (expression)
			//{
			//	case constant - expression:
			//		statement(s);
			//		break; /* optional */
			//	case constant - expression:
			//		statement(s);
			//		break; /* optional */
			//
			//	/* you can have any number of case statements */
			//	default: /* Optional */
			//		statement(s);
			//}

			char grade = 'B';

			switch (grade)
			{
				case 'A':
					Console.WriteLine("Excellent!");
					break;
				case 'B':
				case 'C':
					Console.WriteLine("Well done");
					break;
				case 'D':
					Console.WriteLine("You passed");
					break;
				case 'F':
					Console.WriteLine("Better try again");
					break;
				default:
					Console.WriteLine("Invalid grade");
					break;
			}
			Console.WriteLine("Your grade is  {0}", grade);
			Console.ReadLine();

			//switch (ch1)
			//{
			//	case 'A':
			//		Console.WriteLine("This A is part of outer switch");

			//		switch (ch2)
			//		{
			//			case 'A':
			//				Console.WriteLine("This A is part of inner switch");
			//				break;
			//			case 'B': /* inner B case code */
			//		}
			//		break;
			//	case 'B': /* outer B case code */
			//}

			a = 100;
			b = 200;

			switch (a)
			{
				case 100:
					Console.WriteLine("This is part of outer switch ");

					switch (b)
					{
						case 200:
							Console.WriteLine("This is part of inner switch ");
							break;
					}
					break;
			}
			Console.WriteLine("Exact value of a is : {0}", a);
			Console.WriteLine("Exact value of b is : {0}", b);
			Console.ReadLine();

			/* example of ternary operator */
			a = 10;
			b = (a == 1) ? 20 : 30;
			Console.WriteLine("Value of b is {0}", b);

			b = (a == 10) ? 20 : 30;
			Console.WriteLine("Value of b is {0}", b);
			Console.ReadLine();

		}
	}
}
