using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Filter_by_Age
{
	class Program
	{
		static void Main()
		{
			var people = GetPeople();
			string condition = Console.ReadLine();
			int age = int.Parse(Console.ReadLine());
			string format = Console.ReadLine();

			var tester = CreateTester(condition, age);
			var printer = CreatePrinter(format);
			PrintPeople(people, tester, printer);

		}
		public static Func<int, bool> CreateTester(string condition, int age)
		{
			switch (condition)
			{
				case "younger": return x => x < age;
				case "older": return x => x >= age;
				default: return null;
			}
		}
		public static Action<KeyValuePair<string,int>> CreatePrinter(string format)
		{
			switch (format)
			{
				case "name": return person => Console.WriteLine($"{person.Key}");
				case "age": return person => Console.WriteLine($"{person.Value}");
				case "name age": return person => Console.WriteLine($"{person.Key} - {person.Value}");
				default: return null;
			}
		}
		public static void PrintPeople(Dictionary<string,int> people, Func<int, bool> tester, Action<KeyValuePair<string, int>> printer)
		{
			foreach (var person in people)
			{
				if (tester(person.Value))
				{
					printer(person);
				}
			}

		}
		public static Dictionary<string,int> GetPeople()
		{
			int n = int.Parse(Console.ReadLine());
			var people = new Dictionary<string, int>();
			for (int i = 0; i < n; i++)
			{
				var peopleArgs = Console.ReadLine()
				   .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
				if (!people.ContainsKey(peopleArgs[0]))
				{
					people.Add(peopleArgs[0], int.Parse(peopleArgs[1]));
				}
			}
			return people;
		}
	}
}
