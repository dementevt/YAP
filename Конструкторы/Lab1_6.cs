using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace ConsoleApplication1
{
	class Program
	{
		static void Main(string[] args)
		{
			var myWatch = new Watch("Casio", "electronic", 15.99M);
			myWatch.Print();
		}
	}
	
	class Watch
	{
		public string brand, type;
		public decimal  num;
		public Watch(string brand, string type, decimal num)
		{
			this.brand = brand;
			this.type = type;
			this.num = num;
		}
		
		public void Print()
		{
			Console.WriteLine($"{brand}, {type}, {num}");
		}
	}
}
