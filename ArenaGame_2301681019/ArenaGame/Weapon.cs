using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Weapon
    {
        public string Name { get; private set; }
        public int DamageBonus { get; private set; }
        public Action<Hero, Hero> SpecialEffect { get; private set; }

        public Weapon(string name, int damageBonus, Action<Hero, Hero> specialEffect)
        {
            Name = name;
            DamageBonus = damageBonus;
            SpecialEffect = specialEffect;
        }

        public void ApplySpecialEffect(Hero attacker, Hero defender)
        {
            SpecialEffect?.Invoke(attacker, defender);
        }
    }
}
