using System;

/*
 *  Write a Boolean expression that checks for given integer 
 *  if it can be divided (without remainder) by 7 and 5 at the same time. 
 *  
 * n	Divided by 7 and 5?
 * 3	    false
 * 0	    false
 * 5	    false
 * 7	    false
 * 35	    true
 * 140	    true
 */

class DivideBySevenAndFive
{
    static void Main()
    {
        int userNumber = int.Parse(Console.ReadLine());                     // reading and converting number to int

        bool divisionTrue = (userNumber % 7 == 0) && (userNumber % 5 ==0);  // bool variable for true of /7 and /5 with no remainder

        Console.WriteLine(divisionTrue);


    }
}

