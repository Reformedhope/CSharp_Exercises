using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk5GroupEx9
{
    internal class Program
    {
        //Field Arguements
        public char UserCharacterInput;
        public int UserNumberInput;

        //Method to grab the users character input.
        //The Method continues through a while loop and untill it has a arguement
        //that is met it will continue through the conditions untill one is met or will prompt to try again.
        public void UserInputC()
        {

            while (true)
            {
                Console.Write("Please input a character:\n ");
                if (char.TryParse(Console.ReadLine(), out UserCharacterInput))
                {
                    if (char.IsLetter(UserCharacterInput) || char.IsSymbol(UserCharacterInput) || char.IsPunctuation(UserCharacterInput))//uses the char built in method to confirm if it meets one of the arguements 
                        {                                                                                                                 // if it is a letter/symbol/punctuaction
                        break;
                    }
                     else
                     {
                        Console.WriteLine($"You entered an invalid character {UserCharacterInput}, to help you out were going to switch it to a character that can be used.");
                        UserCharacterInput = '*';
                        break;
                     }

                }
                else
                {
                    Console.WriteLine("Invalid Character or Symbol input, Try again");

                }
               

            }   
        }
        //Method takes in a number from the user. Included proper error handling for unhappy paths such as:
        //input is not a number
        //number is greater then 3
        //loops through the different continues untill one is met. 
        public void UserInputN()
        {
            while (true)
            {
                Console.Write("Please enter the size of the triangle (1–10): \n");
                if (int.TryParse(Console.ReadLine(), out UserNumberInput))
                {
                    if (UserNumberInput <= 10)
                    {
                        Console.WriteLine($"Your Isoscles Trianges has a peak of {UserNumberInput}.");
                        break;   
                    }
                        if(UserNumberInput >= 11)
                        {
                            UserNumberInput = 3;
                            Console.WriteLine("I set your value to 3 since you entered a number greater than 10");
                        break; 
                        }  
                }
                else
                {
                    Console.WriteLine("You didnt enter a numberical value of 3 - 10. We switched it to 3 for you :)");
                    UserNumberInput = 3;
                    break;
          
                }
            }
        }

        //Method to generate the trianges. 
        //First for loop takes an variable as i and argues if it is less then the users input if it is, it increments it to the number.
        //Second loops decriments minus one. Untill it gets back down to 1. 
        public void IsoscelesTriangeGenerator()
        {
            for (int i = 1; i <= UserNumberInput; i++)
            {
                Console.WriteLine(new string(UserCharacterInput, i).PadLeft(UserNumberInput + i - 1));
            }
            for (int i = UserNumberInput - 1; i >= 1; i--)
            {
                Console.WriteLine(new string(UserCharacterInput, i).PadLeft(UserNumberInput + i - 1));
            }



        }
        //The main function controls how things are passed in. 
        //Provides a welcoming message. 
        // Asks the user if they would like to generate a triange. 
            //if yes grabs the users input 
            // calls the generate method
            //prints triange
            //asks if they would like to create another triange. 
      
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Isosceles Triange Generator.\n");
            string Continue = "yes";
            Program p = new Program();
            while (Continue.ToLower() == "yes")
            {   
                Console.Write("Would you like to create a isosceles Triange? ");
                Continue = Console.ReadLine();
                string UserInputLower = Continue.ToLower();
                if (UserInputLower == "yes")
                {
                    p.UserInputC();
                    p.UserInputN();
                    p.IsoscelesTriangeGenerator();
                }
                else if (Continue.ToLower() == "no")
                {
                    Console.WriteLine("Thanks for making Trianges!");
                }
                else
                {
                    Console.WriteLine("Invalid input. ");
                    
                }

            }       
        }   
    }
}
