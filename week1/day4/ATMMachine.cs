// // ATMMachine
using System;
using System.Collections.Generic;

class Program
{
    class Acc
    {
        public string Num;
        public int Pin;
        public double Bal;
        public List<string> Log = new List<string>();
    }

    static void Main()
    {
        var accs = new Dictionary<string, Acc>()
        {
            { "1111", new Acc{ Num="1111", Pin=1234, Bal=1000 } },
            { "2222", new Acc{ Num="2222", Pin=2222, Bal=500 } }
        };

        Console.WriteLine("ATM\n");

        Acc user = null;
        while (user == null)
        {
            Console.Write("Account: ");
            string n = Console.ReadLine();
            Console.Write("PIN: ");
            int p = int.Parse(Console.ReadLine());

            if (accs.ContainsKey(n) && accs[n].Pin == p)
                user = accs[n];
            else
                Console.WriteLine("Wrong info.\n");
        }

        string c = "";
        while (c != "5")
        {
            Console.WriteLine("\n1.Balance  2.Deposit  3.Withdraw  4.History  5.Exit");
            Console.Write("Choice: ");
            c = Console.ReadLine();

            if (c == "1")
            {
                Console.WriteLine($"Balance: {user.Bal}");
            }
            else if (c == "2")
            {
                Console.Write("Amount: ");
                double a = double.Parse(Console.ReadLine());
                user.Bal += a;
                user.Log.Add("+ " + a);
            }
            else if (c == "3")
            {
                Console.Write("Amount: ");
                double w = double.Parse(Console.ReadLine());
                if (w > user.Bal) Console.WriteLine("Not enough.");
                else
                {
                    user.Bal -= w;
                    user.Log.Add("- " + w);
                }
            }
            else if (c == "4")
            {
                Console.WriteLine("History:");
                if (user.Log.Count == 0) Console.WriteLine("No transactions");
                else foreach (var h in user.Log) Console.WriteLine(h);
            }
        }

        Console.WriteLine("\nBye!");
    }
}
