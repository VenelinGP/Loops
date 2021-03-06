﻿using System;

/* Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) 
 * and prints a matrix like in the examples below. Use two nested loops.
 * 
 * Examples:
 * n = 2   matrix      n = 3   matrix      n = 4   matrix
 *         1 2                 1 2 3               1 2 3 4
 *         2 3                 2 3 4               2 3 4 5
 *                             3 4 5               3 4 5 6
 *                                                 4 5 6 7
 */

class MatrixOfNumbers
{
    static void Main()
    {
        int numberN;
        do
        {
            Console.Write("Enter a integer number N (1-20): ");
            numberN = int.Parse(Console.ReadLine()); ;
            if (numberN <= 0)
            {
                Console.WriteLine("N must be greater 0");
            }
            if (numberN > 20)
            {
                Console.WriteLine("N must be smaller 21");
            }
        }
        while ((numberN < 1) || (numberN > 20));
        for (int i = 0; i < numberN; i++)
        {
            for (int j = 1+i; j <= numberN+i; j++)
            {
                Console.Write("{0} ",j);
            }
            Console.WriteLine();
        }
    }
}

