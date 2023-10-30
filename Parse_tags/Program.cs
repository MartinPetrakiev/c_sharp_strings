using System;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    static string ParseUpcaseTagsIteratively(string inputString)
    {
        int indexOpeningTag = 0;
        int indexClosingTag = 0;
        int currentIndex = 0;

        StringBuilder resultString = new StringBuilder();

        while ((currentIndex <= inputString.Length) && (indexOpeningTag > -1) && (indexClosingTag > -1))
        {
            //Get first index of opening tag
            indexOpeningTag = inputString.IndexOf("<upcase>", currentIndex, StringComparison.OrdinalIgnoreCase);

            //Stop search if no opening tag found and append text to current state
            if (indexOpeningTag == -1)
            {
                resultString.Append(inputString.Substring(currentIndex));
                break;
            }

            //Apend text before opening tag
            resultString.Append(inputString.Substring(currentIndex, indexOpeningTag - currentIndex));

            //Move the current index to first index of text to parse
            currentIndex = indexOpeningTag + 8;

            //Get first index of closing tag
            indexClosingTag = inputString.IndexOf("</upcase>", currentIndex, StringComparison.OrdinalIgnoreCase);
            
            //Stop search if no closing tag found and append text to current state
            if (indexClosingTag == -1)
            {
                resultString.Append(inputString.Substring(indexOpeningTag));
                break;
            }

            //Parse text between tags
            string textInsideTags = inputString.Substring(currentIndex, indexClosingTag - currentIndex);
            resultString.Append(textInsideTags.ToUpper());

            //Move current index to next of closing tag end
            currentIndex = indexClosingTag + 9;
        }

        return resultString.ToString();
    }

    static string ParseUpcaseTagsWithRegex(string inputString)
    {
        string pattern = @"(<upcase>)(?'substring'[\w\s\d]+)(<\/upcase>)";
        MatchCollection matches = Regex.Matches(inputString, pattern, RegexOptions.IgnoreCase);
        foreach (Match match in matches)
        {
            inputString = inputString.Replace(match.Groups[0].Value, match.Groups["substring"].Value.ToUpper());
        }

        return inputString;
    }

    static void Main(string[] args)
    {
        string inputString = Console.ReadLine()!;

        Console.WriteLine(ParseUpcaseTagsIteratively(inputString));
        Console.WriteLine(ParseUpcaseTagsWithRegex(inputString));
    }
}

/*

You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
The tags cannot be nested.
Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.

*/