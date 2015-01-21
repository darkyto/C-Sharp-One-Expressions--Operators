using System;

/*
 * Write an expression that calculates rectangle’s perimeter and area by given width and height.
 * 
 * Examples:
 * width	height	perimeter	area
 * 3	    4	    14	         12
 * 2.5	    3	    11	        7.5
 * 5	    5	    20	         25
 */
class Rectangles
{
    static void Main()
    {
        Console.WriteLine("Please eneter width of the rectangle:");
        float width = float.Parse(Console.ReadLine());
        Console.WriteLine("Please eneter height of the rectangle:");
        float height = float.Parse(Console.ReadLine());

        float perimeter = (width + height) * 2;
        float area = width * height;

        Console.Write("Width is {0}\nHeight is {1}\nPerimeter is {2}\nArea is {3}\n",width , height, perimeter, area);
    }
}
