using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Parak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //start "menu"
            string menu;
            string menucheck = ("start");
            Console.WriteLine("Vítejte ve hře Parak. Vaším úkolem bude procházet kobky hradu Parak, nasbírat 5 pokladů a nezemřít u toho.");
            Console.WriteLine("Máte 5 životů. O život přijdete, pokud prohrajete souboj. Prosím, začnětě napsáním start.");
            menu = Console.ReadLine();

            if (menu == menucheck)
            {
                //generace herní mapy
                int[,] map = new int[10, 10];

                //naplnění mapy náhodnými čísly, z části ChatGPT
                Random random = new Random();
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        map[i, j] = random.Next(1, 9);
                    }
                }

                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        Console.WriteLine(map[i, j] + "");
                    }
                }
            }
            else
            {
                Console.WriteLine("Musíte napsat start.");
            }

            Console.ReadKey();
            
        }

    }
}
