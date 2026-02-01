using System;

public class BahaSenpai
{
    public static void Main(string[] args)
    {
        int age = int.Parse(Console.ReadLine());
        if (age >= 18)
        {
            Console.WriteLine("Сигма");
        }
        else
        {
            Console.WriteLine("Маловат еще,иди поплачь,мелочь");
        }
    }
}
