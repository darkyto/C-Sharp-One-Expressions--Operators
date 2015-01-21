using System;

/*
 * 
 * Write an expression that extracts from given integer n the value of given bit at index p.
 *                              
 *                              Examples:

        n	    binary      representation	    p	    bit @ p
        5	    00000000    00000101	        2	    1
        0	    00000000    00000000	        9	    0
        15	    00000000    00001111	        1	    1
        5343	00010100    11011111	        7	    1
        62241	11110011    00100001	        11	    0
 */

class ExtractBitfromInteger
{
    static void Main()
    {
        Console.WriteLine("Pleaase enter N posotive integer number : ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter P the position of the bit for extration : ");
        int p = int.Parse(Console.ReadLine());

        int i = 1;  // 0000 0001 the bit we use later for binary bool check
        int mask = n >> p;

        int mostWantedBit = (mask & i);
        Console.WriteLine("In the number {0} at binary position {1} we have bit {2}", n , p , mostWantedBit);  // the most wanted bit in the known universe is printed

    }
}

