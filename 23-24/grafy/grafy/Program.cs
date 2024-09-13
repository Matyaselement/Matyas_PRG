using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grafy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            node family = new node(1);
            family.AddChild(2);
            family.AddChild(3);
            family.Children[0].AddChild(4);
            family.Children[1].AddChild(5);

            Console.WriteLine("Rodokmen graf: ");
            family.go();

            Console.ReadLine();
        }
    }
}
