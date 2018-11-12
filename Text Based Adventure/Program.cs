using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Name: SzeTu-HW10
 * Class: IGME105
 * Author: Matthew Sze-Tu
 * Purpose: Create a text-based adventure
 * Recent Changes: Moved attributes to Setup
 */
namespace Text_Based_Adventure
{
	class Program
	{
        
        
		public static Boolean Reset = true;
        
        //Run main program
		static void Main(string[] args)
		{
            Boolean Explore = true;
			Boolean Die;
            Boolean ReturnY = true;
			//Create class objects 
			Walkway Walk1 = new Walkway();
			while (Reset == true)
			{
				Tower Tower1 = new Tower();
                //Begin Main process
                Setup.PlayerName = Setup.Welcome();
                Setup.CollectInput();
                Setup.UserFoodInput();
				Setup.Intro();
				Walk1.ExploreWalk();
                //allows returning to walkway
                while (ReturnY == true)
                {
                    Die = Walk1.TowerDoor();
                    //kill player
                    if (Die == true)
                    {
                        Config.GameEnd(1);
                    }
                    //continue normally
                    Tower1.ColoredGreet();
                    Tower1.Entrance();
                    Config.BuildHatSquids();
                    MiniHatSquid.FirstInteraction();
                    Explore = true;
                    while (Explore == true)
                    {
                        Explore = Tower1.RoomTravel();
                        ReturnY = Walk1.ReturnToWalkway();
                        if (ReturnY == true)
                            Explore = false;
                    }
                }				
				Console.WriteLine("Press enter to Close");
				Console.ReadLine();
			}
		}
		

	}
}
