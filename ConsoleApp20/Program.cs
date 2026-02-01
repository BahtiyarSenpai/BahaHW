using System;

public class BahaSenpai
{
    public static void Main(string[] args)
    {
        string login = Console.ReadLine();
        if (login != "admin")
        {
            Console.WriteLine("Доступ запрещен");
        }
    }
}
