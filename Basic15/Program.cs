using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//String

namespace Basic15
{
	class Program
	{
		static void Main(string[] args)
		{

			//compare

			string str1 = "This is test";
			string str2 = "This is text";

			if (String.Compare(str1, str2) == 0)
			{
				Console.WriteLine(str1 + " and " + str2 + " are equal.");
			}
			else
			{
				Console.WriteLine(str1 + " and " + str2 + " are not equal.");
			}
			Console.ReadKey();

			//contains

			string str = "This is test";

			if (str.Contains("test"))
			{
				Console.WriteLine("The sequence 'test' was found.");
			}
			Console.ReadKey();

			//substring

			str = "Last night I dreamt of San Pedro";
			Console.WriteLine(str);
			string substr = str.Substring(23);
			Console.WriteLine(substr);

			//join

			string[] starray = new string[]{"Down the way nights are dark",
			"And the sun shines daily on the mountain top",
			"I took a trip on a sailing ship",
			"And when I reached Jamaica",
			"I made a stop"};

			str = String.Join("\n", starray);
			Console.WriteLine(str);
		}
	}
}
