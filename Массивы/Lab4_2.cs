using System;
using System.Linq;

public class MainClass
{
    public static void Main()
    {
        Console.WriteLine("Введите ваши 4 оценки");
        int[] mark = Console.ReadLine().Split(',').Select(n => Convert.ToInt32(n)).ToArray();
    
        for (int i = 0; i < mark.Length; i++)
        {
            if (mark[i] == 2)
            {
                Console.WriteLine("Ну что, студент, пора долг Родине отдать.");
                return;
            }

            else if (mark[i] == 3 && mark[i] != 2)
            {
                Console.WriteLine("Прощай стипендия!");
                return;
            }
            
            else if (mark[i] == 4 && mark[i] != 2 && mark[i] != 3)
            {
                Console.WriteLine("Живи пока, через полгода увидимся.");
                return;
            }
            
            else if (mark[i] == 5 && mark[i] == 4 && mark[i] != 2 && mark[i] != 3)
            {
                Console.WriteLine("О, отличник появился! На олимпиаду пойдешь.");
                return;
            }
        }
    }
}