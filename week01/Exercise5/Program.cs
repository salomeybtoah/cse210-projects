using System;

class Program
{
    static void Main(string[] args)
    {
        // Call each function in order, saving return values as needed
        
        // 1. Display welcome message
        DisplayWelcome();
        
        // 2. Get user's name
        string userName = PromptUserName();
        
        // 3. Get user's favorite number
        int userNumber = PromptUserNumber();
        
        // 4. Square the number
        int squaredNumber = SquareNumber(userNumber);
        
        // 5. Display the result
        DisplayResult(userName, squaredNumber);
    }
    
    /// <summary>
    /// Displays a welcome message to the user
    /// </summary>
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    
    /// <summary>
    /// Asks the user for their name and returns it
    /// </summary>
    /// <returns>The user's name as a string</returns>
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    
    /// <summary>
    /// Asks the user for their favorite number and returns it
    /// </summary>
    /// <returns>The user's favorite number as an integer</returns>
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    
    /// <summary>
    /// Squares a given number
    /// </summary>
    /// <param name="number">The number to square</param>
    /// <returns>The squared number</returns>
    static int SquareNumber(int number)
    {
        return number * number;
    }
    
    /// <summary>
    /// Displays the user's name and the squared number
    /// </summary>
    /// <param name="name">The user's name</param>
    /// <param name="squaredNumber">The squared number to display</param>
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }
}