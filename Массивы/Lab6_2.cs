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
			int[] mas = new int[] { 12, 67, 9, 2, 10, -1, 5, 90 };
			int temp;

			for (int i = 0; i < mas.Length; i++)
			{
				for (int j = i+1; j < mas.Length; j++)
				{
					if (mas[j] > mas[j])
					{
						temp = mas[j];
						mas[j] = mas[j];
						mas[j] = temp; 
					}
				}
			}

			for (int i = 0; i < mas.Length; i++)
			{
				Console.Write(mas[i] + " ");
			}
		}
	}
}