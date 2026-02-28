using System;
using System.Collections.Generic;

namespace COMP003A.Assignment7
{
    class Program
    {
        static void Main(string[] args)
        { //student sore analyzer
            /* Program purpose is to store a collection of students scores 
            allowing user to display values, calculate total, and calculate average*/
            
            //list to store numeric values
            List<int> scores = new List<int> { 80, 72, 95, 87, 79 };

            bool exitProgram = false;
            
            //menu loop
            while (!exitProgram)
            {
                Console.WriteLine("\n1. Display all values");
                Console.WriteLine("2. Show Total");
                Console.WriteLine("3. Show Average");
                Console.WriteLine("4. Exit");
                Console.Write("Enter Choice: ");

                string input = Console.ReadLine();
                int choice = 0;
                
                //try catch for non numeric inputs
                try
                {
                    choice = int.Parse(input);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid numeric input.");
                    continue; 
                }
                //input validation via logic
                if (choice < 1 || choice > 4)
                {
                    Console.WriteLine("Choice outside of valid range");
                }
                else if (choice == 1)
                {
                    Console.WriteLine("\nValues:");
                    foreach (int score in scores)
                    {
                        Console.WriteLine(score);
                    }
                }
                else if (choice == 2)
                {
                    int total = 0;
                    //calc total
                    foreach (int score in scores)
                    {
                        total += score;
                    }
                    Console.WriteLine($"Total: {total}");
                }
                else if (choice == 3)
                {
                    int total = 0;
                    
                    //calc total avg
                    foreach (int score in scores)
                    {
                        total += score;
                    }

                    double average = (double)total / scores.Length;
                    Console.WriteLine($"Average: {average}");
                }
                else if (choice == 4)
            }
        }
    }
}