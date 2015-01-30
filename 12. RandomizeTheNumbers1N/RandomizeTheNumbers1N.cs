//**************************************************
// NA TAZI ZADACHA OSHTE NE SUM IZMISLIL ALGORITUMA
//**************************************************
using System;
using System.Collections;

// Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.

class RandomizeTheNumbers1N
{
    static void Main()
    {
        Console.Write("Please enter a integer number N: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        Random rnd = new Random();
     /*   for (int i = 1; i <= n; i++)
        {
            arr[i] = i;
        }
        for (int i = 1; i <= n; i++)
        {
            int r = rnd.Next(1,n+1);


            Console.Write((int)arr[r]);
        }
      */
        Console.WriteLine();
    }
}