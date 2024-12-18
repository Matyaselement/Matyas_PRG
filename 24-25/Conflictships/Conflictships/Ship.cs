using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conflictships
{
    internal class Ship
    {
        //instance třídy
        public string name { get; set; } //jméno lodě
        public int length { get; set; } //délka lodě
        public int hits { get; private set; } //počet záasahů lodě
        public List<(int x, int y)> coordi { get; set; } //seznam uchovávající souřadnice lodí
        public List<Ship> ships; // Seznam lodí na poli


        //konskruktor Ship
        public Ship(int shipLength, List<(int x, int y)> coordixy)
        {
            length = shipLength; // Nastaví délku lodě
            hits = 0; // Počáteční počet zásahů je 0
            coordi = coordixy; //nastavení souřadnic
            ships = new List<Ship>(); //seznam lodí - inicializace
        }

        //metoda pro zásahy, pokud jich není na danou loď moc, přidá zásah, kontroluje trefování
        public void Hit((int xa, int ya) position)
        {
            if (coordi.Contains(position))
            {
                if (hits < length)
                {
                    hits++;
                }
            }

        }

        //metoda pro zjišťování, zda je loď potopená nebo ještě ne
        public bool IsSunk()
        {
            return hits >= length;
        }
    }
}

