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
	class Walkway
	{
		Config Config = new Config();
		//Ground Map
		//Gate
		//Straight road
		//Gnarled trees and bushes lining trail (Blocking E/W)
		//Wooden Bridge 
		//Moat
		//Traveling E/W off Bridge will lead to instant game over in moat
		//Large Open Steel gate into giant stone tower

		//Explore the Yard
		public static void ExploreWalk()
		{
			const int PATH_DISTANCE = 50;
			String StepsTaken;
			//Begin Path
			Console.WriteLine("You stand at the start of a dirt path. \nIn the distance you can see the looming silhouette of HatSquid's Great and Wonderful Tower");
			Console.Write("How many steps would you like to take down the path?");
			StepsTaken = Console.ReadLine();
			//Test if can parse
			int Steps;
			Boolean CanParse = int.TryParse(StepsTaken, out Steps);
			if (CanParse == false)
			{
				Console.WriteLine("You did not enter a valid number.");
				Console.Write("Suddenly, you pass out for absolutely no reason.");
				Console.WriteLine("\nWhen you come to, you're at a wooden bridge over a moat, standing before a steel door.");
			}

			//Show number of extra steps if overshot.
			else if (Steps >= 50)
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
		}

		//Roll to Open the Tower door, find colored snake
		public static void TowerDoor()
		{
			int roll1;
			int roll2;
			int total;
			const String COLORS = "Red,Blue,Pink,Gray,Purple,Aquamarine,Gold,Silver";
			String ThirdColor;
			int CLocation;
			int CLength;

			Console.WriteLine("There is a note on the door that says the following: \nDear " + Program.PlayerName + ", The gate is locked and I lost the key. Please find it.");
			Console.WriteLine("Press Enter to roll for finding the key,\n you must roll above a 4 to open the door.");
			Console.ReadLine();
			//Roll Dice
			roll1 = Config.DiceRoll();
			System.Threading.Thread.Sleep(1000);
			roll2 = Config.DiceRoll();
			total = roll1 + roll2;
			Console.WriteLine("Your first roll was a " + roll1);
			Console.WriteLine("Your second roll was a " + roll2);	
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
				Console.WriteLine(Program.PlayerName + "'s adventure ends here, eaten by gators.");
				Console.WriteLine("Press any key to close the program.");
				Console.ReadLine();
				Environment.Exit(0);
			}
			//Continue onwards
			else
				{
					//Select Third Color of String 
					CLocation = COLORS.IndexOf(",");
					CLength = COLORS.Length - CLocation;
					ThirdColor = COLORS.Substring(CLocation + 1, CLength - 1);
					CLocation = ThirdColor.IndexOf(",");
					CLength = ThirdColor.Length - CLocation;
					ThirdColor = ThirdColor.Substring(CLocation + 1, CLength - 1);
					CLocation = ThirdColor.IndexOf(",");
					CLength = ThirdColor.Length - CLocation;
					ThirdColor = ThirdColor.Substring(0, CLocation);
					Console.WriteLine("You've found the key!");
					Console.WriteLine("The door in front of you slides into the ground without you even using the key.");
					Console.WriteLine("You step through the doorway and are greeted by a floating, glowing " + ThirdColor + " Snake.");
				}
			}
		}
	}

