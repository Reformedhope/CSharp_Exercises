using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter5Exercise1
{
    internal class Program
    {

        private int dec;

         private void UserInputsDecimal()
        {
            
            
             Console.WriteLine("Please enter a decimal to convert to a roman numeral: ");
             int.TryParse(Console.ReadLine(), out dec);
           
                
            
            

        }
        static void Main(string[] args)
        {

        }
    }
}
