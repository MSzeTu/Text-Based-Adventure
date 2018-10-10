using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Name: SzeTu-HW5
 * Class: IGME105
 * Author: Matthew Sze-Tu
 * Purpose: Configure method of text-based adventure
 * Recent Changes: Overloaded Dice Roll
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
			//Call Greeting
			MiniHatSquid.Greeting(SupremeSquid, DunceSquid);
		}
    }
}
