using System;

public class Program
{
    static string StringReverse(string inputString)
    {
        char[] charArray = inputString.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    public static void Main()
    {
        string text = Console.ReadLine();
        char[] separators = {' ', ',',':',';','.','!','?','\''};
        string[] wordsInText = text.Split(separators);

        foreach (string word in wordsInText)
        {
            if (word.Length > 1 && word == StringReverse(word))
            {
                Console.WriteLine(word);
            }
        }
    }
}

/*
Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.

civic, radar, level, rotor, kayak, madam, and refer
*/