using System;

// Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].


class RandomNumbersInGivenRange
{
    static void Main()
    {
        Console.Write("Please enter a integer number N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter a integer number Min: ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("Please enter a integer number Max: ");
        int max = int.Parse(Console.ReadLine());
        Random rnd = new Random();
        for (int i = 0; i < n; i++)
        {
            int a = rnd.Next(min,max+1);
            Console.Write("{0} ", a);
        }
        Console.WriteLine();
    }
}