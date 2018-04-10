using System;
using System.Linq;

class Program
{
	static void Main()
	{
		string[] names = Console.ReadLine().Split();

		Action<string> appendText = t => Console.WriteLine("Sir " + t);

		 names.ToList().ForEach(n => appendText(n));
	
	}
}

