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
            //Console.WriteLine("Bob's Big Giveaway");
            //Console.Write("Choose a door : 1, 2 or 3 :");
            //string uservalue = Console.ReadLine();
            //string message;

            //if (uservalue == "1")
            //{
            //     message = "You won a new car !";
            //    Console.WriteLine(message);
            //}

            //else if (uservalue == "2")
            //{
            //     message = "You won a new boat !";
            //    Console.WriteLine(message);
            //}
            //else if (uservalue == "3")
            //{
            //     message = "You won a cat !";
            //    Console.WriteLine(message);
            //}

            //else
            //{
            //     message = "Sorry we didnt understand";
            //    Console.WriteLine(message);
            //    message += " You loose";
            //}
            //Console.ReadLine();

            Console.WriteLine("Bob's Big Giveaway");
            Console.Write("Choose a door : 1, 2 or 3 - ");
            string userValue = Console.ReadLine();

            string message = (userValue == "1") ? "boat" : "strand of lint";
            //Console.WriteLine("You won a {0}",message);
            //Console.ReadLine();

            Console.WriteLine("You entered: {0}, therfore you won a {1}",userValue,message);
            Console.ReadLine();
        }
    }
}
