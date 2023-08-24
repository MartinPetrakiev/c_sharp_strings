using System;
using System.Text;

class Program
{
    static string FillMissingCharsWithStars(string inputString)
    {
        StringBuilder resultString = new StringBuilder();

        if (String.IsNullOrEmpty(inputString))
        {
            resultString.Append(new string('*', 20));
        }
        
        if (inputString.Length < 20)
        {
            string fillingStars = new string('*', 20 - inputString.Length);
            resultString.Append(inputString);
            resultString.Append(fillingStars);
        }

        return resultString.ToString();
    }

    static void Main(string[] args)
    {
        string inputString = Console.ReadLine();

        Console.WriteLine(FillMissingCharsWithStars(inputString));

    }
}

/*

Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with *.
Print the result string into the console.


*/