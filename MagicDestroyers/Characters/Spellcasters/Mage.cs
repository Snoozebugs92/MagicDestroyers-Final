﻿using MagicDestroyers.Enums;
using MagicDestroyers.Equipment.Armors.Light;
using MagicDestroyers.Equipment.Weapons.Blunt;
using System;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Mage : Spellcaster
    {
        private const Faction DEFAULT_FACTION = Faction.Spellcaster;
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTH_POINTS = 120;
        private const int DEFAULT_MANA_POINTS = 100;
        private const string DEFAULT_NAME = "Merlin";

        private readonly ClothRobe DEFAULT_BODY_ARMOR = new ClothRobe();
        private readonly Staff DEFAULT_WEAPON = new Staff();

        public Mage()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
        }

        public Mage(string name, int level)
            : this(name, level, DEFAULT_HEALTH_POINTS)
        {
        }

        public Mage(string name, int level, int healthPoints)
        {
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoints;
            base.ManaPoints = DEFAULT_MANA_POINTS;
            base.Faction = DEFAULT_FACTION;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.Weapon = DEFAULT_WEAPON;
        }

        public int Fireball()
        {
            throw new NotImplementedException();
        }

        public int ArcaneWrath()
        {
            throw new NotImplementedException();
        }

        public int Meditation()
        {
            throw new NotImplementedException();
        }

        public override int Attack()
        {
            return this.Fireball();
        }

        public override int SpecialAttack()
        {
            return this.ArcaneWrath();
        }

        public override int Defend()
        {
            return this.Meditation();
        }
    }
}
