using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_4._Find_Evens_or_Odds
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
			int lower = nums[0];
			int upper = nums[1];
			string command = Console.ReadLine();
			
			OddOrEven(command, nums, lower, upper);
		}
		public static void OddOrEven(string command, int[] nums, int lower, int upper)
		{
			List<int> result = new List<int>();
			Func<int, bool> evenFunc = n => n % 2 == 0;
			Func<int, bool> oddFunc = n => n % 2 != 0;
			switch (command)
			{
				case "odd":
					for (int i = lower; i <= upper; i++)
					{
						if (oddFunc(i))
						{
							result.Add(i);
						}
					}
					Console.WriteLine(string.Join(" ", result));
					break;
				case "even":
					for (int i = lower; i <= upper; i++)
					{
						if (evenFunc(i))
						{
							result.Add(i);
						}
					}
					Console.WriteLine(string.Join(" ", result));
					break;
				default: throw new Exception("OddOrEven crashed!");

			}
		}
	}
}
