using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textGameClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("Jára", 23, 5);
            Enemy enemy1 = new Enemy("Pihrt", 10, 2, 1);
            Enemy enemy2 = new Enemy("Koloděj", 30,3, 2);

            while ()
            {
                enemy1.Hurt(player.Attack())
                player.Hurt(enemy1.Attack())

            Console.ReadKey();
        }
    }
}
