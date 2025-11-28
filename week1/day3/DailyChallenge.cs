// // DailyChallenge
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Enter a word: ");
        string word = Console.ReadLine();

        var result = new Dictionary<char, List<int>>();

        for (int i = 0; i < word.Length; i++)
        {
            char c = word[i];

            if (!result.ContainsKey(c))
                result[c] = new List<int>();

            result[c].Add(i);
        }

        Console.Write("{ ");
        foreach (var item in result)
            Console.Write($"'{item.Key}': [{string.Join(", ", item.Value)}], ");
        Console.WriteLine("}");
    }
}
