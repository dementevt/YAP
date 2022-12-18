using System;
using static System.Console;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = 12;
            int min = 30;
            Console.WriteLine("Введите n: ");
            int n = Convert.ToInt32(ReadLine());
            if (n == 0)
            {
                Console.WriteLine($"{hour}:{min}");
            }
            else
            {
                for (int j = 0; j <= n; j++)
                {
                    hour = 12 + j;
                    min = 5 + j * 5;
                }
                hour %=24;
                min %=60;
                Console.WriteLine($"{hour}:{min}");
            }
        }
    }
}
