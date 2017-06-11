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
            Console.WriteLine("Bob's Big Giveaway");
            Console.Write("Choose a door : 1, 2 or 3 :");
            string uservalue = Console.ReadLine();

            if (uservalue == "1")
            {
                string message = "You won a new car !";
                Console.WriteLine(message);
            }
            Console.ReadLine();
        }
    }
}
