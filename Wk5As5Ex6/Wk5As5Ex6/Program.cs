using System;
using System.Globalization;


///* 
// * Programmer: Stephanie Salzburg
// * Date: 10/09/2025
// * Purpose: Allows the user to enter a single hexadecimal char, converts each to its decimal equivalant and adds them together.  Prints out the hex and the decimal.
// * Class: CITP 180
// * Assignment: Chapter 6 - Programming Excercise 6
// * /

namespace Wk5As5Ex6
{
    internal class Program
    {
        //Fields
        public string UsersChoice;
        public int decimalValue;

        //Feilds holding a specific value.
        public int Counter = 0;

        //Asks the users if they would like to add numbers.
        //while the answer is true number are continue to be added. If the loop is set to false with a no it breaks out and prints the results. 
        public void  AskingUserTocontinue()
        {
           
            while (true)
            {   
                Console.WriteLine("Would you like to add numbers? (yes or no): " );
                UsersChoice = Console.ReadLine();

                if (UsersChoice.ToLower() == "yes")
                {
                    UserInputAndCalculation();
                    
                }
                else if (UsersChoice.ToLower() == "no")
                {
                    DisplayInformation();   
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input. Please enter Yes or No");
                    continue;
                }

            }
            

        }


        public void UserInputAndCalculation()
        { 
            Console.WriteLine("Enter a single hexadecimal character : ");
            string Hex = Console.ReadLine().Trim();        //Reads the users input value and trims any white space and stores in a variable.   
            if (Hex.Length == 1 && int.TryParse(Hex, NumberStyles.HexNumber, null, out decimalValue))// Takes a string and checks the length to make sure the user entered 1 character.
            {                                                                                         //AND telling tryparse to take the string and interprete it as a hexadecimal number instead of a decimal. using the global system library.
                                                                                                      //null is for the current cultures default formatting, it was easier to use then puting in the culture info and cleaner. 
                                                                                                      //lastly converst and outs the decimal value of the hex.
                Console.WriteLine($"Hex: {Hex}  Decimal: {decimalValue}");
            }
            else
            {
                decimalValue = 0; // setting the decimal value too 0 in the case an invalid input is given.
                Console.WriteLine($"Invalid input '{Hex}', using 0 as default.");
            }
            Counter += decimalValue; //incrementing the counter by the value given
        }

      
        public void DisplayInformation()
        {
            Console.WriteLine($"Final total in decimal: {Counter}"); //Prints out the counter toal in addions to the numbers added.
            Console.WriteLine($"Final total in hexadecimal: {Counter:X}"); //Prints out the formats the counter as a hexadecimal string using :X
        }

        //Calls the continue method to confirm if the user wants to continue or not. 
        static void Main(string[] args)
        {
            Program p = new Program();
            p.AskingUserTocontinue();
           

            
        }
    }
}
