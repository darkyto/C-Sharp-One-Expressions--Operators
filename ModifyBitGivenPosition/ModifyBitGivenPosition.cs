using System;

/*
 * We are given an integer number n, a bit value v (v=0 or 1) and a position p.
 * Write a sequence of operators (a few lines of C# code) that modifies n to hold
 * the value v at the position p from the binary representation of n while preserving all other bits in n.
 *                              Examples:
        
        n	    binary      representation of n	    p	    v	binary result	        result
        5	    00000000    00000101	            2	    0	00000000 00000001	    1
        0	    00000000    00000000	            9	    1	00000010 00000000	    512
        15	    00000000    00001111	            1	    1	00000000 00001111	    15
        5343	00010100    11011111	            7	    0	00010100 01011111	    5215
        62241	11110011    00100001	            11	    0	11110011 00100001	    62241 
 * 
 */
class ModifyBitGivenPosition
 {
     static void Main(string[] args)
     {
         Console.WriteLine("Pleaase enter N posotive integer number : ");
         int n = int.Parse(Console.ReadLine());
         Console.WriteLine("Please enter P the position of the bit for extration : ");
         int p = int.Parse(Console.ReadLine());
         Console.WriteLine("Please enter V (0/1) for the bit value you want to assing :");
         int v = int.Parse(Console.ReadLine());

         int i = 1;  // 0000 0001 the bit we use later for binary bool check and for mask
         int mask = n >> p;

         int mostWantedBit = (mask & i); //detailed descrition of this and the above operations in program ExtractBitfromInteger

         bool isBitOne = mostWantedBit == 1;
         bool isBitZero = mostWantedBit == 0;


         if (isBitOne && v == 0)                // bit = 1 ; v = 0
         {
             int maskOne = i << p;              // Ok here is the deal
                                                // I ahve used 4 different ways (masks) for modifieng the most wanted bit
             int newNumber = maskOne ^ n;       // using hte boolean isBitOne to see if the bit is 0 or 1 and checking value of v
             Console.WriteLine(newNumber);      // then applying i<<p 0000 0001 and finally using XOR for wanted number
         }
         else if (isBitZero && v == 0)          // bit = 0 ; v = 0
         {
             int maskOne = ~(i << p);           // negative inversion mask 1111 1110 << p
             int newNumber = maskOne & n;       // using binary AND
             Console.WriteLine(newNumber);      // result
         }
         else if (isBitOne && v == 1)           // bit = 1 ; v = 1
         {
             int maskOne = i << p;              // mask 0000 0001 << p
             int newNumber = maskOne | n;       // using binary OR
             Console.WriteLine(newNumber);      //result
         }
         else if (isBitZero && v == 1)          // bit = 0 ; v = 1 
         {
             int maskOne = ~(i << p);           // using negative inversion 
             int newNumber = ~(maskOne ^ n);    // negative inversion XOR 
             Console.WriteLine(newNumber);      //resut
         }

         //          SIMPLER WAY WITH LESS CODE BELOW - comment the above if-else constuction in order for this to work
         //
         //         if (v == 0)
         //         {
         //             int newNumber = ~(1 << p) & n;
         //             Console.WriteLine(newNumber);
         //         }
         //         else if (v == 1)
         //         {  
         //             int newNumber = (1 << p) | n;
         //             Console.WriteLine(newNumber);
         //         }
     }
 }

