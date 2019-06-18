using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    public class Monster : LivingCreature
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaxDamage { get; set; }
        public int RewardEXP { get; set; }
        public int RewardGold { get; set; }

        public List<LootItems> LootTable { get; set; }

        public Monster(int id, string name, int maxdamage, int rewardEXP, int rewardGold, int currentHP, int maxHP) : base(currentHP, maxHP)
        {
            ID = id;
            Name = name;
            MaxDamage = maxdamage;
            RewardEXP = rewardEXP;
            RewardGold = rewardGold;

            LootTable = new List<LootItems>();
        }
                       
    }
}
