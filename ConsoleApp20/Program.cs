using System;

public class BahaSenpai
{
    public static void Main(string[] args)
    {
        string s = Console.ReadLine();
        if (s.Length > 5)
        {
            Console.WriteLine("Длинное");
        }
        else
        {
            Console.WriteLine("Короткое");
        }
    }
}
