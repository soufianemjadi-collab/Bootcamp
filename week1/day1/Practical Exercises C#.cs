// -------------------------------
        // Exercise 1: Greeting
        // -------------------------------
        Console.WriteLine("Welcome to C# Programming!");
        Console.WriteLine(); // empty line



        // -------------------------------
        // Exercise 2: Personal Info
        // -------------------------------
        string name = "soufiane";  // change if needed
        int age = 28;             // change if needed
        Console.WriteLine("My name is " + name + " and I am " + age + " years old.");
        Console.WriteLine();



        // -------------------------------
        // Exercise 3: Calculator
        // -------------------------------
        int num1 = 10;
        int num2 = 20;
        int sum = num1 + num2;

        Console.WriteLine("The sum of " + num1 + " and " + num2 + " is: " + sum);
        Console.WriteLine();



        // -------------------------------
        // Exercise 4: The Bouncer (If/Else)
        // -------------------------------
        int userAge = 16; // change this value to test both conditions
        if (userAge >= 18)
        {
            Console.WriteLine("Access Granted.");
        }
        else
        {
            Console.WriteLine("Access Denied.");
        }
        Console.WriteLine();



        // -------------------------------
        // Exercise 5: Countdown (Loops)
        // -------------------------------
        int countdown = 10;
        while (countdown >= 1)
        {
            Console.WriteLine(countdown);
            countdown--;  // decrement
        }
        Console.WriteLine("Liftoff!");
        Console.WriteLine();



        // -------------------------------
        // Exercise 6: Repeater (Functions)
        // -------------------------------
        SayHello("Sam");
        SayHello("Youssef");
        SayHello("Amina");
        Console.WriteLine();



        // -------------------------------
        // Exercise 7: Even or Odd?
        // -------------------------------
        for (int i = 1; i <= 10; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine("Number " + i + " is Even");
            }
            else
            {
                Console.WriteLine("Number " + i + " is Odd");
            }
        }
    

    // Function for Exercise 6
    static void SayHello(string name)
    {
        Console.WriteLine("Hello, " + name + "!");
    }
        // -------------------------------
        // Exercise 8: Temperature Converter
        // -------------------------------
        Console.WriteLine("Enter temperature in Celsius: ");
        string celsiusInput = Console.ReadLine();
        double celsius = double.Parse(celsiusInput);
        double fahrenheit = celsius * 9 / 5 + 32;
        Console.WriteLine(celsius + " Celsius is " + fahrenheit + " Fahrenheit.");
        Console.WriteLine();


        // -------------------------------
        // Exercise 9: Number Swapper
        // -------------------------------
        int a = 5;
        int b = 10;
        Console.WriteLine("Before swap: a = " + a + ", b = " + b);
        
        int temp = a;
        a = b;
        b = temp;
        
        Console.WriteLine("After swap: a = " + a + ", b = " + b);
        Console.WriteLine();


        // -------------------------------
        // Exercise 10: Simple Multiplication Table
        // -------------------------------
        Console.WriteLine("Enter a number for multiplication table: ");
        string multinum = Convert.ToInt32(Console.ReadLine());
        
        for (int i = 1; i <= 10; i++)
        {
            int result = multinum * i;
            Console.WriteLine(multinum + " x " + i + " = " + result);
        }