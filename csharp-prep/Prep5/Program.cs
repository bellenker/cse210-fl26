using System;
using System.Net;
using System.Security.Cryptography;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = PromptUserName();
        int number = PromptUserNumber();
        int square = SquareNumber(number);
        int current = DateTime.Now.Year;
        int year;
        PromptUserBirthYear(out year);

        DisplayResult(name, square, current, year);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int num = int.Parse(Console.ReadLine());
        return num;
    }

    static void PromptUserBirthYear(out int year)
    {
        Console.Write($"Please enter the year you were born: ");
        year = int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    static void DisplayResult(string name, int square, int current, int year)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
        Console.WriteLine($"{name}, you will turn {current - year} this year.");
    }

}