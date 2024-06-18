using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossfightStudentTask
{
    internal class Boss
    {
        public string BossType { get; set; }

        public int HP { get; set; }
        public int ATK { get; set; }
        public int STA { get; set; }
        public string BossDesc { get; set; }

        public Boss(string bossType, int hp, int atk, int sta, string bossDesc)
        {
            BossType = bossType;
            HP = hp;
            STA = sta;
            ATK = atk;
            BossDesc = bossDesc;

        }
        public int getDamage()
        {
            Random random = new Random();
            int randomAtkDm = random.Next(1, ATK);
            return (int)randomAtkDm;
        }


    }
}
