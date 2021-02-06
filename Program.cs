using System;

namespace C_sharp_battleship
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                string appName = "C Sharp Battleship";
                string appAuthor = "Homero Rios";
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("{0} by {1}", appName, appAuthor);
                Console.ResetColor();
                Console.WriteLine("Would you like a tutorial? y or n");
                string input = Console.ReadLine();
                while ((input != "y") && (input != "n"))
                {
                    Console.WriteLine("please type in y or n");
                    input = Console.ReadLine();
                }

                if (input == "y")
                {
                    Console.WriteLine("directions: The Game is simple, you will be prompted to select a point on a 10 * 10 grid.The point " +
                        "is made up of an X - value and a Y - value that reprsesents square of the grid... Please see bellow illustration\n");

                    Console.WriteLine("10 - - - - - - - - - -");
                    Console.WriteLine("9  - - - - - - - - - -");
                    Console.WriteLine("8  - - - - - - - - - -");
                    Console.WriteLine("7  - - - - - - - - - -");
                    Console.WriteLine("6  - - - - - - - - - -");
                    Console.WriteLine("5  - - - - - - - - - -");
                    Console.WriteLine("4  - - - - - - - - - -");
                    Console.WriteLine("3  - - - - - - - - - -");
                    Console.WriteLine("2  - - - - - - - - - -");
                    Console.WriteLine("1  - - - - - - - - - -");
                    Console.WriteLine("0  1 2 3 4 5 6 7 8 9 10\n");

                    Console.WriteLine("Once the point is selected you will be promped with a hit or a miss.You will be given a total of 3" +
                        " guesses. if you do not destroy the enemy vessel... You are probably a fit for the 1588 spanish armado and lose " +
                        "the game. However if you annihilate the enenmy which takes up 5 grid spaces you win After which you can gloat " +
                        "to your friends and family, and garner the respect of your peers " +
                        "press any key and let's fire up the boilers and ship off!");

                }
                else if (input == "n")
                {
                    Console.WriteLine("you have chosen not to view the tutorial");
                }

                Console.WriteLine("______________________");
                Console.WriteLine("Are you ready to play? Press y to continue to the game");
                string input2 = Console.ReadLine();
                if (input2 == "y")
                {


                    bool playAgain = true;

                    while (playAgain == true)
                    {

                        int shotsLeft = 8;
                        int shotsLanded = 2;
                        int shotsMissed = 0;


                        Console.Clear();
                        Console.WriteLine("shots remaining = {0}, hits = {1}, Misses = {2}\n", shotsLeft, shotsLanded, shotsMissed);
                        Console.WriteLine("10 - - - - - - - - - -");
                        Console.WriteLine("9  - - - - - - - - - -");
                        Console.WriteLine("8  - - - - - - - - - -");
                        Console.WriteLine("7  - - - - - - - - - -");
                        Console.WriteLine("6  - - - - - - - - - -");
                        Console.WriteLine("5  - - - - - - - - - -");
                        Console.WriteLine("4  - - - - - - - - - -");
                        Console.WriteLine("3  - - - - - - - - - -");
                        Console.WriteLine("2  - - - - - - - - - -");
                        Console.WriteLine("1  - - - - - - - - - -");
                        Console.WriteLine("0  1 2 3 4 5 6 7 8 9 10\n");

                        Console.WriteLine("Choose a number from 0-10 for x axis coordinate:");
                        string xInput = Console.ReadLine();
                        if (xInput != null)
                        {
                            Console.WriteLine("Choose a number from 0-10 for y axis coordinate:");

                        }
                        string yInput = Console.ReadLine();

                        int xAnswer = 6;
                        int yAnswer = 6;

                        if ((Int32.Parse(xInput) == xAnswer) && (Int32.Parse(yInput) == yAnswer))
                        {
                            Console.WriteLine("Direct hit!");
                        }
                        else if ((Int32.Parse(xInput) != xAnswer) && (Int32.Parse(yInput) != yAnswer))
                        {
                            Console.WriteLine("you missed!");
                        }


                        Console.WriteLine("Play again? [y or n]");
                        string answer = Console.ReadLine();

                        if (answer == "n")
                        {
                            playAgain = false;
                        }

                    }
                }
            }


        }
    }
}
