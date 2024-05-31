using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Barbarian : Hero
    {
        public Barbarian(string name) : base(name)
        {
        }

        public override int Attack()
        {
            int attack = base.Attack();
            if (ThrowDice(10))
            {
                attack *= 2; // Barbarian has a chance to deal double damage
            }
            return attack;
        }

        public override void TakeDamage(int incomingDamage)
        {
            if (ThrowDice(20))
            {
                Heal(incomingDamage / 2); // Barbarian can heal part of the incoming damage
            }
            base.TakeDamage(incomingDamage);
        }
    }
}
