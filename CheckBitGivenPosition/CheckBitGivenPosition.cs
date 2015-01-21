using System;

/*
 * 
 * Write a Boolean expression that returns if the bit at position p (counting from 0, 
 * starting from the right) in given integer number n, has value of 1.
 * 
                                         Examples:
            
            n	        binary          representation of n	    p	    bit @ p == 1
            5	        00000000        00000101	            2	        true
            0	        00000000        00000000	            9	        false
            15	        00000000        00001111	            1	        true
            5343	    00010100        11011111	            7	        true
            62241	    11110011        00100001	            11	        false
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

        int mostWantedBit = (mask & i); //detailed descrition of this and the above operations in program ExtractBitfromInteger

        bool isBitOne = mostWantedBit == 1;

        //  if (isBitOne)
        //  {
        //      Console.WriteLine(isBitOne);
        //  }
        //  else
        //  {
        //      Console.WriteLine(isBitOne);
        //  }

        Console.WriteLine(isBitOne ? isBitOne : isBitOne);  //another method for calling the value of the boolen but a bit confusing
    }
}

