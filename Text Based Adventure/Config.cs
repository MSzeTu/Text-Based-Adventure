using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Name: SzeTu-HW4
 * Class: IGME105
 * Author: Matthew Sze-Tu
 * Purpose: Configure method of text-based adventure
 * Recent Changes: Created, Added DiceRoll
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
    }
}
