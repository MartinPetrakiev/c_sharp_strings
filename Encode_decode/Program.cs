using System;

class Program
{
    static string EncodeDecode(string inputString)
    {
        char[] cipher = GenerateCipher(10);
        char[] inputToChars = inputString.ToCharArray();

        int startIndex = 0;
        foreach (char c in cipher)
        {
            inputToChars[startIndex] = (char)(inputToChars[startIndex] ^ c);
            startIndex++;

            if (startIndex > inputString.Length)
            {
                startIndex = 0;
            }
        }

        return new string(inputToChars);
    }

    static char[] GenerateCipher(int length)
    {
        Random random = new Random();
        char[] result = new char[length];

        for (int i = 0; i < length; ++i)
        {
            int index = random.Next(33, 128);

            result[i] = (char)index;
        }

        return result;
    }

    static void Main(string[] args)
    {
        string inputString = Console.ReadLine();

        Console.WriteLine(EncodeDecode(inputString));

    }
}

/*

Write a program that encodes and decodes a string using a given encryption key (cipher).
The key consists of a sequence of characters.
The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first.

*/