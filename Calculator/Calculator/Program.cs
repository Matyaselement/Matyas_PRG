using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vítejte v šetřiči mysli (kalkulačce)");

            Console.WriteLine("Pokud chcete sčítat, odčítat, násobit nebo dělit, stistkněte 1, pokud umocňovat, stiskněte 2: ");
            int o1 = Convert.ToInt32(Console.ReadLine());
            int o2 = Convert.ToInt32(Console.ReadLine());

            if (o1 == "1")

            Console.Write("První číslo: ");
            int c1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Druhé číslo: ");
            int c2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Operace(+, -, *, /, 224): ");
            string op = Console.ReadLine();

            int result = 0;

            bool success = true;

            if (op == "+")
            {
                result = c1 + c2;
            }
            else if (op == "-")
            {
                result = c1 - c2;
            }
            else if (op == "*")
            {
                result = c1 * c2;
            }
            else if (op == "/")
            {
                if (c2 == 0)
                {
                    Console.WriteLine("Chyba, 0 nekamarádí s dělením");
                    success = false;
                }
                else
                {
                    result = c1 / c2;
                }
            }
            //tady začíná část mocnin která bude upravena
            else if (op == "224")
            {
                result = (c1 * c1) * c3;
            }
            //tady ta část končí
            else
            {
                Console.WriteLine("Chyba, neplatná operace");
                success = false;
            }

            if (success == false)
            {
                Console.WriteLine("Výpočet není možný, špatné zadání, zkuste to znovu");
            }
            else
            {
                Console.WriteLine($"Výsledek: {result}");
                Console.WriteLine("Gratuluji, neplýtval jsi svou mysl na jednoduchý úkon počítání");
            }
            Console.ReadKey();
        }
    }
}
