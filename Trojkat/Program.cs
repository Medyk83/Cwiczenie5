// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj wysokość trójkąta:");
        int height = int.Parse(Console.ReadLine());

        int maxLength = height * 2 - 1; // Długość najdłuższego wiersza

        for (int row = 1; row <= height; row++)
        {
            int numChars = row * 2 - 1; // Liczba znaków w bieżącym wierszu
            int padding = (maxLength - numChars) / 2; // Liczba spacji na początku wiersza

            string line = new string(' ', padding); // Początkowe spacje

            for (int i = 0; i < numChars; i++)
            {
                line += "+"; // Dodanie znaku "+"
            }

            Console.WriteLine(line);
        }

        Console.ReadLine();
    }
}
