using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Name: SzeTu-HW5
 * Class: IGME105
 * Author: Matthew Sze-Tu
 * Purpose: Configure method of text-based adventure
 * Recent Changes: Overloaded Dice Roll
 */
namespace Text_Based_Adventure
{
	class Config
	{		
		//Roll die with specified sides
		public static int DiceRoll(int min, int max)
		{
			Random Roll = new Random();
			int answer = Roll.Next(min, max);
			return answer;
		}
        //Roll a number of dice with specified sides 
        public static int DiceRoll(int min, int max, int DiceNum)
        {
            Random Roll = new Random();
            int answer = Roll.Next(min, max);
            answer = (answer * DiceNum) / DiceNum;
            return answer;
        }
		//Create MiniHatSquids
		public static void BuildHatSquids()
		{
			//Create Mini Hat Squids
			MiniHatSquid DunceSquid = new MiniHatSquid();
			MiniHatSquid SupremeSquid = new MiniHatSquid();
			//Set attributes
			DunceSquid.Health = 1;
			DunceSquid.TentacleNum = 0;
			DunceSquid.Hat = "Dunce Cap";
			DunceSquid.Accesories = "nothing";
			DunceSquid.Mood = "Dumb";
			SupremeSquid.Health = 50;
			SupremeSquid.TentacleNum = 6;
			SupremeSquid.Accesories = "wads of cash, Watches, and a Bracelet.";
			SupremeSquid.Mood = "Self-centered";
			SupremeSquid.Hat = "Supreme Brand Flat-brimmed Cap.";
			//Call Greeting
			MiniHatSquid.Greeting(SupremeSquid, DunceSquid);
		}
		//Use when a player loses to end the game
		public static void GameEnd(int loss)
		{
			Console.BackgroundColor = ConsoleColor.DarkRed;
			switch (loss)
			{
				case 0:
					{
						Console.WriteLine("You've chosen to quit the game. In other words, you lose!");
						Console.WriteLine("Thanks for playing! \nPress enter to close the game.");
						Console.ReadLine();
						Environment.Exit(0);
						break;
					}
				case 1:
					{
						Console.WriteLine("The door falls forwards and you are squashed flat.");
						Console.ReadLine();
						Console.WriteLine("The bridge beneath you then breaks, and the gators in the moat enjoy a nice meal!");
						Console.WriteLine(Program.PlayerName + "'s adventure ends here, eaten by gators.");
						Console.WriteLine("Press any key to close the program.");
						Console.ReadLine();
						Environment.Exit(0);
						break;
					}
				case 2:
					{
						Console.WriteLine("The Duncesquid explodes violently, turning everything in a 500 foot radius into a fine, purple ash.");
						Console.WriteLine("This, of course, includes you. Maybe next time don't be such a jerk?");
						Console.WriteLine(Program.PlayerName + "'s adventure ends here, blown up by the DunceSquid.");
						Console.WriteLine("Press any key to close the program.");
						Console.ReadLine();
						Environment.Exit(0);
						break;
					}
				case 3:
					{
						Console.WriteLine("The SupremeSquid jumps away from you, looking very angry. \nYou try to apologize, but it's too late.");
						Console.WriteLine("The SupremeSquid writes a diss track about you. Before you know it, hordes of rapid teenagers are mad at you.");
						Console.WriteLine("You're shamed everywhere you go. The world has no safe havens anymore.");
						Console.WriteLine(Program.PlayerName + "'s adventure ends here, game-ended by the SupremeSquid's youtube fame.");
						Console.WriteLine("Press any key to close the program.");
						Console.ReadLine();
						Environment.Exit(0);
						break;
					}
				case 4:
					{
						Console.WriteLine("You eat the cookie. It's delicious!");
						Console.WriteLine("It's also poisoned. You die. Painfully.");
						Console.WriteLine("You really shouldn't eat random food you find lying around.");
						Console.WriteLine(Program.PlayerName + "'s adventure ends here, killed by a poisonus cookie.");
						Console.WriteLine("Press any key to close the program.");
						Console.ReadLine();
						Environment.Exit(0);
						break;
					}
				//error message
				default:
					{
						Console.WriteLine("SOMETHING HAS GONE HORRIBLY WRONG. ABORTING PROGRAM!");
						Console.ReadLine();
						Environment.Exit(0);
						break;
					}
					
			}
				
		}
    }
}
