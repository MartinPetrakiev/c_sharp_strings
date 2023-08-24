using System;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void ExtractSentances(string inputString)
    {
        string[] allSentances = inputString.Split('.');
        StringBuilder extractedSentances = new StringBuilder();
        
        foreach (string sentance in allSentances)
        {
            string pattern = @"\bin\b";
            Match match = Regex.Match(sentance, pattern);

            if (match.Success)
            {
                extractedSentances.Append(sentance.TrimStart() + ". ");
            }
        }

        if (extractedSentances.Length > 0)
        {
            Console.WriteLine(extractedSentances.ToString());
        }
        else
        {
            Console.WriteLine("NO EXTRACTED SENTANCES");
        }
    }

    static void Main(string[] args)
    {
        string inputString = Console.ReadLine();

        ExtractSentances(inputString);
    }
}

/*
Write a program that extracts from a given text all sentences containing a given word.

Example:
The word is: in

The text is: We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all day. We will move out of it in 5 days.
The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.

Consider that the sentences are separated by . and the words – by non-letter symbols.
*/