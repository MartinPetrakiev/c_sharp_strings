using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void ParseUrl(string url)
    {
        string pattern = @"^(?'protocol'https?):\/\/(?'server'[^\/]+)(?'resource'\/[^?]*)(?'query'\?.*)?$";
        Match match = Regex.Match(url, pattern);

        if (match.Success)
        {
            Console.WriteLine("[protocol] = {0}", match.Groups["protocol"].Value);
            Console.WriteLine("[server] = {0}", match.Groups["server"].Value);
            Console.WriteLine("[resource] = {0}", match.Groups["resource"].Value);

            if (!string.IsNullOrEmpty(match.Groups["query"].Value))
            {
                Console.WriteLine("[query] = {0}", match.Groups["query"].Value);
            }
        }
        else
        {
            Console.WriteLine("Invalid url");
        }
    }

    static void Main(string[] args)
    {
        string url = Console.ReadLine()!;

        ParseUrl(url);
    }
}

/*
Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
*/