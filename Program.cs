using System;

namespace C_sharp_battleship
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            {
                const string appName = "C Sharp Battleship";
                const string appAuthor = "Homero Rios";
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("{0} by {1}", appName, appAuthor);
                Console.ResetColor();
                Console.WriteLine("Would you like a tutorial? y or n");

                var input = Console.ReadLine();
                while ((input != "y") && (input != "n"))
                {
                    Console.WriteLine("please type in y or n");
                    input = Console.ReadLine();
                }

                switch (input)
                {
                    case "y":
                        Console.WriteLine("directions: The Game is simple, you will be prompted to select a point on a 10 * 10 grid.The point " +
                    "is made up of an X - value and a Y - value that represents square of the grid... Please see bellow illustration\n");

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

                        Console.WriteLine("Once the point is selected you will be prompted with a hit or a miss.You will be given a total of 8" +
                            " guesses. if you do not destroy the enemy vessel... You are probably a fit for the 1588 spanish armada and lose " +
                            "the game. However if you annihilate the enemy which takes up 5 grid spaces you win After which you can gloat " +
                            "to your friends and family, and garner the respect of your peers " +
                            "press any key and let's fire up the boilers and ship off!");

                        break;
                    case "n":
                        Console.WriteLine("you have chosen not to view the tutorial");
                        break;
                }

                Console.WriteLine("______________________");
                Console.WriteLine("Are you ready to play? Press y to continue to the game");
                var input2 = Console.ReadLine();
                if (input2 != "y") return;
                
                var playAgain = true;

                while (playAgain == true)
                {

                    var shotsLeft = 8;
                    var shotsLanded = 0;

                    Console.Clear();
                    Console.WriteLine("shots remaining = {0}, hits = {1}\n", shotsLeft, shotsLanded);
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

                    Random random = new Random();

                    var xAnswer1 = random.Next(0, 10);
                    var yAnswer1 = random.Next(0, 10);

                    var xAnswer2 = random.Next(0, 10);
                    var yAnswer2 = random.Next(0, 10);

                    var xAnswer3 = random.Next(0, 10);
                    var yAnswer3 = random.Next(0, 10);

                    var xAnswer4 = random.Next(0, 10);
                    var yAnswer4 = random.Next(0, 10);

                    var xAnswer5 = random.Next(0, 10);
                    var yAnswer5 = random.Next(0, 10);

                    while ((shotsLeft > 0) && (shotsLanded < 5))
                    {

                        Console.WriteLine("Choose a number from 0-10 for x axis coordinate:");
                        var xInput = Console.ReadLine();

                        var isNumeric = int.TryParse(xInput, out _);

                        while (isNumeric == false)
                        {
                            Console.WriteLine("Please choose a numeric value between 0-10");
                            xInput = Console.ReadLine();
                            isNumeric = int.TryParse(xInput, out _);
                        }

                        if (xInput != null)
                        {
                            Console.WriteLine("Choose a number from 0-10 for y axis coordinate:");
                        }

                        var yInput = Console.ReadLine();
                        var isNumericY = int.TryParse(yInput, out _);

                        while (isNumericY == false)
                        {
                            Console.WriteLine("Please choose a numeric value between 0-10");
                            yInput = Console.ReadLine();
                            isNumericY = int.TryParse(yInput, out _);
                        }


                        if ((Int32.Parse(xInput) == xAnswer1) && (Int32.Parse(yInput) == yAnswer1))
                        {
                            --shotsLeft;
                            ++shotsLanded;

                            Console.WriteLine("shots remaining = {0}, hits = {1}\n", shotsLeft, shotsLanded);

                            Console.WriteLine("Direct hit!");
                        }
                        else if ((Int32.Parse(xInput) == xAnswer2) && (Int32.Parse(yInput) == yAnswer2))
                        {
                            --shotsLeft;
                            ++shotsLanded;

                            Console.WriteLine("shots remaining = {0}, hits = {1}\n", shotsLeft, shotsLanded);

                            Console.WriteLine("Direct hit!");
                        }
                        else if ((Int32.Parse(xInput) == xAnswer3) && (Int32.Parse(yInput) == yAnswer3))
                        {
                            --shotsLeft;
                            ++shotsLanded;

                            Console.WriteLine("shots remaining = {0}, hits = {1}\n", shotsLeft, shotsLanded);

                            Console.WriteLine("Direct hit!");
                        }
                        else if ((Int32.Parse(xInput) == xAnswer4) && (Int32.Parse(yInput) == yAnswer4))
                        {
                            --shotsLeft;
                            ++shotsLanded;

                            Console.WriteLine("shots remaining = {0}, hits = {1}\n", shotsLeft, shotsLanded);

                            Console.WriteLine("Direct hit!");
                        }
                        else if ((Int32.Parse(xInput) == xAnswer5) && (Int32.Parse(yInput) == yAnswer5))
                        {
                            --shotsLeft;
                            ++shotsLanded;

                            Console.WriteLine("shots remaining = {0}, hits = {1}\n", shotsLeft, shotsLanded);

                            Console.WriteLine("Direct hit!");
                        }

                        else
                        {
                            --shotsLeft;

                            Console.WriteLine("shots remaining = {0}, hits = {1}\n", shotsLeft, shotsLanded);

                            Console.WriteLine("you missed!");
                        }

                    }

                    if (shotsLeft == 0)
                    {
                        Console.WriteLine("Game over");
                    }

                    if (shotsLanded == 5)
                    {
                        Console.WriteLine("you !won");
                    }

                    Console.WriteLine("Play again? [y or n]");
                    var answer = Console.ReadLine();

                    if (answer == "n")
                    {
                        playAgain = false;
                    }

                }
            }


        }
    }
}
