using System;
using System.Linq;

namespace Problem_3._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
			int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
			Func<int[], int> min = GetMin;

			Console.WriteLine(min(nums));
        }
		public static int GetMin(int[] numbers)
		{
			var min = int.MaxValue;
			foreach (var num in numbers)
			{
				if (num < min)
				{
					min = num;
				}
			}
			return min;
		}
    }
}
