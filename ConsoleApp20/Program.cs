using System;

public class BahaSenpai
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        if (n == 7)
        {
            Console.WriteLine("Счастливое число!");
        }
        else
        {
            Console.WriteLine("Обычное число");
        }
    }
}
