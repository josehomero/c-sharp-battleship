﻿using System;

namespace C_sharp_battleship
{
    class Program
    {
        static void Main(string[] args)
        {
            string appName = "C Sharp Battleship";
            string appAuthor = "Homero Rios";

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("{0} by {1}", appName, appAuthor);

            Console.ResetColor();

            Console.WriteLine("Would you like a tutorial?");
            string input = Console.ReadLine();

            if(input == "y")
            {
                Console.WriteLine("you have chosen turorial");
            } else if(input == "n")
            {
                Console.WriteLine("you have chosen not to view the tutorial");
            }
        }
    }
}
