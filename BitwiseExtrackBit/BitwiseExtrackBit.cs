using System;

/*
 * Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
 * 
 * The bits are counted from right to left, starting from bit #0.
 * 
 * The result of the expression should be either 1 or 0.
 * 
 *                  Examples:
 *          
 * n	        binary      representation	    bit #3
 * 5	        00000000        00000101	        0
 * 0	        00000000        00000000	        0
 * 15	        00000000        00001111	        1
 * 5343	        00010100        11011111	        1
 * 62241	    11110011        00100001            0
 * 
 */

class BitwiseExtrackBit
 {
     static void Main()
     {
         int userNum = int.Parse(Console.ReadLine());
         int position = 3;                  //  predefined value of position of wanted bit
         int i = 1;                         //  bit value 0000 0001 for AND operation with mask
         int mask = userNum >> position;    //  mask on the number (shifting with 3) to move the wanted bit to first position

         int wantedBit = (mask) & i;        //  the masked number compared to 0001 with AND (will return 0 if 0-1 and will return 1 if 1-1)

         Console.WriteLine(wantedBit);

         // code below for testing purposes only
         /*
         int testMask = userNum >> p;
         int testMask1 = userNum << p;
         int testMask2 = userNum | p;
         int testMask3 = userNum % p;
         int testMask4 = userNum & p;
         
         Console.WriteLine("{0} {1} {2} {3} {4}", testMask, testMask1, testMask2, testMask3, testMask4);
         */
     }
 }

