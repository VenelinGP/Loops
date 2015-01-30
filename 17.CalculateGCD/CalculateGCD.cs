using System;

/* Write a program that calculates the greatest common divisor (GCD) of given two integers a and b
 * Use the Euclidean algorithm (find it in Internet).
 */


class CalculateGCD
{
    static void Main()
    {
        Console.WriteLine("Enter 2 integer numbers: ");
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        a = Math.Abs(a);
        b = Math.Abs(b);
        while (a != 0 && b != 0)
        {
            if (a > b)
                a %= b;
            else
                b %= a;
        }

        if (a == 0)
        {
            Console.WriteLine(b);
        }
        else
        {
            Console.WriteLine(a);
        }
    }
}
