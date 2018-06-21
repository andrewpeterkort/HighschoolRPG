using System;
namespace HighschoolRPG
{
    public struct Stats
    {
        public int Looks;
        public int Wits;
        public int Smarts;
        public int Style;
    } 
    public struct Attack
    {
        public int damage;
        public int stat;
    }

    public class Student
    {
        public string Name;
        public Stats allStats;
        public int Hp;
        public int Losses;

        private int getHp()
        {
            return allStats.Looks + allStats.Wits + allStats.Smarts + allStats.Style + Losses;
        }

        public Attack attack()
        {
            int current;
            int countHigh = 0;
            int high = 0;
            int count = 0;

            Attack newAt;

            foreach( var stat in typeof(Stats).GetFields( System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance) )
            {
                count++;
                current = Convert.ToInt32(stat.GetValue(allStats));
                if ( current > high )
                {
                    high = current;
                    countHigh = count;
                }
            }

            newAt.damage = high;
            newAt.stat = countHigh;
            Console.WriteLine("NEW ATTACK");
            Console.WriteLine("HIGHEST NUM: {0}", high);
            Console.WriteLine("NUM POSITION: {0}", countHigh);
            return newAt;
        }

        public bool defend(Attack input)
        {
            int count = 0;
            int current = 0;
            int damage = 0;

            foreach (var stat in typeof(Stats).GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance))
            {
                count++;
                current = Convert.ToInt32(stat.GetValue(allStats));
                if (count == input.stat)
                {
                    damage = input.damage - current;
                    
                }

            }

            damage = (damage > 0) ? damage : 0;
            Hp -= damage;
            Console.WriteLine("{0} toke {1} points of damage and is now at {2} HP", Name, damage, Hp);
            return (Hp <= 0) ? true : false;

        }

        public Student( string name, int looks, int wits, int smarts, int style )
        {
            this.Name = name;
            this.allStats.Looks = looks;
            this.allStats.Wits = wits;
            this.allStats.Smarts = smarts;
            this.allStats.Style = style;
            this.Hp = getHp();
            this.Losses = 0;
        }
    }
}
