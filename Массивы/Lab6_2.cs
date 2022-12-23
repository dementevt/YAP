using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
	class Program
	{
		static void Main()
		{
			int[] mas = { 44, 55, 21, -100, 33, 200, 150};
			Bubble(mas);
			for (int i = 0; i < mas.Length; i++)
			{
				Console.Write(mas[i] + " ");
			}
		}
		static int[] Bubble(int[] mas)
		{
			int temp;
			
			for (int i = 0; i < mas.Length; i++)
			{
				for (int j = 0; j < mas.Length - 1; j++)
				{
					if (mas[j] > mas[j + 1])
					{
						temp = mas[j + 1];
						mas[j + 1] = mas[j];
						mas[j] = temp; 
					}
				}
			}
			return mas;
		}
	}
}