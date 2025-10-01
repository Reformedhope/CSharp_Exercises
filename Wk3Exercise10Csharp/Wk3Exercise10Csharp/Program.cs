///* 
// * Programmer: Stephanie Salzburg
// * Date: 09/26/2025
// * Purpose: Calulates property tax for the new year
// * Class: CITP 180
// * Assignment: Chapter 3 - Programming Excercise 10
// * /


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk3Exercise10Csharp
{
    internal class Program
    {

        //Feilds
        private double OldPropertyValue;
        private double NewPropertyValue;
        private double DivisionOfValue;
        private double MultiValue;
        private double Subraction;

        private void DisplayHeading()
        {
            Console.WriteLine("You will enter the property value and the program will do the math for how much you owe. ");
            Console.WriteLine("__________________________________________________________________________________________");
                
        
          }


        //Gathers information from the user. 
        private void GetPropertyValue()
        {
            Console.Write("What is your Address?");
            Console.ReadLine();
            Console.Write("What is your propertys prior acessed value? ");
            OldPropertyValue = Convert.ToDouble(Console.ReadLine()); // Converts the oldproperty value to a double and then reads it (prints)
            //Console.WriteLine(Console.ReadLine());
        } 

        //Calculates the property tax by takking the old value multiplying it by the new access value. 
        // Then subracting the examption
        //Then checking to make sure its not 0 - fail safe
        //Then divideing th value by the value and multipling it by 10.03 per 1000.00
        //Then returning that value to be changed to be a variable to hold the taxes amount. 
        private double PropertyCalculations()
        {
            NewPropertyValue = OldPropertyValue * 1.027;
            Subraction = NewPropertyValue - 25000;
            if (Subraction < 0)
                Subraction = 0;
            DivisionOfValue = Subraction / 1000.00;
            MultiValue = DivisionOfValue * 10.03;
            return MultiValue;
        }
        //Displays information
        private void DisplayInformation(double taxes)
        {
            Console.WriteLine("Property Tax Owed");
            Console.WriteLine("_________________");
            Console.WriteLine($"{taxes:C2}");

        }

        //controller method
        static void Main(string[] args)
        {   
            //new object
            Program Prop = new Program();
            
            //calling the methods with the object of the class. 
            Prop.DisplayHeading();
            Prop.GetPropertyValue();
            Prop.PropertyCalculations();

            //Converts the property calulations into a variable to be passed to the display information method.
            double taxes = Prop.PropertyCalculations();
            Prop.DisplayInformation(taxes);



        }
    }
}
