// Challenge 1: Multiples List Generator
// using System;

// class Challenge1
// {
//     static void Main()
//     {
//         Console.Write("Enter a number: ");
//         int number = int.Parse(Console.ReadLine());

//         Console.Write("Enter a length: ");
//         int length = int.Parse(Console.ReadLine());

//         for (int i = 1; i <= length; i++)
//         {
//             Console.Write(number * i + " ");
//         }
//     }
// }


// Challenge 2: Remove Consecutive Duplicate Letters

class Challenge2
{    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        string result = "";

        foreach (char c in input)
        {
            if (result.Length == 0 || c != result[result.Length - 1])
            {
                result += c;
            }
        }
        Console.WriteLine("Result: " + result);
    }
}