using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Environment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = typeof(Program).Namespace ?? "<null>";
            Console.WriteLine($"NameSpace: {name}");

        }
    }
}
