using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Name: SzeTu-HW3
 * Class: IGME105
 * Author: Matthew Sze-Tu
 * Purpose: Create a text-based adventure
 * Recent Changes: Added door roll, trimed name, parsed steps, fixed trim of y/n and converted to uppercase. 
 * Fixed Constant Names, Swapped order of Welcome and Question. 
 */
namespace SzeTuM_HW
{
	class Program
	{
		static void Main(string[] args)
		{
			const String COLORS = "Red,Blue,Pink,Gray,Purple,Aquamarine,Gold,Silver";
			String ThirdColor;
			int CLocation;
			int CLength;
			String PlayGame;
			String PlayerName;
			const int PATH_DISTANCE = 50;
			String StepsTaken;
			int roll1;
			int roll2;
			int total;
            //Ask for name
            PlayerName = Welcome();
            //Start Game, ask if they want to play game. 
            Console.Write("Would you like to play the Hatsquid's Great and Wonderful Tower?");
			PlayGame = Console.ReadLine();
            //Prevent Crash when entering nothing
            if(PlayGame == "")
            {
                PlayGame = "N";
            }
            PlayGame = PlayGame.Substring(0, 1);
            //Convert first character to uppercase
            if(PlayGame == "y")
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
			Console.WriteLine("You, the brave adventurer " + PlayerName + ", are on an adventure.");
			Console.WriteLine("\nThe Great and Wonderful HatSquid has created a Great and Wonderful Tower,");
			Console.Write("and it is up to you to explore it and discover what secrets it holds, \nthen get out safely.");
			Console.WriteLine("\nGood Luck!");
			//Ground Map
			//Gate
			//Straight road
			//Gnarled trees and bushes lining trail (Blocking E/W)
			//Wooden Bridge 
			//Moat
			//Traveling E/W off Bridge will lead to instant game over in moat
			//Large Open Steel gate into giant stone tower

			//Begin Path
			Console.WriteLine("You stand at the start of a dirt path. \nIn the distance you can see the looming silhouette of HatSquid's Great and Wonderful Tower");
			Console.Write("How many steps would you like to take down the path?");
			StepsTaken = Console.ReadLine();
			//Test if can parse
			int Steps;
			Boolean CanParse = int.TryParse(StepsTaken,out Steps);
			if(CanParse == false)
			{
				Console.WriteLine("You did not enter a valid number.");
				Console.Write("Suddenly, you pass out for absolutely no reason.");
				Console.WriteLine("\nWhen you come to, you're at a wooden bridge over a moat, standing before a steel door.");
			}
			
			//Show number of extra steps if overshot.
			else if (Steps > 50)
			{
				Console.Write("You took " + Steps + " steps.");
				Steps = Steps - PATH_DISTANCE;
				Console.Write("This is " + Steps + " more than you needed to reach the tower.");
				Console.WriteLine("\nYou have stopped on a wooden bridge over a moat, standing before a steel door.");
			}

			//Show number of needed steps if undershot.
			else
			{
				Console.Write("You took " + Steps + " steps.");
				Steps = PATH_DISTANCE - Steps;
				Console.Write("This is " + Steps + " less than you needed to reach the tower.");
				Console.Write("Suddenly, you pass out for absolutely no reason.");
				Console.WriteLine("\nWhen you come to, you're at a wooden bridge over a moat, standing before a steel door.");
			}
			Console.WriteLine("There is a note on the door that says the following: \nDear " + PlayerName + ", The gate is locked and I lost the key. Please find it.");
			Console.WriteLine("Press Enter to roll for finding the key.");
			Console.ReadLine();
			//Roll Dice
			roll1 = Generator.DiceRoll();
			roll2 = Generator.DiceRoll();
			total = roll1 + roll2;
			Console.WriteLine("You rolled a " + total);
			//Kill Player if underrolled
			if (total < 4)
			{
				Console.WriteLine("You failed to find the key!");
				Console.ReadLine();
				Console.BackgroundColor = ConsoleColor.DarkRed;
				Console.WriteLine("The door falls forwards and you are squashed flat.");
				Console.ReadLine();
				Console.WriteLine("The bridge beneath you then breaks, and the gators in the moat enjoy a nice meal!");
				Console.ReadLine();
				Console.WriteLine(PlayerName + "'s adventure ends here, eaten by gators.");
				Environment.Exit(0);
			}
			//Continue onwards
			else
			{
				//Select Third Color of String 
				CLocation = COLORS.IndexOf(",");
				CLength = COLORS.Length - CLocation;
				ThirdColor = COLORS.Substring(CLocation+1,CLength-1);
				CLocation = ThirdColor.IndexOf(",");
				CLength = ThirdColor.Length - CLocation;
				ThirdColor = ThirdColor.Substring(CLocation+1, CLength-1);
				CLocation = ThirdColor.IndexOf(",");
				CLength = ThirdColor.Length - CLocation;
				ThirdColor = ThirdColor.Substring(0, CLocation);
				Console.WriteLine("You've found the key!");
				Console.WriteLine("The door in front of you slides into the ground without you even using the key.");
				Console.WriteLine("You step through the doorway and are greeted by a floating, glowing "+ThirdColor+" Snake.");
			}
			//First Floor
			//Mostly empty room, Large Central Stone Pillar
			//Slot in the far wall
			//NPC Ghost, Warns to arm self
			//6 suits of armor, one in each corner and one in the middle of East and West
			//Each suit has sword and shield
			//Player may take Sword and/or Shield
			//Inserting Sword into slot causes ceiling to open and Ladder to drop down.  
			//Second Floor 
			//Two suits of armor flanking the ladder. Sword and Shield each
			//Raised Central Pillar, with a little underpass with openings to each cardinal direction
			//Player steps into central underpass, light *click*
			// S, E, and W will randomly click, shooting arrows. Player must block with shield in proper direction 6 times. Failure=Death
			//Upon success, Ladder drops from ceiling in South end of room.
			//Third Floor
			//Large Sphinx sitting in center of room.
			//Again, Suits of armor flank the entrance
			//Sphinx asks Riddle (TBD)
			//On failed answer, Sphinx attacks
			//Fight sphinx
			//On succesful answer, Sphinx steps aside, revealing a hole.
			//Drop down hole
			//Dungeon
			//New spawn point
			//Room 1
			//One torch on wall, player may take it.
			//Locked door
			//table
			//Note saying "Avoid a shocking conclusion.
			//Two keys, wood and metal
			//Metal key electrocutes player when used on door, killing them
			//Wooden Key unlocks door.
			//Room 2
			//Large chasm, rickety Wooden bridge spanning it
			//Basket Holding matches, saw, kite, tape, and a candle
			//Player can cut or burn the bridge
			//If player tries to cross holding anything, bridge snaps
			//Player can cross empty handed
			//Room 3
			// Narrow stone pathway over another chasm
			//While crossing pathway, player will hear a *swish* 
			//If player moves left or right, they fall and die
			//Possibly put a timed delay?
			//Player ducks, scythe swings over their head. 
			//Potentially do 2 more times?
			//Room 4
			//Final boss/puzzle which unlocks exit
			//exit to win
			Console.WriteLine("Press enter to Close");
			Console.ReadLine();
		}
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
			PlayerName = PlayerName.Replace(" ", "");
			return PlayerName;
		}
	}
}
