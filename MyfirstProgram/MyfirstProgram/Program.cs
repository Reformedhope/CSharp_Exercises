//* 
// * Programmer: Stephanie Salzburg
// * Date: 9/4/2025
// * Purpose: a short description about the program
// * Class: CITP 180
// * Assignment: Chapter 1 - Programming Excercise 1 & 6 
// * /

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyfirstProgram
{
    

    internal class Program
    {
        static void Main(string[] args)
        {
            //Problem 1
            Console.WriteLine("Hello world! My Name is Stephanie Salzburg");



            //Problem 6
            //Uses the writeline function to console log  the following strings. 
            //output #1
            Console.WriteLine("Sally sold seashells down by the sea shore");
            Console.WriteLine("\n");
            
            //output #2
            //2 & 3 both use the newline break escape of '\n' to create a new line with the rest of the sentence after it has been placed. 
            Console.WriteLine("Sally sold seashells,\n down by the,\n sea shore");
            Console.WriteLine("\n");

            //output #3
            Console.WriteLine("Sally \nsold \n seashells\n down\n by\n the\n sea\n shore");
            Console.WriteLine("\n");

            //output #4 Just for fun
            Console.WriteLine("Sally \nsold \n \tseashells\n down\n by\n the\n sea\n \tshore");

        }
    }
}
