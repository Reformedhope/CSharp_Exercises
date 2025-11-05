using System;
///* 
// * Programmer:Stephanie Salzburg
// * Date:11/4/2025
// * Purpose: A program that creates a blueprint of a course and seats available. Then prints out the information displaying the information from the 3 parallel arrays in two slightly different formats. 
// * Class: CITP 180
// * Assignment: Chapter 7 - Programming Excercise 10
// * /

namespace Assignment7Ex10
{
    internal class Course
    {
       
        //Ready only 
        public string cName { get; }
        public int current { get; }
        public int maximum { get;}

        //Constructor
       public Course(string cName, int current, int maximum)
        {
            this.cName = cName;
            this.current = current;
            this.maximum = maximum;

        }
        //calculates the seats left
        public int SeatsLeft()
        {    

                return maximum - current;

        }

        //to string method to return an objext as a string
        public override string ToString()
        {
            return $"Course Name: {cName}  Currently Taken Seats: {current} Total Seats Available: {maximum} Seats Left: {SeatsLeft()}";
        }


    }
}
