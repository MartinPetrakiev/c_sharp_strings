using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static int CalculateNumberOfDays(string firstDate, string secondDate)
    {
        string[] firstDateComponents = firstDate.Split('.');
        string[] secondDateComponents = secondDate.Split('.');

        int firstDay = Convert.ToInt32(firstDateComponents[0]);
        int secondDay = Convert.ToInt32(secondDateComponents[0]);
        int firstMonth = Convert.ToInt32(firstDateComponents[1]);
        int secondMonth = Convert.ToInt32(secondDateComponents[1]);
        int firstYear = Convert.ToInt32(firstDateComponents[2]);
        int secondYear = Convert.ToInt32(secondDateComponents[2]);

        DateTime date1 = new DateTime(firstYear, firstMonth, firstDay);
        DateTime date2 = new DateTime(secondYear, secondMonth, secondDay);

        TimeSpan deltaDates;

        if (DateTime.Compare(date1, date2) < 0)
        {
            deltaDates = date2 - date1;
        }
        else
        {
            deltaDates = date1 - date2;
        }

        int distance = deltaDates.Days;

        return distance;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter the first date: ");
        string firstDate = Console.ReadLine();
        Console.Write("Enter the second date: ");
        string secondDate = Console.ReadLine();

        Console.WriteLine("Distance: " + CalculateNumberOfDays(firstDate, secondDate) + " days");
    }
}

/*
Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
*/