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
                                    //private int behaviour;      //dominantnost/recesivnost genu (+ normálnost)

        //slovník, který uchovává možnosti mutací genů
        private static Dictionary<string, List<string>> mutationMap = new Dictionary<string, List<string>>
        {
            { "A", new List<string> { "B", "C", "D" } },
            { "B", new List<string> { "A", "C", "D" } },
            { "C", new List<string> { "A", "B", "D" } },
            { "D", new List<string> { "A", "B", "C" } }
        };

        //konstruktor genu
        public Gen(string n, int cmin, int cmax, int m)
        {
            this.name = n; 
            this.childrenMin = cmin;
            this.childrenMax = cmax; 
            //this.sex = s;
            this.mutation = m; 
            //this.behaviour = b; 
        }
   
        //funkce na start simulace, přidá 2 základní geny A
        public void SimSetup()
        {
            Gen A = new Gen("A", 2, 6, 15);
            activeGenes.Add(A);
            activeGenes.Add(A);
        }

        //funkce na vypsání vlatností genu
        public override string ToString()
        {
            return $"Jméno genu: {name} \nMinimální počet potomků: {childrenMin} \nMaximální počet potomků: {childrenMax} \nŠance na mutaci: {mutation}";
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

        //funkce pro generování nové generace, isnpired chatGPT 
        public void GeneNewGene()
        {
            //list pro novou generaci
            List<Gen> newGeneration = new List<Gen>();
            Random rng = new Random();

            //cyklus rozmnožení
            foreach (Gen parentGene in activeGenes)
            {
                // Vytváření nové generace
                // Pro každý gen v activeGenes vytvoříme nové geny
                int numChildren = rng.Next(parentGene.childrenMin, parentGene.childrenMax + 1);

                //dokud je i memnší než numchildren vytváří nové geny
                for (int i = 0; i < numChildren; i++)
                {
                    string newName = parentGene.name;
                    //podmínka pro mutace
                    if (rng.Next(100) < parentGene.mutation && mutationMap.ContainsKey(parentGene.name))
                    {
                        List<string> possibleMutations = mutationMap[parentGene.name];
                        newName = possibleMutations[rng.Next(possibleMutations.Count)];
                    }
                    //nastaví child gene jako nový gen a změní mu jméno
                    Gen childGene = new Gen(newName, parentGene.childrenMin, parentGene.childrenMax, parentGene.mutation);
                    newGeneration.Add(childGene);
                    /* Vytvoření nového genu
                    Gen childGene = new Gen(parentGene.name, parentGene.childrenMin, parentGene.childrenMax, parentGene.mutation);
                    newGeneration.Add(childGene);*/
                }
            }

            // Novou generaci přiřadíme do activeGenes
            activeGenes = newGeneration;



        }
    }
}
