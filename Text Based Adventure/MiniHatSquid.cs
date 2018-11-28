using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Name: SzeTu-HW11
 * Class: IGME105
 * Author: Matthew Sze-Tu
 * Purpose: Miniature HatSquids
 * Recent Changes: Made ALL the attributes private
 */
namespace Text_Based_Adventure
{
	class MiniHatSquid
	{
		//Attributes for Hatsquid
		private int[] ahealth = { 1,5,50,90,10000,41,8,21,60,666};
        private int health;
		private String hat;
		private String[] aaccesories = {"a Lolipop","a Water Gun","a miniature star","lots of swords","tiny clones of itself","diamonds and other jewels","fire. Just actually fire","a deck of cards","a mirror","nothing"};
        private String accesories;
        private String[] amood = { "dumb","self-Centered","smart","angry","sad","wistful","lustful","greedy","hungry","sleepy"};
        private String mood;
        private int tentaclenum;

		//Gets and sets Health
		public string Hat
		{
			get
			{
				return hat;
			}
			set
			{
				hat = value;
			}
		}

		//Gets AHealth
		public int[] AHealth
		{
			get
			{
				return ahealth;
			}
		}
		//Gets and sets Health
		public int Health
		{
			get
			{
				return health;
			}
			set
			{
				health = value;
			}
		}
		//Gets AAccesories
		public string[] AAccesories
		{
			get
			{
				return aaccesories;
			}
		}
		//Gets and sets Accesories
		public string Accesories
		{
			get
			{
				return accesories;
			}

			set
			{
				accesories = value;
			}
		}

		//gets and sets AMood
		public string[] AMood
		{
			get
			{
				return amood;
			}
		}
		//Gets and sets Mood
		public string Mood
		{
			get
			{
				return mood;
			}

			set
			{
				mood = value;
			}
		}

		//Gets and sets TentacleNum
		public int TentacleNum
		{
			get
			{
				return tentaclenum;
			}
			set
			{
				tentaclenum = value;
			}
		}
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
			Console.WriteLine("The first Hatsquid is wearing a " + SupremeSquid.Hat + " and has " + SupremeSquid.TentacleNum + " Tentacles.");
            Console.WriteLine("Hmmmmmmm that number of tentacles seems familiar actually. \nDid you cause this? I'm pretty sure you entered that number earlier.");
            Console.WriteLine("I may need to keep a closer eye on you... \nAnyways:");
			Console.WriteLine("It's wearing multiple fancy wristwatches and carrying a wad of cash as well as " + SupremeSquid.Accesories + ". \nIt seems to be incredibly " + SupremeSquid.Mood);
			Console.WriteLine("");
			//Describe DunceSquid
			Console.WriteLine("The second Hatsquid is wearing a " + DunceSquid.Hat + " and has 0 tentacles, \nso you're not actually sure how it even moved to greet you.");
			Console.WriteLine("It is carrying " + DunceSquid.Accesories + " and seems extremely " + DunceSquid.Mood);
			//Continue Greeting
			Console.WriteLine("");
			Console.WriteLine("The Hatsquids are just sitting there in front of you. \nThey aren't exactly staring, since they don't have eyes. \nYou arent sure what they're waiting for.");
		}
		//Interactions with initial Hatsquids.
		public static void FirstInteraction()
		{
            Boolean Proper = false;
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
            while (Proper == false)
            {
                //Try again if empty
                Answer = Config.AntiEmpty(Answer);
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
                                Proper = true;
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("You did not enter a valid input. Please enter Q, K, T, or S.");
                                Answer = Console.ReadLine().Trim().ToUpper();
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
}
