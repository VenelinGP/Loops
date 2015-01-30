using System;

/* You are given n integers (given in a single line, separated by a space).
 * Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
 * Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
*/

class OddAndEvenProduct
{
    static void Main()
    {
        Console.Write("Please enter N integers in a single line: ");
        string input = Console.ReadLine();
        string[] split = null;
        split = input.Split(' ');
        int i = 0;
        int productOfOdd = 1;
        int productOfEven = 1;
        foreach (var value in split)
        {
            int temp = int.Parse(split[i]);
            if (i % 2 == 0)
            {
                productOfOdd *= temp;
            }
            else
            {
                productOfEven *= temp;
            }
            i++;
        }
        if (productOfEven == productOfOdd)
        {
            Console.WriteLine("{0} == {1} --> YES", productOfOdd, productOfEven);
        }
        else
        {
            Console.WriteLine("{0} <> {1} --> NO", productOfOdd, productOfEven);
        }
    }
}