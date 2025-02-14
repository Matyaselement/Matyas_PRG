using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textGameClasses
{
    internal class Enemy
    {
        public string name;
        public int hp;
        private int dmg;
        int level;

        public Enemy(string name, int hp, int dmg, int level)
        {
            this.name = name;
            this.hp = hp;
            this.dmg = dmg;
            this.level = level;
        }

        public void SetDmg(int value)
        {
            dmg = value;
            if (dmg <= 0)
            {
                dmg = 1;
            }
        }

        public void Hurt(int incomingDmg)
        {
            hp -= incomingDmg;
            Console.WriteLine("Player" + name +)
        }

        public bool IsAlive()
        {
            return hp > 0;
        }
    }
}
