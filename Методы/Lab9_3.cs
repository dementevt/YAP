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
			int[] mas = new int[] { 93, -9, 15, 16, -3, 0, 18};
			opposite(mas);
		}
		
		static void opposite(int[] mas)
		{
			for (int i = 0; i < mas.Length; i++)
			{
				mas[i] = mas[i] * (-1);
				Console.Write(mas[i] + ", ");
			}
		}
	}
}