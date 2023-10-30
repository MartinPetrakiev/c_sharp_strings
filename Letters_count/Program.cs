using System;

public class Program
{
    public static void Main()
    {
        string inputString = Console.ReadLine();

        char[] arrayChars = inputString.ToCharArray();
        IDictionary<char, int> charOccurrence = new Dictionary<char, int>();

        for (int i = 0; i < arrayChars.Length; i++)
        {
            if (charOccurrence.ContainsKey(arrayChars[i]))
            {
                charOccurrence[arrayChars[i]] = charOccurrence[arrayChars[i]] + 1;
            }
            else
            {
                charOccurrence.Add(arrayChars[i], 1);
            }
        }

        foreach (char c in charOccurrence.Keys)
        {
            Console.WriteLine($"{c}: {charOccurrence[c]}");
        }
    }
}

/*
Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.
*/