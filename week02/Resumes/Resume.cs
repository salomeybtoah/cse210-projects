using System;
using System.Collections.Generic;

public class Resume
{
    // Attributes
    public string _name = "";
    public List<Job> _jobs = new List<Job>();
    
    // Method to display the entire resume
    public void Display()
    {
        // Display the person's name
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        
        // Loop through each job in the list and display it
        foreach (Job job in _jobs)
        {
            job.Display(); // This calls the Display method from Job class
        }
    }
}