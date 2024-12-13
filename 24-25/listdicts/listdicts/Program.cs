using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listdicts
{
    internal class Program
    {
        static void PrintList(List<string>list)
        {
            foreach (string name in list)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            //List
            List<string> myList = new List<string>();
            myList.Add("Škoda");
            myList.Add("Lada");
            myList.Add("Koenigsegg");
            myList.Add("Smart");
            myList.Add("McMurtry");
            PrintList(myList);
            myList.Remove("Lada");
            PrintList(myList);
            myList.RemoveAt(2);
            PrintList(myList);
            if (myList.Exists(carMaker => carMaker.StartsWith("M")))
            {
                Console.WriteLine("V listu je automobilka začínající na písmeno M");
            }
            else
            {
                Console.WriteLine("V listu není žádná automobilka začínající na písmeno M");
            }
            Console.WriteLine() ;
            //Dictionary
            Dictionary<string, string> engCze = new Dictionary<string, string>();
            engCze["Water"] = "Voda";
            engCze["Hospital"] = "Nemocnice";
            engCze["Science"] = "Věda";
            engCze["Heil committee"] = "Heil výbor";
            foreach (KeyValuePair<string, string> trans in engCze)
            {
                string engWord = trans.Key;
                string czeWord = trans.Value;
                Console.WriteLine("Překlad slova či fráze " + engWord+ " do češtiny je " + czeWord);
            }

            Console.ReadKey();
        }
    }
}
