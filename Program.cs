using System.Text.RegularExpressions;
using System;

namespace StudentDB
{
	internal class Program
	{
		static void Main(string[] args)
		{


			bool isActive = true;
			while (isActive)
			{
				string[] students = { "Oliver", "Char", "Owen", "Isaac", "Willow", "Addison"};
				string[] towns = { "Sterling Heights", "Warren", "Troy", "Hamtramck", "Conant", "Hazel Park" };
				string[] foods = { "Pizza", "Wings", "Big Mac", "Lamb Kafta", "Ribs", "Burgers" };
				int input = 0;

				bool isValid = true;
				while (isValid)
				{
					Console.WriteLine("Enter student number for information on them. We currently have 6 students.");
					input = int.Parse(Console.ReadLine()) - 1;
					if (input > -1 && input < students.Length) {
						isValid = false;
					}
					else
					{
						isValid = true;
						Console.WriteLine("that isn't a number in our student list");
					}
				}

				isValid = true;
				while (isValid)
				{
					Console.WriteLine("would you like to know their *hometown* or *favorite food*");
					string checker = Console.ReadLine().ToLower();
					if (checker == "hometown" || checker == "town")
					{
						isValid = false;
						Console.WriteLine(students[input] + " grew up in " + towns[input]);

					} 
					else if (checker == "favorite food" || checker == "food")
					{
						isValid = false;
						Console.WriteLine(students[input]+"'s favorite food is "+foods[input]);
					}
					else
					{
						isValid = true;
						Console.WriteLine("please try *town* or *food*");
					}
				}
				isActive = AskToContinue();
			}
		}
		public static bool AskToContinue()
		{
			Console.WriteLine("wanna check another student? (y/n)");
			string input = Console.ReadLine().ToLower();
			if (input == "y" || input =="yes")
			{
				return true;

			}
			else if (input == "n" || input == "no")
			{
				return false;
			}
			else
			{
				Console.WriteLine("try again (y/n)");
				return AskToContinue();
			}
		}
	}
}