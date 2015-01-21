using System;

/*
 * Write an expression that checks for given integer if its third digit from right-to-left is 7.
 * 
 * Examples:

 * n	Third digit 7?
 * 5	    false
 * 701	    true
 * 9703 	true
 * 877	    false
 * 777877	false
 * 9999799	true
*/
class Third_DigitSeven
{
    static void Main()
    {
        Console.WriteLine("Please enter int data type number:");
        int randomNum = int.Parse(Console.ReadLine());

        bool thirdPos = ((randomNum / 100) % 10 == 7);           //divied by 100 to move the third position to first and then check if there is remainder 7 when divided by 10.

        Console.WriteLine("Is the third digit (right-to-left) the number 7!?");
        Console.WriteLine(thirdPos);                             //if the conditions above are true - true.. if else then false
        
    }
}

