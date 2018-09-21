using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Name: SzeTu-HW3
 * Class: IGME105
 * Author: Matthew Sze-Tu
 * Purpose: Generate Random Numbers 
 * 
 */
namespace SzeTuM_HW
{
	class Generator
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
