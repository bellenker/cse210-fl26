using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        string num = Console.ReadLine();
        int magic = int.Parse(num);

        Console.Write("What is your guess? ");
        string ans = Console.ReadLine();
        int guess = int.Parse(ans);

        if (magic > guess)
        {
            Console.WriteLine("Higher");
        }
        else if (magic < guess)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine("You guessed it!");
        }

    }
}