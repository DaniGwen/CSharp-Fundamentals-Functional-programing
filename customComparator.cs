using System;
using System.Linq;

namespace Problem_8._Custom_Comparator
{
	class Program
	{
		static void Main(string[] args)
		{
			var nums = Console.ReadLine()
				.Split()
				.Select(int.Parse)
				.ToArray();

			Func<int, int, int> comparer = (n1, n2) =>
			 n1 % 2 == 0 && n2 % 2 != 0 ? -1 :
			 n1 % 2 != 0 && n2 % 2 == 0 ? 1 :
			 n1.CompareTo(n2);

			Array.Sort<int>(nums, new Comparison<int>(comparer));
			Console.WriteLine(string.Join(" ", nums));
		}
	}
}
