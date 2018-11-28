using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_Adventure
{
    //Class for HatSquids
    public abstract class HatSquid
    {
        private int attackSkill;
        //Abstract for attacking
        public abstract Boolean Attack();
        public abstract string ReturnName();

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
        public HatSquid(int ASkill)
        {
            attackSkill = ASkill;
        }
    }
}
