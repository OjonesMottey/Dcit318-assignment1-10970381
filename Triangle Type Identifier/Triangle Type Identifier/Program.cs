using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Triangle Type Identifier");
        Console.WriteLine("------------------------");

        // Get input for the three sides
        double side1 = GetSideLength("Enter the length of side 1: ");
        double side2 = GetSideLength("Enter the length of side 2: ");
        double side3 = GetSideLength("Enter the length of side 3: ");

        // Determine and display the triangle type
        string triangleType = IdentifyTriangleType(side1, side2, side3);
        Console.WriteLine("\nThe triangle is " + triangleType + ".");

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }

    static double GetSideLength(string prompt)
    {
        double sideLength;
        while (true)
        {
            Console.Write(prompt);
            if (double.TryParse(Console.ReadLine(), out sideLength) && sideLength > 0)
            {
                return sideLength;
            }
            Console.WriteLine("Invalid input. Please enter a positive number.");
        }
    }

    static string IdentifyTriangleType(double side1, double side2, double side3)
    {
        if (side1 == side2 && side2 == side3)
        {
            return "Equilateral";
        }
        else if (side1 == side2 || side2 == side3 || side1 == side3)
        {
            return "Isosceles";
        }
        else
        {
            return "Scalene";
        }
    }
}