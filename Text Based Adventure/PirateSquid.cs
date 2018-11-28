using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Name: SzeTu-HW11
 * Class: IGME105
 * Author: Matthew Sze-Tu
 * Purpose: Child of HatSquid
 * Recent Changes: created
 */
namespace Text_Based_Adventure
{
    //Class for PirateSquid
    public class PirateSquid : HatSquid
    {
        string HatName = "PirateSquid";
		//Returns Squid Name
        public override string ReturnName()
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
                Console.WriteLine("You're completely fine!");
            }
            return SuccessfulAttack;
        }
    }
}
