using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Name: SzeTu-HW4
 * Class: IGME105
 * Author: Matthew Sze-Tu
 * Purpose: Create a text-based adventure
 * Recent Changes: Created, Added DiceRoll
 */
namespace Text_Based_Adventure
{
	class Config
	{
		

		//Roll 6 sided dice
		public static int DiceRoll()
		{
			Random Roll = new Random();
			int answer = Roll.Next(1, 7);
			return answer;
		}
	}
}
