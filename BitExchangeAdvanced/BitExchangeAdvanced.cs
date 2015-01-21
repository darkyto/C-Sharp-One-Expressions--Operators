using System;

/*
 * 
 * Write a program that exchanges bits {p, p+1, …, p+k-1}
 * with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
 * The first and the second sequence of bits may not overlap.
 * 
 *                                                              Examples:

    n	        p	    q	    k	    binary representation of n	                        binary result	            result
1140867093	    3	    24	    3	    01000100 00000000 01000000 00010101	    01000010 00000000 01000000 00100101	    1107312677
4294901775	    24	    3	    3	    11111111 11111111 00000000 00001111	    11111001 11111111 00000000 00111111	    4194238527
2369124121	    2	    22	    10	    10001101 00110101 11110111 00011001	    01110001 10110101 11111000 11010001	    1907751121
987654321	    2	    8	    11	                    -	                                     -	                    overlapping
123456789	    26	    0	    7	                    -	                                     -	                    out of range            
33333333333	    -1	    0	    33	                    -	                                     -	                    out of range
 * 
 * 
 */
class BitExchangeAdvanced
{
    static void Main()
    {
        Console.WriteLine("Enter N positive integer number : ");
        long num = long.Parse(Console.ReadLine());
        Console.WriteLine("Enter P (starting position for first group) : ");
        int firstPosition = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Q (starting position for second group) : ");
        int secondPosition = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter K (number of bits in a group) : ");
        int groupLenght = int.Parse(Console.ReadLine());


        if (firstPosition + groupLenght > 32 || secondPosition + groupLenght > 32)
        {
            Console.WriteLine("Out of range!");
            Console.WriteLine();
        }
        else if ((firstPosition < secondPosition) && (firstPosition + groupLenght > secondPosition))
        {
            Console.WriteLine("Overlapping");
            Console.WriteLine();
        }

        else if ((firstPosition + groupLenght == 32) || (secondPosition + groupLenght == 32))
        {

            Console.WriteLine("You are trying to move bit group to the border\n of 32-bit integer and write on the sign bit!");

        }

        else
        {
            for (int i = firstPosition, y = secondPosition, j = groupLenght; (i <= 32 && y <= 32) && j > 1; i++, y++, j-- )
            {

                long bitGroupOne = (j << i) & num;
                long bitGroupTwo = (j << y) & num;

                long moveGroupOne = bitGroupOne >> i;
                long moveGroupTwo = bitGroupTwo >> y;

                num = (num & ~(j << i));
                num = (num & ~(j << y));

                num = (num | (moveGroupOne << y));
                num = (num | (moveGroupTwo << i));

            }

            Console.WriteLine(num);
            Console.WriteLine("Your number in bits " + Convert.ToString(num, 2).PadLeft(32, '0'));
           
            
        }



        // this do not works well inside the loop no matter that it worked well in the previous task..

        /*
                long mask = ((j << i) | (j << y));    // creating mask for both goups at once
                long groupOne = (num >> i) & j;       // shifting the three bits group one
                long groupTwo = (num >> y) & j;       // shifting the 3-bits gropu two 

                num = ((num | (groupTwo << y)) | (num | (groupOne << i))) | (num & (~mask));
        */
    }
}

