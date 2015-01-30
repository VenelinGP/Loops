using System;

/*Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix holding
 * the numbers from 1 to n*n in the form of square spiral like in the examples below.
 * 
 * Examples:
 * n = 2   matrix      n = 3   matrix      n = 4   matrix
 *         1 2                 1 2 3               1  2  3  4
 *         4 3                 8 9 4               12 13 14 5
 *                             7 6 5               11 16 15 6
 *                                                 10 9  8  7
 */ 

class SpiralMatrix
{
    static void Main()
    {
        Console.WriteLine("Enter a integer number 1 <= N <= 20: ");
        int num = int.Parse(Console.ReadLine());
        int[,] array = new int[num, num];
        int val = 1;
        int i = 0;
        int j = 0;
        int limitR = num;
        int limitL = -1;
        int limitT = 1;
        int limitB = num;
        do
        {
            // Right
            while (j < limitR)
            {
                array[i,j] = val;
                j++;
                val++;
            }
            limitR--;
            j--;
            i++;
            // Bottom 
            while (i < limitB)
            {
                array[i, j] = val;
                i++;
                val++;
            }
            limitB--;
            i--;
            j--;

           // Left
            while (j > limitL)
            {
                array[i, j] = val;
                j--;
                val++;
            }
            limitL++;
            j++;
            i--;
            // Top
            while (i > limitT)
            {
                array[i, j] = val;
                i--;
                val++;
            }
            limitT++;
           
        } while (val < (num*num)+1);

        for (int k = 0; k < num ; k++)
        {
            for (int l = 0; l < num ; l++)
			{
			    Console.Write("{0:000}  ",array[k,l]); 
			}
            Console.WriteLine();
        }

    }
}
