using System;

/* Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers).
 * The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
 * The card faces should start from 2 to A.
 * Print each card face in its four possible suits: clubs, diamonds, hearts and spades. 
 * Use 2 nested for-loops and a switch-case statement.
 * Note.You may use the suit symbols instead of text.
*/


class PrintADeckOf52Cards
{
    static void Main()
    {
        Console.WriteLine("spade - \u2660, club - \u2663, heart - \u2665, diamond - \u2666  ");
        Console.WriteLine();
        string suit = "";
        for (int i = 0; i < 13; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (j == 0)
                {
                    suit = "\u2660,";
                }
                if (j == 1)
                {
                    suit = "\u2663,";
                }
                if (j == 2)
                {
                    suit = "\u2665,";
                }
                if (j == 3)
                {
                    suit = "\u2666";
                }
                switch (i)
                {
                    case 0:
                        Console.Write(" 2 {0} ", suit);
                        break;
                    case 1:
                        Console.Write(" 3 {0} ", suit);
                        break;
                    case 2:
                        Console.Write(" 4 {0} ", suit);
                        break;
                    case 3:
                        Console.Write(" 5 {0} ", suit);
                        break;
                    case 4:
                        Console.Write(" 6 {0} ", suit);
                        break;
                    case 5:
                        Console.Write(" 7 {0} ", suit);
                        break;
                    case 6:
                        Console.Write(" 8 {0} ", suit);
                        break;
                    case 7:
                        Console.Write(" 9 {0} ", suit);
                        break;
                    case 8:
                        Console.Write("10 {0} ", suit);
                        break;
                    case 9:
                        Console.Write(" J {0} ", suit);
                        break;
                    case 10:
                        Console.Write(" Q {0} ", suit);
                        break;
                    case 11:
                        Console.Write(" K {0} ", suit);
                        break;
                    case 12:
                        Console.Write(" A {0} ", suit);
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine();
        }

    }
}