using System;

public class BahaSenpai
{
    public static void Main(string[] args)
    {
        double price = double.Parse(Console.ReadLine());
        if (price > 1000)
        {
            Console.WriteLine(price * 0.9);
        }
        else
        {
            Console.WriteLine(price);
        }
    }
}
