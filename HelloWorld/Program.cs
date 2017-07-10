using System;
using System.Security.Cryptography.X509Certificates;

namespace HelloWorld
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Car myCar = new Car();

    //        myCar.Make = "Oldsmobile";
    //        myCar.Model = "Cutlas Supreme";
    //        myCar.Year = 1986;
    //        myCar.Color = "Silver";

    //        Console.WriteLine("{0} {1} {2} {3}",
    //            myCar.Make,
    //            myCar.Model,
    //            myCar.Year, 
    //            myCar.Color
    //            );
    //        //decimal value = DetermineMarketValue(myCar);
    //        //Console.WriteLine("{0:C}",value);
    //        Console.WriteLine("{0:C}",myCar.DetermineMarketValue());
    //        Console.ReadLine();
    //    }

    //    private static decimal DetermineMarketValue(Car myCar)
    //    {
    //        decimal carValue = 100.0M;

    //        return carValue;
    //    }


    //    //static void Main(string[] args)
    //    //{
    //    //    DateTime myValue =  DateTime.Now;
    //    //    //Console.WriteLine(myValue.ToString());
    //    //    //Console.WriteLine(myValue.ToShortDateString());
    //    //    //Console.WriteLine(myValue.ToShortTimeString());
    //    //    //Console.WriteLine(myValue.ToLongTimeString());
    //    //    //Console.WriteLine(myValue.AddDays(3).ToShortDateString());
    //    //    //Console.WriteLine(myValue.AddHours(3).ToShortDateString());
    //    //    //Console.WriteLine(myValue.AddDays(-3).ToLongDateString());
    //    //    //Console.WriteLine(myValue.Month);

    //    //    //DateTime myBirthday = new DateTime(1989, 01, 05);
    //    //    //Console.WriteLine(myBirthday.ToShortDateString());

    //    //    DateTime myBirhday = DateTime.Parse("01/05/1989");
    //    //    TimeSpan myAge = DateTime.Now.Subtract(myBirhday);
    //    //    Console.WriteLine(myAge.TotalDays);

    //    //        Console.ReadLine();
    //    //}
    //    //static void Main(string[] args)
    //    //{
    //    //    //string myString = "My \"so-called\" life ";
    //    //    //string myString = "What if i need a \nnew Line?";
    //    //    //string myString = "Go to your  c:\\Drive";
    //    //    //string myString = @"Go to your  c:\Drive";

    //    //    //string myString = String.Format("{0} = {1}", "First", "Second");
    //    //    //string myString = string.Format("{0:C}", 123.45);
    //    //    //string myString = string.Format("{0:N}", 1234567890);
    //    //    //string myString = string.Format("Percentage : {0:P}", .123);
    //    //    //string myString = string.Format("Phone Number: {0:(###) ### ####}", 1234567890);

    //    //    //string myString = " That summer we took threes across the board";
    //    //    //myString = myString.Substring(6);

    //    //    StringBuilder myString = new StringBuilder();
    //    //    for (int i = 0; i < 100; i++)
    //    //    {
    //    //        myString.Append("--");
    //    //        myString.Append(i);
    //    //    }

    //    //    Console.WriteLine(myString);
    //    //    Console.ReadLine();
    //    //}
    //    ////static void Main(string[] args)
    //    ////{
    //    ////    bool displayMenu = true;
    //    ////    while (displayMenu)
    //    ////    {
    //    ////       displayMenu = MainMenu();
    //    ////    }
    //    ////}

    //    ////private static bool MainMenu()
    //    ////{
    //    ////    Console.WriteLine("Choose an option:");
    //    ////    Console.WriteLine("1) Option 1");
    //    ////    Console.WriteLine("2) Option 2");
    //    ////    Console.WriteLine("3) Exit");

    //    ////    string result = Console.ReadLine();

    //    ////    if (result == "1")
    //    ////    {
    //    ////        PrintNumbers();
    //    ////        return true;
    //    ////    }
    //    ////    else if (result == "2")
    //    ////    {
    //    ////        GuessingGame();
    //    ////        return true;
    //    ////    }
    //    ////    else if (result == "3")
    //    ////    {
    //    ////        return false;
    //    ////    }
    //    ////    else
    //    ////    {
    //    ////        return true;
    //    ////    }
    //    ////}

    //    ////private static void PrintNumbers()
    //    ////{
    //    ////    Console.WriteLine("Print numbers");
    //    ////    Console.ReadLine();
    //    ////    Console.Write("Type a number: ");
    //    ////    int result = int.Parse(Console.ReadLine());
    //    ////    int counter = 1;
    //    ////    while ( counter < result)
    //    ////    {
    //    ////        Console.Write(counter);
    //    ////        Console.Write("-");
    //    ////        counter++;

    //    ////    }
    //    ////    Console.ReadLine();
    //    ////}

    //    ////private static void GuessingGame()
    //    ////{
    //    ////    Console.Clear();
    //    ////    Console.WriteLine("Guessing Game !");
    //    ////    Console.ReadLine();
    //    ////    Random myRandom = new Random();
    //    ////    int randomNumber = myRandom.Next(1, 11);

    //    ////    int guesses = 0;
    //    ////    bool incorrect = true;

    //    ////    do
    //    ////    {
    //    ////        Console.WriteLine("Guess a number between 1 and 10:");
    //    ////        string result = Console.ReadLine();
    //    ////        guesses++;
    //    ////        if (result == randomNumber.ToString())
    //    ////            incorrect = false;
    //    ////        else
    //    ////        {
    //    ////            Console.WriteLine("Wrong!");
    //    ////        }
    //    ////    } while (incorrect);
    //    ////    Console.WriteLine("Correct! It took you {0} guesses",guesses);
    //    ////}
    //}


    //class Car
    //{
    //    public string Make { get; set; }
    //    public string Model { get; set; }
    //    public int Year { get; set; }
    //    public string Color { get; set; }

    //    public decimal DetermineMarketValue()
    //    {
    //        decimal carValue;
    //        if (Year > 1990)
    //            carValue = 10000;
    //        else
    //        {
    //            carValue = 2000;
    //        }

    //        return carValue;
    //    }
    //}

    class Scrape
    {
        static void Main(string url)
        {
            PublicKey string 
        }
    }
}
