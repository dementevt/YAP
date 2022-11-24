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
            int steps = Convert.ToInt32(ReadLine());
            if (steps == 0)
            {
                Console.WriteLine($"{hour} часов");
                Console.WriteLine($"{min} минут");
            }
            else
            {
                hour = 13;
                min = 10;
                for(int i = 0; i < steps - 1; i++)
                {
                     hour ++;
                     min += 5;
                     hour %= 24;
                     min %= 60;
                }
                Console.WriteLine($"{hour} часов");
                Console.WriteLine($"{min} минут");
            }
            
        }
    }
}