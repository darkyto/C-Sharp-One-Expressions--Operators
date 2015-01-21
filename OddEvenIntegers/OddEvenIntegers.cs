using System;

/*
 * Write an expression that checks if given integer is odd or even.
 * 
 * Examples:
 * n	Odd?
 * 3	true
 * 2	false
 * -2	false
 * -1	true
 * 0	false
 */

class OddEvenIntegers
{
    static void Main()
    {
        int oddOrEven = int.Parse(Console.ReadLine());
        Console.WriteLine("Odd number?");

        bool oddNum = oddOrEven % 2 == 1;

        Console.WriteLine(oddNum ? true : false);


        //additional interactivity and way to make a check with of-else 
        if (oddNum)
        {
            Console.WriteLine("The number {0} is ODD", oddOrEven);
        }
        else if (!oddNum)
        {
            Console.WriteLine("The number {0} is EVEN", oddOrEven);
        }
        

    }
}

