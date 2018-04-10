using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_9._List_of_Predicates
{
    class Program
    {
        static void Main()
        {
			int range = int.Parse(Console.ReadLine());
			var dividers = Console.ReadLine()
				.Split()
				.Select(int.Parse)
				.ToList();

			Func<int, bool>[] predicates = dividers.Select(div => (Func<int,bool>)(n => n%div == 0)).ToArray();

			List<int> result = new List<int>();

			for (int i = 1; i <= range; i++)
			{
				bool isDivisable = true;

				foreach (var predicate in predicates)
				{
					if (!predicate(i))
					{
						isDivisable = false;
						break;
					}
				}

				if (isDivisable)
				{
					result.Add(i);
				}
			}
			Console.WriteLine(string.Join(" ", result));
        }
    }
}
