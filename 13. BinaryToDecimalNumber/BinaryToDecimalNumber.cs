using System;

/* Using loops write a program that converts a binary integer number to its decimal form.
 * The input is entered as string. The output should be a variable of type long.\
 * Do not use the built-in .NET functionality.
 */
class BinaryToDecimalNumber
{
    static void Main()
    {
        Console.Write("Enter one binary number: ");
        string binary = Console.ReadLine();
        long number = 0;
        int n = binary.Length;
        for (int i = n - 1; i >= 0; i--)
        {
            if (binary[i] == '1')
            {
                number = number + (long)(Math.Pow(2, (n - i - 1)));
            }
        }
        Console.WriteLine("The number is {0}",number);
    }
}