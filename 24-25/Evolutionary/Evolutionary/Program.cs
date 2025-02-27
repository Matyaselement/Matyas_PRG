using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                "\n(PS. pokud jsi v Evolutionary nováčkem, není na škodu si přečíst tutoriální návod." +
                "\nPro návod napiš 'tutorial' pro okamžitou hru napiš 'hra'."); //vymyslet, aby se to smazalo a nebylo furt nahoře

            string menu = Console.ReadLine(); //načte uživatelův vstup a uloží ho do stringu
            Console.Clear ();

            bool gameIsRunning = true; //podmínka hry

            while (gameIsRunning)
            {
                while (menu == "tutorial")
                {
                    //tady později napíšu co nejpřehlednější tutoriálek
                    Console.WriteLine("Ano, tutorial");//sem napíšu tutorial, až budu vědět co hráčovi říct
                    menu = "hra";
                    Console.WriteLine("Nyní se už opravdu můžeš vrhnout na hru! (enter)");
                    Console.ReadLine();
                    Console.Clear();
                }

                if (menu == "hra")
                {
                    //tady bude hra pokračovat i guess
                    Console.WriteLine("tady je hra");
                }
                else
                {
                    Console.WriteLine("Zadal jsi chybný vstup. Musíš napsat přesně 'tutorial' nebo 'hra'. Zkus to znovu.");
                    menu = Console.ReadLine();
                    Console.Clear();
                }
            }
            


            //ať se mi program hned sám neukončí
            Console.ReadLine();
        }
    }
}
