using System;

/* Using loops write a program that converts an integer number to its binary representation.
 * The input is entered as long. The output should be a variable of type string.
 * Do not use the built-in .NET functionality.
*/

class DecimalToBinaryNumber
{
    static void Main()
    {
        Console.Write("Enter one number: ");
        long number = long.Parse(Console.ReadLine());
        string binary = "";
        do
        {
            if (number % 2 == 1)
            {
                binary = "1"+binary;
            }
            else
            {
                binary = "0"+ binary;
            }
            number = number / 2;
        } while (number > 0);
        Console.WriteLine("The binary presentation is: {0}",binary);
    }
}
