using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excerise_4Chapter3
{


    internal class Program
    {
        public int seconds;
        public int minutes = 0;
        public int hours = 0;
        public int numbers;
        //TimeSpan t = TimeSpan.FromSeconds() ;



        public void CollectUsersSeconds()
        {
            Console.WriteLine("How many seconds do you want to convert?: ");
            int.TryParse(Console.ReadLine(), out seconds);

        }

        public void TurnSecondsIntoHours()
        {
            numbers = numbers % (24 * 3600);
            hours = numbers / 3600;
            ;

        }

        public void TurnsecondsIntoMinute()
        {
            numbers %= 3600;
            minutes = numbers / 60;

        }

        public void RemainingSeconds()
        {
            numbers = numbers % 60;
            seconds = numbers;

        }

        public void Display()
        {
            Console.WriteLine($"Here are the results: Hours: {hours}\n Minutes: {minutes} \n Seconds{seconds}");
        }



        
        static void Main(string[] args )
        {
            Program p = new Program();
            p.CollectUsersSeconds();
            p.TurnSecondsIntoHours();
            p.TurnsecondsIntoMinute();
            p.RemainingSeconds();
            p.Display();
        }
    }
}
