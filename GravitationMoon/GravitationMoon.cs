using System;

/*
 * The gravitational field of the Moon is approximately 17% of that on the Earth.
 * Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
 * 
 * Examples:
 * weight	weight on the Moon
 * 86	    14.62
 * 74.6	    12.682
 * 53.7	    9.129 
 */

class GravitationMoon
{
    static void Main()
    {
        Console.WriteLine("Enter your weight and we will give you the best diet EVER!");
        float earthWeight = float.Parse(Console.ReadLine());            // asking for weight and converting it to float number

        float moonWeight = (earthWeight * 17) / 100;                    // 17% from earthWeight

        Console.WriteLine("Became an austronaut and your weight on the Moon will be {1}!!", earthWeight, moonWeight); // calling the results

    }
}

