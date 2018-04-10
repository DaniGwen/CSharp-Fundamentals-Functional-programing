using System;
using System.Linq;

namespace _3._Count_Uppercase_Words
{
    class Program
    {
		static void Main(string[] args)
		{
			string[] text = Console.ReadLine().Split(new[] { '.', ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
			Func<string, bool> checkWord = w => w[0] == w.ToUpper()[0];

			text.Where(checkWord).ToList().ForEach(w => Console.WriteLine(w));
		}
    }
}
