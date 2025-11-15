using System;

///* 
// * Programmer: Stephanie Salzburg
// * Date: 11/15/2025
// * Purpose: Program allows the user to create a 2D array  with as many columns and rows as they want. Adds random numbers to the array. Prints the array and the largest number in the array. 
// * Class: CITP 180
// * Assignment: Chapter 8 - Programming Excercise 6
// * /

namespace Chapter8Ex6TwoDimentionalArray
{
    internal class Program
    {

        private int rows;
        private int columns;
        private int[,] TwoDimensionalArray;

        private Random random = new Random();

        public void ObtainUserInputForTwoDimensionalArraySize()
        {
            while (true)
            {
                Console.WriteLine("Enter the number of rows for the 2D array: ");
                string rowInput = Console.ReadLine();

                Console.WriteLine("Enter the number of columns for the 2D array: ");
                string columnInput = Console.ReadLine();
                //convert string to int and make sure the numbers are greater then 0 if not prompts error 
                if (int.TryParse(rowInput, out rows) &&
                    int.TryParse(columnInput, out columns) &&
                    rows > 0 && columns > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Both values must be positive numbers. Try again.\n");
                }
            }

        }


        //Prints the 2D array
        public void PrintArray()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(TwoDimensionalArray[i, j] + "\t"); 
                }
                Console.WriteLine();
            }
        }


        //fills array with random numbers 
        public void FillArrayWithNumbers()
        {
            TwoDimensionalArray = new int[rows, columns];
            Console.WriteLine($"\nYour array will have {rows} rows and {columns} columns.");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    TwoDimensionalArray[i, j] = random.Next(1, 100);// Puts random numbers in the array
                }
            }
        }
        //Find the largest number by looping through the array and comparing the number with the number held in largestnumber
        public void FindLargestNumbersInArray()
        {
            int largestNumber = TwoDimensionalArray[0, 0];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (TwoDimensionalArray[i,j] > largestNumber)
                    {
                        largestNumber = TwoDimensionalArray[i, j];
                    }
                }
            }
            Console.WriteLine($"\n\nThe largest number in the array is: {largestNumber}") ;



        }


        static void Main(string[] args)
        {
            Program p = new Program();
            p.ObtainUserInputForTwoDimensionalArraySize();
            p.FillArrayWithNumbers();
            p.PrintArray();
            p.FindLargestNumbersInArray();
        }
    }
}
