using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static string ReplaceHyperlinkTags(string inputString)
    {
        string patternOpeningTag = @"(<a\s+[^>]*href\s*=\s*(?:""(?<url>[^""]*)""|'(?<url>[^']*)')\s*>)";
        MatchCollection matchesOpeningTag = Regex.Matches(inputString, patternOpeningTag, RegexOptions.IgnoreCase);
        foreach (Match match in matchesOpeningTag)
        {
            string replaceString = "[URL=" + match.Groups["url"].Value + "]";
            inputString = inputString.Replace(match.Groups[0].Value, replaceString);
        }

        string patternClosingTag = @"</a>";
        MatchCollection matchesClosingTag = Regex.Matches(inputString, patternClosingTag, RegexOptions.IgnoreCase);
        foreach (Match match in matchesClosingTag)
        {
            string replaceString = "[/URL]";
            inputString = inputString.Replace(match.Groups[0].Value, replaceString);
        }

        return inputString;
    }

    static void Main(string[] args)
    {
        string inputString = Console.ReadLine();

        Console.WriteLine(ReplaceHyperlinkTags(inputString));
    }
}

/*
Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].    
*/