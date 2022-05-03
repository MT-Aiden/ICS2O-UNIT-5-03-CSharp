// Aiden McLeod
// ICS2O-Unit5-03-CSharp
// May 1 2022

using System;

class Program
{
    public static void Main(string[] args)
    {
        string ageGroup;

        void seeEligibleMovieTypes()
        {
            Console.WriteLine("What’s your age group?");
            Console.WriteLine("1 - 17 or over");
            Console.WriteLine("2 - 13 to 16");
            Console.WriteLine("3 - 12 and under");
            ageGroup = Console.ReadLine();
            if (ageGroup == "1")
            {
                Console.WriteLine("\nYou can watch R, PG-13, and G rated movies alone.");
            }
            else if (ageGroup == "2")
            {
                Console.WriteLine("\nYou can watch PG-13 and G rated movies alone.");
            }
            else if (ageGroup == "3")
            {
                Console.WriteLine("\nYou can watch a G rated movies alone.");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Please select a valid response.");
                seeEligibleMovieTypes();
            }
        }

        seeEligibleMovieTypes();
        Console.WriteLine("\nFinished.");
    }
}