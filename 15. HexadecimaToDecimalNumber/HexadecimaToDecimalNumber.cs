using System;

/* Using loops write a program that converts a hexadecimal integer number to its decimal form.
 * The input is entered as string. The output should be a variable of type long.
 * Do not use the built-in .NET functionality.
 */

class HexadecimaToDecimalNumber
{
    static void Main()
    {
        Console.Write("Enter one Hex number: ");
        string hex = Console.ReadLine();
        int n = hex.Length;
        long number=0;
        long temp = 0;
        for (int i = hex.Length-1 ; i >= 0; i--)
        {
            if (hex[i] == 'A' || hex[i] == 'a')
            {
                temp = 10;
            }
            else if (hex[i] == 'B' || hex[i] == 'b')
            {
                temp = 11;
            }
            else if (hex[i] == 'C' || hex[i] == 'c')
            {
                temp = 12;
            }
            else if (hex[i] == 'D' || hex[i] == 'd')
            {
                temp = 13;
            }
            else if (hex[i] == 'E' || hex[i] == 'e')
            {
                temp = 14;
            }
            else if (hex[i] == 'F' || hex[i] == 'f')
            {
                temp = 15;
            }
            else
            {
                temp = long.Parse(Convert.ToString(hex[i]));
            }
            number = number + (long)temp * (long)Math.Pow(16, n - i - 1);           
        }
        Console.WriteLine();
        Console.WriteLine(number);
    }
}