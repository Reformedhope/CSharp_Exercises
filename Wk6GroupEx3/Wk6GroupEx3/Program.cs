using System;
/* 
 * Programmer: Stephanie Salzburg, Jonquil Terry, David Segura Aba, Nathan Wenson, Cameron Rickel
 * Date: 10/16/25
 * Purpose: This program is a motorway class that is used as documentation for highway roads. It allows you to provide details to make the travel much easier. 
 * Assignment: Chapter 4 - Programming Exercise 3
 */

namespace Wk6GroupEx3
{
    internal class MotorWay
    {
        //Feilds 
        public string HighwayName{ get; set; }
        public string TypeOfStreet { get; set; }
        public string Direction { get; set; }
        public string Surface { get; set; }
        public int NumOfLanes { get; set; }
        public bool Tolls { get; set; }
        public string MaintainedBy { get; set; }


        //Constructor
        public MotorWay(string highwayName, string typeOfStreet, string direction, string surface, int numOfLanes, bool tolls, string maintainedBy)
        {
            HighwayName = highwayName;
            TypeOfStreet = typeOfStreet;
            Direction = direction;
            Surface = surface;
            NumOfLanes = numOfLanes;
            Tolls = tolls;
            MaintainedBy = maintainedBy;
        }

        // empty constructor, properties will be set later.
        public MotorWay()
        {
            
        }



        public void Instructions()
        {
            Console.WriteLine("Lets take down some information about the road you are going to be traveling on so you dont forget it \n");
        }


        //Below are methods that allow the user to input a response that is then stored. 
        //They each have input validation to make sure the proper input was collected. 
        public string GetName()
        {
            while (true)
            {
                Console.WriteLine("What is the name of the highway? ");
                string Name = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(Name))
                {
                    Console.WriteLine("You must type a valid input. Try again");

                }
                else
                {
                    HighwayName = Name;
                    return HighwayName;
                    
                }
            }
        }
        public string GetType()
        {
            while (true)
            {
                Console.WriteLine("What is the type of street (Road, Street, Avenue, Blvd., Lane, etc.): ");
               string  Type = Console.ReadLine().ToLower();
                if (string.IsNullOrWhiteSpace(Type))
                {
                  Console.WriteLine("You must type a valid input. Try again");
                }
                else
                {
                    TypeOfStreet = Type;
                    return TypeOfStreet;

                }
            }
        }
        public string GetDirection()
        {
            while (true)
            {
                Console.WriteLine("What is the direction (E, W, N, S):  ");
               string Direct = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(Direct))
                {
                    Console.WriteLine("You must type a valid input. Try again");

                }
                else
                {
                    Direction = Direct;
                    return Direction;

                }
            }
        }
        public string GetSurface()
        {
            while (true)
            {
                Console.WriteLine("What Kind of Surface is it (blacktop, gravel, sand, concrete)?: ");
                string Surf = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(Surf))
                {
                    Console.WriteLine("You must type a valid input. Try again");

                }
                else
                {
                    Surface = Surf;
                    return Surface;

                }
            }
        }
        public int GetLanes()
        {
            while (true)
            {
                Console.WriteLine("How many lanes does the road have?: ");
                if (!int.TryParse(Console.ReadLine(),  out int Lanes))
                {
                    Console.WriteLine("You must type a valid input. Try again");

                }
                else
                {
                    NumOfLanes = Lanes;
                    return NumOfLanes;

                }
            }
        }



        public  bool  GetTolls()
        {
            while (true)
            {
                Console.WriteLine("Does this road have tolls (true or false) ");
                if (!bool.TryParse(Console.ReadLine(), out bool TollInput))
                {
                    Console.WriteLine("You must type true or false. Try again");

                }
                else
                {
                    Tolls = TollInput;
                    return Tolls;

                }
            }
        }



        public string GetMaintained()
        {
            while (true)
            {
                Console.WriteLine("Who maintanes the highway? ");
                string Maintained = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(Maintained))
                {
                    Console.WriteLine("You must type a valid input. Try again");

                }
                else
                {
                    MaintainedBy = Maintained;
                    return Maintained;

                }
            }
        }
        public override string ToString()
        {
            return $"Highway: {HighwayName}\n" +
                   $"Type: {TypeOfStreet}\n" +
                   $"Direction: {Direction}\n" +
                   $"Surface: {Surface}\n" +
                   $"Number of Lanes: {NumOfLanes}\n" +
                   $"Tolls: {Tolls}\n" +
                   $"Maintained by: {MaintainedBy}\n";
        }


        //The main method uses a while loop that while the response is true it will continue through the loop and asks the questions about the road. 
        //If takes the unput and makes sure it is not null or has white space. 
        //trims the input and puts it to lower.
        //if the user emters no it exits the loop and displays a nice message. 
        static void Main(string[] args)
        {
            MotorWay road = new MotorWay();

            while (true)
            {
                Console.WriteLine("Would you like to input directions? (Yes or No):");
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("You must enter Yes or No.");
                    continue;
                }

                input = input.Trim().ToLower();

                if (input == "yes")
                {
                    road.Instructions();
                    road.GetName();
                    road.GetType();  
                    road.GetDirection();
                    road.GetSurface();
                    road.GetLanes();
                    road.GetTolls();
                    road.GetMaintained();

                    Console.WriteLine("\n--- Highway Information ---\n");
                    Console.WriteLine(road); 
                }
                else if (input == "no")
                {
                    Console.WriteLine("Thank you for inputting directions");
                    break; 
                }
                else
                {
                    Console.WriteLine("Invalid input. Please type Yes or No.");
                }
            }
        }

    
    }
}
