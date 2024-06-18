using System.Diagnostics.Tracing;

namespace BossfightStudentTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Boss> bossList = new List<Boss>();
            bossList.Add(new Boss(bossType:"Frost Giant", hp:400, atk: 150, sta: 100, bossDesc: "Just the sight of this frozen behemoth chills you to the bone"));
            bossList.Add(new Boss(bossType:"Firelord", hp: 350,atk:200, sta:125, bossDesc:"A blazing giant wielding powerful fire magic against you"));
            bossList.Add(new Boss(bossType: "Waterspirit", hp: 95, atk: 250, sta: 100, bossDesc: "A strong elemental wielding the power of the oceans"));


            List<Champion> championList = new List<Champion>();
            championList.Add(new Champion(championType:"Paladin",hp: 150, atk: 100, sta: 75, champDesc:"A holy warrior bound to a sacred oath"));
            championList.Add(new Champion(championType: "Barbarian", hp: 250, atk: 150, sta: 40, champDesc:"A fierce warrior of primitive background who can enter a battle rage"));
            championList.Add(new Champion(championType: "Wizard", hp: 95, atk: 250, sta: 100, champDesc: "A scholarly magic-user capable of manipulating the structures of reality"));





        }
    }
}
