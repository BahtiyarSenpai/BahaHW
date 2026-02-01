using System;

public class BahaSenpai
{
    public static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        if (a > b)
        {
            Console.WriteLine(a - b);
        }
        else
        {
            Console.WriteLine(b - a);
        }
    }
}
//Why are you Baha