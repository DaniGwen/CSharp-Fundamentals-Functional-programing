using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
	static void Main()
	{
		var price = Console.ReadLine()
			.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
			.Select(double.Parse)
			.Select(n => n * 1.2)
			.ToList();

			price.ForEach(v => Console.WriteLine($"{v:f2}"));

	}
}

