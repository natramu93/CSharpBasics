using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic6
{
	class Program
	{
		static void Main(string[] args)
		{
			//while (condition)
			//{
			//	statement(s);
			//}

			/* local variable definition */
			int a = 10;

			/* while loop execution */
			while (a < 20)
			{
				Console.WriteLine("value of a: {0}", a);
				a++;
			}
			Console.ReadLine();

			//for (init; condition; increment)
			//{
			//	statement(s);
			//}

			/* for loop execution */
			for (a = 10; a < 20; a = a + 1)
			{
				Console.WriteLine("value of a: {0}", a);
			}
			Console.ReadLine();

			//do
			//{
			//	statement(s);
			//} while (condition);


			/* local variable definition */
			a = 10;

			/* do loop execution */
			do
			{
				Console.WriteLine("value of a: {0}", a);
				a = a + 1;
			}
			while (a < 20);
			Console.ReadLine();
			/*
			for (init; condition; increment)
			{
				for (init; condition; increment)
				{
					statement(s);
				}
				statement(s);
			}

			while(condition) {
			  while(condition) {
			   statement(s);
				}
				statement(s);
			}

			do {
   statement(s);
   do {
      statement(s);
   }
   while( condition );
}
while( condition );			*/

				int i, j;
         
         for (i = 2; i < 100; i++) {
            for (j = 2; j <= (i / j); j++)
            if ((i % j) == 0) break; // if factor found, not prime
            if (j > (i / j))
				Console.WriteLine("{0} is prime", i);
         }
         Console.ReadLine();
		}
	}
}
