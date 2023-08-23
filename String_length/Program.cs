using System;
using System.Linq;

class Program
{
    static string FillMissingCharsWithStars(string inputString)
    {
        string resultString = inputString;

        if (String.IsNullOrEmpty(inputString))
        {
            resultString = "";
            IEnumerable<string> stars = Enumerable.Repeat("*", 20);
            foreach (String str in stars)
            {
                resultString += str;
            }
        }
        
        if (inputString.Length < 20)
        {
            IEnumerable<string> stars = Enumerable.Repeat("*", 20 - inputString.Length);
            foreach (String str in stars)
            {
                resultString += str;
            }
        }

        return resultString;
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