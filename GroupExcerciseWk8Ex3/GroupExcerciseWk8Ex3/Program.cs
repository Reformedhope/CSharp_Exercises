using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Programmers: Cameron Rickel,  Jonquil Terry, Nathan Wenson, David Segura Aba
 * Date: 10/29/25
 * Purpose: This Program displays 3 arrays and multiplies the first two and create a new array.
 * Class: CITP 180
 * Assigmnent: Chapter 7 - Programming Exercise 3
 */


namespace GroupExcerciseWk8Ex3
{
    internal class Program
    {
        double[] arrayOne = new double[] { 40, 2, 3, 4, 5, 60, 7, 8, 9 };
        double[] arrayTwo = new double[] { 10, 11, 12, 13, 14, 15, 16,19, 22, 33,44 };
        double[] arrayCombination = new double[10];
        static void Main(string[] args)
        {
            Program p = new Program();
            p.ArrayOneGathering();
            p.ArrayTwoGathering();
            p.CollectingAndMultipling();
            p.DisplayInfo();




        }


        public void ArrayOneGathering()
        {
            for (int i = 0; i < arrayOne.Length; i++)
            {
                Console.WriteLine($"Array Numbers: {arrayOne[i]}");
            }
        }

        //for loop going through the first array
        public void ArrayTwoGathering()
        {
            //for loop going through the second array
            for (int i = 0; i < arrayTwo.Length; i++)
            {
                Console.WriteLine($"Array Nummbers:  {arrayTwo[i]}");
            }
        }

        //multipling the two arrays together
        public void CollectingAndMultipling()
        {

            for (int i = 0; i < 10; i++)
            {
                double firstArray = (i < arrayOne.Length) ? arrayOne[i] : 1;//assigning a new variable to check the length of the array if it not the same legth as the other array then to use 1. 
                double secondArray = (i < arrayTwo.Length) ? arrayTwo[i] : 1;

                arrayCombination[i] = firstArray * secondArray;

            }
            // loops through the combined array and prints out the values. 
            for(int i = 0; i <arrayCombination.Length; i++)
            {
                Console.WriteLine($"Multiplied values: {arrayCombination[i]}");
            }
        }


            public void DisplayInfo()
            {
                int longestLengthArray = Math.Max(arrayOne.Length, Math.Max(arrayTwo.Length, arrayCombination.Length));
                Console.WriteLine($"First Array:\tSecond Array:\tMultiplied Array");

                for (int i = 0; i < longestLengthArray; i++)
                {
                    double firstArray = (i < arrayOne.Length) ? arrayOne[i] : 1;
                    double secondArray = (i < arrayTwo.Length) ? arrayTwo[i] : 1;
                    double thirdCombined = (i < arrayCombination.Length) ? arrayCombination[i] : 1;

                    // Use the temporary variables instead of the arrays directly
                    Console.WriteLine($"\t{firstArray}\t\t{secondArray}\t\t{thirdCombined}");
                }
            }

    }
}
