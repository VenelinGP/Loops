using System;

/* Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the 
 * maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
 * The input starts by the number  n  (alone in a line) followed by  n  lines, each holding an integer number.
 * The output is like in the examples below.
 */

class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        Console.Write("Please enter a positive integer number N= ");
        int n = int.Parse(Console.ReadLine());
        int[] number = new int[n];
        int sum = 0;
        double avg;
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter an integer number: ");
            number[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n-1; i++)
        {
            for (int j = 0; j < n-1; j++)
            {
                if (number[j] > number[j + 1])
                {
                    int temp = number[j + 1];
                    number[j + 1] = number[j];
                    number[j] = temp;
                }
            }
        }
        for (int i = 0; i < n; i++)
			{
                sum += number[i];
			}
        double newSum = Convert.ToDouble(sum);
        avg = newSum / n;
        Console.WriteLine ("Min = {0}",number[0]);
        Console.WriteLine ("Max = {0}",number[n-1]);
        Console.WriteLine ("Sum = {0}",sum);
        Console.WriteLine ("Avg = {0:0.00}",avg);
    }
}