using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_5._Applied_Arithmetics
{
	class Program
	{
		static void Main(string[] args)
		{
			var nums = Console.ReadLine().Split().Select(int.Parse).ToList();
			Func<int, int> addFunc = n => n += 1;
			Func<int, int> subtractFunc = n => n -= 1;
			Func<int, int> multiplyFunc = n => n *= 2;
			Action<List<int>> printAction = a => Console.WriteLine(string.Join(" ", a));
			string command;
			
			while ((command = Console.ReadLine()) != "end")
			{
				switch (command)
				{
					case "add": nums = nums.Select(n => addFunc(n)).ToList();
						break;
					case "subtract": nums = nums.Select(n => subtractFunc(n)).ToList();
						break;
					case "multiply": nums = nums.Select(n => multiplyFunc(n)).ToList();
						break;
					case "print": printAction(nums);
						break;
				}
			}
		}

	}
}
