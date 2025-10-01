
/* 
•  Programmer: Jonquil Deandre Terry, Cameron Rickel, Stephanie Salzburg, David Segura Aba, Nathan Wenson
•  Date: 09/30/25
•  Purpose: A BMI Calculator that allows the users to select the type of calulator based on metric or imperial.
•  Class: CITP 180
•  Assignment: Chapter 5 - Programming Exercise 3
*/
using System;
namespace GroupExerciseWeek4
{

    //User input for meters. 
    internal class Metric
    {
        public double UserWeightInputKg;
        public double Meters;
        public double BMIMetric;

        public void GetUserInputMetric()
        {
            Console.Write("What is your weight in Kilograms? ");
            UserWeightInputKg = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your height in meters: ");
            Meters = Convert.ToDouble(Console.ReadLine());

        }

        //Calculates the BMI for metric and runs through the decision tree to print out the string value.
        public void BMICalculatorMetric(double UserWeightInputKg, double Meters)
        {

            BMIMetric = UserWeightInputKg / (Math.Pow(Meters, 2));// Takes the users input for kg, squares meters and then divides them. 

            Console.WriteLine($"Your Metric BMI is: {BMIMetric:F1}");

            if (BMIMetric < 18.5){ 
                Console.WriteLine("Your BMI Metric is: Under Weight");

             }else if (BMIMetric >= 18.5 && BMIMetric <= 24.9){ 
          
             Console.WriteLine("Your BMI Metric is: Normal");

            }else if (BMIMetric >= 25 && BMIMetric <= 29.9)
            {
                Console.WriteLine("Your BMI Metric is:OverWeight");
            }
            else
            {
                Console.WriteLine("Your BMI Metric is: Obese");
            }

        }






    }
    internal class Imperial
    {

        
        public double UserWeightInputImperial;
        public double Feet;
        public double Inches;
        public double TotalInches;
        public double BMIImperial;

        //User input for Imperial. Breaks feet and inches into two input statements to make it easier for the user.
        public void GetUserInputImperial()
        {
            Console.Write("What is your weight in pounds? ");
            UserWeightInputImperial = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your height in feet: ");
            Feet = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your height in inches: ");
            Inches = Convert.ToDouble(Console.ReadLine());

        }
        //Calculates the Imperial BMI and runs through the decision tree and gives them the corrected string value for there BMI. 
        public void BMICalculatorImperial(double UserWeightInputImperial, double Feet, double Inches)
        {
          TotalInches = (Feet * 12) + Inches;// Takes the feet and inches entered multiplys feet by 12 and stores it in a new value. 

          BMIImperial = (UserWeightInputImperial * 703) / Math.Pow(TotalInches, 2); // Takes the weight multiples it by 703 first as well as squares the total inches.Then divides them to get the BMI.


            Console.WriteLine($"Your Imperial BMI is: {BMIImperial:F1}");

            if (BMIImperial < 18.5)
            {
                Console.WriteLine("Your BMI Imperial is: Under Weight");

            }
            else if (BMIImperial >= 18.5 && BMIImperial <= 24.9)
            {

                Console.WriteLine("Your BMI Imperial is: Normal");

            }
            else if (BMIImperial >= 25 && BMIImperial <= 29.9)
            {
                Console.WriteLine("Your BMI Imperial is:OverWeight");
            }
            else
            
                Console.WriteLine("Your BMI Imperial is: Obese");
          


        }





        //Main function that calls out to the classes and methods within them.
        //Runs a choice tree too identify which BMI information the user would like to calculate. 
        static void Main(string[] args)
        {
            
            Imperial i = new Imperial(); //Creating a new object of the Imperial class.
            Metric m = new Metric(); //Creating a new object of the Metric class.


            Console.WriteLine("welcome to the BMI Calculator"); 
            Console.Write("Do you want to calculate your BMI in Imperial or in Metric or Both: ");//Gives printed instructions for selecting the right BMI for the user.
            string UsersBMIOfChoice = Console.ReadLine();
            UsersBMIOfChoice = UsersBMIOfChoice.ToLower();
            if (UsersBMIOfChoice == "imperial")
            {
                i.GetUserInputImperial(); // Calls the input method
                i.BMICalculatorImperial(i.UserWeightInputImperial, i.Feet, i.Inches);//Calls the calculator method for imperial with the neccesary passed values.

            }
            else if (UsersBMIOfChoice == "Metric")
            {
                m.GetUserInputMetric(); // Calls the input for metric method.
                m.BMICalculatorMetric(m.UserWeightInputKg, m.Meters); //Calls the calculator for metric with the neccesary passed values.
            }
            else if (UsersBMIOfChoice == "both") //If the user selects both, then it runs both the metric and imperial input and calulator.
            {
                i.GetUserInputImperial();
                m.GetUserInputMetric();
                m.BMICalculatorMetric(m.UserWeightInputKg, m.Meters);
                i.BMICalculatorImperial(i.UserWeightInputImperial, i.Feet, i.Inches);

            }
            else
                Console.WriteLine("Invalid option, try again.");


        }
    }
}
