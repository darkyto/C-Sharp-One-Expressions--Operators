using System;

/*
 * Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
 * Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
 * Prints on the console the number in reversed order: dcba (in our example 1102).
 * Puts the last digit in the first position: dabc (in our example 1201).
 * Exchanges the second and the third digits: acbd (in our example 2101).
 * The number has always exactly 4 digits and cannot start with 0.
 * 
 * Examples:
 * 
 * n	sum of digits	reversed	last digit in front	    second and third digits exchanged
 * 2011	    4	        1102	    1201	                2101
 * 3333	    12	        3333	    3333	                3333
 * 9876	    30	        6789	    6987	                9786 
 */

class FourDigitNumber
{
    static void Main()
    {
        Console.WriteLine("Enter four digit number (no zero in leading position) :");

        int fourDigit = int.Parse(Console.ReadLine());

        int pos1 = (fourDigit/ 1000) % 10;
        int pos2 = (fourDigit / 100) % 10;
        int pos3 = (fourDigit /  10) % 10;
        int pos4 = (fourDigit /   1) % 10;

        int sum = pos1 + pos2 + pos3 + pos4;

        
        //Console.WriteLine("test" + fourDigit + "test" + pos1 + "test" + pos2 + "test" + pos3 + "test" + pos4);

        Console.WriteLine("Entered number: {0}", fourDigit);
        Console.WriteLine("Sum of the digits: {0}", sum);
        Console.WriteLine("Reversed number: {3}{2}{1}{0}", pos1, pos2, pos3, pos4);
        Console.WriteLine("Last will be first: {3}{0}{1}{2}", pos1, pos2, pos3, pos4);
        Console.WriteLine("Second and third digits {0}{2}{1}{3}", pos1 , pos2 , pos3, pos4);

    }
}

