using System;

/*
 * 
Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).
Examples:

    x	    y	    inside
    0	    1	    true
    -2	    0	    true
    -1	    2	    false
    1.5	    -1	    true
    -1.5	-1.5	false
    100	    -30	    false
    0	    0	    true
    0.2	    -0.8	true
    0.9	    -1.93	false
    1	    1.655	true
 */

class PointInCircle
{
    static void Main()
    {
        //      formila for area of circle with coordinates of the centre
        //      (x - h)*(x - h) + (y - k)*(y - k) = r * r  
        //      where x and y are coordinates 
        //      and h.k are the coordinates for the centre of circle (0,0 in this case)
        //      and r is the given radius (2 in this case)
        double radius = 2;
        double hCentre = 0;             // if you need to write a circle with coordinates different from K({0, 0}, 2)
        double kCentre = 0;             // then simply change those three variables - radius and the two coordinates for the centre of circle 

        Console.WriteLine("Enter X coordinate");
        double x = double.Parse(Console.ReadLine());            //asking for X coordinate (converting to double floating number)
        Console.WriteLine("Enter Y coordinate");
        double y = double.Parse(Console.ReadLine());            //asking for Y coordinate (converting to double floating number)

        double dx = x - hCentre;
        double dy = y - kCentre;

        double circle = Math.Pow(dx, 2) + Math.Pow(dy, 2);      //variable circle = area of circle (x - h)*(x - h) + (y - k)*(y - k)
        double diameter = radius * radius;
        bool inCircleTrue = circle <= (diameter);               //last operation checkng if (x - h)*(x - h) + (y - k)*(y - k) = r * r   is TRUE or FALSE

       
        Console.WriteLine(inCircleTrue);

    }
}

