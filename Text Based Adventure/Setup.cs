using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Name: SzeTu-HW6
 * Class: IGME105
 * Author: Matthew Sze-Tu
 * Purpose: Sets up the text-based adventure
 * Recent Changes: No changes
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
			else if(PlayGame == "N")
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
	}
}
