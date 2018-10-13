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

        //Introduce Player to the building and rooms
		public void ColoredGreet()
		{
			//Colors for later use
			const String COLORS = "Red,Blue,Pink,Gray,Purple,Aquamarine,Gold,Silver";
			String ThirdColor;
			int CLocation;
			int CLength;
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
			Console.WriteLine("You step through the doorway and are greeted by a floating, glowing " + ThirdColor + " ball. The ball then instantly disappears.");
		}
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
