using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        
        if (!int.TryParse(Console.ReadLine(), out int num))
        {
            Console.WriteLine("Invalid input. Please enter an integer.");
            return;
        }

        if (num < 0)
        {
            Console.WriteLine("Factorial not possible for negative numbers.");
            return;
        }

        int fact = 1;
        for (int i = 1; i <= num; i++)
        {
            fact *= i;
        }

        Console.WriteLine("Factorial = " + fact);
    }
}
