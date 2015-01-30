using System;

// Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
// Use only one loop. Print the result with 5 digits after the decimal point



class CalculateRow
{
    static void Main()
    {
        Console.Write("Enter a integer number N: ");
        int numberN = int.Parse(Console.ReadLine());;
        Console.Write("Enter a integer number X: ");
        int numberX = int.Parse(Console.ReadLine());
        double sum = 1.0;
        double temp = 0.0;
        double x = Convert.ToDouble(numberX);
        double fact = 1;
        double sqr = 0;
        for (int i = 1; i <= numberN; i++)
        {
            temp = Convert.ToDouble(i);
            fact = fact*temp;
            sqr = Math.Pow(x, temp);
            sum = sum + fact / sqr;
        }
        Console.WriteLine("Sum = {0:F5}",sum);
    }
}

