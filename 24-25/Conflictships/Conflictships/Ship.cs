using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conflictships
{
    internal class Ship
    {
        //instance třídy
        public string name { get; set; } //jméno lodě
        public int length { get; set; } //délak lodě
        public int hits { get; private set; } //počet záasaů lodě

        //konskruktor Ship
        public Ship(int shipLength)
        {
            length = shipLength;  // Nastaví délku lodě
            hits = 0;         // Počáteční počet zásahů je 0
        }

        //metoda pro zásahy, pokud jich není na danou loď moc, přidá zásah
        public void Hit()
        {
            if (hits < length)
            {
                hits++;
            }
        }

        //metoda pro zjišťování, zda je loď potopená nebo ještě ne
        public bool IsSunk()
        {
            return hits >= length;
        }
    }
}

