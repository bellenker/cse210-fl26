using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your total grade percentage?");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80 && grade < 90)
        {
            letter = "B";
        }
        else if (grade >= 70 && grade < 80)
        {
            letter = "C";
        }
        else if (grade >= 60 && grade < 70)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        int lnum = grade % 10;
        string gradeSign = "";

        if (lnum >= 7)
        {
            gradeSign = "+";
        }
        else if (lnum < 3)
        {
            gradeSign = "-";
        }
        else
        {
            gradeSign = "";
        }

        if (letter == "A" && gradeSign == "+")
        {
            gradeSign = "";
        }
        else if (letter == "F")
        {
            gradeSign = "";
        }

        Console.WriteLine($"Your grade is a/an {letter}{gradeSign}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations you pass!");
        }
        else
        {
            Console.WriteLine("You are almost there! Try again, you can do it!");
        }
    }
}