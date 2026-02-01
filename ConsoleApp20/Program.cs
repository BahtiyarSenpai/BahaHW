using System;

public class BahaSenpai
{
    public static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        if (num > 0)
        {
            Console.WriteLine("Плюс");
        }
        else if (num < 0)
        {
            Console.WriteLine("Минус");
        }
        else
        {
            Console.WriteLine("Ноль");
        }
    }
}
//Why are you Baha
