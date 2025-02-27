using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolutionary
{
    internal class Player
    {
        public List<string> unlockedGenes = new List<string>();
        public void PlayerGameSetup()
        {
            unlockedGenes.Add("A");
            Gen A = new Gen("A", 2, 6, true, 15, 1);
            unlockedGenes2.Add(A);  
        }

        public List<Gen> unlockedGenes2 = new List<Gen>();
        

    }
        
}
