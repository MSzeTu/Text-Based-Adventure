using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Name: SzeTu-HW10
 * Class: IGME105
 * Author: Matthew Sze-Tu
 * Purpose: Initial walkway of text-based adventure
 * Recent Changes: No Changes
 */
namespace Text_Based_Adventure
{
	class Walkway
	{
		private String LastName;
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
        public void ExploreWalk()
        {
            //Path and step variables
            const int PATH_DISTANCE = 50;
            String StepsTaken;
			//Begin Path
			Console.WriteLine("Hm now that I think of it, you probably have a last name don't you?");
			Console.WriteLine("Alright then, what's your last name?");
			LastName=Console.ReadLine();
			LastName = Config.AntiEmptyC(LastName);
			Console.WriteLine(LastName + " huh?");
			Setup.PlayerName = Setup.PlayerName + " " + LastName;
            Console.WriteLine("You stand at the start of a dirt path. \nIn the distance you can see the looming silhouette of HatSquid's Great and Wonderful Tower");
            Console.Write("How many steps would you like to take down the path?");
            StepsTaken = Console.ReadLine();
            //Test if can parse
            int Steps;
            Boolean CanParse = int.TryParse(StepsTaken, out Steps);
            while (CanParse == false)
            {
                Console.WriteLine("You did not enter a valid number.");
                Console.Write("Please enter a valid integer.");
                StepsTaken = Console.ReadLine();
                CanParse = int.TryParse(StepsTaken, out Steps);
            }
            for (int i = Steps; i < PATH_DISTANCE; i = i+Steps)
            {
                Console.WriteLine("You have taken a total of " + i + " steps. You have not yet reached the door.");
                Console.WriteLine("How many more steps would you like to take?");
                StepsTaken = Console.ReadLine();
                CanParse = int.TryParse(StepsTaken, out Steps);
                while (CanParse == false)
                {
                    Console.WriteLine("You did not enter a valid number.");
                    Console.Write("Please enter a valid integer.");
                    StepsTaken = Console.ReadLine();
                    CanParse = int.TryParse(StepsTaken, out Steps);
                }
            }
            if (Steps > 50)
            {
                Console.WriteLine("The path was only 50 steps long!");
            }
            Console.WriteLine("\nYou have stopped on a wooden bridge over a moat, standing before a steel door.");
        }
        //Return to yard from rooms
        public Boolean ReturnToWalkway()
        {
            Boolean Leave = false;
            String Answer;
            Console.WriteLine("Do you want to return to the walkway [Y] or [N]?");
            Answer = Console.ReadLine().Trim().ToUpper();
            Answer = Config.AntiEmpty(Answer);
            if (Answer == "Y")
            {
                Console.WriteLine("You go back through the front door, which closes behind you.");
                Leave = true;
            }
            return Leave;
        }
		//Roll to Open the Tower door, find colored orb
		public Boolean TowerDoor()
		{
			Boolean Die = false;
            //Dice rolls
			int roll1;
			int roll2;
			int total;

			Console.WriteLine("There is a note on the door that says the following: \nDear " + Setup.PlayerName + ", The gate is locked and I lost the key. Please find it.");
			Console.WriteLine("Press Enter to roll for finding the key,\n you must roll above a 4 to open the door.");
			Console.ReadLine();
			//Roll Dice
			roll1 = Config.DiceRoll(1,7);
			System.Threading.Thread.Sleep(1000);
			roll2 = Config.DiceRoll(1,7,500);
			total = roll1 + roll2;
			Console.WriteLine("Your first roll was a " + roll1);
			Console.WriteLine("Your second roll was a " + roll2);	
			Console.WriteLine("You rolled a " + total);
			//Kill Player if underrolled
			if (total <= 4)
			{
				Console.WriteLine("You failed to find the key!");
				Die = true;
				Console.ReadLine();
			}
			return Die;
			}
		}
	}
