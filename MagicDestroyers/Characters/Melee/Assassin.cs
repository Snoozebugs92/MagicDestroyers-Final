//using MagicDestroyers.Enums;
//using MagicDestroyers.Equipment.Armors.Leather;
//using MagicDestroyers.Equipment.Weapons.Sharp;
//using System;
//
//namespace MagicDestroyers.Characters.Melee
//{
//    public class Assassin : Melee
//    {
//        private const Faction DEFAULT_FACTION = Faction.Melee;
//        private const int DEFAULT_LEVEL = 1;
//        private const int DEFAULT_HEALTH_POINTS = 120;
//        private const int DEFAULT_ABILITY_POINTS = 100;
//        private const string DEFAULT_NAME = "Snark";
//
//        private readonly LightLeatherVest DEFAULT_BODY_ARMOR = new LightLeatherVest();
//        private readonly Sword DEFAULT_WEAPON = new Sword();
//        
//        public Assassin()
//          : this(DEFAULT_NAME, DEFAULT_LEVEL)
//      {
//      }
//
//        public Assassin(string name, int level)
//          : this(name, level, DEFAULT_HEALTH_POINTS)
//      {
//      }
//
//        public Assassin(string name, int level, int healthPoints)
//      {
//          base.Name = name;
//          base.Level = level;
//          base.HealthPoints = healthPoints;
//          base.AbilityPoints = DEFAULT_ABILITY_POINTS;
//          base.Faction = DEFAULT_FACTION;
//          base.BodyArmor = DEFAULT_BODY_ARMOR;
//          base.Weapon = DEFAULT_WEAPON;
//      }
//
//        public void Raze()
//      {
//          throw new NotImplementedException();
//      }
//
//        public void BleedToDeath()
//      {
//          throw new NotImplementedException();
//      }
//
//        public void Survival()
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
