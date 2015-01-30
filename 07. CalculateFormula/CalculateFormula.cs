using System;
using System.Numerics;
/* In combinatorics, the number of ways to choose k different members out of a group of n different elements 
 * (also known as the number of combinations) is calculated by the following formula
 * For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
 * Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). 
 * Try to use only two loops. 
 */


class CalculateFormula
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
        BigInteger faktNMinusK = 1;
        for (int i = 1; i <= numberN; i++)
        {
            factN = factN * i;
            if (i <= numberK)
            {
                factK = factK * i;
            }
        }
        int NMinusK = numberN - numberK;
        for (int i = 1; i <= NMinusK; i++)
        {
            faktNMinusK = faktNMinusK * i;
        }
        result = factN / (factK*faktNMinusK);
        Console.WriteLine("Result = {0}", result);
    }
}