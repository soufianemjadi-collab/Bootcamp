// // // Exercise 1: Birthday Look-up
// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         var birthdays = new Dictionary<string, string>()
//         {
//             {"Alice", "1999/04/12"},
//             {"Bob", "2001/10/03"},
//             {"Sara", "1995/01/22"},
//             {"David", "2000/12/30"},
//             {"Maya", "1998/06/17"}
//         };

//         Console.WriteLine("Birthday Lookup");
//         Console.Write("Name: ");
//         var name = Console.ReadLine();

//         if (birthdays.TryGetValue(name, out string date))
//             Console.WriteLine($"{name}'s birthday: {date}");
//         else
//             Console.WriteLine("Not found.");
//     }
// }

// // // Exercise 2: Birthdays Advanced
// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         var birthdays = new Dictionary<string, string>()
//         {
//             {"Alice", "1999/04/12"},
//             {"Bob", "2001/10/03"},
//             {"Sara", "1995/01/22"},
//             {"David", "2000/12/30"},
//             {"Maya", "1998/06/17"}
//         };

//         Console.WriteLine("People:");
//         foreach (var name in birthdays.Keys) Console.WriteLine("- " + name);

//         Console.Write("\nWho are you looking for? ");
//         var input = Console.ReadLine();

//         if (birthdays.ContainsKey(input))
//             Console.WriteLine($"{input}: {birthdays[input]}");
//         else
//             Console.WriteLine($"Sorry, no birthday info for {input}.");
//     }
// }
// // // Exercise 3 – Sum Sequence (X + XX + XXX + XXXX)
// using System;

// class Program
// {
//     static int SumSeq(int x)
//     {
//         int total = 0;
//         string s = x.ToString();

//         for (int i = 1; i <= 4; i++)
//             total += int.Parse(new string(s[0], i));

//         return total;
//     }

//     static void Main()
//     {
//         Console.Write("X: ");
//         int x = int.Parse(Console.ReadLine());
//         Console.WriteLine("Result: " + SumSeq(x));
//     }
// }
// // Exercise 4: Double Dice
using System;
using System.Collections.Generic;

class Program
{
    static Random rnd = new Random();

    static int Roll() => rnd.Next(1, 7);

    static int UntilDoubles()
    {
        int tries = 0;
        while (true)
        {
            tries++;
            if (Roll() == Roll()) break;
        }
        return tries;
    }

    static void Main()
    {
        var results = new List<int>();

        for (int i = 0; i < 100; i++)
            results.Add(UntilDoubles());

        int total = 0;
        foreach (var r in results) total += r;

        Console.WriteLine("Total: " + total);
        Console.WriteLine("Average: " + Math.Round(total / 100.0, 2));
    }
}



