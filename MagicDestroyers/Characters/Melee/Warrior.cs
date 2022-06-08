﻿using MagicDestroyers.Enums;
using MagicDestroyers.Equipment.Armors.Heavy;
using MagicDestroyers.Equipment.Weapons.Sharp;
using System;

namespace MagicDestroyers.Characters.Melee
{
    public class Warrior : Melee
    {
        private readonly Chainlink DEFAULT_BODY_ARMOR = new Chainlink();
        private readonly Axe DEFAULT_WEAPON = new Axe();     

        public Warrior()
            : this(Constants.Warrior.NAME, 1)
        {
        }

        public Warrior(string name, int level)
            : this(name, level, Constants.Warrior.HEALTH_POINTS)
        {
        }

        public Warrior(string name, int level, int healthPoints)
        {
            base.AbilityPoints = Constants.Warrior.ABILITY_POINTS;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.Weapon = DEFAULT_WEAPON;
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoints;
            base.Faction = Faction.Melee;
            base.IsAlive = true;
            base.Scores = 0;
        }

        public int Strike()
        {
            return base.Weapon.DamagePoints + 7;
        }

        public int Execute()
        {
            return base.Weapon.DamagePoints + 12;
        }

        public int SkinHarden()
        {
            return base.BodyArmor.ArmorPoints + 6;
        }

        public override int Attack()
        {
            return Strike();
        }

        public override int SpecialAttack()
        {
            return this.Execute();
        }

        public override int Defend()
        {
            return this.SkinHarden();
        }
    }
}
