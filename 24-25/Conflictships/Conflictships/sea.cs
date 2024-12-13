using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conflictships
{
    internal class Sea
    {
        //(v téhle třídě můžeš najít random easteregg na Star Wars :D)

        //hrací pole
        private char[,] battleSea;

        //konstruktor pro hrací pole (jeho vygenerování)
        public Sea()
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

        //metoda pro vykreslování moře (pole) (chatGPT tu radil hodně)
        public void Render()
        {
            Console.Write("   ");//přidá mezery na začátek písmenkové řady
            for (char charBinks = 'A'; charBinks <= 'J'; charBinks++)//postupně vypisuje písmena od A do J
            {
                Console.Write(charBinks + " ");//přidává mezery mezi písmena
            }
            Console.WriteLine();//přesune na nový řádek

            //přidá sloupec čísel
            for (int row = 0; row < 10; row++)
            {
                Console.Write((row + 1).ToString().PadLeft(2) + " ");
                for (int col = 0; col < 10; col++)
                {
                    Console.Write(battleSea[row, col] + " ");
                }
                Console.WriteLine(); 
            }
        }
    }
}
