Console.WriteLine("Exercise — FizzBuzz");
Console.Write("Enter a number between 1 and 100: ");
int num = int.Parse(Console.ReadLine());

if (num % 3 == 0 && num % 5 == 0)
{
    Console.WriteLine("FizzBuzz");
}
else if (num % 3 == 0)
{
    Console.WriteLine("Fizz");
}
else if (num % 5 == 0)
{
    Console.WriteLine("Buzz");
}
else
{
    Console.WriteLine(num);
}



Console.WriteLine("Exercise : Build a Triangle Pattern");
for (int i = 1; i <= 5; i++)
{
  
    Console.WriteLine(new string('*',i));
}

Console.Write("Enter a word: ");
string word = Console.ReadLine();

string reversed = "";

foreach (char c in word)
{
    reversed = c + reversed;
}

Console.WriteLine(reversed);