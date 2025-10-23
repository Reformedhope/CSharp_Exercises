using System;
///* 
// * Programmer: Stephanie Salzburg
// * Date: 10/22/2025
// * Purpose: Program takes user input for name and sales total. The program then calculates how many federal tax, social security tax, retirement funds, and commision is earned by running through calculations. 
//              The program then out puts the information to the user and displays. 
// * Class: CITP 180
// * Assignment: Chapter 4 - Programming Excercise 8
// * /

namespace EmployeePay
{
    internal class Program
    {



        static void Main(string[] args)
        {
            //variables 
            double tempSalesHolder;
            string enter;
            


           
            //While loop to allow for more object to be created
            while (true) 
            {   
                
                Employee E = new Employee();//Creating an object

                Console.WriteLine("Would you like to enter revenue calculations for an employee?(Y or N): ");
                enter = Console.ReadLine().ToUpper();
                if (enter == "Y")
                {


                    Console.WriteLine("Employee Name");
                    E.Name = Console.ReadLine();


                    while (true) //while loop to get correct input from user for a double input.
                    {
                        Console.WriteLine("Sales amount for the week: ");
                        string input = Console.ReadLine();
                        if (double.TryParse(input, out tempSalesHolder))
                        {
                            E.SalesAmount = tempSalesHolder;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a monetary value.\n");
                        }
                    }
                    //calling the methods in the other calls
                    E.CommisionsIncome();
                    E.GetTaxAmount();
                    E.SocialSecurityWithheld();
                    E.AdditionalDeductions();
                    E.RevenueTotal();

                    //Displays information well formated 
                    Console.WriteLine("--Employee Revenue Data---\n");
                    Console.WriteLine($"Employee Name: {E.Name}\n");
                    Console.WriteLine($"Total Sales: ${E.SalesAmount:F2}\n");
                    Console.WriteLine($"Total Tax Deductions: ${E.FederalTaxAmount:F2}\n");
                    Console.WriteLine($"Retirement Amount: ${E.RetirementAmount:F2}\n");
                    Console.WriteLine($"Social Security Deductions: ${E.SocialSecurityAmount:F2}\n");
                    Console.WriteLine($"Take Home Pay: ${E.TakeHome:F2}");
                }
                else
                {
                    Console.WriteLine("See you again soon.");
                    break;
                }
            }

        }
    }
}
