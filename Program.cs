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

            Console.WriteLine("Would you like a tutorial? y or n");
            string input = Console.ReadLine();

            while((input != "y") || (input != "n")){
                if ((input != "y") || (input != "n"))
                {
                    Console.WriteLine("Please type in either y or n");
                }
            }

                 if (input == "y")
            {
                Console.WriteLine("you have chosen turorial");
            }
            else if (input == "n")
            {
                Console.WriteLine("you have chosen not to view the tutorial");
            }


        }
    }
}
