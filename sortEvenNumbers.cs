using System;
using System.Linq;
namespace Sort_Even_Numbers
{
    class Program
    {
        static void Main()
        {
			var nums = Console.ReadLine().Split(", ").Select(int.Parse).Where(s => s % 2 == 0).OrderBy(n=>n).ToArray();
			Console.WriteLine(string.Join(",", nums));
        }
    }
}
