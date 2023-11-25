using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ukol22dpole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Předem se omlouvám, že je velká část kódu více či méně inspirovaná/převzatá z ChatGPT. Prostě jsem si nevěděl rady.
             * Myslím si, že je pořád lepší udělat úkol s ChatGPT a snažit se kódu porozumět, než vzdát úkol s tím, že nevím jak na to.
             * Snažil jsem se co nejvíce slepě neopisovat, ale spíše jen přijít na to, jak danou část úkolu udělat (buď s ChatGPT, nebo W3 schools apod.)
             */

            Console.WriteLine("Vítejte v aplikaci 2D pole! Hezkou zábavu!"); //"přivítání" v aplikaci (cmd)

            //načte hodnotu a, funkce zjištěna z ChatGPT

            Console.WriteLine("Zadejte počet řádků vašeho pole: ");
            int a = int.Parse(Console.ReadLine());

            //to samé jako u a, ale pro b

            Console.WriteLine("Zadejte počet sloupců vašeho pole: ");
            int b = int.Parse(Console.ReadLine());

            //vytvoří pole podle zadaných hodnot a; b

            int[,] array = new int[a, b];

            //naplní pole náhodnými čísly 1 - 10, převzato z ChatGPT

            Random random = new Random();

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    array[i, j] = random.Next(1, 100);
                }
            }

            Console.WriteLine("Vytvořené 2D pole: ");

            //pro přehlednost vypíše pole do cmd jako matici, zjištěno z stackoverflow, porozumění kódu díky ChatGPT (vysvětlil)

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++) //prochází hodnoty v poli
                {
                    Console.Write(string.Format("{0} ", array[i, j])); //vypisuje hodnoty do cmd
                }
                Console.Write(Environment.NewLine + Environment.NewLine); //odděluje od sebe hodnoty pro větší přehlednost
            }

            //zpřístupní, popřípadě přeskočí funkci násobení 2D pole číslem

            Console.WriteLine("Chcete vynásobit 2D pole číslem? Pokud ano, napište 1, pokud ne, napište 2. Jiné vstupy nepiště.: ");
            int yorn = int.Parse(Console.ReadLine()); //yorn = yes or no
            if (yorn == 1)
            {
                //sekvence pro násobení, části převzaté z ChatGPT, části jen inspirované, části vlastní

                Console.WriteLine("Napište číslo, kterým budete násobit: ");
                int multi = int.Parse(Console.ReadLine());

                //vynásobí pole dříve zadaným číslem (multi), převzato z ChatGPT

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] *= multi;
                    }
                }

                //vypíše vynásobené pole

                Console.WriteLine("Vypisuji vynásobené pole: ");
                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < b; j++) //prochází hodnoty v poli
                    {
                        Console.Write(string.Format("{0} ", array[i, j])); //vypisuje hodnoty do cmd
                    }
                    Console.Write(Environment.NewLine + Environment.NewLine); //odděluje od sebe hodnoty pro větší přehlednost
                }

            }
            else if (yorn == 2)
            {
                Console.WriteLine("Nenásobíme 2D pole");
            }
            else
            {
                Console.WriteLine("Musíte zadat pouze 1 nebo 2!");
            }

            Console.ReadKey();//podmínka pro okamžité neuzavření cmd (počká na jakýkoliv vstup od uživatele)
        }
       

    }
}
