using System;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        string inputString = Console.ReadLine();
        // char[] separators = { ' ', ',', ':', ';', '.', '!', '?', '\'' };
        // string[] words = inputString.Split(separators);

        MatchCollection wordMatches = Regex.Matches(inputString, @"\.*[\w\-'\d\.]+[A-Za-z\d']");
        string[] words = wordMatches.Cast<Match>()
                                    .Select(m => m.Value)
                                    .ToArray();
        IDictionary<string, int> wordOccurrence = new Dictionary<string, int>();

        for (int i = 0; i < words.Length; i++)
        {
            if (wordOccurrence.ContainsKey(words[i]))
            {
                wordOccurrence[words[i]] = wordOccurrence[words[i]] + 1;
            }
            else
            {
                wordOccurrence.Add(words[i], 1);
            }
        }

        foreach (string word in wordOccurrence.Keys)
        {
            Console.WriteLine($"{word}: {wordOccurrence[word]}");
        }
    }
}

/*
Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.
*/