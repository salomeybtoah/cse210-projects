using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store the numbers
        List<int> numbers = new List<int>();
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        int userNumber = -1;
        
        // Keep asking for numbers until user enters 0
        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());
            
            // Only add non-zero numbers to the list
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }
        
        // ===== CORE REQUIREMENTS =====
        
        // Calculate sum, average, and max
        int sum = 0;
        int max = int.MinValue;
        int smallestPositive = int.MaxValue;
        
        foreach (int number in numbers)
        {
            // Add to sum
            sum += number;
            
            // Check for new maximum
            if (number > max)
            {
                max = number;
            }
            
            // Check for smallest positive number (stretch challenge)
            if (number > 0 && number < smallestPositive)
            {
                smallestPositive = number;
            }
        }
        
        // Calculate average (cast to double for decimal precision)
        double average = (double)sum / numbers.Count;
        
        // Display core results
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
        
        // ===== STRETCH CHALLENGES =====
        
        // Display smallest positive number
        if (smallestPositive != int.MaxValue)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }
        else
        {
            Console.WriteLine("No positive numbers were entered.");
        }
        
        // Sort and display the list
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}