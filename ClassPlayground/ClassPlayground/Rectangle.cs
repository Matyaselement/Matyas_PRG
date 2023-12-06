using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPlayground
{
    internal class Rectangle
    {
        public int Width;
        public int Height;

        public Rectangle(int width, int height)
        {
            width = Width;
            height = Height;
        }

        public void CalculateArea()
        {
            Console.WriteLine("Pro spočítání obsahu obdélníku stiskněte 1");
            string ifarea = Console.ReadLine();
            if (ifarea == "1")
            {
                int area = Width * Height;
                Console.WriteLine("Obsah obdélníku je",area);
            }
        }
    }
}
