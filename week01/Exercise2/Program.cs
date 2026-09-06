using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask for grade percentage
        Console.Write("Enter your grade percentage: ");
        int grade = int.Parse(Console.ReadLine());

        // ===== PART 1: Print directly in each if/else block =====
        Console.WriteLine("\n--- Part 1: Printing directly ---");
        
        if (grade >= 90)
        {
            Console.WriteLine("A");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("B");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("C");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("D");
        }
        else
        {
            Console.WriteLine("F");
        }

        // ===== PART 2: Refactored to use a variable =====
        Console.WriteLine("\n--- Part 2: Using a variable ---");
        
        // Variables to store results
        string letter = "";
        string sign = "";

        // Determine letter grade
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine sign using last digit (if not an F)
        if (letter != "F")
        {
            int lastDigit = grade % 10;
            
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }

        // Handle special cases: No A+ or F+/F-
        if (letter == "A" && sign == "+")
        {
            sign = "";
        }

        // Display the grade
        Console.WriteLine($"Your grade is: {letter}{sign}");

        // Pass/Fail message
        Console.WriteLine("\n--- Pass/Fail Result ---");
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course!");
        }
        else
        {
            Console.WriteLine("Don't give up! Keep trying for next time.");
        }
    }
}