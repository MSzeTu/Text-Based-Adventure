using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Name: SzeTu-HW10
 * Class: IGME105
 * Author: Matthew Sze-Tu
 * Purpose: Various Creatures of text-based adventure
 * Recent Changes: Created
 */
namespace Text_Based_Adventure
{
	public class Creatures
	{
		//Class for Hat Wearing Alligator
		public class FancyAlligator
		{

		}

		//Class for Hat Wearing Bird
		public class DapperBird
		{

		}

		//Class for HatSquids
		public abstract class HatSquid
		{
            private int attackSkill;
            //Abstract for attacking
            public abstract Boolean Attack();

            protected Boolean IsAttackSuccessful()
            {
                Boolean SAttack=false;
                Random Roll = new Random();
                int AttackRoll = Roll.Next(1, 7);
                if (attackSkill >= AttackRoll)
                {
                    SAttack = true;
                }
                return SAttack;
            }
            public HatSquid(int ASkill)
            {
                attackSkill = ASkill;
            }
		}

		//Class for VikingSquid
		public class VikingSquid: HatSquid
		{
            
            string HatName = "VikingSquid";
            public string ReturnName()
            {
                return HatName;
            }
            const int SKILL_LEVEL = 5;
            //Constructor to set skill level
            public VikingSquid() : base(SKILL_LEVEL)
            {
                
            }
            //Attack method for attacking the player
            public override Boolean Attack()
            {
                Boolean SuccessfulAttack = false;
                Console.WriteLine("The VikingSquid prepares to attack!");
                SuccessfulAttack = IsAttackSuccessful();
                if (SuccessfulAttack == true)
                {
                    Console.WriteLine("The VikingSquid throws a MASSIVE axe at you!");
                }
                if (SuccessfulAttack == false)
                {
                    Console.WriteLine("The Vikingsquid throws a can of Axe Body Spray at you!");
                }
                return SuccessfulAttack;
            }
        }

		//Class for PirateSquid
		public class PirateSquid: HatSquid
		{
            string HatName = "PirateSquid";
            public string ReturnName()
            {
                return HatName;
            }
            const int SKILL_LEVEL = 3;
            //Constructor to set skill level
            public PirateSquid() : base(SKILL_LEVEL)
            {
            }

            //Attack method for attacking the player
            public override Boolean Attack()
            {
                Boolean SuccessfulAttack = false;
                Console.WriteLine("The PirateSquid prepares to attack!");
                SuccessfulAttack = IsAttackSuccessful();
                if (SuccessfulAttack == true)
                {
                    Console.WriteLine("The PirateSquid shoots you with a lot of flintlocks!");
                }
                if (SuccessfulAttack == false)
                {
                    Console.WriteLine("The PirateSquid eats an orange!");
                }
                return SuccessfulAttack;
            }
        }


	}
}
