using System;

public class BahaSenpai
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        while (n >= 0)
        {
            Console.Write(n + "  ");
            n--;
        }
    }
}
