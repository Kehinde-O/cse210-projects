using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Swimming swimming = new Swimming(new DateOnly(2022, 12, 25), 50, 23);
        Console.WriteLine("Swimming Activity");
        Console.WriteLine(swimming.GetSummary());

        Console.WriteLine();
        Console.WriteLine("Running Activity");
        Running running = new Running(new DateOnly(2022, 12, 25), 90, 30);
        Console.WriteLine(running.GetSummary());

        Console.WriteLine();
        Console.WriteLine("Cycling Activity");
        Cycling cycling = new Cycling(new DateOnly(2022, 12, 25), 45, 10);
        Console.WriteLine(cycling.GetSummary());
        Console.WriteLine();
    }
}