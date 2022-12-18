using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
   
    class Program
    {

        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Factorize(num);
        }

        static void Factorize(int num)
        {
            int a = 1;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0 && i <= a)
                {
                    a = num / i;
                    Console.WriteLine($"{num} = {i} * {a}");
                }
            }
        }
    }
}
