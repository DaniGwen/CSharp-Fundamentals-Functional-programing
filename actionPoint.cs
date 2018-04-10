using System;
using System.Linq;

class Program
{
	static void Main()
	{
		var text = Console.ReadLine().Split();
		Action<string> action = r => Console.WriteLine(r);
		foreach (var word in text)
		{
			action(word);
		}
	}
}

