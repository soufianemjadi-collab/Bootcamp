// // Exercise 1: Birthday Look-up
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