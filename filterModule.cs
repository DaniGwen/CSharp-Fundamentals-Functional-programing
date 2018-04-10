using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_11._Party_Reservation_Filter_Module
{
	class Program
	{
		static void Main(string[] args)
		{
			var people = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
			List<string> goingList = new List<string>();
			foreach (var name in people)
			{
				goingList.Add(name);
			}
			ExecuteCommand(people, goingList);
			PrintPeople(goingList);
		}
		public static void PrintPeople(List<string> goingList)
		{
			if (goingList.Any())
			{
				var name = string.Join(" ", goingList);
				Console.WriteLine($"{name}");
			}
			else
			{
				Console.WriteLine("Nobody is going to the party!");
			}
		}

		public static void ExecuteCommand(List<string> people, List<string> goingList)
		{
			var command = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

			while (command[0] != "Print")
			{

				switch (command[1])
				{
					case "Starts with":
						ForeachName(command[0], people, goingList, n => n.StartsWith(command[2]));
						break;
					case "Ends with":
						ForeachName(command[0], people, goingList, n => n.EndsWith(command[2]));
						break;
					case "Length":
						ForeachName(command[0], people, goingList, n => n.Length == int.Parse(command[2]));
						break;
					case "Contains":
						ForeachName(command[0], people, goingList, n => n.Contains(command[2]));
						break;
					default:
						break;
				}
				command = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
			}
		}

		public static void ForeachName(string command, List<string> people, List<string> goingList, Func<string, bool> condition)
		{
			foreach (var name in people)
			{
				if (condition(name))
				{
					switch (command)
					{
						case "Remove filter":
							foreach (var n in people)
							{
								if (condition(n))
								{
									goingList.Add(name);
								}
							}
							break;
						case "Add filter":
							if (goingList.Contains(name))
							{
								goingList.Remove(name);
							}
							break;
						default:
							break;
					}
				}
			}
			
		}
	}
}
