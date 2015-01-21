using System;

/*
 * Write an expression that checks if given positive integer number n (n = 100) 
 * is prime (i.e. it is divisible without remainder only to itself and 1).
 * 
 *  Examples:
 * 
 * n	Prime?
 * 1	false
 * 2	true
 * 3	true
 * 4	false
 * 9	false
 * 97	true
 * 51	false
 * -3	false
 * 0	false
 */

class PrimeNumberCheck
{
    static void Main()
    {
        Console.WriteLine("Please enter positive integer number:");
        int userInteger = int.Parse(Console.ReadLine());

        bool isPrime = true;  // we will use this boolen nested inside the loops - where the number is not prime I will use !IsPrime

        if (userInteger < 3)        // starting with the check of all number before 3... 2 is prime and 0 and 1 are technicaly NOT primes                    
        {
            if (userInteger == 2)   // if user number i s2 - PRIME
            {
                Console.WriteLine(isPrime);
                Console.WriteLine("The number {0} is Prime", userInteger);
            }
            else                    // 0 and 1 and all negative values are not primes so it would return false
            {
                Console.WriteLine(!isPrime);
                Console.WriteLine("{0} is NOT a prime number", userInteger);
            }
        }
        else
        {
            if (userInteger % 2 == 0)       // now if the number is equal or larger then 3 we are checkin for all even numbers (which are NOT primes becasue they all divede by two)
            {
                Console.WriteLine(!isPrime);
                Console.WriteLine("{0} is NOT a prime number", userInteger);
            }
            else                                            // after excluding all even nums we are going all in.. 
            {
                int oddNumbers;                             // decalring a variable for the ood numbers
                
                for (oddNumbers = 3; userInteger % oddNumbers !=0; oddNumbers += 2) ; 
                // the loop above is crutial - it start from 3 (after special check).. 
                // and goes until the moment user number divied by current member is not returning remainder.. 
                // that means that we either have a succesful division or we have a PRIME divided by itself
                //      the loot starts from 3 ; 
                //      goes up to userIntereger is divided by oddNumber without remainder ; 
                //      incrediment + 2 to skip all EVEN numbers

                //  NOTE : we can use also
                //  for (oddNumbers = 2; userInteger % oddNumbers !=0; oddNumbers ++)  without the code : if (userInteger % 2 == 0) 
                //  and it will check ALL members including even number but it will be more slow for larger loops
                //  and we will still need a check for 0,1 and negative numbers

                if (oddNumbers == userInteger)  // now the last check - if the division is made by two numbers with equal values.. PRIME
                {
                    Console.WriteLine(isPrime);
                    Console.WriteLine("The number {0} is Prime", userInteger);
                }
                else        // else check when division is made by number other than userNumber - NOT PRIME
                {
                    Console.WriteLine(!isPrime);
                    Console.WriteLine("{0} is NOT a prime number", userInteger);
                }
            }
        }

    }
}

