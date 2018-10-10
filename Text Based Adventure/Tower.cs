using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Name: SzeTu-HW5
 * Class: IGME105
 * Author: Matthew Sze-Tu
 * Purpose: Main tower of text-based adventure
 * Recent Changes: Added Methods
 */
namespace Text_Based_Adventure
{
	class Tower
	{
        //Rooms
            //Kitchen with absolutely nothing in it.
            //Pool room with a giant swimming pool. The pool is empty but theres water everywhere else
            //Wardrobe with lots and lots of hats.
            //Upside-down-house room where everything is upside dooooooooooooooooown
            //Tiny room with a hole that leads to the dungeon.

        //Greeting for the first Mini Hatsquids.
        public void Greeting()
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
			//Greet Player
			Console.WriteLine("Two small Hatsquids appear out of nowhere and make their way towards you.");
			Console.WriteLine("You've never seen a Hatsquid before. Each one consists of a number of tentacles extending out of the bottom of a hat.");
			Console.WriteLine("");
			//Describe SupremeSquid
			Console.WriteLine("The first Hatsquid is wearing a " + SupremeSquid.Hat + " and has " + SupremeSquid.TentacleNum + "Tentacles.");
			Console.WriteLine("It's carrying and wearing multiple " + SupremeSquid.Accesories + " and seems to be incredibly " + SupremeSquid.Mood);
			Console.WriteLine("");
			//Describe DunceSquid
			Console.WriteLine("The second Hatsquid is wearing a "+DunceSquid.Hat+" and has "+DunceSquid.TentacleNum+" tentacles, \nso you're not actually sure how it even moved to greet you.");
			Console.WriteLine("It is carrying " + DunceSquid.Accesories + " and seems extremely "+DunceSquid.Mood);
			//Continue Greeting
			Console.WriteLine("");
			Console.WriteLine("The Hatsquids are just sitting there in front of you. \nThey aren't exactly staring, since they don't have eyes. \nYou arent sure what they're waiting for.");

        }
        //Introduce Player to the building and rooms
        public void Entrance()
        {
            //Have player enter
            Console.WriteLine("Press enter to look around the tower entrance.");
            Console.ReadLine();
            Console.WriteLine("");
            //Describe Layout
            Console.WriteLine("Through the now-missing gate you can see down a straight hallway with shiny silver stone walls.");
            Console.WriteLine("On the left there are two doorways leading to two seperate rooms.");
            Console.WriteLine("On the right there are ALSO two doorways leading to two seperate rooms.");
            Console.WriteLine("The hallway ends at a stone wall with an extremely tiny door at the bottom, only big enough for maybe a mouse.");
            Console.WriteLine("");
            //Describe each door
            Console.WriteLine("The first door on the left has a sign on it that says its the pool. \nThere is a small stream of water leaking out from under the door.");
            Console.WriteLine("The second door on the left is labeled as the upside-down-house. The door is, fittingly, upside down.");
            Console.WriteLine("The first door on the right is labeled as the kitchen. The door is actually just on fire. You're not sure why.");
            Console.WriteLine("The second door on the right is labeled as the wardrobe. There is nothing of note about that door otherwise.");
            Console.WriteLine("It looks like theres a tiny sign on the small door at the end of the hall, but you can't read it from here.");
			Console.WriteLine("Press Enter to continue.");
			Console.ReadLine();
			Console.WriteLine("");
        }
	}
}
