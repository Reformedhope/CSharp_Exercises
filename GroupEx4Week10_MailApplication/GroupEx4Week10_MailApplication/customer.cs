using System;
/*
 * Programmers: Cameron Rickel, Stephanie Salzburg, Jonquil Terry, Nathan Wenson, David Segura Aba
 * Date: 11/14/25
 * Purpose: The purpose of this program is to generate a personalized mailing label. The program asks for first & last name, DOB, Zip, POS date  and combined the information to give the code for the mailing label 
 * Class : CITP 180
 * Assignment: Chapter 8 - Programming Exercise 4
 */

namespace GroupEx4Week10_MailApplication
{
    internal class Customer
    {
        // Arrays to store information
        public string[] firstName = new string[1];
        public string[] lastName = new string[1];
        public int[] BirthMonth = new int[1];
        public int[] BirthDay = new int[1];
        public int[] BirthYear = new int[1];
        public string[] MonthAbbs = new string[1];
        public int[] Zip = new int[1];
        public int[] purchasedSubscriptionMonth = new int[1];
        public string[] SubscriptionMonthAbbs = new string[1];

   
     

        // constructor
        public Customer() { }

        // Method to collect first and last name
        public void CollectNameInput()
        {
            while (true)  
            {
                Console.WriteLine("Please enter your first and last name (Example: Larry Smith):");
                string fullName = Console.ReadLine();
                string[] spaced = fullName.Split(' ');

                if (spaced.Length >= 2)
                {
                    firstName[0] = spaced[0];
                    lastName[0] = spaced[1];
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Enter both first and last name.");
                }
            }
        }
        //obtains the bithdate and splits it into 3 different arrays. 
        public void CollectBirthDate()
        {
            while (true)
            {
                Console.WriteLine("What is your date of birth? (Enter in the format mm/dd/yyyy):");
                string birthdayAcquired = Console.ReadLine();
                string[] date = birthdayAcquired.Split('/');

                if (date.Length == 3 &&
                    int.TryParse(date[0], out int month) &&
                    int.TryParse(date[1], out int day) &&
                    int.TryParse(date[2], out int year))
                {
                    if (month >= 1 && month <= 12 && day >= 1 && day <= 31)
                    {
                        BirthMonth[0] = month;
                        BirthDay[0] = day;
                        BirthYear[0] = year;

                       
                        string[] monthAbbs = { "Jan", "Feb", "Mar", "Apr", "May", "Jun",
                                                "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
                        MonthAbbs[0] = monthAbbs[month - 1];  

                        break; 
                    }
                    else
                    {
                        Console.WriteLine("Invalid month or day. Please enter again.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter date in mm/dd/yyyy format.");
                }
            }
        }
        //collect the zip and then gets the last two then stores it in the array.
        public void CollectZip()
        {
            while (true)
            {
                Console.WriteLine("What is your ZipCode? (Example: 19946)");
                string zipAquired = Console.ReadLine();

                // Check length of zip code and that its numeric
                if (zipAquired.Length == 5 && int.TryParse(zipAquired, out int zip))
                {
                    int lastTwo = zip % 100; 
                    this.Zip[0] = zip;  
                    Console.WriteLine("Last two digits: " + lastTwo);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid ZipCode. Make sure it is 5 digits.");
                }
            }
        }
        public void CollectPurchaseOfSub()
        {
            while (true)
            {
                Console.WriteLine("Enter the month number when you purchased your subscription (1-12):");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int month) && month >= 1 && month <= 12)
                {
                    purchasedSubscriptionMonth[0] = month;
                    string[] monthAbbs = { "Jan", "Feb", "Mar", "Apr", "May", "Jun",
                                    "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
                    SubscriptionMonthAbbs[0] = monthAbbs[month - 1]; 

                    break; 
                }
                else
                {
                    Console.WriteLine("Invalid month. Please enter a number from 1 to 12.");
                }
            }
        }
        public void CustomerCode()
        {
            string CustomerCode = lastName[0];

            int yearTwoDigits = BirthYear[0] % 100;
            CustomerCode += yearTwoDigits.ToString("D2"); 

            int totalChars = firstName[0].Length + lastName[0].Length;
            CustomerCode += totalChars.ToString();

            CustomerCode += SubscriptionMonthAbbs[0];

            int zipLastTwo = Zip[0] % 100;
            CustomerCode += zipLastTwo.ToString("D2"); 

            Console.WriteLine(CustomerCode);
        }



    }
}
