using System;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    static string CensorForbiddenWords(string inputString, string[] forbiddenWords)
    {
        StringBuilder patternWords = new StringBuilder();
        StringBuilder resultString = new StringBuilder(inputString);

        for (int i = 0; i < forbiddenWords.Length; i++)
        {
            patternWords.Append(forbiddenWords[i]);
            if (i < forbiddenWords.Length - 1)
            {
                patternWords.Append('|');
            }
        }

        string pattern = $@"\b({patternWords.ToString()})\b";
        MatchCollection matchesInString = Regex.Matches(inputString, pattern);
        foreach (Match match in matchesInString)
        {
            string replacementString = new string('*', match.Groups[0].Value.Length);
            resultString.Replace(match.Groups[0].Value, replacementString);
        }

        return resultString.ToString();
    }

    static void Main(string[] args)
    {
        string inputString = Console.ReadLine()!;
        string[] forbiddenWords = { "PHP", "CLR", "Microsoft" };

        Console.WriteLine(CensorForbiddenWords(inputString, forbiddenWords));
    }
}

/*
We are given a string containing a list of forbidden words and a text containing some of these words.
Write a program that replaces the forbidden words with asterisks.

Example text: Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.HI

Forbidden words: PHP, CLR, Microsoft

The expected result: ********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.
*/