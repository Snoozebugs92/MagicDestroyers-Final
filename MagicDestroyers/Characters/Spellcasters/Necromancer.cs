using MagicDestroyers.Enums;
using MagicDestroyers.Equipment.Armors.Leather;
using MagicDestroyers.Equipment.Weapons.Sharp;
using System;

namespace MagicDestroyers.Characters.Spellcasters
{
public class Necromancer : Spellcaster
    {
        private readonly LightLeatherVest DEFAULT_BODY_ARMOR = new LightLeatherVest();
        private readonly Sword DEFAULT_WEAPON = new Sword();

        public Necromancer()
            : this(Constants.Necromancer.NAME, 1)
        {
        }

        public Necromancer(string name, int level)
            : this(name, level, Constants.Necromancer.HEALTH_POINTS)
        {
        }

        public Necromancer(string name, int level, int healthPoints)
        {
            base.ManaPoints = Constants.Necromancer.MANA_POINTS;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.Weapon = DEFAULT_WEAPON;
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoints;
            base.Faction = Faction.Spellcaster;
            base.IsAlive = true;
            base.Scores = 0;
        }

        public int ShadowRage()
        {
            return base.Weapon.DamagePoints + 8;
        }

        public int VampireTouch()
        {
            return base.Weapon.DamagePoints + 10;
        }

        public int BoneShield()
        {
            return base.Weapon.DamagePoints + 12;
        }

        public override int Attack()
        {
            return this.ShadowRage();
        }

        public override int SpecialAttack()
        {
            return this.VampireTouch();
        }

        public override int Defend()
        {
            return this.BoneShield();
        }
    }
}
