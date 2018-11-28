using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Name: SzeTu-HW11
 * Class: IGME105
 * Author: Matthew Sze-Tu
 * Purpose: Parent class to the other HatSquids
 * Recent Changes: created
 */
namespace Text_Based_Adventure
{
    //Class for HatSquids
    public abstract class HatSquid
    {
        private int attackSkill;
        //Abstract for attacking
        public abstract Boolean Attack();
		//Abstract for returning name
        public abstract string ReturnName();
		//Checks if Attack is successful or not
        protected Boolean IsAttackSuccessful()
        {
            Boolean SAttack = false;
            Random Roll = new Random();
            int AttackRoll = Roll.Next(1, 7);
            if (attackSkill >= AttackRoll)
            {
                SAttack = true;
            }
            return SAttack;
        }
		//Constructor that sets the private variable
        public HatSquid(int ASkill)
        {
            attackSkill = ASkill;
        }
    }
}
