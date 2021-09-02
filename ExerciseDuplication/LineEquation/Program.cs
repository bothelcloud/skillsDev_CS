using System;

namespace LineEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Decleration of the variables for the program
            double x1, y1, x2, y2, m, b;

            //Introduction to the program
            Console.Write("Hello and thanks for using line equation generator!\n\n");
            Console.Write("What is the X1 coordinate: ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("What is the Y1 coordinate: ");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("What is the X2 coordinate: ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("What is the Y2 coordinate: ");
            y2 = Convert.ToDouble(Console.ReadLine());

            // Generate the slope of the line
            m = (y2 - y1) / (x2 - x1);

            // Generating the b value for the equation
            b = y1 - (m * x1);

            // Outputting the equation
            Console.WriteLine("\nThe equation for the line is y=" + m + "x+" + b);
        }
    }
}
