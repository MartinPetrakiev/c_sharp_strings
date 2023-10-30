using System;
using System.Text.RegularExpressions;

class Program
{
    static string ExtractTitle(string html)
    {
        string pattern = @"<title\b[^>]*>(.*?)</title>";
        Match match = Regex.Match(html, pattern);
        return match.Success ? match.Groups[1].Value.Trim() : "No title available";
    }

    static string ExtractBodyText(string html)
    {
        string result = "No body text available";
        
        string pattern = @"<body\b[^>]*>(.*?)</body>";
        Match match = Regex.Match(html, pattern);
        if (match.Success)
        {
            string bodyContent = match.Groups[1].Value;

            result = Regex.Replace(bodyContent, "<.*?>", string.Empty); 
        }

        return result;
    }

    static void Main()
    {
        string html = "<html><head><title>News</title></head><body><p><a href=\"http://academy.telerik.com\">Telerik Academy</a>aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.</p></body></html>";

        string title = ExtractTitle(html);

        string bodyText = ExtractBodyText(html);

        Console.WriteLine("Title: " + title);
        Console.WriteLine("Text: " + bodyText);
    }
}
