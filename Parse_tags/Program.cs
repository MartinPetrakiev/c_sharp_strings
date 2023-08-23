using System;
using System.Text.RegularExpressions;

class Program
{
    static string ParseupcaseTagsIteratively(string inputString)
    {
        int indexOpeningTag = 0;
        int indexClosingTag = 0;
        int end = inputString.Length;
        int start = 0;
        int countCharactersToExamine = 0;

        while ((start <= end) && (indexOpeningTag > -1) && (indexClosingTag > -1))
        {
            countCharactersToExamine = end - start;
            indexOpeningTag = inputString.IndexOf("<upcase>", start, countCharactersToExamine);

            if (indexOpeningTag == -1)
            {
                break;
            }

            start = indexOpeningTag + 8;
            countCharactersToExamine = end - start;

            indexClosingTag = inputString.IndexOf("</upcase>", start, countCharactersToExamine);

            if (indexClosingTag == -1)
            {
                break;
            }

            countCharactersToExamine = indexClosingTag - start;

            string currentSubstring = inputString.Substring(start, indexClosingTag - start);
            string currentSubstringToUpper = currentSubstring.ToUpper();

            inputString = inputString.Replace("<upcase>" + currentSubstring + "</upcase>", "<upcase>" + currentSubstring.ToUpper() + "</upcase>");

            start = indexClosingTag + 9;
        }

        return inputString;
    }

    static string ParseupcaseTagsWithRegex(string inputString)
    {
        string pattern = @"(<upcase>)(?'substring'[\w\s\d]+)(<\/upcase>)";
        MatchCollection matches = Regex.Matches(inputString, pattern, RegexOptions.IgnoreCase);
        foreach (Match match in matches)
        {
            inputString = inputString.Replace(match.Groups["substring"].Value, match.Groups["substring"].Value.ToUpper());
        }

        return inputString;
    }

    static void Main(string[] args)
    {
        string inputString = Console.ReadLine()!;

        Console.WriteLine(ParseupcaseTagsIteratively(inputString));
        Console.WriteLine(ParseupcaseTagsWithRegex(inputString));
    }
}

/*

You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
The tags cannot be nested.
Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.

*/