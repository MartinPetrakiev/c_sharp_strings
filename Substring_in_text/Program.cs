using System;

class Program
{
    static int FindSubstringCountOccurrance(string inputString)
    {
        int indexFound = 0;
        int end = inputString.Length;
        int start = 0;
        int countCharactersToExamine = 0;
        int countSubstringFound = 0;

        while ((start <= end) && (indexFound > -1))
        {
            countCharactersToExamine = end - start;
            indexFound = inputString.IndexOf("in", start, countCharactersToExamine);

            if (indexFound == -1)
            {
                break;
            }

            countSubstringFound++;
            
            start = indexFound + 1;
        }

        return countSubstringFound;
    }

    static void Main(string[] args)
    {
        string inputString = "We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";

        Console.WriteLine(FindSubstringCountOccurrance(inputString));

    }
}

/*

Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).

Example:
The target sub-string is in
The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
The result is: 9

*/