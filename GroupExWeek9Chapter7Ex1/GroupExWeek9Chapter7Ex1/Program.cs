using System;
/* 
 * Programmer: Stephanie Salzburg, Jonquil Terry, David Segura Aba, Nathan Wenson, Cameron Rickel
 * Date: 11/3/2025
 * Purpose: Allows the user to input monthly rainfall into an array by and having a parrall array that it pairs the rainfall with. Displays the report of all the months and rainfall for each month. 
 * Additionally, it shows the average rainfall for the year.
 * Assignment: Chapter 7 - Programming Exercise 1
 */

namespace GroupExWeek9Chapter7Ex1
{
    internal class Rainfall
    {
        
        //Instancating the arrays
        string[] MonthArray = new string[12] { "Jan", "Feb", "Mar", "Apr", "May", "June", "July", "Aug", "Sept", "Oct", "Nov", "Dec" };

        
        double[] RainFallInput = new double[12];

        



        //instructions
        public void InstructionsAndDisplay()
        {
            Console.WriteLine("Let's create a rainfail tracker together.");
            Console.WriteLine("_________________________________________");
            Console.WriteLine("The tracker will display a month and allow you to enter \n the rainfall for said month. \n It will then tally your results together and provide an average.");
        }

        //Method that loops through the rainfallinput length and assigns 12 values to the input array. 
       // Asking the user to input a value checking for valid user input of not empty and confirming it is a double.
        public void UsersRainfallInput()
        {
            for (int i = 0; i < RainFallInput.Length; i++)
            {
                while (true)
                {
                    
                    Console.WriteLine($"Input the rainfall for: {MonthArray[i]}");
                    string rainFall = Console.ReadLine();
                    if (string.IsNullOrEmpty(rainFall))
                    {
                        Console.WriteLine("Empty Input. Try again.");
                        continue;
                    }
                    double RFInput;
                    bool isDouble = double.TryParse(rainFall, out RFInput);
                    if (isDouble)
                    {
                        RainFallInput[i] = RFInput;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You must enter a numberical value. Try again. ");
                        continue;
                    }
                        
                }

            }

        }




        //Method to tally the total rainfall
        public double AverageRainFallCalculation()
        {
            double TotalRainfall = 0;
            
            foreach (double RFV in RainFallInput) 
            {
                TotalRainfall += RFV;
 
            }
            
            double AverageRain = TotalRainfall / 12;
            return AverageRain;
            

        }

        //Prints out the two arrays. Loops through both arrays and displays the values. Additionally,
        //displays the value of the average rainfall
        public void DisplayInformation(double AverageRain)
        {
            Console.WriteLine("Total rain accumulated.");
            Console.WriteLine("________________________\n");
            Console.WriteLine("Month\t\t Rainfall");
            for(int i = 0; i < 12; i++)
            {
                Console.WriteLine($"{MonthArray[i]}\t\t\t{RainFallInput[i]}");
                Console.WriteLine("____________________________");
            }
            Console.WriteLine($"Average rainfall for the year: {AverageRain}");
        }





        //main function to call the methods
        static void Main(string[] args)
        {
            Rainfall r = new Rainfall();
            r.InstructionsAndDisplay();
            r.UsersRainfallInput();
            double average = r.AverageRainFallCalculation();
            r.DisplayInformation(average);

        }
    }
}
