using System;
using System.Globalization;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers (positive and negative), type 0 when finished.");
        List<int> number = new List<int>();
        int entry = -1;

        while (entry != 0)
        {
            Console.Write("Enter a number: ");

            string ans = Console.ReadLine();
            entry = int.Parse(ans);

            if (entry != 0)
            {
                number.Add(entry);
            }
        }

        int sum = 0;
        foreach (int answer in number)
        {
            sum += answer;
        }

        Console.WriteLine($"The sum is: {sum}");

        float ave = ((float)sum) / number.Count;
        Console.WriteLine($"The average is: {ave}");

        int max = number[0];

        foreach (int answer in number)
        {
            if (answer > max)
            {
                max = answer;
            }
        }
        Console.WriteLine($"The max is: {max}");

        var posNum = number.Where(n => n > 0);

        if (posNum.Any())
        {
            int small = posNum.Min();
            Console.WriteLine($"The smallest positive number is: {small}");
        }
        else
        {
            Console.WriteLine("No positive numbers were entered.");
        }

        number.Sort();
        Console.WriteLine("The sorted list is: " + string.Join(", ", number));
    }
}