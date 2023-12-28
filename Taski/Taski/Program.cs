using System;

public class Programmm
{
    public int Aboba(int n)
    {
        return (int) Math.Pow(2, n);
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Привет, мир!");

        Console.WriteLine($"2^10 = " + Math.Pow(2, 10));

        Programmm programmm = new Programmm();
        programmm.Aboba(1);

        Console.WriteLine("Нажми любую клавишу для выхода...");
        Console.ReadKey();
    }

    
}
