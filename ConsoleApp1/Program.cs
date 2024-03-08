using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter length of Fibonacci series:");
        string input = Console.ReadLine();
        if (int.TryParse(input, out int length))
        {
            if (length > 0)
            {
                int a = 0, b = 1;
                Console.Write("Fibonacci series: ");
                for (int i = 0; i < length; i++)
                {
                    Console.Write($"{a} ");
                    int temp = a + b;
                    a = b;
                    b = temp;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
}
