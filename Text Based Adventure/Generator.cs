using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzeTuM_HW
{
	class Generator
	{
		public static int DiceRoll()
		{
			Random Roll = new Random();
			int answer = Roll.Next(1, 7);
			return answer;
		}

	}
}
