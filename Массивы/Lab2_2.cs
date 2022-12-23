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
			WriteLine("Введите первое число: ");
			int num1 = int.Parse(ReadLine());
			int[] n1 = GetIntArray(num1);
			WriteLine("Введите второе число: ");
			int num2 = int.Parse(ReadLine());
			int[] n2 = GetIntArray(num2);
			int coincidence = 0;
			for (int i = 0; i < n1.Length; i++)
			{
				if (n1[i] == n2[i])
					coincidence++;
			}
			WriteLine($"Совпадение {coincidence} элементов");
			
		}
		static int[] GetIntArray(int num)
		{
			List<int> listOfInts = new List<int>();
			while(num > 0)
			{
				listOfInts.Add(num % 10);
				num /= 10;
			}
			listOfInts.Reverse();
			return listOfInts.ToArray();
		}
	}
}