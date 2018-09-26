using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Name: SzeTu-HW4
 * Class: IGME105
 * Author: Matthew Sze-Tu
 * Purpose: Create a text-based adventure
 * Recent Changes: Created and added methods
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
			String PlayerName = "Lazy";
			String TempName;
			Console.WriteLine("Welcome to HatSquid's Spooky Tower!");
			Console.WriteLine("\nCan you enter, then escape again for no good reason?");
			Console.WriteLine("Type your commands such as walk, search, duck, etc \nto explore the world  and try to survive!");
			Console.Write("Please enter your name.");
			TempName = Console.ReadLine();
			if (string.IsNullOrEmpty(TempName) != true)
			{
				PlayerName = TempName;
			}
			else
			{
				Console.WriteLine("If you won't enter a name, I'll simply call you " + PlayerName + "!");
			}
			//Removes White Space
			Program.PlayerName = PlayerName.Replace(" ", "");
			return PlayerName;
		}

		//Provides opening narration and asks if player wants to play
		public static void Intro()
		{
			String PlayGame;
			//Ask for name
			//Start Game, ask if they want to play game. 
			Console.Write("Would you like to play the Hatsquid's Great and Wonderful Tower?");
			PlayGame = Console.ReadLine();
			//Prevent Crash when entering nothing
			if (PlayGame == "")
			{
				PlayGame = "N";
			}
			PlayGame = PlayGame.Substring(0, 1);
			//Convert first character to uppercase
			if (PlayGame == "y")
			{
				PlayGame = "Y";
			}
			else if (PlayGame == "n")
			{
				PlayGame = "N";
			}
			//Determine if player wants to play
			if (PlayGame == "Y")
			{
				Console.WriteLine("Alright then, lets goooooooooooo!");
			}
			else
			{
				Console.WriteLine("Well you don't have a choice anyways, here we goooooooooooooooooo!");
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
