using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Name: SzeTu-HW5
 * Class: IGME105
 * Author: Matthew Sze-Tu
 * Purpose: Miniature HatSquids
 * Recent Changes: Created
 */
namespace Text_Based_Adventure
{
	class MiniHatSquid
	{
		//Attributes for Hatsquid
		public int Health;
		public String Hat;
		public int TentacleNum;
		public String Accesories;
		public String Mood;

		//MiniHatSquid Descriptions
		/*SupremeSquid
			Wearing a Supreme Brand Flat-Brimmed Cap
			Has 6 tentacles
			Carrying a wad of money, wearing multiple wrist watches, and has a bracelet
			Is very self-centered, likes to show off it's money
			Something about Rice and Paul
			Fairly Tanky
		DunceSquid
			Is just a Dunce Cap. Doesn't even have any tentacles
			Really stupid, how does it even exist?
			Dies in 1 hit from literally anything.
		**/

		//Greeting for the first Mini Hatsquids.
		public static void Greeting(MiniHatSquid SupremeSquid, MiniHatSquid DunceSquid)
		{
			//Greet Player
			Console.WriteLine("Two small Hatsquids appear out of nowhere and make their way towards you.");
			Console.WriteLine("You've never seen a Hatsquid before. Each one consists of a number of tentacles extending out of the bottom of a hat.");
			Console.WriteLine("");
			//Describe SupremeSquid
			Console.WriteLine("The first Hatsquid is wearing a " + SupremeSquid.Hat + " and has " + SupremeSquid.TentacleNum + "Tentacles.");
			Console.WriteLine("It's carrying and wearing multiple " + SupremeSquid.Accesories + " and seems to be incredibly " + SupremeSquid.Mood);
			Console.WriteLine("");
			//Describe DunceSquid
			Console.WriteLine("The second Hatsquid is wearing a " + DunceSquid.Hat + " and has " + DunceSquid.TentacleNum + " tentacles, \nso you're not actually sure how it even moved to greet you.");
			Console.WriteLine("It is carrying " + DunceSquid.Accesories + " and seems extremely " + DunceSquid.Mood);
			//Continue Greeting
			Console.WriteLine("");
			Console.WriteLine("The Hatsquids are just sitting there in front of you. \nThey aren't exactly staring, since they don't have eyes. \nYou arent sure what they're waiting for.");

		}
	}
}
