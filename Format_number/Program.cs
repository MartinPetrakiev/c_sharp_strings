using System;
using System.Text;

class Program
{
    static string FormatNumberToDecimal(int inputNumber)
    {
        return string.Format("{0,15:F2}", inputNumber);
    }

    static string FormatNumberToHexadecimal(int inputNumber)
    {

        return string.Format("{0,15:X}", inputNumber);
    }

    static string FormatNumberToPercent(int inputNumber)
    {
        return string.Format("{0,15:F2}", inputNumber * 100);
    }

    static void Main(string[] args)
    {
        int inputNumber = Convert.ToInt32(Console.ReadLine()!);

        Console.WriteLine(FormatNumberToDecimal(inputNumber));
        Console.WriteLine(FormatNumberToHexadecimal(inputNumber));
        Console.WriteLine(FormatNumberToPercent(inputNumber));
    }
}

/*
Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
Format the output aligned right in 15 symbols.
*/