using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossfightStudentTask
{
    internal class Champion
    {
        public string ChampionType { get; set; }
        public int HP { get; set; }
        public int ATK { get; set; }
        public int STA { get; set; }
        public string ChampDesc { get; set; }

        public Champion(string championType, int hp, int atk, int sta, string champDesc)
        {
            ChampionType = championType;
            HP = hp;
            ATK = atk;
            STA = sta;
            ChampDesc = champDesc;



        }
        public int getDamage()
        {
            Random random = new Random();
            int randomAtkDm = random.Next(1, ATK);
            return (int)randomAtkDm;
        }



    }




}
