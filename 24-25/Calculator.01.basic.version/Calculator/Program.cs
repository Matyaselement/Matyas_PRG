using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2024-2025.
 * Extended by students.
 */

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * ZADANI
             * Vytvor program ktery bude fungovat jako kalkulacka. Kroky programu budou nasledujici:
             * 1) Nacte vstup pro prvni cislo od uzivatele (vyuzijte metodu Console.ReadLine() - https://learn.microsoft.com/en-us/dotnet/api/system.console.readline?view=netframework-4.8.
             * 2) Zkonvertuje vstup od uzivatele ze stringu do integeru - https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/how-to-convert-a-string-to-a-number.
             * 3) Nacte vstup pro druhe cislo od uzivatele a zkonvertuje ho do integeru. (zopakovani kroku 1 a 2 pro druhe cislo)
             * 4) Nacte vstup pro ciselnou operaci. Rozmysli si, jak operace nazves. Muze to byt "soucet", "rozdil" atd. nebo napr "+", "-", nebo jakkoliv jinak.
             * 5) Nadefinuj integerovou promennou result a prirad ji prozatimne hodnotu 0.
             * 6) Vytvor podminky (if statement), podle kterych urcis, co se bude s cisly dit podle zadane operace
             *    a proved danou operaci - https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/selection-statements.
             * 7) Vypis promennou result do konzole
             * 
             * Rozsireni programu pro rychliky / na doma (na poradi nezalezi):
             * 1) Vypis do konzole pred nactenim kazdeho uzivatelova vstupu co po nem chces (aby vedel, co ma zadat)
             * 2) a) Kontroluj, ze uzivatel do vstupu zadal, co mel (cisla, popr. ciselnou operaci). Pokud zadal neco jineho, napis mu, co ma priste zadat a program ukoncete.
             * 2) b) To same, co a) ale misto ukonceni programu opakovane cti vstup, dokud uzivatel nezada to, co ma
             *       - https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-while-statement
             * 3) Umozni uzivateli zadavat i desetinna cisla, tedy prekopej kalkulacku tak, aby umela pracovat s floaty
             */

            //podmínka pro loop více operací na jedno spuštění aplikace
            Boolean loop = true;

            while (loop)
            {
                //načte první vstup od uživatele a zkonvertuje ho do intu
                Console.WriteLine("Vítejte v kalkulačce. Zadejte prosím první číslo: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Zadali jste číslo " + num1);
                
                //načítá a konvertuje druhý vstup
                Console.WriteLine("Nyní zadejte číslo druhé: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Zadali jste číslo " + num2);

                //zadání číselných operací
                Console.WriteLine("Zadejte číselnou operaci (pomocí znaku v závorce). Na výběr jsou: sčítání (+), odčítání (-), násobení (*), dělení (/): ");
                string numOp = Console.ReadLine();

                //hodnota výsledku, později se přepíše
                int result = 0;

                //podmínky pro jednotlivé číselné operace
                if (numOp == "+")
                {
                    result = num1 + num2;
                    Console.WriteLine("Výsledek sčítání je: " + result);
                }
                else if (numOp == "-")
                {
                    result = num1 - num2;
                    Console.WriteLine("Výsledek odčítání je: " + result);
                }
                else if (numOp == "*")
                {
                    result = num1 * num2;
                    Console.WriteLine("Výsledek násobení je: " + result);
                }
                else if (numOp == "/")
                {
                    //podmínka pro (ne)dělení nulou, opakování cyklu loop kalkulačky
                    if (num2 == 0)
                    {
                        Console.WriteLine("Nulou nelze dělit!");
                        Console.WriteLine("Chcete pokračovat v počítání (y/n)?");
                        string loopCheck1 = Console.ReadLine();
                        if (loopCheck1 == "y")
                        {
                            loop = true;
                        }
                        else if (loopCheck1 == "n")
                        {
                            loop = false;
                        }
                    }
                    else
                    {
                        result = num1 / num2;
                        Console.WriteLine("Výsledek dělení je: " + result);
                    }
                }

                //chybová hláška pro případ nezadání sprévné hodnoty smybolizující číselnou operaci
                else
                {
                    Console.WriteLine("Je třeba zadat jednu z možností v závorkách (+, -, *, /)!");
                }

                //reset počítacího cyklu loop kalkulačky
                Console.WriteLine("Chcete počítat dál (y/n)?");
                string loopCheck2 = Console.ReadLine();
                if (loopCheck2 == "y")
                {
                    loop = true;
                }
                else if (loopCheck2 == "n")
                {
                    loop = false;
                }
            }
         Console.ReadKey(); //Toto nech jako posledni radek, aby se program neukoncil ihned, ale cekal na stisk klavesy od uzivatele.
        }
    }
}
