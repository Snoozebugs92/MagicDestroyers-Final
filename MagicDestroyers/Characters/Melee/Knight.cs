    using MagicDestroyers.Enums;
    using MagicDestroyers.Equipment.Armors.Heavy;
    using MagicDestroyers.Equipment.Weapons.Blunt;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace MagicDestroyers.Characters.Melee
    {
        public class Knight : Melee
        {
        private readonly Chainlink DEFAULT_BODY_ARMOR = new Chainlink();
        private readonly Hammer DEFAULT_WEAPON = new Hammer();
            
        public Knight()
            : this(Constants.Knight.NAME, 1)
        {
        }

        public Knight(string name, int level)
            : this(name, level, Constants.Knight.HEALTH_POINTS)
        {
        }

        public Knight(string name, int level, int healthPoints)
        {
            base.AbilityPoints = Constants.Knight.ABILITY_POINTS;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.Weapon = DEFAULT_WEAPON;
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoints;
            base.Faction = Faction.Melee;
            base.IsAlive = true;
            base.Scores = 0;
        }

        public int HolyBlow()
        {
                return base.Weapon.DamagePoints + 9;
        }

        public int PurifySoul()
        {
                return base.Weapon.DamagePoints + 9;
        }

        public int RighteousWings()
        {
                return base.Weapon.DamagePoints + 4;
        }

        public override int Attack()
        {
            return this.HolyBlow();
        } 

        public override int SpecialAttack()
        {
            return this.PurifySoul();
        }

        public override int Defend()
        {
            return this.RighteousWings();
        }
    }
}
