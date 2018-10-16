using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Name: SzeTu-HW6
 * Class: IGME105
 * Author: Matthew Sze-Tu
 * Purpose: Miniature HatSquids
 * Recent Changes: No changes
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
		//Interactions with initial Hatsquids.
		public static void FirstInteraction()
		{
			String Answer;
			Console.WriteLine("The Supreme Hatsquid is waving it's money around, almost... showing it off? \nis this Hatsquid flexing on you?");
			Console.WriteLine("The Dunce Hatsquid is sitting there doing nothing, since it kind of lacks tentacles.");
			Console.WriteLine("You seem to have a few options.(Enter the bracketed letter to choose an option).");
			Console.WriteLine("");
			Console.WriteLine("[Q]uit");
			Console.WriteLine("[K]ick the DunceSquid");
			Console.WriteLine("[T]ake the SupremeSquid's money");
			Console.WriteLine("[S]how the SupremeSquid your fancy wristwatch");
			//Receive Answer
			Answer = Console.ReadLine().Trim().ToUpper();
			//Default if empty
			if (string.IsNullOrEmpty(Answer) == true)
			{
				Console.WriteLine("Ah a rulebreaker huh? I bet a rulebreaker like you would try to take that Squid's Lunchmoney!");
				Console.WriteLine("You try to take the SupremeSquid's money.");
				Config.GameEnd(3);
			}
			//converts to first letter
			Answer = Answer.Substring(0, 1);
			Console.WriteLine("");
			if (Answer != "Q")
			{
				if (Answer != "K")
				{
					if (Answer != "T")
					{
						if (Answer == "S")
						{
							Console.WriteLine("You show off your expensive watch to the SupremeSquid.");
							Console.WriteLine("In return, it show's off seven watches on each tentacle that are even more expensive and fancy.");
							Console.WriteLine("Satisifed that it seems to be better than you, the SupremeSquid picks up the DunceSquid and phases through the floor.");
							Console.WriteLine("Press enter to continue forwards.");
							Console.ReadLine();
						}
						else
						{
							Console.WriteLine("Ah a rulebreaker huh? I bet a rulebreaker like you would try to take that Squid's Lunchmoney!");
							Console.WriteLine("You try to take the SupremeSquid's money.");
							Config.GameEnd(3);
						}
					}
					else
					{
						Console.WriteLine("You try to take the SupremeSquid's money.");
						Config.GameEnd(3);
					}
				}
				else
				{
					Console.WriteLine("You rear back and punt the DunceSquid with all your might!");
					Config.GameEnd(2);
				}
			}
			else
			{
				Config.GameEnd(0);
			}
		}
	}
}
