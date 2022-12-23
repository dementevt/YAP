using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace ConsoleApplication1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите ваши 4 оценки");
			int[] mark = Console.ReadLine().Split(',').Select(n => Convert.ToInt32(n)).ToArray();
			
			for (int i = 0; i < mark.Length; i++)
			{
				if (mark[i] == 2)
				{
					Console.WriteLine("Ну что, студент, пора долг Родине отдать.");
					return;
				}
			}
			for (int i = 0; i < mark.Length; i++)
			{
				if (mark[i] == 3)
				{
					Console.WriteLine("Прощай стипендия!");
					return;
				}
			}
			for (int i = 0; i < mark.Length; i++)
			{
				if ((mark[i] == 4) || ((mark[i] == 4) && (mark[i] == 5)))
				{
					Console.WriteLine("Живи пока, через полгода увидимся.");
					return;
				}
			}
			for (int i = 0; i < mark.Length; i++)
			{
				if (mark[i] == 5)
				{
					Console.WriteLine("О, отличник появился! На олимпиаду пойдешь.");
					return;
				}
			}
		}
	}
}