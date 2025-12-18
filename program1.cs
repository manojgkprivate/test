using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        int fact = 1;

        if (num < 0)
        {
            Console.WriteLine("Factorial not possible.");
        }
        else
        {
            for (int i = 1; i <= num; i++)
            {
                fact *= i;
            }
            Console.WriteLine("Factorial = " + fact);
        }
    }
}
