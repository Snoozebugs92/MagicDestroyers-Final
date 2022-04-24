//using MagicDestroyers.Enums;
//using MagicDestroyers.Equipment.Armors.Leather;
//using MagicDestroyers.Equipment.Weapons.Blunt;
//using System;
//
//namespace MagicDestroyers.Characters.Spellcasters
//{
//    public class Druid : Spellcaster
//    {
//        private const Faction DEFAULT_FACTION = Faction.Spellcaster;
//        private const int DEFAULT_LEVEL = 1;
//        private const int DEFAULT_HEALTH_POINTS = 120;
//        private const int DEFAULT_MANA_POINTS = 100;
//        private const string DEFAULT_NAME = "Cenarius";
//
//        private readonly LightLeatherVest DEFAULT_BODY_ARMOR = new LightLeatherVest();
//        private readonly Staff DEFAULT_WEAPON = new Staff();
//
//        public Druid()
//          : this(DEFAULT_NAME, DEFAULT_LEVEL)
//      {
//      }
//
//        public Druid(string name, int level)
//          : this(name, level, DEFAULT_HEALTH_POINTS)
//      {
//      }
//
//        public Druid(string name, int level, int healthPoints)
//      {
//          base.Name = name;
//          base.Level = level;
//          base.HealthPoints = healthPoints;
//          base.ManaPoints = DEFAULT_MANA_POINTS;
//          base.Faction = DEFAULT_FACTION;
//          base.BodyArmor = DEFAULT_BODY_ARMOR;
//          base.Weapon = DEFAULT_WEAPON;
//      }
//
//        public void Moonfire()
//      {
//          throw new NotImplementedException();
//      }
//
//        public void Starburst()
//      {
//          throw new NotImplementedException();
//      }
//
//        public void OneWithTheNature()
//      {
//          throw new NotImplementedException();
//      }
//
//        public override void Attack()
//      {
//          throw new NotImplementedException();
//      }
//
//        public override void SpecialAttack()
//      {
//          throw new NotImplementedException();
//      }
//
//        public override void Defend()
//      {
//          throw new NotImplementedException();
//      }
//    }
//}
