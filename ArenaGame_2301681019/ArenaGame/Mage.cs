using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Mage : Hero
    {
        public Mage(string name) : base(name)
        {
        }

        public override int Attack()
        {
            int attack = base.Attack();
            if (ThrowDice(20))
            {
                attack += 50; // Mage has a chance to cast a powerful spell
            }
            return attack;
        }

        public override void TakeDamage(int incomingDamage)
        {
            if (ThrowDice(15))
            {
                incomingDamage /= 2; // Mage can reduce incoming damage with a shield spell
            }
            base.TakeDamage(incomingDamage);
        }
    }
}
