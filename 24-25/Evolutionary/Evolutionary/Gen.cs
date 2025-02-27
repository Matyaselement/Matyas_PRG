using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Evolutionary
{
    internal class Gen
    {
   
        public List <Gen> activeGenes = new List <Gen> ();

        private string name;
        private int childrenMin;
        private int childrenMax; 
        private bool sex; 
        private int mutation; 
        private int behaviour;

        public Gen A = new Gen ("A", 2, 6, true, 15, 1);

        public Gen(string n, int cmin, int cmax, bool s, int m, int b)
        {
            this.name = n; //jméno genu
            this.childrenMin = cmin; //počet potomků genu minimální
            this.childrenMax = cmax; //počet potomků maximální
            this.sex = s; //pohlaví genu
            this.mutation = m; //šance na matuaci
            this.behaviour = b; //dominantnost/recesivnost genu (+ normálnost)
        }
   
        public void GameSetup()
        {
            Gen A = new Gen("A", 2, 6, true, 15, 1);
            activeGenes.Add(A);
            activeGenes.Add(A);
        }

        public override string ToString()
        {
            return $"Jméno genu: {name} \nMinimální počet potomků: {childrenMin} \nMaximální počet potomků: {childrenMax} \nPohlaví genu: {sex} \nŠance na mutaci: {mutation} \nPovaha genu: {behaviour}";
        }


    }
}
