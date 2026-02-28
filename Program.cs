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
                
                
            }
        }
    }
}