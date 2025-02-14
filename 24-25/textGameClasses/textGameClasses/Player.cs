using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textGameClasses
{
    internal class Player
    {
        public string name;
        public int hp;
        private int dmg;

        public Player(string name, int hp, int dmg)
        {
            this.name = name;
            this.hp = hp;
            this.dmg = dmg;
        }

        public void SetDmg(int value)
        {
            dmg = value;
            if (dmg <= 0)
            {
                dmg = 1;
            }
        }

        public int GetDmg()
        {
            return dmg;
        }
        public bool IsAlive()
        {
            return hp > 0;
        }
    }
}
