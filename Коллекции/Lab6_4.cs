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
			List<int> list = new List<int> ();
			int c = 0;
			string a = Console.ReadLine();
			string[] b = a.Split(",");
			for (int i = 0; i < b.Length; i++)
			{
				list.Add(int.Parse(b[i]));
			}

			for (int i = list[0]; i < list[list.Count-1]; i++)
			{
				if (i != list[c])
				{
					Console.Write(i + " ");
				}
				else c++;
			}
		}
	}
}
