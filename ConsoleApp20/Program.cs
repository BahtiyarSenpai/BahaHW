using System;

public class BahaSenpai
{
    public static void Main(string[] args)
    {
        int mark = int.Parse(Console.ReadLine());
        if (mark == 5)
        {
            Console.WriteLine("Отличник!");
        }
        else if (mark == 4)
        {
            Console.WriteLine("Хорошая Оценка");
        }
        else
        {
            Console.WriteLine("Деградация?");
        }
    }
}
//Why are you Baha
