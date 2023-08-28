using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static string ReverseWordsInSentance(string sentance)
    {
        char sentancePunctuationMark = sentance[sentance.Length - 1];

        char[] spearators = { ',', ' ' };
        string[] words = sentance.Substring(0, sentance.Length - 1).Split(spearators);
        string[] reversedSentanceElements = new string[words.Length];

        int wordsLastIndex = words.Length - 1;
        int currentIndex = 0;

        int[] commaIndices = Enumerable.Range(0, words.Length)
                                       .Where(i => string.IsNullOrEmpty(words[i]))
                                       .ToArray();
                                       
        List<string> wordsList = words.ToList();

        foreach (int commaIndex in commaIndices)
        {
            reversedSentanceElements[commaIndex] = ",";
            wordsList.RemoveAt(commaIndex);
        }
    
        wordsList.Reverse();
        
        int nextWordIndex = 0;
        while (currentIndex < reversedSentanceElements.Length)
        {
            if (!string.IsNullOrEmpty(reversedSentanceElements[currentIndex]))
            {
                currentIndex++;
                continue;
            }
            else
            {
                reversedSentanceElements[currentIndex] = wordsList[nextWordIndex];
            }

            nextWordIndex++;
            currentIndex++;
        }

        string result = "";

        foreach (string word in reversedSentanceElements)
        {
            if (word == ",")
            {
                result += word;
            }
            else
            {
                result += " " + word;
            }
        }

        return result.TrimStart() + sentancePunctuationMark;
    }

    static void Main(string[] args)
    {
        string sentance = Console.ReadLine()!;

        Console.WriteLine(ReverseWordsInSentance(sentance));
    }
}

/*
Write a program that reverses the words in given sentence.

Input
C# is not C++, not PHP and not Delphi!

Output
Delphi not and PHP, not C++ not is C#!  < -------- ONLY WORD POSITIONS ARE REVERSED
*/