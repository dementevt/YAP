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
			string a = Console.ReadLine();
			string[] b = a.Split(" ");
			List<int> list= new List<int>();
			int s = 0, e = 0, start = 1, end = 1;
			for (int i = 0; i < b.Length; i++)
			{
				if (start == 1)
				{
					if (b[i] == "0") 
					{
						start = 0;
						s = i + 1; 
					}
				}
				else if (end == 1)
				{
					if (b[i] == "0") 
					{ 
						end = 0; 
						e = i; 
					}
				}
			}
			for (int i = s; i < e; i++)
			{
				list.Add(int.Parse(b[i]));
			}
			list.Sort();
			list.Reverse();
			Console.Write(String.Join(", ", list));
		}
	}
}