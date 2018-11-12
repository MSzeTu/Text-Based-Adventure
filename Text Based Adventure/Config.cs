using System;
/*Name: SzeTu-HW9
 * Class: IGME105
 * Author: Matthew Sze-Tu
 * Purpose: Configure method of text-based adventure
 * Recent Changes: Added ANOTHER Dice Roll Method
 */
namespace Text_Based_Adventure
{
    class Config
	{		
		//Roll die with specified sides
		public static int DiceRoll(int min, int max)
		{
			Random Roll = new Random();
			int answer = Roll.Next(min, max);
			return answer;
		}
        //Roll a number of dice with specified sides 
        public static int DiceRoll(int min, int max, int DiceNum)
        {
            Random Roll = new Random();
            int answer = Roll.Next(min, max);
            answer = (answer * DiceNum) / DiceNum;
            return answer;
        }
		//Create MiniHatSquids
		public static void BuildHatSquids()
		{
            int ArrayChoice = Config.DiceRoll(0, 10);
			//Create Mini Hat Squids
			MiniHatSquid DunceSquid = new MiniHatSquid();
			MiniHatSquid SupremeSquid = new MiniHatSquid();
            //Set attributes
            DunceSquid.Health = DunceSquid.AHealth[0];
            DunceSquid.TentacleNum = 0;
			DunceSquid.Hat = "Dunce Cap";
            DunceSquid.Accesories = DunceSquid.AAccesories[9];
			DunceSquid.Mood = DunceSquid.AMood[0];
            SupremeSquid.Health = SupremeSquid.AHealth[ArrayChoice];
            SupremeSquid.TentacleNum = Program.TentacleNum[ArrayChoice];
            SupremeSquid.Accesories = SupremeSquid.AAccesories[ArrayChoice];
            SupremeSquid.Mood = SupremeSquid.AMood[ArrayChoice];
			SupremeSquid.Hat = "Supreme Brand Flat-brimmed Cap.";
			//Call Greeting
			MiniHatSquid.Greeting(SupremeSquid, DunceSquid);
		}
		//Wins the Game and gives one of the endings as needed
		public static void WinGame(int win)
		{
			switch (win)
			{
				case 1:
					{
						Console.WriteLine(Setup.PlayerName + " spends the rest of their life as a loyal servant to the Great Hatsquid.");
						Console.WriteLine("It's a pretty good job, full benefits, good pay, free dental, delicious meals.");
						Console.WriteLine("Eventually, they rise up to be Hatsquid's 1st Tentacle Man, and from this position, \nhelp Hatsquid conquer the entire world.");
						Console.WriteLine("This yields a new age of peace and prosperity that lasts until the end of all time.");
						Console.WriteLine("Congratulations!You won!");
						//Prevents looping
						Console.WriteLine("Press enter to close the game.");
						Console.ReadLine();
						Environment.Exit(0);
						break;
					}
				case 2:
					{
						Console.WriteLine("The Great Hatsquid pity's you! He snaps his fingers (HE DOESN'T EVEN HAVE FINGERS) and you are lifted into the air.");
						Console.WriteLine("You float off away from the tower, reflecting on your journey along the way.");
						Console.WriteLine("Eventually you're dropped off at a lovely hotel in Hawaii. How kind of The Great Hatsquid!");
						Console.WriteLine("You spend the rest of your life in Hawaii, and get to witness The Great Hatsquid conquer the entire world.");
						Console.WriteLine("Congratulations!"+Setup.PlayerName+" has won!");
						//Prevents looping
						Console.WriteLine("Press enter to close the game.");
						Console.ReadLine();
						Environment.Exit(0);
						break;
					}
				case 3:
					{
						Console.WriteLine("You turn and look at The Great Hatsquid. He waves at you to leave.");
						Console.WriteLine("You nod, and begin to climb down the ladder.");
						SnakeEater();
						Console.WriteLine("You finally reach the bottom of the ladder. Wasn't that a lovely song?");
						Console.WriteLine("Satisified with your journey that you gained nothing from, you head home.");
						Console.WriteLine("Congratulations!"+Setup.PlayerName + " has won!");
						//Prevents looping
						Console.WriteLine("Press enter to close the game.");
						Console.ReadLine();
						Environment.Exit(0);
						break;
					}
					//error message
				default:
					{
						Console.WriteLine("SOMETHING HAS GONE HORRIBLY WRONG. ABORTING PROGRAM!");
						Console.ReadLine();
						Environment.Exit(0);
						break;
					}
			}
		}
		//Use when a player loses to end the game
		public static void GameEnd(int loss)
		{
			Console.BackgroundColor = ConsoleColor.DarkRed;
			switch (loss)
			{
				case 0:
					{
						Console.WriteLine("You've chosen to quit the game. In other words, you lose!");
						Console.WriteLine("Thanks for playing! \nPress enter to close the game.");
						Console.ReadLine();
						Environment.Exit(0);
						break;
					}
				case 1:
					{
						Console.WriteLine("The door falls forwards and you are squashed flat.");
						Console.ReadLine();
						Console.WriteLine("The bridge beneath you then breaks, and the gators in the moat enjoy a nice meal!");
						Console.WriteLine(Setup.PlayerName + "'s adventure ends here, eaten by gators.");
						Console.WriteLine("Press any key to close the program.");
						Console.ReadLine();
						Environment.Exit(0);
						break;
					}
				case 2:
					{
						Console.WriteLine("The Duncesquid explodes violently, turning everything in a 500 foot radius into a fine, purple ash.");
						Console.WriteLine("This, of course, includes you. Maybe next time don't be such a jerk?");
						Console.WriteLine(Setup.PlayerName + "'s adventure ends here, blown up by the DunceSquid.");
						Console.WriteLine("Press any key to close the program.");
						Console.ReadLine();
						Environment.Exit(0);
						break;
					}
				case 3:
					{
						Console.WriteLine("The SupremeSquid jumps away from you, looking very angry. \nYou try to apologize, but it's too late.");
						Console.WriteLine("The SupremeSquid writes a diss track about you. Before you know it, hordes of rapid teenagers are mad at you.");
						Console.WriteLine("You're shamed everywhere you go. The world has no safe havens anymore.");
						Console.WriteLine(Setup.PlayerName + "'s adventure ends here, game-ended by the SupremeSquid's youtube fame.");
						Console.WriteLine("Press any key to close the program.");
						Console.ReadLine();
						Environment.Exit(0);
						break;
					}
				case 4:
					{
						Console.WriteLine("You eat the cookie. It's delicious!");
						Console.WriteLine("It's also poisoned. You die. Painfully.");
						Console.WriteLine("You really shouldn't eat random food you find lying around.");
						Console.WriteLine(Setup.PlayerName + "'s adventure ends here, killed by a poisonus cookie.");
						Console.WriteLine("Press any key to close the program.");
						Console.ReadLine();
						Environment.Exit(0);
						break;
					}
				case 5:
					{
						Console.WriteLine("The room begins to shrink around you.");
						Console.WriteLine("You try to curl into a ball and take up as little space as possible, but it doesn't help.");
						Console.WriteLine("Eventually the room closes around you, crushing you completely.");
						Console.WriteLine(Setup.PlayerName + "'s adventure ends here, every bone in their body crushed by the shrinking room.");
						Console.WriteLine("Press any key to close the program.");
						Console.ReadLine();
						Environment.Exit(0);
						break;
					}
				case 6:
					{
						Console.BackgroundColor = ConsoleColor.White;
						Console.ForegroundColor = ConsoleColor.Black;
						System.Console.Clear();					
						Console.WriteLine("The door swings open and you step through the doorway...");
						Console.WriteLine("");
						Console.WriteLine("Only to be met with nothingness.");
						Console.WriteLine("You turn around, but theres nothing. All around you is nothing. No color, no light, no sound.");
						Console.WriteLine("Welcome to the void! Enjoy your stay!");
						Console.WriteLine(Setup.PlayerName + "'s adventure ends here, trapped in the endless void.");
						Console.WriteLine("Press any key to close the program.");
						Console.ReadLine();
						Environment.Exit(0);
						break;
					}
				case 7:
					{
						Console.WriteLine("You fall. And you fall. And you fall. And you fall. And you fall.");
						Console.WriteLine("And you fall. And you fall. And you fall. And you fall. And you fall.");
						Console.WriteLine("And you fall. And you fall. And you fall. And you fall. And you fall.");
						Console.WriteLine("And you fall. And you fall. And you fall. And you fall. And you fall.");
						Console.WriteLine("And you fall. And you fall. And you fall. And you fall. And you fall.");
						Console.WriteLine("And you fall. And you fall. And you fall. And you fall. And you fall.");
						Console.WriteLine("And you fall. And you fall. And you fall. And you fall. And you fall.");
						Console.WriteLine("And you fall. And you fall. And you fall. And you fall. And you fall.");
						Console.WriteLine("And you fall. And you fall. And you fall. And you fall. And you fall.");
						Console.WriteLine("And you fall. And you fall. And you fall. And you fall. And you fall.");
						Console.WriteLine("And you fall. And you fall. And you fall. And you fall. And you fall.");
						Console.WriteLine(Setup.PlayerName + "'s adventure ends here, they're still falling.");
						Console.WriteLine("Press any key to close the program.");
						Console.ReadLine();
						Environment.Exit(0);
						break;
					}
				case 8:
					{
						Console.WriteLine("YOU STAND STILL AND TAKE IT LIKE A MAN!");
						Console.WriteLine("Unfortunately, everyone is equal, and men are no stronger or more resiliant than anyone else.");
						Console.WriteLine("A giant schoolbus flies through the air and slams into your head, knocking it clean off your body.");
						Console.WriteLine("Your body then falls into the pit. I have no idea where your head ended up.");
						Console.WriteLine(Setup.PlayerName + "'s adventure ends here, killed by HatSquid's schoolbus.");
						Console.WriteLine("Press any key to close the program.");
						Console.ReadLine();
						Environment.Exit(0);
						break;
					}
				case 9:
					{
						Console.WriteLine("Turns out, Darkness doesn't like being cursed very much. You really hurt it's feelings.");
						Console.WriteLine("Have you ever heard the phrase 'The Darkness was suffocating?' \nBecause this Darkness is, and it's not a pleasent experience for you.");
						Console.WriteLine(Setup.PlayerName + "'s adventure ends here, literally suffocated by Darkness. They were rude anyways so it's okay.");
						Console.WriteLine("Press any key to close the program.");
						Console.ReadLine();
						Environment.Exit(0);
						break;
					}
				case 10:
					{
						Console.WriteLine("Unfortunately, The Great Hatsquid decides he's not a huge fan of someone demanding things of him.");
						Console.WriteLine("He taps his cane on the ground twice, and before you can blink you're surronded by multiple copies of The Great Hatsquid.");
						Console.WriteLine("Each one grabs hold of one of your limbs, and what follows is not very pleasent.");
						Console.WriteLine(Setup.PlayerName + "'s adventure ends here. torn to pieces by The Great Hatsquid.");
						Console.WriteLine("Their body parts made some lovely decorations for his tower, though!");
						Console.WriteLine("Press any key to close the program.");
						Console.ReadLine();
						Environment.Exit(0);
						break;
					}
				case 11:
					{
						Console.WriteLine("The Great Hatsquid comes down with it's cane on the top of your head, knocking you out.");
						Console.WriteLine("Bet you wish you had a helmet, maybe you should have grabbed one when you got that sword!");
						Console.WriteLine("When you wake up, you're back in the main hall of the tower. Wow that sucks!");
						Console.WriteLine("Great, now you have to go all the way back up!");
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        break;
					}
				//error message
				default:
					{
						Console.WriteLine("SOMETHING HAS GONE HORRIBLY WRONG. ABORTING PROGRAM!");
						Console.ReadLine();
						Environment.Exit(0);
						break;
					}
					
			}
				
		}
		//Plays(writes) the song from Metal Gear Solid for a joke
		public static void SnakeEater()
		{
			Console.WriteLine("Continue pressing enter to go down the ladder.");
			Console.ReadLine();
			Console.WriteLine("What a thrill");
			Console.ReadLine();
			Console.WriteLine("With darkness and silence through the night");
			Console.ReadLine();
			Console.WriteLine("What a thrill");
			Console.ReadLine();
			Console.WriteLine("I'm searching and I'll melt into you");
			Console.ReadLine();
			Console.WriteLine("What a fear in my heart");
			Console.ReadLine();
			Console.WriteLine("But you're so supreme!");
			Console.ReadLine();
			Console.WriteLine("");
			Console.WriteLine("I give my life. not for honor, but for you");
			Console.ReadLine();
			Console.WriteLine("(Snake Eater)");
			Console.ReadLine();
			Console.WriteLine("In my time, there'll be no one else");
			Console.ReadLine();
			Console.WriteLine("Crime, it's the way I fly to you (Snake Eater)");
			Console.ReadLine();
			Console.WriteLine("I'm still in a dream, Snake Eater");
			Console.ReadLine();
			Console.WriteLine("");
			Console.WriteLine("Someday you go through the rain");
			Console.ReadLine();
			Console.WriteLine("And someday you feed on a tree frog");
			Console.ReadLine();
			Console.WriteLine("It's ordeal, the trial to survive.");
			Console.ReadLine();
			Console.WriteLine("For the day we see new light");
			Console.ReadLine();
			Console.WriteLine("");
			Console.WriteLine("I give my life. not for honor, but for you");
			Console.ReadLine();
			Console.WriteLine("(Snake Eater)");
			Console.ReadLine();
			Console.WriteLine("In my time, there'll be no one else");
			Console.ReadLine();
			Console.WriteLine("Crime, it's the way I fly to you (Snake Eater)");
			Console.ReadLine();
			Console.WriteLine("I'm still in a dream, Snake Eater");
			Console.ReadLine();
			Console.WriteLine("I'm still in a dream, Snake Eater");
			Console.ReadLine();
			Console.WriteLine("(I do not own the rights to the song 'Snake Eater' \n all credit goes to the owners and creators.");
		}
        //Prevents errors when no input is entered
        public static string AntiEmpty(string input)
        {
            while (string.IsNullOrEmpty(input) == true)
            {
                Console.WriteLine("You did not enter anything. Please enter SOMETHING at all.");
                input = Console.ReadLine().Trim().ToUpper();
            }
            input = input.Trim().ToUpper();
            return input;
        }
        //Prevents errors when no input is entered without changing the case of the input
        public static string AntiEmptyC(string input)
        {
            while (string.IsNullOrEmpty(input) == true)
            {
                Console.WriteLine("You did not enter anything. Please enter SOMETHING at all.");
                input = Console.ReadLine();
            }
            input = input.Trim();
            return input;
        }

        //Random Generator that goes from 0 to where we want it to go
        public static int RandomG(int limit)
        {
            int Returned;
            Random Gen = new Random();
            Returned = Gen.Next(0, limit);
            return Returned;

        }
    }
}
