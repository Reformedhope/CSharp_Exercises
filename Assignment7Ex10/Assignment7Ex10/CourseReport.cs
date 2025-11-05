using System;


namespace Assignment7Ex10
{
    internal class CourseReport 
    {
     

        static void Main(string[] args)
        {
            //3 parallel arrays
            string[] className = { "CS150", "CS250", "CS270", "CS300", "CS350" };
            int[] currentEnrollment = { 180, 21, 9, 4, 20 };
            int[] maximumEnrollment = { 200, 30, 20, 20, 20 };

            //creating an array of Course objects
            Course[] courses = new Course[className.Length];

            // Loops through the indexes and create course objects using data from the arrays, store them in the courses array
            for (int i = 0; i < className.Length; i++)
            {
                courses[i] = new Course(className[i], currentEnrollment[i], maximumEnrollment[i]);
            }
            //loops over courses array and prints the tostring method in the blue print. 
            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine(courses[i].ToString());
                Console.WriteLine("_____________");
            }
        

            //loops through the arrays to print out the arrays in a column. Added to make it look like the example. 
            Console.WriteLine($"Course Name: \tCurrently Taken Seats: \tTotal Seats Available: \t Seats Left: ");
            Console.WriteLine("-------------------------------------------------------------------------------");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{className[i]}\t\t\t{currentEnrollment[i]}\t\t\t{maximumEnrollment[i]}\t\t\t{courses[i].SeatsLeft()}");
            }




        }




    }
}

























//Create Two classes name DataMembers and 