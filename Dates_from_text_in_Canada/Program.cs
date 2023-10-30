using System;
using System.Text.RegularExpressions;
using System.Globalization;
                    
public class Program
{
    public static void Main()
    {
        string inputText = "Af asfa sfgsd  10.08.2023, 25.12.2022, and 05.06.2024. Aaasd asf fgh re 29.08.2023 asfag  sa fd.";

        string pattern = @"(\d{2}.\d{2}.\d{4})";

        Regex regex = new Regex(pattern);
        MatchCollection matches = regex.Matches(inputText);

        CultureInfo culture = new CultureInfo("en-CA");

        foreach (Match match in matches)
        {
            if (DateTime.TryParseExact(match.Value, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
            {
                string formattedDate = date.ToString("D", culture); // "D" format - long date pattern
                Console.WriteLine(formattedDate);
            }
        }
    }
}

/*
Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
Display them in the standard date format for Canada.
*/