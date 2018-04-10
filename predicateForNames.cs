using System;
using System.Linq;

namespace Problem_7._Predicate_for_Names
{
    class Program
    {
        static void Main(string[] args)
        {
			int nameLength = int.Parse(Console.ReadLine());
			var names = Console.ReadLine().Split();

			Func<string, bool> filterNames = n => n.Length <= nameLength;
			 
			var result = names.Where(filterNames);
			foreach (var name in result)
			{
				Console.WriteLine(name);
			}
        }
    }
}
