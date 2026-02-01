using System;

public class BahaSenpai
{
    public static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        if (a % 2 == 0)
        {
            Console.WriteLine("Четное");
        }
        else
        {
            Console.WriteLine("Нечетное");
        }
    }
}
