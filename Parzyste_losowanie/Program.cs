// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        int n = 10; // liczba parzystych liczb do wylosowania
        int min = -8;
        int max = 8;

        Random random = new Random();
        int count = 0;
        int i = 0;

        Console.WriteLine("Wylosowane liczby parzyste:");
        while (i < n)
        {
            int number = random.Next(min, max + 1);
            count++;

            if (number % 2 == 0)
            {
                Console.Write(number);

                i++;
                if (i < n)
                {
                    Console.Write(", ");
                }
            }
        }

        Console.WriteLine();
        Console.WriteLine("Liczba rzeczywistych losowań: " + count);
        Console.ReadLine();
    }
}
