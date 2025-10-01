/* 
•  Programmer: Stephanie Salzburg
•  Date: 10/1/2025
•  Purpose: A calculator that allows you to get the radius of a circle the area of a rectangle and the surface area of a cylinder.
•  Class: CITP 180
•  Assignment: Chapter 5 - Programming Exercise 4
*/

using System;

namespace Assignment4Week4
{
    internal class Calculations
    {
        //Calculates the circle radius and has input validation. Uses Math.Pi function from the systems library. 
        public void CicleDimentions()
        {
            double CircleRadiusInput;

            while (true)
            {
                Console.Write("What is the radius of the circle: ");
                if (double.TryParse(Console.ReadLine(), out CircleRadiusInput) && CircleRadiusInput > 0)
                {
                    break; // breaks out of the while loop since the input is valid
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
            }

            double circleArea = Math.PI * Math.Pow(CircleRadiusInput, 2);

            Console.WriteLine($"The area of the circle is: {circleArea:F2}");
        }

        //Calculates the Area of a Rectangle and has input validation.
        public void RectangleDimentions()
        {
            double RectangleLength; 
            double RectangleWidth;
            while (true)
            {

                Console.Write("Enter the length of the rectangle: ");
                if (double.TryParse(Console.ReadLine(), out RectangleLength) && RectangleLength > 0)
                {
                    Console.Write("Enter the width of the rectangle: ");
                    if (double.TryParse(Console.ReadLine(), out RectangleWidth) && RectangleWidth > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input entered.");
                    }
                }


            }
            double RectangleArea = RectangleLength * RectangleWidth;
            Console.WriteLine($"This is the area of a rectangle:{RectangleArea:F2}");

        }
        //Calculates the Surface area of a Cylinder, also has input validation.
        public void CylinderDimentions()
        {
            double CylinderRadius;
            double CylinderHeight;
            while (true)
            {
                Console.Write("What is the radius of the cylinder?");
                if (double.TryParse(Console.ReadLine(), out CylinderRadius) && CylinderRadius > 0){
                    Console.Write("What is the height of the cylinder?");
                    if(double.TryParse(Console.ReadLine(), out CylinderHeight) && CylinderHeight > 0)
                    {
                      break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid inputs");
                    }
                
                
                
                }

            }
            double TwoTimesPi = 2 * Math.PI;
            double PiTimeRadius = TwoTimesPi * CylinderRadius * CylinderHeight;
            double TwoPiTimesPower = TwoTimesPi * Math.Pow(CylinderRadius, 2);
            double SurfaceArea = PiTimeRadius + TwoPiTimesPower;

            Console.WriteLine($"This is the Surface area of a cylinder: {SurfaceArea:F2}");
        }

        // Control Module to ask the user which object they want to get results for as well as a welcome message. 
        static void Main(string[] args)
        {
            

            Console.WriteLine("Welcome to the Dimenstion Calculator");
            Console.WriteLine("Which shape would you like to calulate Dimenstions on? ");
            Console.Write("Enter 1 for Circle, 2 for Rectangle, and 3 for Cylinder: ");


           string UserShapeSelected = Console.ReadLine();

            Calculations c = new Calculations();
            switch (UserShapeSelected)
            {
                case "1":
                    c.CicleDimentions();
                    break;
                case "2":
                    c.RectangleDimentions();
                    break;
                case "3":
                    c.CylinderDimentions();
                    break;
                default:
                    Console.WriteLine("You did not select an option available.");
                    break;
            }

        }


    }

    
}
