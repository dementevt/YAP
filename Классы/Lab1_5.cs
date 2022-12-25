using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Worker
    {
        public string name;
        public string surname;
        public int rate;
        public int days;
        
        public void GetFullName()
        {
            Console.WriteLine($"Фамилия и имя: {surname} {name}");
        }
        public void GetSalary()
        {
            Console.WriteLine($"Заработная плата = {rate * days}");
            
        }
    }
    
    class main
    {
        public static void Main()
        {
            Worker worker = new Worker();
            worker.surname = "Galkin";
            worker.name = "Pavel";
            worker.rate = 120;
            Console.Write("Кол-во отработанных дней: ");
            worker.days = int.Parse(Console.ReadLine());
            worker.GetFullName();
            worker.GetSalary();
        }
    }
}