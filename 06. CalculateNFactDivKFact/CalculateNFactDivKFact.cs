using System;
using System.Numerics;

// Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
// Use only one loop.

class CalculateNFactDivKFact
{
    static void Main()
    {
        int numberN;
        int numberK;
        do
        {
            Console.Write("Enter a integer number N (0-100): ");
            numberN = int.Parse(Console.ReadLine()); ;
            Console.Write("Enter a integer number K (0-100): ");
            numberK = int.Parse(Console.ReadLine());
            if (numberK >= numberN)
            {
                Console.WriteLine("N must be greater K!");
            }
        }
        while(numberK >= numberN);
       
        BigInteger result = 1;
        BigInteger factN = 1;
        BigInteger factK = 1;
        for (int i = 1; i <= numberN; i++)
        {
            factN = factN * i;
            if (i <= numberK)
            {
                factK = factK * i;
            }
        }
        result = factN / factK;
        Console.WriteLine("Result = {0}", result);
    }
}