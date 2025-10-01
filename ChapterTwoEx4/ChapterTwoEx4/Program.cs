///* /
// * Programmer: Stephanie SAlzburg
// * Date: 09/19/2025
// * Purpose: A program that takes an amount and runs through it to find how many of each monetary coin should be returned
// * Class: CITP 180
// * Assignment: Chapter 2 - Programming Excercise 4
// * /

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterTwoEx4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Discriptions of change being provided and change being converted from int to double. 
            Console.WriteLine("Change you provided: ");
            int PocketChangeInDollars = 20;
            double PocketChangeInCents = PocketChangeInDollars / 100.0;
            Console.WriteLine("{0:c}", PocketChangeInCents);
            Console.WriteLine("----------------------");



            //Variables holding the amounts in each ints 
            int Quarters = 25;
            int Dimes = 10;
            int Nickles = 5;
            int Pennies = 1;


            //Variable holding the origional amount that changes based on what is remaining.
            int OriginalCents = PocketChangeInDollars;



            //Logic for quaters for how many quarters are in the amount provided 
            int NumQtrs = PocketChangeInDollars /= Quarters;
            //Logic for what is the remaining amount after the quarters have been divided/if quarters could be divided from origional.
            int RemainingAfterQtrs = OriginalCents % Quarters;




            //Logic for Dimes for how many quarters are in the amount provided 
            int NumDimes = RemainingAfterQtrs / Dimes;
            //Logic for what is the remaining amount after the Dimes have been divided/if Dimes could be divided from origional.
            int RemainingAfterDimes = RemainingAfterQtrs % Dimes;





            //Logic for Nickles for how many quarters are in the amount provided 
            int NumNickles = RemainingAfterDimes / Nickles;
            //Logic for what is the remaining amount after the Nickles have been divided/if Nickles could be divided from origional
            int RemainingAfterNickles = RemainingAfterDimes % Nickles;




            //Logic for Pennies for how many quarters are in the amount provided 
            int NumPennies = RemainingAfterNickles / Pennies;
            //Logic for what is the remaining amount after the Pennies have been divided/if Pennies could be divided from origional
            int RemainingAfterPennies = RemainingAfterNickles % Pennies;




            //Console.WriteLines for printing out each of the amounts of how many qts, dimes, nickles, and pennies you should recieve back.
            Console.WriteLine("Change you should get back if you are just converting to largest values:");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine($"You have {NumQtrs} Quarters");
            Console.WriteLine($"You have {NumDimes} Dimes");
            Console.WriteLine($"You have {NumNickles} Nickles");
            Console.WriteLine($"You have {NumPennies} Pennies");








        }
    }

}
