using System;

/*
 * Write an expression that calculates trapezoid's area by given sides a and b and height h.
 * 
 *      Examples:
 *      a	    b	    h	    area
 *      5	    7	    12	    72
 *      2	    1	    33	    49.5
 *      8.5	    4.3	    2.7	    17.28
 *      100	    200	    300	    45000
 *      0.222	0.333	0.555	0.1540125
 *      
 *      formula for area of trapezoid ((a+b)/2)*h
 *      
 */

class Trapezoids
{
    static void Main()
    {
        Console.WriteLine("Enter A side of trapezoid:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter B side:of trapezoid");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter H height of trapezoid:");
        double h = double.Parse(Console.ReadLine());

        double area = ((a + b) / 2) * h;
        // variable for the formula for area of trapezoid (isosceles) in pure mathematical expresion
        
        /*
         *       a + b
         *     ( ----- ) * h 
         *         2       
        */

        Console.WriteLine("The area of the trapezoid is: {0}",area);

    }
}

