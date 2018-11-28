using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Name: SzeTu-HW11
 * Class: IGME105
 * Author: Matthew Sze-Tu
 * Purpose: Sets up the text-based adventure
 * Recent Changes: Child of HatSquid
 */
namespace Text_Based_Adventure
{
    //Class for VikingSquid
    public class VikingSquid : HatSquid
    {

        string HatName = "VikingSquid";
		//Returns HatSquid name
        public override string ReturnName()
        {
            return HatName;
        }
        const int SKILL_LEVEL = 4;
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
                Console.WriteLine("The VikingSquid throws a can of Axe Body Spray at you!");
                Console.WriteLine("You use it. You smell great! The VikingSquid is sated.");
            }
            return SuccessfulAttack;
        }
    }
}
