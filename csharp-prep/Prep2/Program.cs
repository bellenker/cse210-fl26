using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your total grade percentage?");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

        if (grade >= 90)
        {
            Console.WriteLine("You got an A!");
        }
        else if (grade >= 80 && grade < 90)
        {
            Console.WriteLine("You got a B!");
        }
        else if (grade >= 70 && grade < 80)
        {
            Console.WriteLine("You got a C!");
        }
        else if (grade >= 60 && grade < 70)
        {
            Console.WriteLine("You got a D.");
        }
        else if (grade > 0 && grade < 60)
        {
            Console.WriteLine("You got an F.");
        }
        else
        {
            Console.WriteLine("I'm sorry, that is not a valid grade percentage. Try again.");
        }
        if (grade >= 70 && grade <= 100)
        {
            Console.WriteLine("Congratulations you pass!");
        }
        else if (grade >= 0 && grade <= 69)
        {
            Console.WriteLine("You are almost there! Try again, you can do it!");
        }
        else
        {
            Console.WriteLine("Try again and write your percentage as two numbers. Ex: 69");
        }
    }
}