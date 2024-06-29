using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Grade Calculator");
        Console.WriteLine("Enter a numerical grade between 0 and 100:");
        
        string input = Console.ReadLine();
        int grade;
        
        if (int.TryParse(input, out grade))
        {
            if (grade >= 0 && grade <= 100)
            {
                string letterGrade = CalculateGrade(grade);
                Console.WriteLine("Letter Grade: " + letterGrade);
            }
            else
            {
                Console.WriteLine("Error: Grade must be between 0 and 100.");
            }
        }
        else
        {
            Console.WriteLine("Error: Invalid input. Please enter a valid number.");
        }
        
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    static string CalculateGrade(int grade)
    {
        if (grade >= 90)
            return "A";
        else if (grade >= 80)
            return "B";
        else if (grade >= 70)
            return "C";
        else if (grade >= 60)
            return "D";
        else
            return "F";
    }
}