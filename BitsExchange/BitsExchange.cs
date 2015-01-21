using System;

/*
 * Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
 * 
 *                              Examples:

    n                binary representation of n	                            binary result	                result
 * 
 *                  ***                      ***                    ***                      ***
1140867093	    01000100 00000000 01000000 00010101	            01000010 00000000 01000000 00100101	        1107312677
255406592	    00001111 00111001 00110010 00000000	            00001000 00111001 00110010 00111000	        137966136
4294901775	    11111111 11111111 00000000 00001111	            11111001 11111111 00000000 00111111	        4194238527
5351	        00000000 00000000 00010100 11100111	            00000100 00000000 00010100 11000111	        67114183
2369124121	    10001101 00110101 11110111 00011001	            10001011 00110101 11110111 00101001	        2335569705 


 * * 
 */

class BitsExchange
  {
      static void Main()
       {
          Console.WriteLine("Please enter positive number : ");
          uint num = uint.Parse(Console.ReadLine());

          uint i = 7;                                // 0000 0111 to use for masking the 3-bits groups (3-4-5  and 24-25-26)
                                                     // using mask with three 1s will alllows us to modify 
                                                     // just the sequence of those three bids in group

          uint bitGroupOne = (i << 3) & num;         // extracting first group 3-4-5 with mask 00000111 for case num=5351 bits are 100
          // Console.WriteLine("Bit group one " + Convert.ToString(bitGroupOne, 2).PadLeft(32, '0'));// temp

          uint bitGroupTwo = (i << 24) & num;        // extracting group 24-25-26 with mask 00000111 for case num=5351 bits are 000
  
          uint moveGroupOne = bitGroupOne >> 3;      // now that gave me a lot of headache until i got it...
          uint moveGroupTwo = bitGroupTwo >> 24;     // after extracting the group of bits we want we push them back

          num = (num & ~(i << 3));                   // applying negative inversion to num so we can make space for bitGroupOne and bitGroupTwo
          num = (num & ~(i << 24));                  // modifying group two for the reason above 
         
          num = (num | (moveGroupOne << 24));        // moving the groups to thei new homes - in case 5351 here we move 100
          num = (num | (moveGroupTwo << 3));         // moving the groups to thei new homes   in case 5351 here we have 000

          Console.WriteLine(num);
          Console.WriteLine("Your number in bits " + Convert.ToString(num, 2).PadLeft(32, '0'));

          ////Second variant with less code but harder to understand
           
           
          //uint mask = ((i << 3) | (i << 24));    // creating mask for both goups at once
          //uint groupOne = (num >> 3) & 7 ;       // shifting the three bits and then using binary AND with 00000111
          //uint groupTwo = (num >> 24) & 7;       // shifting the 3-bits (24-25-26) to the start and then binary AND 00000111


          //Console.WriteLine(((groupOne << 24) | (groupTwo << 3)) | (num & (~mask)));  
           
          // // in one operation using negavtive inversion with binary AND num and in the same time binary OR for both
          // // groups of bits so they can arrive to their new homes...

          
      }
  }

