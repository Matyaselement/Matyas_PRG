﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Evolutionary
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Úvod do simulace, "hlavní menu"
            Console.WriteLine
                ("Vítej v simulaci Evolutionary!" +
                "\nV simulaci, kde můžeš sledovat vývoj roztodivných organismů." +
                "\nKdo ví co se stane, vrhni se do toho a uvidíš!" +
                "\n(PS. pokud jsi v Evolutionary nováčkem, není na škodu si přečíst tutoriální návod.)" +
                "\nPro návod napiš 'tutorial' pro okamžitou simulaci napiš 'sim'.");

            //načte uživatelův vstup a uloží ho do stringu
            string menu = Console.ReadLine(); 
            Console.Clear ();

            //podmínka simulace
            bool simIsRunning = true;

            while (simIsRunning)
            {
                if(menu == "tutorial")
                {
                    //tady později napíšu co nejpřehlednější tutoriálek
                    Console.WriteLine("Simulaci začínáš s danou dvojicí základních genů A.\nSleduješ jak si v Evolutionary povedou.\nStačí se pouze řídit pokyny simulace.");
                    menu = "sim";
                    Console.WriteLine(" \nNyní se už opravdu můžeš vrhnout na simulaci! (enter)");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (menu == "sim")
                {
                    

                    //příprava herní instance
                    Console.Clear() ;
                    Console.WriteLine("Informace o aktuální generaci v simulaci:\n ");
                    Player player = new Player();
                    player.PlayerSimSetup();

                    //vypíše informace o aktuálně odemčených genech
                    Console.WriteLine("Odemčené geny:");
                    foreach (Gen g in player.unlockedGenes2)
                    {
                        Console.WriteLine(g.ToString());
                    }

                    //vypíše geny ze seznamu aktuálně aktivních genů simulace
                    Console.WriteLine("Jednotlivé generace genů: \n");
                    Gen simulation = new Gen("", 0, 0, 0);
                    simulation.SimSetup();

                    //cyklus tvoření nových generací, heavily chatGPT inspired
                    int generationCount = 1;
                    while (true)
                    {
                        Console.WriteLine($"\nGenerace {generationCount}:");
                        simulation.ShowGeneration();

                        

                        Console.WriteLine("\nPřeješ si pokračovat na další generaci? Napiš 'ano' nebo 'ne'.");
                        string wannaNewGen = Console.ReadLine();

                        if (wannaNewGen == "ano")
                        {
                            //vygeneruje novou generaci pomocí metody GeneNewGene
                            Console.WriteLine("\nDobrá, jdeme na další generaci!");
                            Console.ReadLine();
                            simulation.GeneNewGene();
                            generationCount++;
                        }
                        //ukončení simulace
                        else if (wannaNewGen == "ne")
                        {
                            Console.WriteLine("Dobrá, simulace končí touto generací.");
                            simIsRunning = false;
                            break;  // Ukončí cyklus
                        }
                        else
                        {
                            Console.WriteLine("Ou! Zadal jsi chybný vstup, musíš napsat přímo 'ano' nebo 'ne'. Zkus to znovu!");
                        }
                    }

                    //bývalý systém ukončení
                    /*ukončení simulace
                    Console.WriteLine("\nPřeješ si simulaci v této generaci ukončit? Napiš 'ano' nebo 'ne'.");
                    string end2 = Console.ReadLine();

                    //podmínka pro cyklus konce
                    bool endCon = false;
                    while (!endCon)
                    {
                        
                        if (end2 == "ne")
                        {
                            Console.WriteLine("\nDobrá, jdeme na další generaci!");
                            Console.ReadLine ();
                            endCon = true;
                        }
                        else if (end2 == "ano")
                        {
                            Console.WriteLine("Dobrá, simulace končí touto generací.");
                            endCon = true;

                            //ukončí main loop simulace
                            simIsRunning = false;
                        }
                        else
                        {
                            Console.WriteLine("Ou! Zadal jsi chybný vstup, musíš napsat přímo 'ano' nebo 'ne'. Zkus to znovu!");
                            end2 = Console.ReadLine();
                        }
                    }*/
                }
                else
                {
                    Console.WriteLine("Zadal jsi chybný vstup. Musíš napsat přesně 'tutorial' nebo 'sim'. Zkus to znovu.");
                    menu = Console.ReadLine();
                    Console.Clear();
                }
            }
            


            //ať se mi program hned sám neukončí
            Console.ReadLine();
        }
    }
}
