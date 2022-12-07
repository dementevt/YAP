using System;
using static System.Console;

namespace ConsoleApplication1
{
	class Program
	{
		static void Main(string[] args)
		{
			int number = int.Parse(ReadLine());
			int c = 0;
			while (number > 1)
			{
				if (number % 2 == 0)
					number /= 2;
				else number = number * 3 + 1;
				c++;
			}
			WriteLine($"Количество необходимых действий над числом - {c");
		}
	}
}
