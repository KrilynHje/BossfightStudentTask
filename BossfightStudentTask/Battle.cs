using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossfightStudentTask
{
    internal class Battle
    {
        private Champion champion;
        private Boss boss;

        public Battle(Champion champion, Boss boss)
        {
            this.champion = champion;
            this.boss = boss;


        }
        void Fight()
        {

            int actionStamReq = 8;

            int bossDamage = boss.getDamage();
            int bossMaxHp = boss.HP;
            int bossCurrentHp = bossMaxHp;
            int bossMaxSta=boss.STA;
            int bossCurrentSta = bossMaxSta;
            int bossAtk =boss.ATK;
            


            int championDamage = champion.getDamage();
            int championMaxHP=champion.HP;
            int championCurrentHp = championMaxHP;
            int championMaxSta=champion.STA;
            int championCurrentSta=championMaxSta;
            int championAtk=champion.ATK;






            bool inBattle = true;
            while (inBattle)
            {
                if () { }


            }


        }
    }

}
