using System;

/* Using loops write a program that converts an integer number to its hexadecimal representation.
 * The input is entered as long. The output should be a variable of type string.
 * Do not use the built-in .NET functionality.
 */

class DecimalToHexadecimalNumber
{
    static void Main()
    {
        Console.Write("Enter one number: ");
        long number = long.Parse(Console.ReadLine());
        long temp = 0;
        string hex = "";
        do
        {
            temp = number % 16;
            if (temp == 10)
            {
                hex = "A" + hex;
            }
            else if( temp == 11 )
            {
                hex = "B" + hex;
            }
            else if (temp == 12)
            {
                hex = "C" + hex;
            }
            else if (temp == 13)
            {
                hex = "D" + hex;
            }
            else if (temp == 14)
            {
                hex = "E" + hex;
            }
            else if (temp == 15)
            {
                hex = "F" + hex;
            }
            else 
            {
                hex = temp.ToString() + hex;
            }
            number = number / 16;
        } while (number > 0);
        Console.WriteLine("The hex presentation is: {0}", hex);
    }
}