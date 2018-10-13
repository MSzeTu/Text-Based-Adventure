using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Name: SzeTu-HW5
 * Class: IGME105
 * Author: Matthew Sze-Tu
 * Purpose: Create a text-based adventure
 * Recent Changes: Created Objects, animals, and Overloaded Dice Roll
 */
namespace Text_Based_Adventure
{
	class Program
	{
        //Setup Playername attribute
		public static String PlayerName = "Lazy";
        //Run main program
		static void Main(string[] args)
		{
			Boolean Die;
			//Create class objects 
			Walkway Walk1 = new Walkway();
            Tower Tower1 = new Tower();
			
            //Begin Main process
            PlayerName = Setup.Welcome();
			Setup.Intro();
			Walk1.ExploreWalk();
			Die = Walk1.TowerDoor();
			//kill player
			if(Die == true)
			{
				Config.GameEnd(1);
			}
			//continue normally
			Tower1.ColoredGreet();
            Tower1.Entrance();
			Config.BuildHatSquids();
			MiniHatSquid.FirstInteraction();
			Console.WriteLine("Press enter to Close");
			Console.ReadLine();
		}
		

	}
}
