using System;
using static System.Console;

namespace ConsoleApplication1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Высота: ");
			int floar = int.Parse(ReadLine());
			int space = floar;
			for (int i = 0, z = 1; i < floar; i++, z+=2)
			{
				Console.Write(new string(' ',space--));
				Console.Write(new string('*',z));
				Console.WriteLine();
			}
		}
	}
}