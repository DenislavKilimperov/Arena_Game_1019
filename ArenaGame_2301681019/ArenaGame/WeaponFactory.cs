using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public static class WeaponFactory
    {
        public static Weapon CreateSword()
        {
            return new Weapon("Sword", 20, (attacker, defender) =>
            {
                // Sword has a chance to deal double damage
                if (Random.Shared.Next(100) < 10)
                {
                    defender.TakeDamage(attacker.Strength);
                }
            });
        }

        public static Weapon CreateBow()
        {
            return new Weapon("Bow", 10, (attacker, defender) =>
            {
                // Bow has a chance to poison the enemy
                if (Random.Shared.Next(100) < 20)
                {
                    defender.TakeDamage(30);
                }
            });
        }

        public static Weapon CreateDagger()
        {
            return new Weapon("Dagger", 15, (attacker, defender) =>
            {
                // Dagger has a chance to make the enemy bleed over time
                if (Random.Shared.Next(100) < 15)
                {
                    defender.TakeDamage(10);
                    defender.TakeDamage(10);
                }
            });
        }
    }
}
