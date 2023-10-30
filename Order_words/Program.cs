using System;

public class Program
{
    public static void Main()
    {
        string inputString = Console.ReadLine();
        string[] words = inputString.Split(' ');

        Array.Sort(words, (a,b) => String.Compare(a, b));

        foreach (string word in words)
        {
            Console.WriteLine(word);
        }

    }
}

/*
Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
*/