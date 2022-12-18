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
			int startValue = int.Parse(Console.ReadLine());
			int endValue = int.Parse(Console.ReadLine());
			PrintEven(GetMultiple(startValue, endValue));
		}
		static List<int> GetMultiple(int start,int end)
		{
			List<int> list = new List<int>();
			for (int i = start; i < end; i++)
			{
				if (i % 7 == 0 && i != 0) 
				{
					list.Add(i);
				}
			}
			return list;
		}
		static void PrintEven(List<int> list)
		{
			for (int j = 0; j < list.Count; j += 2)
			{
					Console.Write(list[j] + " ");
			}
		}
	}
}