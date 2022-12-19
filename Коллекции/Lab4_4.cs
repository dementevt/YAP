using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите число n ");
			int n = Convert.ToInt32(Console.ReadLine());
			sirakuz(n);
		}
		static void sirakuz (int n)
		{
			int count = 0;
			List <int> list = new List<int>();
			while (n != 1)
			{
				if (n % 2 == 0)
				{
					n = n / 2;
					count += 1;
					list.Add(n);
				}
				else
				{
					n = 3 * n + 1;
					count += 1;
					list.Add(n);
				}
			}
			foreach (int a in list)
			{
				Console.Write(a + " ");
			}
		}
	}
}