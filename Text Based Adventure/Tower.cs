using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Name: SzeTu-HW10
 * Class: IGME105
 * Author: Matthew Sze-Tu
 * Purpose: Main tower of text-based adventure
 * Recent Changes: No changes
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
            Console.WriteLine("The first door on the left has a sign on it that says it's the pool. \nThere is a small stream of water leaking out from under the door.");
            Console.WriteLine("The second door on the left is labeled as the upside-down-house. The door is, fittingly, upside down.");
            Console.WriteLine("The first door on the right is labeled as the kitchen. The door is actually just on fire. You're not sure why.");
            Console.WriteLine("The second door on the right is labeled as the wardrobe. There is nothing of note about that door otherwise.");
            Console.WriteLine("It looks like theres a tiny sign on the small door at the end of the hall, but you can't read it from here.");
			Console.WriteLine("Press Enter to continue.");
			Console.ReadLine();
			Console.WriteLine("");
        }
        //Allows travel from room to room
		public Boolean RoomTravel()
		{
            Boolean Explore = true;
            Boolean Continue = false;
			Dungeon Dungeon1 = new Dungeon();
			Boolean Pass = false;
			string Answer;
            Boolean Proper = false;
			Console.WriteLine("With that taken care of, which room do you want to go to? (Enter the bracketed letter to choose.):");
			Console.WriteLine("The [P]ool");
			Console.WriteLine("The [U]pside-Down House");
			Console.WriteLine("The [K]itchen");
			Console.WriteLine("The [W]ardrobe");
			Console.WriteLine("The [S]mall Door");
			Console.WriteLine("[Q]uit (this is not a room, this WILL quit the game.)");
			Answer = Console.ReadLine().Trim().ToUpper();
            while (Proper == false)
            {
                Answer = Config.AntiEmpty(Answer);
			    Answer = Answer.Substring(0, 1);           
                switch (Answer)
                {
                    case "P":
                        {
                            Pool();
                            Proper = true;
                            break;
                        }
                    case "U":
                        {
                            UpsideDown();
                            Proper = true;
                            break;
                        }
                    case "K":
                        {
                            Kitchen();
                            Proper = true;
                            break;
                        }
                    case "W":
                        {
                            Wardrobe();
                            Proper = true;
                            break;
                        }
                    case "S":
                        {
                            Boolean SDProper = false;
                            String Jump;                       
                            while (SDProper == false)
                            {
                                Pass = SmallDoor();
                                Console.WriteLine("Do you want to jump in the hole?([Y] or [N])");
                                Jump = Console.ReadLine().Trim().ToUpper();
                                Jump = Config.AntiEmpty(Jump);
                                if (Jump == "Y")
                                {
                                    if (Pass == true)
                                    {
                                        Dungeon1.DungeonRoomOne();
                                        Continue = Dungeon1.Continue();
                                        if (Continue == true)
                                        {
                                            Dungeon1.DungeonRoomTwo();
                                            Continue = Dungeon1.Continue();
                                        }
                                        if (Continue == true)
                                        {
                                            Dungeon1.DungeonRoomThree();
                                            Continue = Dungeon1.Continue();
                                        }
                                        if (Continue == true)
                                        {
                                            Dungeon1.HatSquidsThrone();
                                        }
                                        Proper = true;
                                        SDProper = true;
                                        if (Continue == false)
                                        {
                                            Proper = false;
                                            SDProper = true;
                                            Answer = "R";
                                        }                                
                                    }
                                }
                                else if (Jump == "N")
                                {
                                    Proper = true;
                                    SDProper = true;
                                }
                                else
                                {
                                    Console.WriteLine("Please enter 'Y' or 'N'");
                                }
                            }                           
                            break;
                        }
                    case "Q":
                        {
                            Config.GameEnd(0);
                            break;
                        }
                    case "R":
                        {
                            Console.WriteLine("Welcome back to the main entrance!");
                            Console.WriteLine("Where do you want to go?");
                            Console.WriteLine("The [P]ool");
                            Console.WriteLine("The [U]pside-Down House");
                            Console.WriteLine("The [K]itchen");
                            Console.WriteLine("The [W]ardrobe");
                            Console.WriteLine("The [S]mall Door");
                            Console.WriteLine("[Q]uit (this is not a room, this WILL quit the game.)");
                            Answer = Console.ReadLine().Trim().ToUpper();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("You did not enter a valid input.");
                            Console.WriteLine("Your options are Q, P, U, K, W, or S");
                            Answer = Console.ReadLine().Trim().ToUpper();
                            break;
                        }
                }
			}
            return Explore;
		}
		//Pool Room 
		public void Pool()
		{
			Console.WriteLine("You step through the Pool door and are instantly submerged in cool water.");
			Console.WriteLine("Luckily, you are somehow able to breath in the water.");
			Console.WriteLine("Looking around, you notice that the room contains an olympic sized swimming pool. \nDespite this, inside the pool is the only place there is no water.");
			Console.WriteLine("Everywhere else in the room is water.");
			Console.WriteLine("You think you here the muted roar of a waterfall, but you can't see one anywhere.");
			Console.WriteLine("Press enter to continue.");
			Console.ReadLine();
		}
		//UpsideDown House Room
		public void UpsideDown()
		{
			Console.WriteLine("You open the Upside-Down door and carefully step through it, finding yourself standing on an empty floor.");
			Console.WriteLine("When you look up, you realize you are actually on a ceiling. \nOn the ceiling-floor with you are multiple upside down chandeliers, standing straight up.");
			Console.WriteLine("On the celing (or is it the floor?) above you are various upsidedown furniture, \nincluding a lovely wooden table with chairs around it.");
			Console.WriteLine("On the tables are bowls of soup. You have no idea how the soup is staying inside the upside-down bowls.");
			Console.WriteLine("Press enter to continue.");
			Console.ReadLine();
		}
		//Kitchen Room
		public void Kitchen()
		{
            int FoodChoice = Config.RandomG(Setup.UserFood.Count());
			Console.WriteLine("You stupidly grab the flaming handle of the kitchen door. Lucky for you, it feels perfectly fine. \nYou turn the handle and enter the room.");
			Console.WriteLine("You find yourself in a perfectly normal kitchen, aside from the fact that everything is on fire. \nYou are also on fire, but it's apparently not a problem.");
			Console.WriteLine("There's a lovely stone counter in here with various kitchen utensils. They are, of course on fire. \nEverything is on fire.");
			Console.BackgroundColor = ConsoleColor.White;
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("Even the text is on fire.");
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Press enter to look around in a little more detail.");
			Console.ReadLine();
            Console.WriteLine("Way up on a shelf you can see "+Setup.UserFood[FoodChoice]);
            Console.WriteLine("As expected, it's on fire. Still looks good though!");
            System.Threading.Thread.Sleep(1000);
            FoodChoice = Config.RandomG(Setup.UserFood.Count());
            Console.WriteLine("Press enter to look around in even more detail.");
            Console.ReadLine();
            Console.WriteLine("Over next to the burning sink is "+Setup.UserFood[FoodChoice]);
            Console.WriteLine("It's actually not on fire. \nNo wait, that was just a trick of the light, it's burning.");
            System.Threading.Thread.Sleep(1000);
            FoodChoice = Config.RandomG(Setup.UserFood.Count());
            Console.WriteLine("Press enter to open the flaming fridge and see what it contains.");
            Console.ReadLine();
            Console.WriteLine("There's only one item of food in the fridge, a " + Setup.UserFood[FoodChoice]);
            Console.WriteLine("It's on fire. Why is there even a fridge? Does it keep the fire cool? That makes no sense!");
            Console.WriteLine("Press enter to leave this flaming room of fire.");
            Console.ReadLine();
            Console.WriteLine();                       
		}
		//Wardrobe Room
		public void Wardrobe()
		{
			Console.WriteLine("You open the door to the Wardrobe and enter.");
			Console.WriteLine("The room is filled with coatstands. Coatstands everywhere. \nEvery single coatstand has at least one hat on it.");
			Console.WriteLine("There are also countless hooks on the walls, each hook containing a hat.");
			Console.WriteLine("There are Baseball caps, Dunce Caps, Top hats, helmets, turbans, fedoras, fezs, beanies, berets.");
			Console.WriteLine("You get the idea, there are a LOT of hats.");
			Console.WriteLine("Press enter to continue.");
			Console.ReadLine();
		}
		//Small Door
		public Boolean SmallDoor()
		{
            Boolean Proper = false;
			String Answer;
			Boolean Pass = false;
			Console.WriteLine("You go to the small door and bend down low to open it's tiny handle.");
			Console.WriteLine("The door swings open. Suddenly, you're standing in HUGE room with a massive door in front of you.");
			Console.WriteLine("In the room is the SupremeSquid again, as well as a table with a cookie that's labeled 'Eat me'.");
			Console.WriteLine("No you do not need to file a copyright complaint.");
            //Repeats until valid input
            while (Proper == false)
            {
                Console.WriteLine("How do you want to deal with this door?(Enter the bracketed letter to choose.)");
                Console.WriteLine("[A]sk Supremesquid for help?");
                Console.WriteLine("[O]pen the door on your own?");
                Console.WriteLine("[E]at the cookie?");
                Console.WriteLine("[Q]uit?");
                Answer = Console.ReadLine().Trim().ToUpper();
                Answer = Config.AntiEmpty(Answer);
                Answer = Answer.Substring(0, 1);
                if (Answer != "Q")
                {
                    if (Answer != "A")
                    {
                        if (Answer != "O")
                        {
                                if (Answer == "E")
                                {
                                    Console.WriteLine("You pick up the cookie. It's peanut-butter flavored!");
                                    Proper = true;
                                    Config.GameEnd(4);
                                }
                                else
                                {                               
                                    Console.WriteLine("You did not enter a valid answer, Please try again.");                                    
                                }
                        }
                        else
                        {
                            DoorOpen();
                            Proper = true;
                            Pass = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("You ask the SupremeSquid for help. You feel like it laughs at you?");
                        Console.WriteLine("It's hard to tell when it doesn't have a face. Or a mouth.");
                        Console.WriteLine("Nevertheless, it floats into the air and turns the doorhandle.");
                        Console.WriteLine("The massive door swings outwards, revealing a hole in the floor. Hurray!");
                        Proper = true;
                        Pass = true;
                    }
                }
                else
                {
                    Proper = true;
                    Config.GameEnd(0);
                }                
            }
			Console.WriteLine("Press enter to continue.");
			Console.ReadLine();
			return Pass;
		}
		//Opens the door in the smalldoor room
		public void DoorOpen()
		{
			Console.WriteLine("You try to open the door on your own.");
			Console.WriteLine("You can't even reach the doorknob.");
			Console.WriteLine("The SupremeSquid seems to laugh at you(It's hard to tell when it doesn't have a face. Or a mouth.)");
			Console.WriteLine("It then floats into the air and turns the doorhandle.");
			Console.WriteLine("The massive door swings outwards, revealing a hole in the floor. Hurray!");
			Console.WriteLine("Press enter to continue");
			Console.ReadLine();
		}
	}
}
