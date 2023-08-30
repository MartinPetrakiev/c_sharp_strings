using System;
using System.Text.RegularExpressions;
using System.Globalization;

public class Program
{
    public static void Main()
    {
        string inputDateString = "23.08.2023 23:30:21";
        
        string pattern = @"(\d{2}\.\d{2}\.\d{4})\s(\d{2}:\d{2}:\d{2})";
        MatchCollection matchedDates = Regex.Matches(inputDateString, pattern);
        CultureInfo culture = new CultureInfo("bg-BG");
        
        foreach (Match match in matchedDates)
        {
            if (DateTime.TryParseExact(match.Groups[0].Value, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out DateTime date))
            {
                date = date.AddHours(6);
                date = date.AddMinutes(30);
                string formattedDate = date.ToString("F", culture);
                Console.WriteLine(formattedDate);
            }
            else
            {
                Console.WriteLine("Invalid date or format.");
            }
        }
    }
}

/*
Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.
*/