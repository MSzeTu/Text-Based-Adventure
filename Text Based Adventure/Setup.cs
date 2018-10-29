using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Name: SzeTu-HW8
 * Class: IGME105
 * Author: Matthew Sze-Tu
 * Purpose: Sets up the text-based adventure
 * Recent Changes: Created new method to collect input and store in Array
 */
namespace Text_Based_Adventure
{
    class Setup
    {
        /*
         * Welcome the player to the game, have them enter their name. 
         */
        public static string Welcome()
        {
            String TempName;
            Console.WriteLine("Welcome to HatSquid's Spooky Tower!");
            Console.WriteLine("\nCan you enter, then escape again for no good reason?");
            Console.WriteLine("Type your commands such as walk, search, duck, etc \nto explore the world  and try to survive!");
            Console.Write("Please enter your name.");
            //Remove empty space from name
            TempName = Console.ReadLine().Trim();
            TempName = Config.AntiEmpty(TempName);
            return TempName;
        }

        //Provides opening narration and asks if player wants to play
        public static void Intro()
        {
            String PlayGame;
            //Ask for name
            //Start Game, ask if they want to play game. 
            Console.Write("Would you like to play the Hatsquid's Great and Wonderful Tower?");
            PlayGame = Console.ReadLine().Trim().ToUpper();
            //Prevent error if nothing entered
            PlayGame = Config.AntiEmpty(PlayGame);
            //Convert to first letter only
            PlayGame = PlayGame.Substring(0, 1);
            //Repeats until valid input
            while (PlayGame != "Y" && PlayGame != "N")
            {
                Console.WriteLine("That's not how questions work. Please enter Yes or No.");
                PlayGame = Console.ReadLine().Trim().ToUpper();
                if (string.IsNullOrEmpty(PlayGame) == false)
                {
                    PlayGame = PlayGame.Substring(0, 1);
                }
                Console.WriteLine(PlayGame);
            }
            if (PlayGame == "Y")
            {
                Console.WriteLine("ALRIGHT LET'S GOOOOOOOOOOOOOOOOOOOOO");
            }
            else if (PlayGame == "N")
            {
                Console.WriteLine("Oh, uh, okay then. I'm sorry I asked... Bye Bye.");
                Config.GameEnd(0);
            }
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.Cyan;
            //Provide opening narration/instructions
            Console.WriteLine("You, the brave adventurer " + Program.PlayerName + ", are on an adventure.");
            Console.WriteLine("\nThe Great and Wonderful HatSquid has created a Great and Wonderful Tower,");
            Console.Write("and it is up to you to explore it and discover what secrets it holds, \nthen get out safely.");
            Console.WriteLine("\nGood Luck!");
        }
        //Collect user input and store in array for later
        public static void CollectInput()
        {
            String SChoice;
            int Choice;
            Boolean CanParse;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("I am now going to collect some data from you to personalize your experience.");
            Console.WriteLine("You will have to enter 10 numbers. Please ensure each number is between 10 and 100.");
            for (int i = 0; i < Program.ASize; i++)
            {
                Console.WriteLine("Please enter a number between 10 and 100. You have entered " + i + " out of " + Program.ASize + " numbers.");
                SChoice = Console.ReadLine();
                SChoice = Config.AntiEmpty(SChoice);
                CanParse = int.TryParse(SChoice, out Choice);
                while (Choice < 10 || Choice > 100)
                {
                    CanParse = false;
                    while (CanParse == false)
                    {                       
                        Console.WriteLine("You did not enter a valid number");
                        Console.WriteLine("Please enter a number between 10 and 100.");
                        SChoice = Console.ReadLine();
                        SChoice = Config.AntiEmpty(SChoice);
                        CanParse = int.TryParse(SChoice, out Choice);
                    }
                    
                }
                Program.TentacleNum[i] = Choice;
            }
            Console.WriteLine("Thank you for entering numbers! You have chosen:");
            foreach (int i in Program.TentacleNum)
            {
                Console.WriteLine(i);
            }
        }
	}
}
