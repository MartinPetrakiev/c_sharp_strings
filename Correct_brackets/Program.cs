using System;

class Program
{
    static bool CheckBrackets(string inputString)
    {
        bool IsCorrect;
        Stack<char> stack = new Stack<char>();

        for (int i = 0; i < inputString.Length; i++)
        {
            char currentChar = inputString[i];

            if (currentChar == '(' || currentChar == '[' || currentChar == '{')
            {
                stack.Push(currentChar);
                continue;
            }

            if (stack.Count == 0)
            {
                return false;
            }

            char charFromStack;
            switch (currentChar)
            {
                case ')':
                    charFromStack = stack.Pop();
                    if (charFromStack == '[' || charFromStack == '{')
                    {
                        IsCorrect = false;
                    }
                    break;
                case ']':
                    charFromStack = stack.Pop();
                    if (charFromStack == '(' || charFromStack == '{')
                    {
                        IsCorrect = false;
                    }
                    break;
                case '}':
                    charFromStack = stack.Pop();
                    if (charFromStack == '(' || charFromStack == '[')
                    {
                        IsCorrect = false;
                    }
                    break;
            }
        }
        
        IsCorrect = stack.Count == 0;

        return IsCorrect;
    }

    static void Main(string[] args)
    {
        string inputString = Console.ReadLine()!;

        Console.WriteLine(CheckBrackets(inputString))

    }
}

/*
Write a program to check if in a given expression the brackets are put correctly.
Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).
*/