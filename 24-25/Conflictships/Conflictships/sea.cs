using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conflictships
{
    internal class sea
    {
        //hrací pole
        private char[,] battleSea;

        //konstruktor pro hrací pole (jeho vygenerování)
        public sea()
        {
            //vytvoření pole 
            battleSea = new char[10, 10];

            //cyklus který naplní pole znaky pro vodu (vlnky)
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    battleSea[i, j] = '~';
                }

            }
        }

        //metoda pro vykreslování moře (pole)
        public void Render()
        {
            //vypíše písmena pro určení pozice
            Console.WriteLine("  A B C D E F G H I J");
            for (int col = 0; col < 10; col++)
            {
                //vypíše postupně řádky a čísla u nich (chatGPT zde radil hodně)
                Console.Write((col + 1).ToString().PadLeft(2) + " ");
                for (int row = 0; row < 10; row++)
                {
                    Console.Write(battleSea[col, row] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
