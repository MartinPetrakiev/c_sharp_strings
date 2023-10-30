using System;

public class Program
{
    
    static string RemoveConsecutiveIdenticalLetters(string input)
    {
        char previousChar = input[0];
        char[] resultChars = new char[input.Length];
        int resultIndex = 0;

        resultChars[resultIndex++] = previousChar;

        for (int i = 1; i < input.Length; i++)
        {
            char currentChar = input[i];

            if (currentChar != previousChar)
            {
                resultChars[resultIndex++] = currentChar;
                previousChar = currentChar;
            }
        }

        return new string(resultChars, 0, resultIndex);
    }
    
    public static void Main()
    {
        string input = Console.ReadLine();

        string result = RemoveConsecutiveIdenticalLetters(input);
        
        Console.WriteLine(result);
    }
}

/*
Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
Example: aaaaabbbbbcdddeeeedssaa | abcdedsa
*/