using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolutionary
{
    internal class Player
    {
        //seznam odemčených genů
        public List<string> unlockedGenes = new List<string>();

        //funkce: přidá základní gen A do odemčených genů
        public void PlayerSimSetup()
        {
            unlockedGenes.Add("A");
            Gen A = new Gen("A", 2, 6, 15, 1);
            unlockedGenes2.Add(A);  
        }

        public List<Gen> unlockedGenes2 = new List<Gen>();
        

    }
        
}
