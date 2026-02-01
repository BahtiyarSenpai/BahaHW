using System;

public class BahaSenpai
{
    public static void Main(string[] args)
    {
        int t = int.Parse(Console.ReadLine());
        if (t < 0)
        {
            Console.WriteLine("Мороз");
        }
        else if (t > 25)
        {
            Console.WriteLine("Жара");
        }
        else
        {
            Console.WriteLine("Нормально");
        }
    }
}
