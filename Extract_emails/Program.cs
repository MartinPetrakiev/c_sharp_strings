using System;
using System.Text.RegularExpressions;
using System.Net.Mail;
                    
public class Program
{
    public static void Main()
    {
        string text = Console.ReadLine();
        
        string emailPattern = @"(?<identifier>[A-Za-z1-9][A-Za-z1-9-_\.]+[A-Za-z1-9])(@)(?<host>[A-Za-z1-9][A-Za-z1-9-_\.]+[A-Za-z1-9])\.(?<domain>[a-z]{2,})";
        MatchCollection allMatches = Regex.Matches(text, emailPattern);
        
        foreach (Match match in allMatches)
        {
            MailAddress emailAdress;
            bool emailAddressIsValid = MailAddress.TryCreate(match.Value, out emailAdress);
            if (emailAddressIsValid)
            {
                Console.WriteLine(emailAdress);
            }
        }
    }
}

/*
Write a program for extracting all email addresses from given text.
All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails
*/