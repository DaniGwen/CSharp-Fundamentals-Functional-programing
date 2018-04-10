using System;
using System.Linq;
using System.Collections.Generic;

namespace Problem_6._Reverse_and_Exclude
{
	class Program
	{
		static void Main()
		{
			var nums = Console.ReadLine().Split().Select(int.Parse);
			int divider = int.Parse(Console.ReadLine());
			
			Func<int, bool> filterFunc = n => n % divider != 0;
			
			var result= nums.Reverse().Where(filterFunc);
			Console.WriteLine(string.Join(" ", result));
		}
	}
}
