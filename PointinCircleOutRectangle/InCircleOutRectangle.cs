using System;
using System.Drawing;

/*
 * Write an expression that checks for given point (x, y) 
 * if it is within the circle K({1, 1}, 1.5) and out of the 
 * rectangle R(top=1, left=-1, width=6, height=2).
 * 
 *          Examples:
 * 
 *      x	    y	    inside K & outside of R
 *      1	    2	    yes
 *      2.5	    2	    no
 *      0	    1	    no
 *      2.5	    1	    no
 *      2	    0	    no
 *      4	    0	    no
 *      2.5	    1.5	    no
 *      2	    1.5	    yes
 *      1	    2.5	    yes
 *      -100	-100	no
 * 
 * ------------------------------
 * 
 *      circle K({1, 1}, 1.5)
 *      rectangle R(top= 1, left= -1, width= 6, height= 2)
 *      Refer to CircleInPoint task if you need more information on the circle part
 *      here I basicaly addded the rectangle check and visualise the answers
 */

class InCircleOutRectangle
{
    static void Main()
    {

        double radius = 1.5; // circle K({1, 1}, 1.5)
        double hCentre = 1;  // circle K({1, 1}, 1.5)
        double kCentre = 1;  // circle K({1, 1}, 1.5)

        Console.WriteLine("Enter X coordinate");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter Y coordinate");
        double y = double.Parse(Console.ReadLine());

        double dx = x - hCentre;
        double dy = y - kCentre;

        double circle = Math.Pow(dx, 2) + Math.Pow(dy, 2);
        double radiusRaised = radius * radius;
        bool inCircleTrue = circle <= (radiusRaised); //check for the circle complete

        bool checkRectangle = x < -1 || x > 5 || y < -1 || y > 1;  
        //  RECTANGLE check for all that is within the coordinates.
        //  (top= 1, left= -1, width= 6, height= 2) 
        //  means that it starts from -1 to 5 on x coordinates(6 width)
        //  and the lower point is -1 on y coordinate - the highest i 1 (2 height)


        bool areBothOK = (inCircleTrue && checkRectangle); //calling both checks together

        if (areBothOK)
        {
            Console.WriteLine(areBothOK);
        }
        else
        {
            Console.WriteLine("No!");
        }
    }
}

