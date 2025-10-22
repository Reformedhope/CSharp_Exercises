using System;
/* 
 * Programmer: Stephanie Salzburg, Jonquil Terry, David Segura Aba, Nathan Wenson, Cameron Rickel
 * Date: 10/16/25
 * Purpose: This program collects information from a user regarding national,local, state parks and creates an object with the information.
 * Assignment: Chapter 4 - Programming Exercise 7
 */





namespace GroupExChapter4Ex7Wk7
{
    internal class Class
    {

        //Test method to take user input and call the methods to do calculations
        static void Main(string[] args)
        {
            ParkInformation Park = new ParkInformation();  //Park Object

            Console.WriteLine("Park Name:");
            Park.ParkName = Console.ReadLine();
            while (true)
            {
                Console.WriteLine("Park Type (1:State, 2:National, 3:Local):");
                string typeInput = Console.ReadLine();
                switch (typeInput)
                {
                    case "1":
                        Park.LocationType = "State";
                        break;
                    case "2":
                        Park.LocationType = "National";
                        break;
                    case "3":
                        Park.LocationType = "Local";
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please enter 1, 2, or 3.");
                        continue; 
                }
                break; 
            }


            Console.WriteLine("Facility Fee:");
            Park.FacilityFee = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("How many total employees over the last 12 months::");
            Park.NumEmployees = int.Parse(Console.ReadLine());

            Console.WriteLine("Number of Visitors in the last 12 months:");
            Park.NumVisitors12 = int.Parse(Console.ReadLine());

            Console.WriteLine("Annual Budget:");
            Park.AnnualBudget = Convert.ToDouble(Console.ReadLine());

            Park.FacilitiesAvailable();
           
            Console.WriteLine("\n--- Park Information ---");
            Console.WriteLine(Park.ToString());
            Console.WriteLine("\n------------------------");
           

        }
    }
}
