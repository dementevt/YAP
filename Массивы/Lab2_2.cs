using System;

public class MainClass
{
    public static void Main()
    {
        int[] n = { 1, 3, 4, 5, 6 };
        int[] n1 = { 2, 3, 5, 5, 0 };
        int coincidence = 0;
        for (int i = 0; i < n.Length; i++)
        {
            if (n[i] == n1[i])
                coincidence++;
        }
        Console.WriteLine("Совпадение" + coincidence + "элементов");
    }
}