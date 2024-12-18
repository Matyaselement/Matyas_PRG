using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conflictships
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sea mojePole = new Sea();
            mojePole.Render();
            Console.ReadKey();
        }
    }
}
