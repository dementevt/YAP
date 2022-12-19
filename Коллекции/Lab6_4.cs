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
			List<int> list = new List<int> {1, 2, 5, 7, 8, 10};
			int c = 0;
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