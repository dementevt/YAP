using System;
using static System.Console;

namespace ConsoleApplication1
{
	class Program
	{
		static void Main(string[] args)
		{
			Write("Введите текст: ");
			string text = ReadLine();
			string[] words = text.Split(' ');
			foreach (string word in words)
			{
				foreach (char letter in word)
					Console.WriteLine(letter);
				Console.WriteLine();
			}
		}
	}
}
