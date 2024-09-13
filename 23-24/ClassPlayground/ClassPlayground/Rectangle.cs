using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPlayground
{
    internal class Rectangle
    {
        public int width;
        public int height;

        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public void CalculateArea()
        {
            Console.WriteLine("Pro spočítání obsahu obdélníku stiskněte 1");
            string ifarea = Console.ReadLine();
            if (ifarea == "1")
            {
                int area = width * height;
                Console.WriteLine("Obsah obdélníku je " + area);
            }
        }

        public void CalculateAspectRatio()
        {
            Console.WriteLine("Pro spočítání poměru stran a zjištění typu obdélníku stiskněte 2");
            int ratio;
            string ifratio = Console.ReadLine();
            if (ifratio == "2")
            {
                ratio = width / height;
                if (ratio > 1)
                {
                    Console.WriteLine($"Poměr stran je {ratio} a obdélník je široký");
                }
                if(ratio < 1)
                {
                    Console.WriteLine($"Poměr stran je {ratio} a obdélník je vysoký");
                }
                if (ratio == 1)
                {
                    Console.WriteLine($"Poměr stran je {ratio} a obdélník je čtverec");
                }
            }
            
            
        }
    }
}
