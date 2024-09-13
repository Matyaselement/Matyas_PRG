using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace tridy
{
    internal class human
    {
        public int age;
        public int height;
        public int weight;
        public string name;
        public string skincolour;
        public human partner;

        public human(int age, int weight, string name, int height)
        {
            this.age = age;
            this.height = height;
            this.weight = weight;
            this.name = name;
            this.height = height;
        }

        public void IntroduceHuman();
        {
            Console.WriteLine("Jmenuji se" {name} "je mi" {age} "let. Měřím"{height})

        }

        static void Main(string[] args)
        {
            
        }
    }
}
