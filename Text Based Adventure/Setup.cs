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
			if (string.IsNullOrEmpty(TempName) == true)
			{
				Console.WriteLine("If you won't enter a name, I'll simply call you " + Program.PlayerName + "!");
                TempName = "Lazy";
			}
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
            if(string.IsNullOrEmpty(PlayGame) == true)
            {
                PlayGame = "No";
            }
			//Convert to first letter only
			PlayGame = PlayGame.Substring(0, 1);
			//Convert first character to uppercase
			if (PlayGame != "Y")
			{
				Console.WriteLine("Well you don't have a choice anyways, here we goooooooooooooooooo!");
			}
			else
			{
				Console.WriteLine("Alright then, lets goooooooooooo!");
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
