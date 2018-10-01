using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Name: SzeTu-HW4
 * Class: IGME105
 * Author: Matthew Sze-Tu
 * Purpose: Create a text-based adventure
 * Recent Changes: Seperated code into 6 classes, called the new methods.
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
			PlayerName = Setup.Welcome();
			Setup.Intro();
			Walkway.ExploreWalk();
			Walkway.TowerDoor();
			
			Console.WriteLine("Press enter to Close");
			Console.ReadLine();
		}
		

	}
}
