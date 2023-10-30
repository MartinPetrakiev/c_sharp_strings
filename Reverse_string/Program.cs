using System;

class Program
{
    static string ReverseStringRecursively(string inputString)
    {
        if (inputString.Length > 0)
        {
            string lastCharacter = inputString[inputString.Length - 1].ToString();
            string inputStringToPenult = inputString.Substring(0, inputString.Length - 1);

            return lastCharacter + ReverseStringRecursively(inputStringToPenult);
        }

        return inputString;
    }

    static string ReverseStringIteratively(string inputString)
    {
        string reversed = "";

        for (int i = inputString.Length - 1; i >= 0; i--)
        {
            reversed += inputString[i].ToString();
        }

        return reversed;
    }

    static void Main(string[] args)
    {
        string inputString = Console.ReadLine()!;

        string reversedStringRecursivly = ReverseStringRecursively(inputString);
        string reversedStringIterativley = ReverseStringIteratively(inputString);

        Console.WriteLine("Using recursion: " + reversedStringRecursivly);
        Console.WriteLine("Using iteration: " + reversedStringIterativley);

    }
}

/*

Write a program that reads a string, reverses it and prints the result at the console.

*/