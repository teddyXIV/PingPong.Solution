using System;
using PingPong.Models;
using PingPong.UserInterfaceModels;

namespace PingPong
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(WelcomeBanner.Welcome);
            Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
            Console.WriteLine("Welcome to Ping Pong!");
            Console.WriteLine("Enter a number, and this program will count up from 1 to your chosen number");
            Console.WriteLine("Numbers divisible by 3 and 5 will be replaced by 'ping-pong'");
            Console.WriteLine("Numbers divisible by 3 will be replaced by 'ping'");
            Console.WriteLine("Numbers divisible by 5 will be replaced by 'pong'");
            Console.WriteLine("Please enter a number, or die.");
            string stringNumber = Console.ReadLine();

            if (!string.IsNullOrEmpty(stringNumber) && int.TryParse(stringNumber, out int userInt))
            {
                PingPongCalc pingPong = new PingPongCalc(userInt);
                List<int> numList = pingPong.CreateListFromUserInt();
                List<object> parsedList = numList.ConvertAll(x => (object)x);

                parsedList = pingPong.DivisibleBy3And5Check(parsedList);
                parsedList = pingPong.DivisibleBy3Check(parsedList);
                parsedList = pingPong.DivisibleBy5Check(parsedList);
                foreach (var item in parsedList)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number");
            }
        }

    }
}

