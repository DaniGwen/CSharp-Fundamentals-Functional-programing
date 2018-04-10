using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_10._Predicate_Party_
{
	class Program
	{


		static void Main()
		{
			var people = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

			ExecuteCommand(people);
			PrintPeople(people);

		}

		public static void PrintPeople(List<string> people)
		{
			if (people.Any())
			{
				var name = string.Join(", ", people);
				Console.WriteLine($"{name} are going to the party!");
			}
			else
			{
				Console.WriteLine("Nobody is going to the party!");
			}
		}

		public static void ExecuteCommand(List<string> people)
		{
			var command = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

			while (command[0] != "Party!")
			{
				if (command.Length < 3)
				{
					command = Console.ReadLine().Split();
					continue;
				}
				switch (command[1])
				{
					case "StartsWith":
						ForeachName(command[0], people, n => n.StartsWith(command[2]));
						break;
					case "EndsWith":
						ForeachName(command[0], people, n => n.EndsWith(command[2]));
						break;
					case "Length":
						ForeachName(command[0], people, n => n.Length == int.Parse(command[2]));
						break;
					default:
						break;
				}
				command = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			}
		}
		public static void ForeachName(string command, List<string> people, Func<string, bool> condition)
		{
			for (int i = people.Count - 1; i >= 0; i--)
			{
				if (condition(people[i]))
				{
					switch (command)
					{
						case "Remove":
							people.RemoveAt(i);
							break;
						case "Double":
							people.Add(people[i]);
							break;
						default:
							break;
					}
				}
			}
		}
	}
}