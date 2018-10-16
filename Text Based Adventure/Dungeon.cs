using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Name: SzeTu-HW6
 * Class: IGME105
 * Author: Matthew Sze-Tu
 * Purpose: Dungeon of Text-Based Adventure
 * Recent Changes: Added all room puzzles
 */
namespace Text_Based_Adventure
{
	class Dungeon
	{
		//Dungeon
		//New spawn point
		//Room 2
		//Large chasm, rickety Wooden bridge spanning it
		//Basket Holding matches, saw, kite, tape, and a candle
		//Player can cut or burn the bridge
		//If player tries to cross holding anything, bridge snaps
		//Player can cross empty handed
		//Room 3
		// Narrow stone pathway over another chasm
		//While crossing pathway, player will hear a *swish* 
		//If player moves left or right, they fall and die
		//Possibly put a timed delay?
		//Player ducks, scythe swings over their head. 
		//Potentially do 2 more times?
		//Room 4
		//Final boss/puzzle which unlocks exit
		//exit to win

		/*Room 1
		/Simple, two key puzzle
		Don't use either key to continue */
		public void DungeonRoomOne()
		{
			string Answer;
			Console.WriteLine("You leap into the hole and fall for a very very long time.");
			Console.WriteLine("You land in a massive pool of water. The water then drains away, leaving you in a nice dry room.");
			Console.WriteLine("You're in a steel boxlike room, which now has a ceiling somehow. There are no light sources, yet the room is well lit.");
			Console.WriteLine("There is a wooden door in one of the walls, with a comically large padlock on it. \nYou aren't sure what the padlock is even connected to.");
			Console.WriteLine("There is a table with two large keys on it, a black key and a white key. Next to the table, on the ground, is the DunceSquid from earlier.");
			Console.WriteLine("You think the DunceSquid is judging you, but it's too brainless to even manage that.");
			Console.WriteLine("What would you like to do?(Enter the bracketed letter to choose)");
			Console.WriteLine("Pick up the [B]lack key and use it on the padlock.");
			Console.WriteLine("Pick up the [W]hite key and use it on the padlock.");
			Console.WriteLine("[K]ick the DunceSquid.");
			Console.WriteLine("Try to open the [L]ocked door.");
			Console.WriteLine("[Q]uit.");
			Answer = Console.ReadLine().Trim().ToUpper();
			if (string.IsNullOrEmpty(Answer) == true)
			{
				Console.WriteLine("If you aren't going to enter anything I'll just assume you don't want to play.");
				Config.GameEnd(0);
			}
			Answer = Answer.Substring(0, 1);
			switch (Answer)
			{
				case "Q":
					Config.GameEnd(0);
					break;
				case "B":
					{
						Console.WriteLine("You pick up the black key, insert it into the padlock, and turn it.");
						Config.GameEnd(5);
						break;
					}
				case "W":
					{
						Console.WriteLine("You pick up the white key, insert it into the padlock, and turn it.");
						Console.WriteLine("Press enter to continue.");
						Console.ReadLine();
						Config.GameEnd(6);
						break;
					}
				case "K":
					{
						Console.WriteLine("You rear back and punt the DunceSquid with all your might!");
						Config.GameEnd(2);
						break;
					}
				case "L":
					{
						Console.WriteLine("You grab the doorhandle of the locked and turn it.");
						Console.WriteLine("The door swings open with ease, revealing the next room.");
						Console.WriteLine("Did I say the door was locked? I could have sworn the door was locked.");
						Console.WriteLine("It just kind of made sense for the door to be locked, you know? I guess it wasn't");
						Console.WriteLine("I guess it wasn't, I'm sorry.");
						Console.WriteLine("Press enter to continue.");
						Console.ReadLine();
						break;
					}
				default:
					Console.WriteLine("If you aren't going to enter a valid input I'm just going to guess you want to kick the DunceSquid.");
					Console.WriteLine("You rear back and punt the DunceSquid with all your might!");
					Config.GameEnd(2);
					break;
			}
		}
		/*Room 2
		 * Cross the bridge or fall
		 * While crossing, duck or get hit by a bus
		 */
		public void DungeonRoomTwo()
		{
			string Answer;
			Console.WriteLine("Through the door is, surprise surprise, another room! This one is pretty simple.");
			Console.WriteLine("It's a large room with a single stone bridge in front of you, with no guardrails.");
			Console.WriteLine("The room is lit by torches on the wall.");
			Console.WriteLine("On either side of the stone bridge is an endless yawning void. You cannot see the bottom.");
			Console.WriteLine("What do you do now?(I think you get the idea at this point)");
			Console.WriteLine("Grab one of the [T]orches");
			Console.WriteLine("[C]ross the bridge.");
			Console.WriteLine("[Q]uit");
			Console.WriteLine("[J]UMP IN THE PIT!!!!!");
			Answer = Console.ReadLine().Trim().ToUpper();
			if (string.IsNullOrEmpty(Answer) == true)
			{
				Console.WriteLine("If you aren't going to enter anything I'll just assume you don't want to play.");
				Config.GameEnd(0);
			}
			Answer = Answer.Substring(0, 1);
			switch (Answer)
			{
				case "Q":
					{
						Config.GameEnd(0);
						break;
					}
				case "T":
					{
						Console.WriteLine("You walk over and grab one of the torches.");
						Console.WriteLine("Unluckily for you, the torches are on the walls, OVER the pit.");
						Console.WriteLine("You fall into the pit as you try to go to the torch.");
						Config.GameEnd(7);
						break;
					}
				case "J":
					{
						Console.WriteLine("WHY WOULD YOU DO THAT?");
						Console.WriteLine("Alright, uhhhh, I guess you jump into the pit? Maybe you do a sick flip or something I don't know.");
						Config.GameEnd(7);
						break;
					}
				case "C":
					{
						string CrossAnswer;
						Console.WriteLine("You begin to cross the bridge.");
						Console.WriteLine("Once you're halfway across, you hear a loud whooshing sound.");
						Console.WriteLine("What do you do?");
						Console.WriteLine("[D]uck!");
						Console.WriteLine("TAKE IT LIKE A [M]AN!");
						CrossAnswer = Console.ReadLine().Trim().ToUpper();
						if (String.IsNullOrEmpty(CrossAnswer) == true)
						{
							Console.WriteLine("INACTION IS INACTION EVEN IF YOU DON'T SAY SO!");
							Console.WriteLine("LET'S DO THIS!");
							Config.GameEnd(8);
						}
						CrossAnswer = CrossAnswer.Substring(0, 1);
						if (CrossAnswer != "D")
						{
							if (CrossAnswer == "M")
							{
								Console.WriteLine("YEAH THAT'S THE SPIRIT!");
								Config.GameEnd(8);
							}
							else
							{
								Console.WriteLine("REAL MEN BREAK THE RULES! YOU'RE GONNA STAND STILL AND TAKE IT!");
								Config.GameEnd(8);
							}
						}
						else
						{
							Console.WriteLine("You duck, and a massive schoolbus sails over your head, honking the entire time.");
							Console.WriteLine("The stand back up and finish crossing the bridge.");
							Console.WriteLine("You open the door and move into the next room");
							Console.WriteLine("Press enter to continue.");
							Console.ReadLine();
						}
					}
					break;
			}
		}
		/*Room 3
		 * Light the dark room with a candle
		 * Get out of the pit with either hat
		 */
		public void DungeonRoomThree()
		{
			string Answer;
			String PitAnswer;
			Console.WriteLine("You are now in a pitch black room. You can't see a thing. What do you do?");
			Console.WriteLine("[C]urse the Darkness.");
			Console.WriteLine("[L]ight a Candle!");
			Console.WriteLine("[Q]uit.");
			Answer = Console.ReadLine().Trim().ToUpper();
			if (String.IsNullOrEmpty(Answer) == true)
			{
				Console.WriteLine("If you aren't going to enter anything I'll just assume you don't want to play.");
				Config.GameEnd(0);
			}
			Answer = Answer.Substring(0, 1);
			if (Answer == "Q")
			{
				Config.GameEnd(0);
			}
			else if (Answer == "C")
			{
				Console.WriteLine("You curse the darkness. Like, you really lay into it.");
				Console.WriteLine("Seriously, you say some pretty hurtful stuff. Didn't your parents teach you not to use that language?");
				Config.GameEnd(9);
			}
			else if (Answer == "L")
			{
				Console.WriteLine("You light a candle. I have no idea where you found a candle. or what you lit it with, but you do it anyways.");
				Console.WriteLine("Good job.");
				Console.WriteLine("Press enter to continue.");
				Console.ReadLine();
			}
			else
			{
				Console.WriteLine("If you aren't going to enter a valid response, I'll just assume you're cursing the Darkness.");
				Console.WriteLine("You curse the darkness. Like, you really lay into it.");
				Console.WriteLine("Seriously, you say some pretty hurtful stuff. Didn't your parents teach you not to use that language?");
				Config.GameEnd(9);
			}
			Console.WriteLine("The candle miraculously lights up the whole room!");
			Console.WriteLine("You're at the bottom of a pit. Way way waaaaaaaaaaaaaaaaaaaaay up above you can make out a pinprick of light.");
			Console.WriteLine("In front of you, on posts, are two hats. Which one do you put on?");
			Console.WriteLine("The [P]ropeller hat?");
			Console.WriteLine("The [C]limbing helmet?");
			Console.WriteLine("[Q]uit");
			PitAnswer = Console.ReadLine().Trim().ToUpper();
			if (String.IsNullOrEmpty(PitAnswer) == true)
			{
				Console.WriteLine("If you aren't going to enter anything I'll just assume you don't want to play.");
				Config.GameEnd(0);
			}
			PitAnswer = PitAnswer.Substring(0, 1);
			if (PitAnswer == "Q")
			{
				Config.GameEnd(0);
			}
			else if (PitAnswer == "P")
			{
				Console.WriteLine("You put on the propeller hat. You look absolutely ridiculous in that.");
				Console.WriteLine("You spin the propeller and make airplane noises. \nAirplanes don't even have propellers why are you doing that?");
				Console.WriteLine("The hat lifts you up into the air and out of the pit.");
				Console.WriteLine("I'm amazed that that worked. Truly. Good job getting out of the pit, you are now outside.");
				Console.WriteLine("The hat flies off your head and off into the distance. Goodbye, hat!");
				Console.WriteLine("Press enter to continue.");
				Console.ReadLine();
			}
			else if (PitAnswer == "C")
			{
				Console.WriteLine("You put on the climbing helmet. It makes you feel invigorated!");
				Console.WriteLine("You run towards the wall, jump at it, and grab hold of the rocks.");
				Console.WriteLine("With your SICK climbing helmet you easily scale the extremely tall side of the pit and pop up outside.");
				Console.WriteLine("The climbing helmet climbs off your head and climbs back down into the pit. Goodbye, helmet!");
				Console.WriteLine("Press enter to continue.");
				Console.ReadLine();
			}
			else
			{
				Console.WriteLine("You failed to enter a valid answer, let's just say you want to use the propeller hat.");
				Console.WriteLine("You put on the propeller hat. You look absolutely ridiculous in that.");
				Console.WriteLine("You spin the propeller and make airplane noises. \nAirplanes don't even have propellers why are you doing that?");
				Console.WriteLine("The hat lifts you up into the air and out of the pit.");
				Console.WriteLine("I'm amazed that that worked. Truly. Good job getting out of the pit, you are now outside.");
				Console.WriteLine("The hat flies off your head and off into the distance. Goodbye, hat!");
				Console.WriteLine("Press enter to continue.");
				Console.ReadLine();
			}
		}
		/*Final room of the dungeon
		 * Confront Hatsquid
		 * Get out of the tower
		 * */
		public void HatSquidsThrone()
		{
			string Answer;
			Console.WriteLine("You are standing on the very top of Hatsquid's Wonderful Tower.");
			Console.WriteLine("The pit you've climbed out of is gone. All around you is a gorgeous view as far as the eye can see.");
			Console.WriteLine("You walk over to the edge of the tower and look down. You are VERY high up, wouldn't want to fall now.");
			Console.WriteLine("On the middle of the tower roof is a magnificent fabulously detailed golden throne. It looks incredibly comfy.");
			Console.WriteLine("Sitting (Standing? You aren't quite sure) on the throne is THE Hatsquid himself.");
			Console.WriteLine("The True Hatsquid  is a Black Tophat with eight tentacles coming out of the bottom.");
			Console.WriteLine("He (we aren't quite sure how we know it's a he) carries an ornate cane. \nThe throne he's on is far too big for him");
			Console.Write("Yet he still looks quite regal.");
			Console.WriteLine("There's no way down from this tower (why did you come up here in the first place?). What do you want to do?");
			Console.WriteLine("[K]neel before His Majesty.");
			Console.WriteLine("[D]emand that he let you down from the tower.");
			Console.WriteLine("[B]eg to be let free.");
			Console.WriteLine("Ask [P]olitely to be let free");
			Console.WriteLine("[A]ttack The Great Hatsquid.");
			Console.WriteLine("[Q]uit");
			Answer = Console.ReadLine().Trim().ToUpper();
			if (string.IsNullOrEmpty(Answer) == true)
			{
				Console.WriteLine("If you aren't going to enter anything I'll just assume you don't want to play.");
				Config.GameEnd(0);
			}
			Answer = Answer.Substring(0, 1);
			switch (Answer)
			{
				case "Q":
					{
						Config.GameEnd(0);
						break;
					}
				case "K":
					{
						Console.WriteLine("You respectfully kneel before Hatsquid. He seems very pleased.");
						Console.WriteLine("You swear your life to him, citing your puzzle-solving skills as why he should accept you.");
						Console.WriteLine("He accepts!");
						Config.WinGame(1);
						break;
					}
				case "D":
					{
						Console.WriteLine("Well that's not very polite.");
						Console.WriteLine("You loudly and aggressively demand that The Great Hatsquid lets you down from his Wonderful Tower.");
						Console.WriteLine("He seems incredibly alarmed. Seems no one has ever taken that tone with him.");
						Console.WriteLine("Congrats! You're unique!");
						Config.GameEnd(10);
						break;
					}
				case "B":
					{
						Console.WriteLine("You grovel and beg to be let down from the tower.");
						Console.WriteLine("It's pretty embarrassing to watch.");
						Console.WriteLine("The Great Hatsquid seems to laugh at you (again, hard to tell when he doesn't actually have a mouth).");
						Console.WriteLine("You ramp up the act. You're really crying now, rivers of tears and all. \nYou consider trying to kiss it's tentacles but decide against it.");
						Console.WriteLine("The Great Hatsquid is moved by your tears!");
						Config.WinGame(2);
						break;
					}
				case "P":
					{
						Console.WriteLine("You ask very politely if The Great Hatsquid can help you get down from his Wonderful Tower.");
						Console.WriteLine("He listens attentively (He doesn't even have ears how is he doing this?) and nods (which moves his entire body/hat).");
						Console.WriteLine("He gestures with a tentacle to the side of the tower.");
						Console.WriteLine("You walk over to where he gestured. Where once there was nothing, there is now a very very very tall ladder.");
						Console.WriteLine("Press enter to begin descending the ladder.");
						Console.ReadLine();
						Config.WinGame(3);
						break;
					}
				case "A":
					{
						Console.WriteLine("You draw your sword (Where did you get a sword? Why didn't you tell me? \nI'm the narrator I need to know these things!");
						Console.WriteLine("and lunge forwards at The Great Hatsquid.");
						Console.WriteLine("The Great Hatsquid jumps into the air, causing you to stab into the throne. Come on man, \nthat was a perfectly good throne!");
						Config.GameEnd(11);
						break;
					}
			}

		}
	}
}
