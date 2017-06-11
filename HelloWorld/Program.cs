using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x;
            //int y;
            //x = 7;
            //y = x + 3;
            Console.WriteLine("What is your name?");
            Console.WriteLine("Type your first name:");
            string myFirstName;
            myFirstName = Console.ReadLine();

            Console.WriteLine("What is your Last Name ?");
            Console.WriteLine("Type your Last Name :");

            string myLastName;
            myLastName = Console.ReadLine();
            Console.WriteLine("Hello, " + myFirstName + " " + myLastName );
            Console.ReadLine();
        }
    }
}
