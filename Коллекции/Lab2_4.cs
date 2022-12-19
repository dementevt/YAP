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
			bool start = true, end = true;
			int s = 0, e = 0;
			for (int i = 0; i < b.Length; i++)
			{
				if (start)
				{
					if (b[i] == "0") 
					{
						start = false;
						s = i; 
					}
				}
				else if (end)
				{
					if (b[i] == "0") 
					{ 
						end = false; 
						e = i; 
					}
				}
			}
			for (int i =  s + 1; i < e; i++)
			{
				list.Add(int.Parse(b[i]));
			}
			list.Sort();
			list.Reverse();
			foreach(int j in list)
			{
				Console.Write(j + " ");
			}
		}
	}
}