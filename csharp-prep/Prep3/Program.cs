using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 100);

        int guess = -1;
        int count = 0;

        while (magic != guess)
        {
            Console.Write("What is your guess? ");
            string ans = Console.ReadLine();
            guess = int.Parse(ans);
            count++;

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
                Console.WriteLine($"Total guesses made: {count}");
            }
        }

    }
}