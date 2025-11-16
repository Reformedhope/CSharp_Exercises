using System;


namespace Chapter3Exercise1
{
    internal class Program
    {
        private string name;
        private string saying;
        //obtains the users name
        public string UserInput()
        {
            while (true) 
            {
                Console.WriteLine("Please enter your name: ");
                name = Console.ReadLine();
                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("You did not entry your name. Try again.");
                }
                else
                {
                    break;
                }
            }
            return name;
        }
        //obtains the favorite saying
        public string FavoriteSaying()
        {
            while (true)
            {
                Console.WriteLine("Please enter your favorite saying: ");
                saying = Console.ReadLine();
                if (string.IsNullOrEmpty(saying))
                {
                    Console.WriteLine("You did not entry your name. Try again.");
                }
                else
                {
                    break;
                }
            }
            return saying;


        }
        //displays the name and favorite saying
        public void DisplayNameAndSaying()
        {
            Console.WriteLine($"<><><>{name}<><><>\n <><><><>{saying}<><><><>");
        }

        //calls the methods
        static void Main(string[] args)
        {
            Program p = new Program();
            p.UserInput();
            p.FavoriteSaying();
            p.DisplayNameAndSaying();
        }
    }
}
