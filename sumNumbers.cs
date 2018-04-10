using System;
using System.Linq;


class Program
{
	static void Main(string[] args)
	{
		var input = Console.ReadLine();
		Func<string, int> parser = n => int.Parse(n);
		var nums = input.Split(", ")
			.Select(parser)
			.ToArray();
		
		Console.WriteLine(nums.Count());
		Console.WriteLine(nums.Sum());
	}
}

