// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static bool IsPrime(int number)
    {
        if (number < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }

    static void Main()
    {
        Console.Write("Podaj wartość n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Pierwsze {n} liczb:");
        Console.ReadLine();

        int count = 0;
        int currentNumber = 2;

        while (count < n)
        {
            if (IsPrime(currentNumber))
            {
                Console.WriteLine(currentNumber);
                count++;
            }

            currentNumber++;

        }
    }
}
