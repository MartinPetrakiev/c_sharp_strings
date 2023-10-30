using System;
using System.Text;

class Program
{
    static string ConvertToUnicode(string inputString)
    {
        StringBuilder resultString = new StringBuilder();

        foreach (char c in inputString)
        {
            resultString.Append(String.Format("\\u{0:X4}", (int)c));
        }

        return resultString.ToString();
    }

    static void Main(string[] args)
    {
        string inputString = Console.ReadLine()!;

        Console.WriteLine(ConvertToUnicode(inputString));
    }
}

/*
Write a program that converts a string to a sequence of C# Unicode character literals.
Use format strings.
*/