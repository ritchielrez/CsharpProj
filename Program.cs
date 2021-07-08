using System;

class Basic
{
    static void Basics()
    {
        string Name = Console.ReadLine();

        Console.WriteLine("Hello, {0}", Name);

    }

    static void Vars()
    {
        double num1, num2, num3;

        Console.Write("Enter a number: ");  
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter another number: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter another number: ");
        num3 = Convert.ToDouble(Console.ReadLine());

        double total = num1 + num2 + num3;

        Console.WriteLine("The average is {0}", total / 3);

    }

    static void Main()
    {
        Console.Title = "BasicApp";

        Console.ForegroundColor = ConsoleColor.Green;

        Basics();
        Vars();
    }
}
