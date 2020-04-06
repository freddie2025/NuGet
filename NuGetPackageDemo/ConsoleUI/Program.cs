using System;
using FredCo.Helpers.Calculations;

namespace ConsoleUI
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine($"The sum of 5 and 2 is { Calculator.Add(2,7) }");

			Console.ReadLine();
		}
	}
}
