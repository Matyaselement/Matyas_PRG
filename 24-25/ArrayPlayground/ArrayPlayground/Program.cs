using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2024-2025.
 * Extended by students.
 */

namespace ArrayPlayground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TODO 1: Vytvoř integerové pole a naplň ho pěti libovolnými čísly.
            int[] array1 = { 7, 69, 420, 42, 13 };

            //TODO 2: Vypiš do konzole všechny prvky pole, zkus jak klasický for, kde i využiješ jako index v poli, tak foreach.
            Console.WriteLine("Vypsani for cyklem");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine(array1[i]);
            }
            Console.WriteLine("Vypsani foreachem");
            foreach (int number in array1)
            {
                Console.WriteLine(number);
            }

            //TODO 3: Spočti sumu všech prvků v poli a vypiš ji uživateli.
            int sum = 0;
            foreach (int number in array1)
            {
                sum += number;
            }
            Console.WriteLine("Suma: " + sum);

            //TODO 4: Spočti průměr prvků v poli a vypiš ho do konzole.
            double average = (double)sum / array1.Length;
            Console.WriteLine("Prumer je: " + average);

            //TODO 5: Najdi maximum v poli a vypiš ho do konzole.
            int max = array1[0];
            for (int i = 1; i < array1.Length; i++)
            {
                if (array1[i] > max)
                {
                    max = array1[i];
                }
            }
            Console.WriteLine("max: " + max);

            //TODO 6: Najdi minimum v poli a vypiš ho do konzole.
            int min = array1.Min();
            Console.WriteLine("min: " + min);

            //TODO 7: Vyhledej v poli číslo, které zadá uživatel, a vypiš index nalezeného prvku do konzole.
            int numberToFind = int.Parse(Console.ReadLine());
            bool foundNumber = false;
            for (int i = 0; i < array1.Length; i++)
            {
                if (numberToFind == array1[i])
                {
                    Console.WriteLine("cislo je na indexu: " + i);
                    foundNumber = true;
                    break;
                }
            }
            if (!foundNumber)
            {
                Console.WriteLine("cislo v poli neni");
            }
            int index;

            //TODO 8: Přepiš pole na úplně nové tak, že bude obsahovat 100 náhodně vygenerovaných čísel od 0 do 9.
            Random rng = new Random();
            array1 = new int[100];
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = rng.Next();
                Console.WriteLine(array1[i] + ", ");
            }
            Console.WriteLine();

            //TODO 9: Spočítej kolikrát se každé číslo v poli vyskytuje a spočítané četnosti vypiš do konzole.
            int[] counts = new int[10];
            foreach (int number in array1)
            {
                counts[number]++;
            }
            for (int i = 0; i < counts.Length; i++)
            {
                Console.WriteLine("Cetnost cislice: " + i + ": " + counts[i]);
            }

            //TODO 10: Vytvoř druhé pole, do kterého zkopíruješ prvky z prvního pole v opačném pořadí.
            int[] array2 = new int[100];
            for (int i = 0; i < array2.Length; i--)
            {
                array2[i] = array1[(array1.Length - i) - 1];
                Console.Write(array1[i]);
            }
            Array.Copy(array1.Reverse().ToArray(), array2, array1.Length);

            //Zkus is dál hrát s polem dle své libosti. Můžeš třeba prohodit dva prvky, ukládat do pole prvky nějaké posloupnosti (a pak si je vyhledávat) nebo cokoliv dalšího tě napadne

            Console.ReadKey();
        }
    }
}
