using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class main
    {
        public static void Main()
        {
            XYZ xyz = new XYZ();
            Console.WriteLine("Координаты мухи: ");
            Console.Write("\tx = ");
            xyz.Xmuha = double.Parse(Console.ReadLine());
            Console.Write("\ty = ");
            xyz.Ymuha = double.Parse(Console.ReadLine());
            Console.Write("\tz = ");
            xyz.Zmuha = double.Parse(Console.ReadLine());
            Console.WriteLine("Координаты паука: ");
            Console.Write("\tx = ");
            xyz.Xpavuk = double.Parse(Console.ReadLine());
            Console.Write("\ty = ");
            xyz.Ypavuk = double.Parse(Console.ReadLine());
            Console.Write("\tz = ");
            xyz.Zpavuk = double.Parse(Console.ReadLine());
            if (xyz.Ymuha == 0)
            {
                xyz.poPloskosti();
                xyz.poPryamoy();
            }
            else
            {
                Console.Write("Данные некорректны или муха находится не на полу");
            }
        }
    }
    
    class XYZ
    {
        public double Xmuha;
        public double Ymuha;
        public double Zmuha;
        public double Xpavuk;
        public double Ypavuk;
        public double Zpavuk;
        
        public void poPloskosti()
        {
            double p = Math.Sqrt(Math.Pow(Xpavuk - Xmuha, 2) + Math.Pow(Ypavuk - Ymuha, 2));
            Console.WriteLine("Путь по плоскости: " + Math.Round(p, 5));
        }
        public void poPryamoy()
        {
            double s = Math.Sqrt(Math.Pow(Xpavuk - Xmuha, 2) + Math.Pow(Ypavuk - Ymuha, 2) + Math.Pow(Zpavuk - Zmuha, 2));
            Console.WriteLine("Расстояние между мухой и пауком по прямой линии: " + Math.Round(s, 5));
        }
        
        
    }
}