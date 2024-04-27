using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(1, 100);
        int guess,number_of_guess = 1;
        Console.Write("What is your guess? ");
        guess = int.Parse(Console.ReadLine());

        while (magic_number != guess)
        {
            if (magic_number > guess)
            {
                Console.WriteLine("Higher.");
            }
            else
            {
                Console.WriteLine("Lower.");
            }
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            number_of_guess++;
        }
        Console.WriteLine($"You guessed it!, it took you {number_of_guess} guesse(s).");
    }
}