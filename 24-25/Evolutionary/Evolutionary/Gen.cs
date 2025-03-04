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
        //seznam aktivních genů
        public List <Gen> activeGenes = new List <Gen> (); 

        //vlastnosti genů
        private string name;        //jméno genu
        private int childrenMin;    //počet potomků genu minimální
        private int childrenMax;    //počet potomků maximální
        //private bool sex;           //pohlaví genu
        private int mutation;       //šance na matuaci
        private int behaviour;      //dominantnost/recesivnost genu (+ normálnost)

        

        //konstruktor genu
        public Gen(string n, int cmin, int cmax, int m, int b)
        {
            this.name = n; 
            this.childrenMin = cmin;
            this.childrenMax = cmax; 
            //this.sex = s;
            this.mutation = m; 
            this.behaviour = b; 
        }
   
        //funkce na start simulace, přidá 2 základní geny A
        public void SimSetup()
        {
            Gen A = new Gen("A", 2, 6, 15, 1);
            activeGenes.Add(A);
            activeGenes.Add(A);
        }

        //funkce na vypsání vlatností genu
        public override string ToString()
        {
            return $"Jméno genu: {name} \nMinimální počet potomků: {childrenMin} \nMaximální počet potomků: {childrenMax} \nŠance na mutaci: {mutation} \nPovaha genu: {behaviour}";
        }

        //funkce na vypsání generace, chatGPT
        public void ShowGeneration()
        {
            foreach (Gen g in activeGenes)
            {
                Console.Write(g.name + " ");
            }
            Console.WriteLine();
        }

        //funkce pro generování nové generace, heavily isnpired chatGPT 
        public void GeneNewGene()
        {
            //list pro novou generaci
            List<Gen> newGeneration = new List<Gen>();

            //cyklus rozmnožení
            foreach (Gen parentGene in activeGenes)
            {
                // Vytváření nové generace
                // Pro každý gen v activeGenes vytvoříme nové geny
                Random rand = new Random();
                int numChildren = rand.Next(parentGene.childrenMin, parentGene.childrenMax + 1);

                //dokud je i mneší než numchildren vytváří nové geny
                for (int i = 0; i < numChildren; i++)
                {
                    // Vytvoření nového genu
                    Gen childGene = new Gen(parentGene.name, parentGene.childrenMin, parentGene.childrenMax, parentGene.mutation, parentGene.behaviour);
                    newGeneration.Add(childGene);
                }
            }

            // Novou generaci přiřadíme do activeGenes
            activeGenes = newGeneration;

        }
    }
}
