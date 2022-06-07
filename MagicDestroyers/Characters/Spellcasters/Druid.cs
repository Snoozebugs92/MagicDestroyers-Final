using MagicDestroyers.Enums;
using MagicDestroyers.Equipment.Armors.Leather;
using MagicDestroyers.Equipment.Weapons.Blunt;
using System;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Druid : Spellcaster
    {
        private readonly LightLeatherVest DEFAULT_BODY_ARMOR = new LightLeatherVest();
        private readonly Staff DEFAULT_WEAPON = new Staff();
    
        public Druid()
            : this(Constants.Druid.NAME, 1)
        {
        }
    
        public Druid(string name, int level)
            : this(name, level, Constants.Druid.HEALTH_POINTS)
        {
        }
    
        public Druid(string name, int level, int healthPoints)
        {
            base.ManaPoints = Constants.Druid.MANA_POINTS;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.Weapon = DEFAULT_WEAPON;
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoints;
            base.Faction = Faction.Spellcaster;
            base.IsAlive = true;
            base.Scores = 0;
        }
    
        public int Moonfire()
        {
            return base.Weapon.DamagePoints + 10;
        }
    
        public int Starburst()
        {
            return base.Weapon.DamagePoints + 11;
        }
    
        public int OneWithTheNature()
        {
            return base.Weapon.DamagePoints + 15;
        }
    
        public override int Attack()
        {
            return this.Moonfire();
        }
    
        public override int SpecialAttack()
        {
            return this.Starburst();
        }
    
        public override int Defend()
        {
            return this.OneWithTheNature();
        }
    }
}
